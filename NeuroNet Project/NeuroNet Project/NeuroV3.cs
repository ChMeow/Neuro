using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroV3
{
    public class Neuro
    {
        float LearnRate;
        int[] layer; //layer information
        Layer[] layers; //layers in the network



        /// Constructor setting up layers
        public Neuro(int[] layer, float LearnRate, bool UpdateExistingWeight, string WeightPath) // nodes in each layer, eg. 5 layer network: 4,5,5,5,1 = 4 input , 5 nodes each layer, and 1 output.
        {
            //deep copy layers
            this.LearnRate = LearnRate;
            this.layer = new int[layer.Length];
            for (int i = 0; i < layer.Length; i++)
                this.layer[i] = layer[i];

            //creates neural layers
            layers = new Layer[layer.Length - 1];

            for (int i = 0; i < layers.Length; i++)
            {
                layers[i] = new Layer(layer[i], layer[i + 1], WeightPath, i, UpdateExistingWeight); // layer[i] represent the input nodes and layer[i+1] represent output nodes.
            }
        }

        /// High level feedforward for this network
        /// input = input to feedforward
        public float[] FeedForward(float[] inputs, int Activate)
        {
            //feed forward
            layers[0].FeedForward(inputs, Activate);
            for (int i = 1; i < layers.Length; i++)
            {
                layers[i].FeedForward(layers[i - 1].outputs, Activate);
            }

            return layers[layers.Length - 1].outputs; //return output of last layer
        }

        /// High level back porpagation
        /// Note: It is expexted the one feed forward was done before this back prop.
        /// <param name="expected">The expected output form the last feedforward</param>
        public void BackProp(float[] expected, int Activate)
        {
            // run over all layers backwards
            for (int i = layers.Length - 1; i >= 0; i--)
            {
                if (i == layers.Length - 1)
                {
                    layers[i].BackPropOutput(expected, Activate); //back prop output
                }
                else
                {
                    layers[i].BackPropHidden(layers[i + 1].gamma, layers[i + 1].weights, Activate); //back prop hidden
                }
            }

            //Update weights
            for (int i = 0; i < layers.Length; i++)
            {
                layers[i].UpdateWeights(LearnRate);
            }
        }


        public void WtoF()
        {
            //Output weights to Files
            for (int i = 0; i < layers.Length; i++)
            {
                layers[i].WeightsToFiles(i);
            }
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        /// Each individual layer in the ML{
        public class Layer
        {
            int numberOfInputs; //# of neurons in the previous layer
            int numberOfOuputs; //# of neurons in the current layer


            public float[] outputs; //outputs of this layer
            public float[] inputs; //inputs in into this layer
            public float[,] weights; //weights of this layer
            public float[,] weightsDelta; //deltas of this layer
            public float[] gamma; //gamma of this layer
            public float[] error; //error of the output layer

            public static Random random = new Random(); //Static random class variable

            /// Constructor initilizes vaiour data structures
            /// <param name="numberOfInputs">Number of neurons in the previous layer</param>
            /// <param name="numberOfOuputs">Number of neurons in the current layer</param>
            public Layer(int numberOfInputs, int numberOfOuputs, string WeightPath, int CountL, bool UpdateExistingWeight)
            {
                this.numberOfInputs = numberOfInputs;
                this.numberOfOuputs = numberOfOuputs;

                //initilize datastructures
                outputs = new float[numberOfOuputs];
                inputs = new float[numberOfInputs];
                weights = new float[numberOfOuputs, numberOfInputs];
                weightsDelta = new float[numberOfOuputs, numberOfInputs];
                gamma = new float[numberOfOuputs];
                error = new float[numberOfOuputs];
                bool WeightExist;
                if (UpdateExistingWeight == true) WeightExist = true;
                else WeightExist = false;
                InitilizeWeights(WeightExist, WeightPath, CountL); //initilize weights
            }

            /// Initilize weights between -0.5 and 0.5
            public void InitilizeWeights(bool WeightExist, string WeightPath, int CountL)
            {
                if (WeightExist == true)
                {
                    WeightPath = WeightPath + @"\W" + CountL + @".txt";
                    int k = 0;
                    int loop = 0;
                    string[] split;
                    char[] tab = new char[3];
                    tab[0] = Convert.ToChar("\t");
                    tab[1] = Convert.ToChar("\r");
                    tab[2] = Convert.ToChar("\n");

                    string readText = File.ReadAllText(WeightPath);
                    split = readText.Split(tab);
                    string[] split2 = new string[split.Length];
                    for (int jj = 0; jj < split.Length; jj++)
                    {
                        if (split[jj] != "")
                        {
                            split2[k] = split[jj];
                            k++;
                        }
                    }

                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        for (int j = 0; j < numberOfInputs; j++)
                        {
                            double temp = 0;
                            temp = Convert.ToDouble(split2[loop]);
                            weights[i, j] = (float)temp;
                            loop++;
                        }
                    }

                }
                else
                {
                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        for (int j = 0; j < numberOfInputs; j++)
                        {
                            weights[i, j] = (float)random.NextDouble() - 0.5f;
                        }
                    }
                }
            }

            /// Feedforward this layer with a given input
            /// <param name="inputs">The output values of the previous layer</param>
            public float[] FeedForward(float[] inputs, int Activate)
            {
                this.inputs = inputs;// keep shallow copy which can be used for back propagation

                //feed forwards
                for (int i = 0; i < numberOfOuputs; i++)
                {
                    outputs[i] = 0;
                    for (int j = 0; j < numberOfInputs; j++)
                    {
                        outputs[i] += inputs[j] * weights[i, j];
                    }

                    outputs[i] = Activ(outputs[i], Activate);
                }

                return outputs;
            }


            /// Back propagation for the output layer
            /// <param name="expected">The expected output</param>
            public void BackPropOutput(float[] expected, int Activate)
            {
                //Error dervative of the cost function
                for (int i = 0; i < numberOfOuputs; i++)
                    error[i] = outputs[i] - expected[i];

                //Gamma calculation
                for (int i = 0; i < numberOfOuputs; i++)
                    gamma[i] = error[i] * Deriv(outputs[i], Activate);

                //Caluclating detla weights
                for (int i = 0; i < numberOfOuputs; i++)
                {
                    for (int j = 0; j < numberOfInputs; j++)
                    {
                        weightsDelta[i, j] = gamma[i] * inputs[j];
                    }
                }
            }

            /// Back propagation for the hidden layers
            /// <param name="gammaForward">the gamma value of the forward layer</param>
            /// <param name="weightsFoward">the weights of the forward layer</param>
            public void BackPropHidden(float[] gammaForward, float[,] weightsFoward, int Activate)
            {
                //Caluclate new gamma using gamma sums of the forward layer
                for (int i = 0; i < numberOfOuputs; i++)
                {
                    gamma[i] = 0;

                    for (int j = 0; j < gammaForward.Length; j++)
                    {
                        gamma[i] += gammaForward[j] * weightsFoward[j, i];
                    }

                    gamma[i] *= Deriv(outputs[i], Activate);
                }

                //Caluclating detla weights
                for (int i = 0; i < numberOfOuputs; i++)
                {
                    for (int j = 0; j < numberOfInputs; j++)
                    {
                        weightsDelta[i, j] = gamma[i] * inputs[j];
                    }
                }
            }

            /// Updating weights
            public void UpdateWeights(float LearnRate)
            {
                for (int i = 0; i < numberOfOuputs; i++)
                {
                    for (int j = 0; j < numberOfInputs; j++)
                    {
                        weights[i, j] -= weightsDelta[i, j] * LearnRate;
                    }
                }
            }

            public void WeightsToFiles(int L)
            {
                int j, i = 0;
                string FinalWeight = "";
                string W_SavePath = @"I:\Test data\NN_WE\W" + L + ".txt";
                for (i = 0; i < numberOfOuputs; i++)
                {
                    for (j = 0; j < numberOfInputs; j++)
                    {
                        FinalWeight = FinalWeight + weights[i, j] + "\t";
                    }
                    FinalWeight = FinalWeight + "\r\n";
                    File.WriteAllText(W_SavePath, FinalWeight);
                }
            }






            /// Activation function 
            /// 1. Tanh
            /// 2. Logistic
            /// 3. Binary Step
            /// 4. ArcTan
            /// 5. SoftSign
            /// 6. SoftPlus
            /// 7. Bent identity
            /// 8. Sin
            /// 9. Gaussian


            public float Activ(float value, int Act)
            {
                float tempF;
                switch (Act)
                {
                    case 1:
                        value = (float)Math.Tanh(value);
                        break;

                    case 2:
                        tempF = (float)Math.Exp(value);
                        value = 1 / (1 + tempF);
                        break;

                    case 3:
                        if (value < 0) value = 0;
                        else value = 1;
                        break;

                    case 4:
                        value = (float)Math.Atan(value);
                        break;

                    case 5:
                        tempF = value;
                        if (tempF < 0) tempF = -tempF;
                        value = value / (1 + tempF);
                        break;

                    case 6:
                        tempF = (float)Math.Exp(value);
                        value = (float)Math.Log(tempF + 1);
                        break;

                    case 7:
                        tempF = (float)Math.Sqrt(value * value + 1);
                        value = (tempF - 1) / 2 + value;
                        break;

                    case 8:
                        value = (float)Math.Sin(value);
                        break;

                    case 9:
                        tempF = value * value;
                        value = (float)Math.Exp(-tempF);
                        break;

                    default:
                        return value;
                }
                return value;
            }

            public float Deriv(float value, int Act)
            {
                float tempF;
                switch (Act)
                {
                    case 1:
                        value = 1 - (value * value);
                        break;

                    case 2:
                        value = Activ(value, Act);
                        value = value * (1 - value);
                        break;

                    case 3:
                        value = 0.2f;
                        break;

                    case 4:
                        value = 1 / (value * value + 1);
                        break;

                    case 5:
                        tempF = value;
                        if (tempF < 0) tempF = -tempF;
                        value = value / ((1 + tempF) * (1 + tempF));
                        break;

                    case 6:
                        value = Activ(value, 2);
                        break;

                    case 7:
                        tempF = (float)Math.Sqrt(value * value + 1);
                        value = value / (2 * tempF) + 1;
                        break;

                    case 8:
                        value = (float)Math.Cos(value);
                        break;

                    case 9:
                        tempF = value * value;
                        value = -2 * value * (float)Math.Exp(-tempF);
                        break;

                    default:
                        return value;
                }
                return value;
            }
        }
    }
}
