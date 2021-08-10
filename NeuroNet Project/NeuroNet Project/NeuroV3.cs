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
        float momentum;
        int miniBatchError = 0;
        int[] layer; // Number of nodes in each layer
        Layer[] layers; // The "Layer"s in the network

        // Layer Construction
        public Neuro(int[] layer, float LearnRate, bool UpdateExistingWeight, string WeightPath, string BiasPath, float momentum) // nodes in each layer, eg. 5 layer network: 4,5,5,5,1 = 4 input , 5 nodes each layer, and 1 output.
        {
            this.LearnRate = LearnRate;
            this.momentum = momentum;
            this.layer = new int[layer.Length];
            for (int i = 0; i < layer.Length; i++)
                this.layer[i] = layer[i];

            // Creates layers
            layers = new Layer[layer.Length - 1];

            for (int i = 0; i < layers.Length; i++)
            {
                layers[i] = new Layer(layer[i], layer[i + 1], WeightPath, i, UpdateExistingWeight, BiasPath); // layer[i] represent the input nodes and layer[i+1] represent output nodes.
            }
        }

        // Feed forward
        public float[] FeedForward(float[] inputs, int Activate)
        {
            layers[0].FeedForward(inputs, Activate);
            for (int i = 1; i < layers.Length; i++)
            {
                layers[i].FeedForward(layers[i - 1].outputs, Activate); //Sending in input data or previous layer as inputs
            }

            // Result
            return layers[layers.Length - 1].outputs; 
        }

        // Backpropagation
        public void BackProp(float[] expected, int Activate, bool adaptive, float adaptiveWeight, float decayRate, bool miniBatch, bool miniBatchProceed, bool newMiniBatch)
        {
            if(miniBatch)
            {
                for (int i = layers.Length - 1; i >= 0; i--)
                {
                    if(miniBatchProceed)
                    {
                        // Final layer
                        if (i == layers.Length - 1)
                        {
                            layers[i].BackPropOutput(expected, Activate, miniBatch, newMiniBatch);
                        }
                        // Hidden layers
                        else
                        {
                            layers[i].BackPropHidden(layers[i + 1].dydx, layers[i + 1].weights, Activate);
                        }
                    }
                    else
                    {
                        // Final layer
                        if (i == layers.Length - 1)
                        {
                            layers[i].BackPropOutput(expected, Activate, miniBatch, newMiniBatch);
                        }
                    }

                }

                if (miniBatchProceed)
                {
                    //Update weights
                    for (int i = 0; i < layers.Length; i++)
                    {
                        layers[i].UpdateWeights(LearnRate, momentum, adaptive, adaptiveWeight, decayRate);
                    }

                    //Update bias
                    for (int i = 0; i < layers.Length; i++)
                    {
                        layers[i].UpdateBias(LearnRate, momentum, adaptive, adaptiveWeight, decayRate);
                    }
                }
            }
            else
            {
                // starts from the final layer to the front layer.
                for (int i = layers.Length - 1; i >= 0; i--)
                {
                    // Final layer
                    if (i == layers.Length - 1)
                    {
                        layers[i].BackPropOutput(expected, Activate, false, true);
                    }
                    // Hidden layers
                    else
                    {
                        layers[i].BackPropHidden(layers[i + 1].dydx, layers[i + 1].weights, Activate);
                    }
                }

                //Update weights
                for (int i = 0; i < layers.Length; i++)
                {
                    layers[i].UpdateWeights(LearnRate, momentum, adaptive, adaptiveWeight, decayRate);
                }

                //Update bias
                for (int i = 0; i < layers.Length; i++)
                {
                    layers[i].UpdateBias(LearnRate, momentum, adaptive, adaptiveWeight, decayRate);
                }
            }
        }

        // Save weights to Files
        public void WtoF(int N, int C, string savePath)
        {
            for (int L = 0; L < layers.Length; L++)
            {
                layers[L].WeightsToFiles(N, C, L, savePath);
            }
        }

        // Save biases to Files
        public void BtoF(int N, int C, string savePath)
        {
            for (int L = 0; L < layers.Length; L++)
            {
                layers[L].BiasToFiles(N, C, L, savePath);
            }
        }

        // Info for each individual layer
        public class Layer
        {
            int numberOfInputs; // number of nodes in the previous layer
            int numberOfOuputs; // number of nodes in the current layer


            public float[] outputs; // outputs of this layer
            public float[] inputs; // inputs of this layer
            public float[,] weights; // weights of this layer
            public float[,] weightsCorrection; // Corrections of this layer
            public float[] bias; // biases of this layer
            public float[,] momentumWeight; // The weightCorrection from previous epoch
            public float[] momentumBias; // The biasCorrection from previous epoch
            public float[] dydx; //dydx of this layer
            public float[] error; //error of the output layer
            public float cummulativeError; // experimental for adaptive momentum and learning rate

            public static Random random = new Random(); 

            // numberOfInputs = number of input nodes for this layer
            // numberOfOuputs = number of output nodes for this layer
            public Layer(int numberOfInputs, int numberOfOuputs, string WeightPath, int CountL, bool UpdateExistingWeight, string BiasPath)
            {
                this.numberOfInputs = numberOfInputs;
                this.numberOfOuputs = numberOfOuputs;

                outputs = new float[numberOfOuputs];
                inputs = new float[numberOfInputs];
                weights = new float[numberOfOuputs, numberOfInputs];
                weightsCorrection = new float[numberOfOuputs, numberOfInputs];
                bias = new float[numberOfOuputs];
                momentumWeight = new float[numberOfOuputs, numberOfInputs];
                momentumBias = new float[numberOfOuputs];
                dydx = new float[numberOfOuputs];
                error = new float[numberOfOuputs];

                bool WeightExist;
                if (UpdateExistingWeight == true) WeightExist = true;
                else WeightExist = false;
                InitilizeWeights(WeightExist, WeightPath, CountL); 
                InitilizeBias(UpdateExistingWeight, BiasPath, CountL);
            }

            // Random weights between -0.5 and 0.5
            public void InitilizeWeights(bool WeightExist, string WeightPath, int CountL)
            {
                if (WeightExist == true)
                {
                    WeightPath = WeightPath + CountL + @".txt";
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

            // Random Bias from -0.5 to 0.5 
            public void InitilizeBias(bool BiasExist, string BiasPath, int CountL)
            {
                if (BiasExist == true)
                {
                    BiasPath = BiasPath + CountL + @".txt";
                    int k = 0;
                    int loop = 0;
                    string[] split;
                    char[] tab = new char[3];
                    tab[0] = Convert.ToChar("\t");
                    tab[1] = Convert.ToChar("\r");
                    tab[2] = Convert.ToChar("\n");

                    string readText = File.ReadAllText(BiasPath);
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
                            double temp = 0;
                            temp = Convert.ToDouble(split2[loop]);
                            bias[i] = (float)temp;
                            loop++;
                    }
                    
                }
                else
                {
                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        bias[i] = (float)random.NextDouble() - 0.5f;
                    }
                }
            }

            // Feedforward for this layer
            public float[] FeedForward(float[] inputs, int Activate)
            {
                this.inputs = inputs;

                for (int i = 0; i < numberOfOuputs; i++)
                {
                    outputs[i] = 0;
                    for (int j = 0; j < numberOfInputs; j++)
                    {
                        outputs[i] += inputs[j] * weights[i, j];
                    }
                    outputs[i] += bias[i];
                    outputs[i] = Activ(outputs[i], Activate);
                }
                return outputs;
            }

            // Backpropagation Final Layer
            public void BackPropOutput(float[] expected, int Activate, bool minibatch, bool newMiniBatch)
            {
                //Error dervative of the cost function
                if (minibatch)
                {
                    if (newMiniBatch)
                    {
                        Array.Clear(weightsCorrection, 0, weightsCorrection.Length);
                    }
                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        error[i] = outputs[i] - expected[i];
                    }
                    // calculation
                    for (int i = 0; i < numberOfOuputs; i++)
                        dydx[i] = 2 * error[i] * Deriv(outputs[i], Activate);

                    //Caluclating detla weights
                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        for (int j = 0; j < numberOfInputs; j++)
                        {
                            weightsCorrection[i, j] = weightsCorrection[i, j] + dydx[i] * inputs[j];
                        }
                    }
                    //if(!miniBatchProceed) // Meow's style minibatch, it learns but painfully slow
                    //for (int i = 0; i < numberOfOuputs; i++)
                    //{
                    //        error[i] = error[i] + outputs[i] - expected[i];
                    //        error[i] = error[i] / 3;
                    //}
                    //else
                    //{
                    //    for (int i = 0; i < numberOfOuputs; i++)
                    //    {
                    //        error[i] = error[i] + outputs[i] - expected[i];
                    //        error[i] = error[i] / 3;
                    //    }
                    //    // calculation
                    //    for (int i = 0; i < numberOfOuputs; i++)
                    //        dydx[i] = 2 * error[i] * Deriv(outputs[i], Activate);

                    //    //Caluclating detla weights
                    //    for (int i = 0; i < numberOfOuputs; i++)
                    //    {
                    //        for (int j = 0; j < numberOfInputs; j++)
                    //        {
                    //            weightsCorrection[i, j] = dydx[i] * inputs[j];
                    //        }
                    //    }
                    //}
                }
                else
                {
                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        error[i] = outputs[i] - expected[i];
                    }

                    // calculation
                    for (int i = 0; i < numberOfOuputs; i++)
                        dydx[i] = 2 * error[i] * Deriv(outputs[i], Activate);

                    //Caluclating detla weights
                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        for (int j = 0; j < numberOfInputs; j++)
                        {
                            weightsCorrection[i, j] = dydx[i] * inputs[j];
                        }
                    }
                }
            }

            // Backpropagation Hidden Layers
            // dydxForward and weightsForward = dydx and weight in the next layer
            public void BackPropHidden(float[] dydxForward, float[,] weightsFoward, int Activate)
            {
                //Caluclate new dydx using dydx sums of the forward layer
                for (int i = 0; i < numberOfOuputs; i++)
                {
                    dydx[i] = 0;

                    for (int j = 0; j < dydxForward.Length; j++)
                    {
                        dydx[i] += dydxForward[j] * weightsFoward[j, i];
                    }

                    dydx[i] *= Deriv(outputs[i], Activate);
                }

                //Caluclating detla weights
                for (int i = 0; i < numberOfOuputs; i++)
                {
                    for (int j = 0; j < numberOfInputs; j++)
                    {
                        weightsCorrection[i, j] = dydx[i] * inputs[j];
                    }
                }
            }

            // Updating weights
            public void UpdateWeights(float LearnRate, float momentum, bool adaptive, float adaptiveWeight, float decayRate)
            {
                if(adaptive == true)
                {
                    float newLR = 0;
                    float newM = 0;
                    newLR = LearnRate * (float) Math.Exp(-adaptiveWeight / decayRate);
                    newM = momentum * (float)Math.Exp(-adaptiveWeight / decayRate);

                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        for (int j = 0; j < numberOfInputs; j++)
                        {
                            weights[i, j] -= weightsCorrection[i, j] * newLR;
                            weights[i, j] -= newM * momentumWeight[i, j];
                            momentumWeight[i, j] = weightsCorrection[i, j];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        for (int j = 0; j < numberOfInputs; j++)
                        {
                            weights[i, j] -= weightsCorrection[i, j] * LearnRate;
                            weights[i, j] -= momentum * momentumWeight[i, j];
                            momentumWeight[i, j] = weightsCorrection[i, j];
                        }
                    }
                }
            }

            public void UpdateBias(float LearnRate, float momentum, bool adaptive, float adaptiveBias, float decayRate)
            {
                if(adaptive == true)
                {
                    float newLR = 0;
                    float newM = 0;
                    newLR = LearnRate * (float)Math.Exp(-adaptiveBias / decayRate);
                    newM = momentum * (float)Math.Exp(-adaptiveBias / decayRate);

                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        bias[i] -= dydx[i] * newLR;
                        bias[i] -= newM * momentumBias[i];
                        momentumBias[i] = dydx[i];
                    }
                }
                else
                {
                    for (int i = 0; i < numberOfOuputs; i++)
                    {
                        bias[i] -= dydx[i] * LearnRate;
                        bias[i] -= momentum * momentumBias[i];
                        momentumBias[i] = dydx[i];
                    }
                }
            }

            public void WeightsToFiles(int N, int C, int L, string savePath)
            {
                int j, i = 0;
                string FinalWeight = "";
                string W_SavePath = savePath + @"\N" + N + "C" + C + "L" + L + ".txt";
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
            public void BiasToFiles(int N, int C, int L, string savePath)
            {
                int i = 0;
                string FinalBias = "";
                string B_SavePath = savePath + @"\N" + N + "C" + C + "L" + L + ".txt";
                for (i = 0; i < numberOfOuputs; i++)
                    FinalBias = FinalBias + bias[i] + "\r\n";
                File.WriteAllText(B_SavePath, FinalBias);
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
            /// 10.Identity

            public float Activ(float value, int Act)
            {
                float tempF;
                switch (Act)
                {
                    case 1:
                        value = (float)Math.Tanh(value);
                        break;

                    case 2:
                        tempF = (float)Math.Exp(-value);
                        value = 1 / (1 + tempF);
                        break;

                    case 3:
                        if (value <= 0) value = 0;
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

                    case 10:
                        value = value;
                        break;

                    default:
                        return value;
                }
                return value;
            }

            public float Deriv(float value, int Act)
            {
                float tempF;
                float tempG;
                switch (Act)
                {
                    case 1:
                        value = 1 - (value * value);
                        break;

                    case 2:
                        tempF = Activ(value, Act);
                        tempF = (float)Math.Log(tempF);
                        tempG = (float)Math.Exp(-value);
                        value = -tempF * tempG;
                        break;

                    case 3:
                        value = 0.5f;
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
                        tempG = 2 + value;
                        value = value / (tempF * tempG) + 1 / (tempG * tempG);
                        break;

                    case 8:
                        value = (float)Math.Cos(value);
                        break;

                    case 9:
                        tempF = value * value;
                        value = -2 * value * (float)Math.Exp(-tempF);
                        break;

                    case 10:
                        value = 1;
                        break;

                    default:
                        return value;
                }
                return value;
            }
           
        }

        
    }
    
}
