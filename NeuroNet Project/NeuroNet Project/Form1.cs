﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FolderSelect;
using NeuroV3;
using FileProcessing;
using System.Reflection;
using WpfMath;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace NeuroNet_Project
{
    public partial class Form_Main : Form
    {
        string[] inputFiles;
        string[] outputFiles;
        string[] weightFolder;
        string existingWeightPath; // with part of the name included, N and C value // C is the continue cycle, N is for seperate cycle. ie. N will increase a number if use existing weight is unchecked.
        string existingBiasPath;
        int P_activ, P_loops, P_layer, P_nodes, P_save, D_loops, D_Compare;
        float P_learn;
        int[] layer;
        float[] input;
        float[] expected;
        float[] result = new float[1];
        int N = 0, C = 0;
        int[] checkNC = new int[6];
        Assembly _assembly;
        Stream _imageStream;
        int loopsCounter;
        bool checkPlaying = false;
        int previousLoopsCounter = 0;
        float cost;
        float[] different;
        int[] weightInfo;
        float tempAdaptiveCorrection = 0;
        float[] tempMaxMin = new float[2];
        double UPPER = 0;
        double LOWER = 0;
        float[,] norMinMax = new float[20,4];

        string resultSingle;
        string resultAll;
        string resultLoops;
        string resultRMS;
        string resultParameter;
        string resultReportWeight;
        string CurrentTime;

        int[] equationNodes = new int[99];
        int[,] equationAvailableWeight = new int[99,99];
        int equationMaxN = 0;
        int equationMaxW = 0;

        public Form_Main()
        {
            InitializeComponent();
            // need this 4 line to initialize Worker 1///////////////
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
            //backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);// < AVOID < this caused worker to do duplicate work
            // backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            // backgroundWorker1.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorker1_RunWorkerCompleted);
        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            P_activ = comboBox_ActivateFunction.SelectedIndex + 1;
            P_loops = (int)numericUpDown_loops.Value;
            P_layer = (int)numericUpDown_layer.Value;
            P_nodes = (int)numericUpDown_nodes.Value;
            P_save = (int)numericUpDown_save.Value;
            P_learn = (float)numericUpDown_learn.Value;
            layer = new int[P_layer];
            for (int i = 1; i < P_layer - 1; i++)
                layer[i] = P_nodes;
            layer[0] = inputFiles.Length;
            layer[P_layer - 1] = outputFiles.Length;
            D_loops = fileProcess.checkData(label_InputPath.Text);
            D_Compare = fileProcess.checkData(label_OutputPath.Text);
            checkNC = fileProcess.checkWeight(label_WeightPath.Text);
            N = checkNC[0];
            C = checkNC[1];

            if (checkBox_UseExistW.Checked == true)
            {
                existingWeightPath = label_WeightPath.Text + @"\N" + N + "C" + C + "L";
                existingBiasPath = label_biasPath.Text + @"\N" + N + "C" + C + "L";
                if (checkNC[2] != P_layer - 2)
                {
                    richTextBox_Summary.Focus();
                    TimeNow();
                    richTextBox_Summary.SelectionColor = Color.Red;
                    richTextBox_Summary.AppendText("ERROR! Unable to proceed, weight data not match." + "\r\n");
                    goto endofthisbutton;
                }
                previousLoopsCounter = C;
            }
            else previousLoopsCounter = 0;

            if (D_loops != D_Compare || D_loops < 0)
            {
                richTextBox_Summary.Focus();
                TimeNow();
                richTextBox_Summary.SelectionColor = Color.Red;
                richTextBox_Summary.AppendText(@"ERROR! Unable to proceed, input / output data not match." + "\r\n");
                goto endofthisbutton;
            }

            label_LRM.Text = "Momentum: " + String.Format("{0:f" + 15 + "}", numericUpDown_momentum.Value) + "\t" + "          Learning rate: " + String.Format("{0:f" + 15 + "}", numericUpDown_learn.Value);

            //Saving other info into PARAMETERS folder.
            string parametersFileName = label_WeightPath.Text + "\\PARAMETERS" + "\\PARAMETERS.TXT";
            if (!Directory.Exists(label_WeightPath.Text + "\\PARAMETERS")) { Directory.CreateDirectory(label_WeightPath.Text + "\\PARAMETERS"); }
            string parametersText = "Activation Function =" + comboBox_ActivateFunction.SelectedItem + "\r\n" +
                                    "Normalized X min (Range) =" + numericUpDownNorIMin.Value +"\r\n" +
                                    "Normalized X max (Range) =" + numericUpDownNorIMax.Value +"\r\n" +
                                    "Normalized Y min (Range) =" + numericUpDownNorOMin.Value +"\r\n" +
                                    "Normalized Y max (Range) =" + numericUpDownNorOMax.Value +"\r\n" +
                                    "Normalized Data =" + checkBoxCustomNor.Checked.ToString() + "\r\n" +
                                    "Learning rate =" + numericUpDown_learn.Value +"\r\n" +
                                    "Momentum  =" + numericUpDown_momentum.Value +"\r\n" +
                                    "Decay Rate =" + numericUpDown_DecayRate.Value +"\r\n" +
                                    "Decaying Rate =" + checkBox_adaptiveRate.Checked.ToString();
            try
            {
                using (StreamWriter writer = new StreamWriter(parametersFileName))
                {
                    writer.Write(parametersText);
                }
            }
            catch (Exception exp)
            {
                Console.Write(exp.Message);
            }

            // Worker is doing the feedforward backpropagation.

            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            panel_Loading.BringToFront();
            checkPlaying = true;
            setPlayStopButton(checkPlaying);
           
            if (richTextBox_FinalResult.Text == "") requestParameter(true);
            if (checkBox_UseExistW.Checked == false) requestParameter(true);

            endofthisbutton:
            int gg = 0; // don't put any code beyond this point.
        }


        private void button_Input_Click(object sender, EventArgs e)
        {
            var inputSelect = new FolderSelectDialog();
            inputSelect.Title = "Select Input Path";
            inputSelect.InitialDirectory = textBox_MainFolder.Text;
            if (inputSelect.ShowDialog(IntPtr.Zero))
            {
                label_InputPath.Text = inputSelect.FileName;
            }
        }

        private void button_Output_Click(object sender, EventArgs e)
        {
            var OutputSelect = new FolderSelectDialog();
            OutputSelect.Title = "Select Output Path";
            OutputSelect.InitialDirectory = textBox_MainFolder.Text;
            if (OutputSelect.ShowDialog(IntPtr.Zero))
            {
                label_OutputPath.Text = OutputSelect.FileName;
            }
        }

        private void button_Weight_Click(object sender, EventArgs e)
        {
            var WeightSelect = new FolderSelectDialog();
            WeightSelect.Title = "Select Weight Path";
            WeightSelect.InitialDirectory = textBox_MainFolder.Text;
            if (WeightSelect.ShowDialog(IntPtr.Zero))
            {
                label_WeightPath.Text = WeightSelect.FileName;
            }
        }


        private void label_InputPath_TextChanged(object sender, EventArgs e)
        {
            inputFiles = Directory.GetFiles(label_InputPath.Text);
            richTextBox_Summary.Focus();
            TimeNow();
            richTextBox_Summary.SelectionColor = Color.LightSkyBlue;
            richTextBox_Summary.AppendText("Number of input in " + label_InputPath.Text + " . . . ");
            richTextBox_Summary.SelectionColor = Color.Lime;
            richTextBox_Summary.AppendText(inputFiles.Length + "\r\n");
        }

        private void pictureBox_StopCont_Click(object sender, EventArgs e)
        {
            if (checkPlaying == true)
            {
                if (backgroundWorker1.WorkerSupportsCancellation == true)
                {
                    backgroundWorker1.CancelAsync();
                }
            }
            else
            {
                button_Go.PerformClick();
            }
            
        }

        private void pictureBox_Switch_Click(object sender, EventArgs e)
        {
            panel_Loading.SendToBack();
        }

        private void pictureBox_Switch2_Click(object sender, EventArgs e)
        {
            panel_Loading.BringToFront();
        }

        private void label_OutputPath_TextChanged(object sender, EventArgs e)
        {
            outputFiles = Directory.GetFiles(label_OutputPath.Text);
            richTextBox_Summary.Focus();
            TimeNow();
            richTextBox_Summary.SelectionColor = Color.LightSkyBlue;
            richTextBox_Summary.AppendText("Number of output in " + label_OutputPath.Text + " . . . ");
            richTextBox_Summary.SelectionColor = Color.Lime;
            richTextBox_Summary.AppendText(outputFiles.Length + "\r\n");
        }

        private void button_clearLog_Click(object sender, EventArgs e)
        {
            richTextBox_FinalResult.Text = "";
        }

        private void button_saveLog_Click(object sender, EventArgs e)
        {
            {
                string saveLog = "";
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = textBox_MainFolder.Text;
                saveFileDialog1.Title = "Save text Files";
                //saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Rich Text files (*.rtf)|*.rtf";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveLog = saveFileDialog1.FileName;
                    richTextBox_FinalResult.SaveFile(saveLog);
                }

            }
        }

        private void button_Vin_Click(object sender, EventArgs e)
        {
            var WeightSelect = new FolderSelectDialog();
            WeightSelect.Title = "Select Input Path";
            WeightSelect.InitialDirectory = textBox_MainFolder.Text;
            if (WeightSelect.ShowDialog(IntPtr.Zero))
            {
                label_Vin.Text = WeightSelect.FileName;
            }
            try
            {
                inputFiles = Directory.GetFiles(label_Vin.Text);
                D_loops = fileProcess.checkData(label_Vin.Text);
            }
            catch (Exception ee)
            {
                int xxx = 0;
            }
        }

        private void button_Vw_Click(object sender, EventArgs e)
        {
            var WeightSelect = new FolderSelectDialog();
            WeightSelect.Title = "Select Weight Path";
            WeightSelect.InitialDirectory = textBox_MainFolder.Text;
            if (WeightSelect.ShowDialog(IntPtr.Zero))
            {
                label_Vw.Text = WeightSelect.FileName;
            }
            weightInfo = fileProcess.checkWeightInfo(label_Vw.Text);
            string tempW = "";
            tempW = "Layer =" + weightInfo.Length + "\r\n" + "Nodes = { ";
            for (int i = 0; i < weightInfo.Length - 1; i++) tempW = tempW + weightInfo[i] + " , ";
            tempW = tempW + weightInfo[weightInfo.Length - 1] + " }";
            labelWinfo.Text = tempW;

            if(File.Exists(label_Vw.Text + "\\PARAMETERS\\PARAMETERS.TXT"))
            {
                string line;
                int lineNumber = 0;
                try
                {
                    using (StreamReader reader = new StreamReader(label_Vw.Text + "\\PARAMETERS\\PARAMETERS.TXT"))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            var availableData = line.Split(new char[] { '=' });
                            if (lineNumber == 0)
                            {
                                comboBox_Vact.SelectedItem = availableData[1];
                            }
                            else if (lineNumber == 5 && availableData[1] == "True") buttonNorPath.PerformClick();
                            lineNumber++;
                        }
                    }
                }
                catch (Exception exp)
                {
                    Console.Write(exp.Message);
                }
                
            }
            //find layer info to layer[] here
        }

        private void button_Vgo_Click(object sender, EventArgs e)
        {
            bool isTheFileValid = true;
            bool noError = true;
            checkNC = fileProcess.checkWeight(label_Vw.Text);
            string VResult = "";
            float[] feedResult;
            string checkWeightPath = "";
            int[,] foundWeight = new int[99,99];
            int weightLength = 0;
            int maxWeightLength = 0;
            int resultLength = 0;
            N = checkNC[0]; //last continue
            C = checkNC[1]; //last iteration
            int maxN = checkNC[3]; //max continue
            int maxC = checkNC[4]; //max iteration 
            // D_loops is the max available lines in each input file.

            
            int DPV = (int)numericUpDown_DPV.Value;
            P_activ = comboBox_Vact.SelectedIndex + 1;

            // Cleaning Textbox
            if (richTextBox_Vout.Text == " ( ╯°Д°)╯ ︵ □ ") { richTextBox_Vout.Text = ""; }
            if (richTextBox_Vout.Text == "ALL WEIGHT FILES MUST CONTAIN SAME SET OF NODES !") { richTextBox_Vout.Text = ""; }


            //Gather all infomation
            for (int continueN = 0; continueN <= maxN; continueN++)
            {
                weightLength = 0;
                for (int checkW = 0; checkW <= maxC; checkW++)
                {
                    checkWeightPath = label_Vw.Text + @"\N" + continueN + "C" + checkW + "L0.txt";
                    if (File.Exists(checkWeightPath))
                    {
                        foundWeight[continueN,weightLength] = checkW; 
                        if (maxWeightLength < weightLength) { maxWeightLength = weightLength; }
                        weightLength++;
                    }
                }
            }

            existingWeightPath = label_Vw.Text + @"\N" + N + "C" + C + "L";
            existingBiasPath = label_Vbp.Text + @"\N" + N + "C" + C + "L";
            try
            {
                Neuro net = new Neuro(weightInfo, 0, true, existingWeightPath, existingBiasPath, (float)numericUpDown_momentum.Value); //intiilize network
                input = fileProcess.getData(label_Vin.Text, 0);
                feedResult = net.FeedForward(input, P_activ);
                resultLength = feedResult.Length;
            }
            catch (Exception exx)
            {
                MessageBox.Show("Weight File: Nodes MISMATCH!", "|д･) WHAT ?!!!");
                richTextBox_Vout.Text = " ( ╯°Д°)╯ ︵ □ ";
                noError = false;
            }

            for (int continueN = 0; continueN <= maxN & noError; continueN++)
            {
                //Start from N = 0  (ΦωΦ)/
                VResult = "Loops:" + "\t";

                //Generate first line
                for (int k = 0; k <= maxWeightLength; k++)
                {
                    try
                    {
                        checkWeightPath = label_Vw.Text + @"\N" + continueN + "C" + foundWeight[continueN, k] + "L0.txt";
                        if (File.Exists(checkWeightPath)) { isTheFileValid = true; }
                        else { isTheFileValid = false; }
                    }
                    catch (Exception exx)
                    {
                        isTheFileValid = false;
                    }
                    for (int j = 0; j < resultLength & isTheFileValid; j++)
                    {
                        VResult = VResult + foundWeight[continueN, k] + "\t";
                    }
                }
                VResult = VResult + "\r\n";
                richTextBox_Vout.AppendText(VResult);

                //Generate results
                for (int j = 0; j < D_loops & noError ; j++)
                {
                    VResult = "N = " + continueN + "\t";
                    for (int k = 0; k <= maxWeightLength & noError; k++)
                    {
                        try
                        {
                            checkWeightPath = label_Vw.Text + @"\N" + continueN + "C" + foundWeight[continueN, k] + "L0.txt";
                            existingWeightPath = label_Vw.Text + @"\N" + continueN + "C" + foundWeight[continueN, k] + "L";
                            existingBiasPath = label_Vbp.Text + @"\N" + continueN + "C" + foundWeight[continueN, k] + "L";
                            if (File.Exists(checkWeightPath)) { isTheFileValid = true; }
                            else { isTheFileValid = false; }
                        }
                        catch (Exception exx)
                        {
                            isTheFileValid = false;
                        }

                        if (isTheFileValid)
                        {
                            try
                            {
                                Neuro net2 = new Neuro(weightInfo, 0, true, existingWeightPath, existingBiasPath, (float)numericUpDown_momentum.Value); //intiilize network
                                input = fileProcess.getData(label_Vin.Text, j);
                                feedResult = net2.FeedForward(input, P_activ);
                                for (int g = 0; g < feedResult.Length; g++)
                                {
                                    if (checkBoxDeNor.Checked == true) feedResult[g] = Normalized.reverseNor(feedResult[g], norMinMax[g, 0], norMinMax[g, 1], norMinMax[g, 2], norMinMax[g, 3]);
                                    VResult = VResult + String.Format("{0:f" + DPV + "}", Math.Round(feedResult[g], DPV)) + "\t";
                                }
                            }
                            catch (Exception exx)
                            {
                                MessageBox.Show("Weight File: Nodes MISMATCH!", "|д･) WHAT ?!!!");
                                richTextBox_Vout.Text = " ( ╯°Д°)╯ ︵ □ ";
                                noError = false;
                            }
                        }
                    }
                    VResult = VResult + "\r\n";
                    richTextBox_Vout.AppendText(VResult);
                }

                VResult = "\r\n" + "================================================================================================================" + "\r\n" + "\r\n";
                richTextBox_Vout.AppendText(VResult);
            }

            // richTextBox_Vout.AppendText(VResult);               
            
            //float[] tempV;
            //Neuro net = new Neuro(weightInfo, 0, true, existingWeightPath, existingBiasPath, (float)numericUpDown_momentum.Value); //intiilize network
            //P_activ = comboBox_Vact.SelectedIndex + 1;
            //for (int j = 0; j < D_loops; j++)
            //{
            //    input = fileProcess.getData(label_Vin.Text, j);
            //    tempV = net.FeedForward(input, P_activ);
            //    //for (int g = 0; g < tempV.Length; g++) VResult = VResult + String.Format("{0:f" + DPV + "}", Math.Round(tempV[g], DPV)) + "\t";
            //    for (int g = 0; g < tempV.Length; g++)
            //    {
            //        if(checkBoxDeNor.Checked == true) tempV[g] = Normalized.reverseNor(tempV[g], norMinMax[g, 0], norMinMax[g, 1], norMinMax[g, 2], norMinMax[g, 3]);
            //        VResult = VResult + String.Format("{0:f" + DPV + "}", Math.Round(tempV[g], DPV)) + "\t";
            //    }
            //    VResult = VResult + "\r\n";
            //}
        }

        private void button_Vsave_Click(object sender, EventArgs e)
        {
            string saveLog = "";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.InitialDirectory = textBox_MainFolder.Text;
            saveFileDialog1.Title = "Save text Files";
            //saveFileDialog1.CheckFileExists = true;
            saveFileDialog1.CheckPathExists = true;
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "Rich Text files (*.rtf)|*.rtf";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                saveLog = saveFileDialog1.FileName;
                richTextBox_Vout.SaveFile(saveLog);
            }

        }

        private void button_Vclear_Click(object sender, EventArgs e)
        {
            richTextBox_Vout.Text = "";
        }

        private void button_BiasPath_Click(object sender, EventArgs e)
        {
            var biasSelect = new FolderSelectDialog();
            biasSelect.Title = "Select Bias Path";
            biasSelect.InitialDirectory = textBox_MainFolder.Text;
            if (biasSelect.ShowDialog(IntPtr.Zero))
            {
                label_biasPath.Text = biasSelect.FileName;
            }
        }

        private void button_VBP_Click(object sender, EventArgs e)
        {
            {
                var biasSelect = new FolderSelectDialog();
                biasSelect.Title = "Select Bias Path";
                biasSelect.InitialDirectory = textBox_MainFolder.Text;
                if (biasSelect.ShowDialog(IntPtr.Zero))
                {
                    label_Vbp.Text = biasSelect.FileName;
                }
            }
        }

        private void pictureBox_Info_Click(object sender, EventArgs e)
        {
            Info helpInfo = new Info();
            Form checkhelp = Application.OpenForms["Info"];
            if (checkhelp == null)
                helpInfo.Show();
            else
                Application.OpenForms["Info"].Focus();
        }

        /// <summary>
        /// NOT YET DONE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_WeightPath_TextChanged(object sender, EventArgs e)
        {
            weightFolder = Directory.GetDirectories(label_WeightPath.Text);
            // weight checking not yet complete
        }

        private void button_MainFolder_Click(object sender, EventArgs e)
        {
            var OutputSelect = new FolderSelectDialog();
            OutputSelect.Title = "Select Main Folder Path for Data";
            OutputSelect.InitialDirectory = @"c:\";
            if (OutputSelect.ShowDialog(IntPtr.Zero))
            {
                textBox_MainFolder.Text = OutputSelect.FileName;
            }
        }



        // GUI SETTING ///////////////////////////////////////////////////////////////////////////////////////////
        private void button_SaveSetting_Click(object sender, EventArgs e)
        {
            string setPath;
            setPath = Directory.GetCurrentDirectory();
            setPath = setPath + "\\config.ini";
            StreamWriter file =
                new StreamWriter(setPath);

            file.WriteLine(label_InputPath.Text);
            file.WriteLine(label_OutputPath.Text);
            file.WriteLine(label_WeightPath.Text);
            file.WriteLine(label_biasPath.Text);
            file.WriteLine(numericUpDown_save.Value);
            file.WriteLine(comboBox_ActivateFunction.Text);
            file.WriteLine(numericUpDown_layer.Value);
            file.WriteLine(numericUpDown_nodes.Value);
            file.WriteLine(numericUpDown_loops.Value);
            file.WriteLine(numericUpDown_learn.Value);
            file.WriteLine(numericUpDown_DP.Value);
            file.WriteLine(numericUpDown_momentum.Value);
            file.WriteLine(numericUpDown_DecayRate.Value);
            file.WriteLine(textBox_MainFolder.Text);
            file.WriteLine(numericUpDown_momentum.Value);
            file.WriteLine(numericUpDownNorIMin.Value);
            file.WriteLine(numericUpDownNorIMax.Value);
            file.WriteLine(numericUpDownNorOMin.Value);
            file.WriteLine(numericUpDownNorOMax.Value);
            if (checkBoxCustomNor.Checked == true) file.WriteLine("1"); else file.WriteLine("0");

            file.Close();
            richTextBox_Summary.Focus();
            TimeNow();
            richTextBox_Summary.SelectionColor = Color.Lime;
            richTextBox_Summary.AppendText("Setting Saved." + "\r\n");
            GC.Collect();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            string setPath;
            setPath = Directory.GetCurrentDirectory();
            _assembly = Assembly.GetExecutingAssembly();
            _imageStream = _assembly.GetManifestResourceStream("NeuroNet_Project.switch.bmp");
            pictureBox_Switch.Image = new Bitmap(_imageStream);
            _imageStream = _assembly.GetManifestResourceStream("NeuroNet_Project.switch2.bmp");
            pictureBox_Switch2.Image = new Bitmap(_imageStream);
            _imageStream = _assembly.GetManifestResourceStream("NeuroNet_Project.play.png");
            pictureBox_StopCont.Image = new Bitmap(_imageStream);
            Decimal checkstate = 0;

            // Read the file and display it line by line.
            setPath = setPath + "\\config.ini";

            if (File.Exists(setPath))
            {
                StreamReader file =
                    new StreamReader(setPath);
                try
                {
                    //file.ReadLine(); to skip a line
                    label_InputPath.Text = file.ReadLine();
                    label_OutputPath.Text = file.ReadLine();
                    label_WeightPath.Text = file.ReadLine();
                    label_biasPath.Text = file.ReadLine();
                    numericUpDown_save.Value = Convert.ToDecimal(file.ReadLine());
                    comboBox_ActivateFunction.Text = file.ReadLine();
                    numericUpDown_layer.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDown_nodes.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDown_loops.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDown_learn.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDown_DP.Value    = Convert.ToDecimal(file.ReadLine());
                    numericUpDown_momentum.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDown_DecayRate.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDown_DecayRate.Enabled = false;
                    textBox_MainFolder.Text = file.ReadLine();
                    numericUpDown_momentum.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDownNorIMin.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDownNorIMax.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDownNorOMin.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDownNorOMax.Value = Convert.ToDecimal(file.ReadLine());
                    checkstate = Convert.ToDecimal(file.ReadLine());
                    if (checkstate == 1) checkBoxCustomNor.Checked = true; else checkBoxCustomNor.Checked = false;
                }
                catch (Exception exx)
                {
                    richTextBox_Summary.Focus();
                    TimeNow();
                    richTextBox_Summary.SelectionColor = Color.Red;
                    richTextBox_Summary.AppendText("Config File Error !!!");
                    ErrorText();
                }

                file.Close();
                GC.Collect();

            }
        }

        private void checkBox_adaptiveRate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_adaptiveRate.Checked != true) numericUpDown_DecayRate.Enabled = false;
            else numericUpDown_DecayRate.Enabled = true;
        }

        private void Form_Main_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button_Normalize_Click(object sender, EventArgs e)
        {
            switch (comboBox_ActivateFunction.SelectedIndex)
            {
                case 0:
                    UPPER = 1;
                    LOWER = -1;
                    break;

                case 1:
                    UPPER = 1;
                    LOWER = 0;
                    break;
                case 2:
                    UPPER = 1;
                    LOWER = 0;
                    break;
                case 3:
                    UPPER = 1.5707963;
                    LOWER = -1.5707963;
                    break;
                case 4:
                    UPPER = 1;
                    LOWER = -1;
                    break;
                case 5:
                    UPPER = 99999;
                    LOWER = 0;
                    break;
                case 6:
                    UPPER = 999;
                    LOWER = -1;
                    break;
                case 7:
                    UPPER = 1;
                    LOWER = -1;
                    break;
                case 8:
                    UPPER = 1;
                    LOWER = 0;
                    break;
                case 9:
                    UPPER = 999;
                    LOWER = -1;
                    break;

                default:
                    UPPER = 999;
                    break;
            }
            if (UPPER == 999)
            {
                MessageBox.Show("Not available for the selected activation function.");
            }
            else
            {
                double InMax = Convert.ToDouble(numericUpDownNorIMax.Value);
                double InMin = Convert.ToDouble(numericUpDownNorIMin.Value);
                double OutMax = Convert.ToDouble(numericUpDownNorOMax.Value);
                double OutMin = Convert.ToDouble(numericUpDownNorOMin.Value);
                Normalized.norData(label_InputPath.Text, label_OutputPath.Text, LOWER, UPPER, InMin, InMax, OutMin, OutMax, checkBoxCustomNor.Checked);
            }

            //1.Tanh
            //2.Logistic
            //3.Binary Step
            //4.ArcTan
            //5.SoftSign
            //6.SoftPlus
            //7.Bent identity
            //8.Sin
            //9.Gaussian
            //10.Identity
        }

        private void buttonNorPath_Click(object sender, EventArgs e)
        {
            var NorSelect = new FolderSelectDialog();
            norMinMax[0, 0] = 0;
            norMinMax[0, 1] = 0;
            NorSelect.Title = @"Select the Output's MinMax Path";
            NorSelect.InitialDirectory = textBox_MainFolder.Text;
            if (NorSelect.ShowDialog(IntPtr.Zero))
            {
                labelNorPath.Text = NorSelect.FileName;
            }
            norMinMax = fileProcess.norMinMaxInfo(labelNorPath.Text);
            if(norMinMax[0,0] != 0 && norMinMax[0,1] != 0)
            {
                checkBoxDeNor.Checked = true;
                checkBoxDeNor.Text = "De-normalization: Enabled";
            }
            else
            {
                checkBoxDeNor.Checked = false;
                checkBoxDeNor.Text = "De-normalization: Disabled";
                labelNorPath.Text = "--";
            }
            
        }

        private void checkBoxDeNor_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBoxDeNor.Checked == true) checkBoxDeNor.Text = "De-normalization: Enabled";
            else checkBoxDeNor.Text = "De-normalization: Disabled";
        }

        private void buttonCopy_Valid_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox_Vout.Text);
        }

        private void buttonCopy_Main_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox_Summary.Text);
        }

        private void button_EqWeight_Click(object sender, EventArgs e)
        {
            bool isfolderSelected = false;
            var WeightSelect = new FolderSelectDialog();
            WeightSelect.Title = "Select Weight Path";
            WeightSelect.InitialDirectory = textBox_MainFolder.Text;
            if (WeightSelect.ShowDialog(IntPtr.Zero))
            {
                label_EqW.Text = WeightSelect.FileName;
                Array.Clear(equationNodes, 0, equationNodes.Length);
                Array.Clear(equationAvailableWeight, 0, equationAvailableWeight.Length);
                listBox_availableWeight.Items.Clear();
                isfolderSelected = true;
            }

            if (isfolderSelected)
            {
                weightInfo = fileProcess.checkWeightInfo(label_EqW.Text);
                string tempW = "";
                tempW = "Layers = " + weightInfo.Length + "\r\n" + "Nodes Configuration = { ";
                int i;
                for (i = 0; i < weightInfo.Length - 1; i++) equationNodes[i] = weightInfo[i];
                equationNodes[i] = weightInfo[weightInfo.Length - 1];
                i = 0;
                while (equationNodes[i] != 0)
                {
                    tempW = tempW + equationNodes[i] + " , ";
                    i++;
                }
                tempW = tempW + " }";
                // richTextBox_TestDebug.Text = tempW + "\r\n";

                checkNC = fileProcess.checkWeight(label_EqW.Text);
                N = checkNC[0]; //last continue
                C = checkNC[1]; //last iteration
                equationMaxN = checkNC[3]; //max continue
                equationMaxW = checkNC[4]; //max iteration 

                for (int continueN = 0; continueN <= equationMaxN; continueN++)
                {
                    i = 0;
                    for (int checkW = 0; checkW <= equationMaxW; checkW++)
                    {
                        string checkWeightPath = label_EqW.Text + @"\N" + continueN + "C" + checkW + "L0.txt";
                        if (File.Exists(checkWeightPath))
                        {
                            equationAvailableWeight[continueN, i] = checkW;
                            string newItem = "N=" + continueN + ", ITERATION=" + checkW;
                            listBox_availableWeight.Items.Add(newItem);
                            i++;
                        }
                    }
                }
            }

        }

        private void button_EqBias_Click(object sender, EventArgs e)
        {
                var biasSelect = new FolderSelectDialog();
                biasSelect.Title = "Select Bias Path";
                biasSelect.InitialDirectory = textBox_MainFolder.Text;
                if (biasSelect.ShowDialog(IntPtr.Zero))
                {
                    label_EqB.Text = biasSelect.FileName;
                }
        }

        private void button_EqGen_Click(object sender, EventArgs e)
        {
            int selectedEqN = 0;
            int selectedEqW = 0;
            int iEq = 0;
            bool switchEq = false;
            int dp = int.Parse(numericUpDown_eqDP.Value.ToString());
            try
            {
                richTextBox_TestDebug.AppendText("\r\n" + "\r\n" + "==============================BASIC INFO===========================================" + "\r\n" + "\r\n");
                richTextBox_TestDebug.AppendText("Weight Path: ");
                richTextBox_TestDebug.AppendText(label_EqW.Text + "\r\n");
                richTextBox_TestDebug.AppendText("Bias Path: ");
                richTextBox_TestDebug.AppendText(label_EqB.Text + "\r\n" + "\r\n" + "Nodes Configuration: { ");

                for (iEq = 0; equationNodes[iEq] != 0; iEq++) richTextBox_TestDebug.AppendText(equationNodes[iEq] + ", ");
                richTextBox_TestDebug.Undo();
                richTextBox_TestDebug.AppendText(equationNodes[iEq - 1] + " }" + "\r\n"); 

                if (File.Exists(label_EqW.Text + "\\PARAMETERS\\PARAMETERS.TXT"))
                {
                    string line;
                    using (StreamReader reader = new StreamReader(label_EqW.Text + "\\PARAMETERS\\PARAMETERS.TXT"))
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            richTextBox_TestDebug.AppendText(line + "\r\n");
                        }
                    }
                }

                richTextBox_TestDebug.AppendText("\r\n" + "\r\n" + @"Weight / Bias Files:" + "\r\n");

                // richTextBox_TestDebug.AppendText(listBox_availableWeight.SelectedItem.ToString() + "\r\n");
                string tempEqNW = listBox_availableWeight.SelectedItem.ToString();
                var eqNW = tempEqNW.Split(new char[] { 'N', '=', 'I', 'T', 'E', 'R', 'A', 'I', 'O', ',', ' ' });
                for (int k = 0; k < eqNW.Length; k++)
                {
                    if (eqNW[k] != "" & !switchEq) { selectedEqN = int.Parse(eqNW[k].ToString()); switchEq = true; }
                    if (eqNW[k] != "" & switchEq) selectedEqW = int.Parse(eqNW[k].ToString());
                }

                // Reading the selected files
                var eqWeightList = new List<string>();
                var eqBiasList = new List<string>();
                var eqWeightPNGList = new List<string>();
                var eqBiasPNGList = new List<string>();
                for (int i = 0; i < iEq - 1; i++)
                {
                    eqWeightList.Add(label_EqW.Text + "\\N" + selectedEqN + "C" + selectedEqW + "L" + i + ".txt");
                    eqBiasList.Add(label_EqB.Text + "\\N" + selectedEqN + "C" + selectedEqW + "L" + i + ".txt");
                    eqWeightPNGList.Add(label_EqW.Text + "\\IMAGE\\N" + selectedEqN + "C" + selectedEqW + "L" + i + ".png");
                    eqBiasPNGList.Add(label_EqB.Text + "\\IMAGE\\N" + selectedEqN + "C" + selectedEqW + "L" + i + ".png");
                }

                for (int i = 0; i < eqWeightList.Count; i++)
                {
                    richTextBox_TestDebug.AppendText(eqWeightList[i] + "\r\n");
                    richTextBox_TestDebug.AppendText(eqBiasList[i] + "\r\n");
                }

                // Basic Formula
                richTextBox_TestDebug.AppendText("\r\n" + "\r\n" + "\r\n");
                string latexOri = @"X_{N} = f(A_{N-1})";
                var parser1 = new TexFormulaParser();
                var formula1 = parser1.Parse(latexOri);
                var pngBytes1 = formula1.RenderToPng(20.0, 0.0, 0.0, "Arial");
                if (!Directory.Exists(label_EqW.Text + "\\IMAGE")) { Directory.CreateDirectory(label_EqW.Text + "\\IMAGE"); }
                File.WriteAllBytes(label_EqW.Text + "\\IMAGE\\Basic01.png", pngBytes1);
                FileStream pngStream1 = new FileStream(label_EqW.Text + "\\IMAGE\\Basic01.png", FileMode.Open, FileAccess.Read);
                Clipboard.SetImage(Image.FromStream(pngStream1));
                pngStream1.Close();
                richTextBox_TestDebug.Paste();
                richTextBox_TestDebug.AppendText(",  " + "\t" + "\t");

                latexOri = @"f(A_{N-1}) = activation function";
                formula1 = parser1.Parse(latexOri);
                pngBytes1 = formula1.RenderToPng(20.0, 0.0, 0.0, "Arial");
                File.WriteAllBytes(label_EqW.Text + "\\IMAGE\\Basic03.png", pngBytes1);
                pngStream1 = new FileStream(label_EqW.Text + "\\IMAGE\\Basic03.png", FileMode.Open, FileAccess.Read);
                Clipboard.SetImage(Image.FromStream(pngStream1));
                pngStream1.Close();
                richTextBox_TestDebug.Paste();
                richTextBox_TestDebug.AppendText("\r\n" + "\r\n");

                latexOri = @"X_{N} = f(W_{N-1}X_{N-1} + B_{N-1})";
                formula1 = parser1.Parse(latexOri);
                pngBytes1 = formula1.RenderToPng(20.0, 0.0, 0.0, "Arial");
                File.WriteAllBytes(label_EqW.Text + "\\IMAGE\\Basic02.png", pngBytes1);
                pngStream1 = new FileStream(label_EqW.Text + "\\IMAGE\\Basic02.png", FileMode.Open, FileAccess.Read);
                Clipboard.SetImage(Image.FromStream(pngStream1));
                pngStream1.Close();
                richTextBox_TestDebug.Paste();
                richTextBox_TestDebug.AppendText("\r\n" + "\r\n");

                latexOri = @"A_{N-1} = W_{N-1}X_{N-1} + B_{N-1}";
                formula1 = parser1.Parse(latexOri);
                pngBytes1 = formula1.RenderToPng(20.0, 0.0, 0.0, "Arial");
                File.WriteAllBytes(label_EqW.Text + "\\IMAGE\\Basic04.png", pngBytes1);
                pngStream1 = new FileStream(label_EqW.Text + "\\IMAGE\\Basic04.png", FileMode.Open, FileAccess.Read);
                Clipboard.SetImage(Image.FromStream(pngStream1));
                pngStream1.Close();
                richTextBox_TestDebug.Paste();
                richTextBox_TestDebug.AppendText("\r\n" + "\r\n");

                latexOri = @"\pmatrix{A_{1}\\A_{2}\\.\\.\\.\\A_{m}}= \pmatrix{W_{1,1}&W_{1,2}&...&W_{1,n}\\ W_{2,1}&W_{2,2}&...&W_{2,n} \\.&.&.&.\\.&.&.&.\\.&.&.&.\\W_{m,1}&W_{m,2}&...&W_{m,n}} \pmatrix{X_{1}\\X_{2}\\.\\.\\.\\X_{n}} + \pmatrix{B_{1}\\B_{2}\\.\\.\\.\\B_{m}}";
                formula1 = parser1.Parse(latexOri);
                pngBytes1 = formula1.RenderToPng(20.0, 0.0, 0.0, "Arial");
                File.WriteAllBytes(label_EqW.Text + "\\IMAGE\\Basic05.png", pngBytes1);
                pngStream1 = new FileStream(label_EqW.Text + "\\IMAGE\\Basic05.png", FileMode.Open, FileAccess.Read);
                Clipboard.SetImage(Image.FromStream(pngStream1));
                pngStream1.Close();
                richTextBox_TestDebug.Paste();
                richTextBox_TestDebug.AppendText("\r\n" + "\r\n" + "N = layer number, start from the leftmost layer as FIRST layer ** The FIRST layer is also the input X **");
                richTextBox_TestDebug.AppendText("\r\n" + "n = number of input from the previous layer" + "\r\n" + "m = number of output in the current layer" + "\r\n");

                richTextBox_TestDebug.AppendText("\r\n" + "\r\n" + "==============================WEIGHT LIST==================================================" + "\r\n" + "\r\n");
                // Generates Weight PNG
                for (int k = 0; k < eqWeightList.Count; k++)
                {
                    string line = "";
                    string latex = @"W_{" + k;
                    latex = latex + @"}=\pmatrix{";
                    StreamReader file = new StreamReader(eqWeightList[k]);
                    while ((line = file.ReadLine()) != null)
                    {
                        var availableNumber = line.Split(new char[] { '\r', '\n', '\t', ' ' });
                        for (int i = 0; i < availableNumber.Length; i++)
                        {
                            if (availableNumber[i] != "")
                            {
                                double eqTemp = double.Parse(availableNumber[i]);
                                latex = latex + Math.Round(eqTemp, dp) + "&";
                            }
                        }
                        latex = latex.Remove(latex.Length - 1);
                        latex = latex + @"\\";
                    }
                    latex = latex.Remove(latex.Length - 2);
                    latex = latex + "}";
                    var parser = new TexFormulaParser();
                    var formula = parser.Parse(latex);
                    var pngBytes = formula.RenderToPng(20.0, 0.0, 0.0, "Arial");
                    if (!Directory.Exists(label_EqW.Text + "\\IMAGE")) { Directory.CreateDirectory(label_EqW.Text + "\\IMAGE"); }

                    File.WriteAllBytes(eqWeightPNGList[k], pngBytes);

                    FileStream pngStream = new FileStream(eqWeightPNGList[k], FileMode.Open, FileAccess.Read);
                    Clipboard.SetImage(Image.FromStream(pngStream));
                    pngStream.Close();
                    richTextBox_TestDebug.Paste();
                    file.Close();
                    richTextBox_TestDebug.AppendText("\t");
                }

                richTextBox_TestDebug.AppendText("\r\n" + "\r\n" + "==============================BIAS LIST==================================================" + "\r\n" + "\r\n");
                // Generates Bias PNG
                for (int k = 0; k < eqBiasList.Count; k++)
                {
                    string line = "";
                    string latex = @"B_{" + k;
                    latex = latex + @"}=\pmatrix{";
                    StreamReader file = new StreamReader(eqBiasList[k]);
                    while ((line = file.ReadLine()) != null)
                    {
                        var availableNumber = line.Split(new char[] { '\r', '\n', '\t', ' ' });
                        for (int i = 0; i < availableNumber.Length; i++)
                        {
                            if (availableNumber[i] != "")
                            {
                                double eqTemp = double.Parse(availableNumber[i]);
                                latex = latex + Math.Round(eqTemp, dp) + "&";
                            }
                        }
                        latex = latex.Remove(latex.Length - 1);
                        latex = latex + @"\\";
                    }
                    latex = latex.Remove(latex.Length - 2);
                    latex = latex + "}";
                    var parser = new TexFormulaParser();
                    var formula = parser.Parse(latex);
                    var pngBytes = formula.RenderToPng(20.0, 0.0, 0.0, "Arial");
                    if (!Directory.Exists(label_EqB.Text + "\\IMAGE")) { Directory.CreateDirectory(label_EqB.Text + "\\IMAGE"); }

                    File.WriteAllBytes(eqBiasPNGList[k], pngBytes);

                    FileStream pngStream = new FileStream(eqBiasPNGList[k], FileMode.Open, FileAccess.Read);
                    Clipboard.SetImage(Image.FromStream(pngStream));
                    pngStream.Close();
                    richTextBox_TestDebug.Paste();
                    file.Close();
                    richTextBox_TestDebug.AppendText("\t");
                }
                GC.Collect();
            }
            catch (Exception exx) { richTextBox_TestDebug.AppendText("(O_o)?" + "\r\n"); }
        }

        private void richTextBox_TestDebug_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            richTextBox_TestDebug.Clear();
        }

        private void button_Copy_Click(object sender, EventArgs e)
        {
            richTextBox_TestDebug.Copy();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            {
                string saveLog = "";
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = textBox_MainFolder.Text;
                saveFileDialog1.Title = "Save";
                //saveFileDialog1.CheckFileExists = true;
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "txt";
                saveFileDialog1.Filter = "Rich Text files (*.rtf)|*.rtf";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    saveLog = saveFileDialog1.FileName;
                    richTextBox_TestDebug.SaveFile(saveLog);
                }

            }
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl1.TabPages[e.Index];
            Color col = e.Index == 0 ? Color.Aqua : Color.Yellow;
            e.Graphics.FillRectangle(new SolidBrush(col), e.Bounds);

            Rectangle paddedBounds = e.Bounds;
            int yOffset = (e.State == DrawItemState.Selected) ? -2 : 1;
            paddedBounds.Offset(1, yOffset);
            TextRenderer.DrawText(e.Graphics, page.Text, Font, paddedBounds, page.ForeColor);
        }

        public void setPlayStopButton(bool isPlaying)
        {
            _assembly = Assembly.GetExecutingAssembly();
            if (isPlaying == true)
                _imageStream = _assembly.GetManifestResourceStream("NeuroNet_Project.stop.png");
            else
                _imageStream = _assembly.GetManifestResourceStream("NeuroNet_Project.play.png");
            pictureBox_StopCont.Image = new Bitmap(_imageStream);
        }

        public void requestParameter(bool e)
        {
            resultParameter =
                "Date: " + DateTime.Now + "\r\n" +
                "Activation Function: :" + comboBox_ActivateFunction.Text + "\r\n" +
                "Number of input: " + inputFiles.Length + "\r\n" +
                "Number of output: " + outputFiles.Length + "\r\n" +
                "Number of layer: " + numericUpDown_layer.Value + "\r\n" +
                "Number of nodes: " + numericUpDown_nodes.Value + "\r\n" +
                "Learning rate: " + numericUpDown_learn.Value + "\r\n";
        }

        // WORKER HERE //////////////////////////////////////////////////////////////////////////////

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            richTextBox_Summary.Focus();
            richTextBox_Summary.SelectionColor = Color.LightSkyBlue;
            switch (e.ProgressPercentage)
            {
                case 1:
                    richTextBox_FinalResult.AppendText(resultAll);
                    richTextBox_currentError.Text = resultRMS;
                    richTextBox_CurrentLoop.Text = resultLoops + "\t" +"N: " + N;
                    richTextBox_CurrentY.Text = resultSingle;
                    float newLR = 0;
                    float newM = 0;
                    newLR = (float)numericUpDown_learn.Value * (float)Math.Exp(-tempAdaptiveCorrection / (float)numericUpDown_DecayRate.Value); 
                    newM = (float)numericUpDown_momentum.Value * (float)Math.Exp(-tempAdaptiveCorrection / (float)numericUpDown_DecayRate.Value);

                    if (checkBox_adaptiveRate.Checked == true)
                    {
                        label_LRM.Text = "Momentum: " + String.Format("{0:f" + 15 + "}", newM) + "\t" + "          Learning rate: " + String.Format("{0:f" + 15 + "}", newLR);
                    }
                    else
                    {
                        label_LRM.Text = "Momentum: " + String.Format("{0:f" + 15 + "}", numericUpDown_momentum.Value) + "\t" + "          Learning rate: " + String.Format("{0:f" + 15 + "}", numericUpDown_learn.Value);
                    }
                    TimeNow();
                    richTextBox_Summary.SelectionColor = Color.Lime;
                    richTextBox_Summary.AppendText(resultRMS + "\r\n");

                    break;
                case 2:
                    label_loopsCounter.Text = "Loops: " + loopsCounter;
                    break;
                case 3:
                    TimeNow();
                    richTextBox_Summary.SelectionColor = Color.LightSkyBlue;
                    richTextBox_Summary.AppendText("Neural Network Initialized");
                    break;
                case 4:
                    TimeNow();
                    richTextBox_Summary.SelectionColor = Color.LightSkyBlue;
                    richTextBox_Summary.AppendText("Weight and bias saved to " );
                    richTextBox_Summary.SelectionColor = Color.Lime;
                    richTextBox_Summary.AppendText(" . . . " + resultReportWeight + "\r\n");
                    break;
                case 5:
                    richTextBox_Summary.SelectionColor = Color.Lime;
                    richTextBox_Summary.AppendText(" . . . OK " + "\r\n");
                    break;
                default:
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                richTextBox_Summary.Focus();
                TimeNow();
                richTextBox_Summary.SelectionColor = Color.Red;
                richTextBox_Summary.AppendText("Cancelled by user !!!" + "\r\n" );
                checkPlaying = false;
                setPlayStopButton(checkPlaying);
            }
            else if (e.Error != null)
            {
                richTextBox_Summary.Focus();
                TimeNow();
                richTextBox_Summary.SelectionColor = Color.Red;
                richTextBox_Summary.AppendText("Error !!!");
                ErrorText();
                checkPlaying = false;
                setPlayStopButton(checkPlaying);
            }
            else
            {
                richTextBox_Summary.Focus();
                TimeNow();
                richTextBox_Summary.SelectionColor = Color.Lime;
                richTextBox_Summary.AppendText(@"BackPropagation completed. " + "\r\n");
                checkPlaying = false;
                checkBox_UseExistW.Checked = true;
                setPlayStopButton(checkPlaying);
            }
        }

        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int[] ArrayForRandom = new int[D_loops];
            Random targetJ = new Random();
            int tempTarget;
            BackgroundWorker worker = sender as BackgroundWorker;
            if (N != -1 && checkBox_UseExistW.Checked == false) N++;
            if (N == -1) N = 0;
            if (checkBox_UseExistW.Checked == false) C = 0;


            worker.ReportProgress(3);
            Neuro net = new Neuro(layer, P_learn, checkBox_UseExistW.Checked, existingWeightPath, existingBiasPath, (float)numericUpDown_momentum.Value); //intiilize network
            worker.ReportProgress(5);

            for (int i = 1; i < P_loops + 1; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                for (int k = 0; k < D_loops; k++) ArrayForRandom[k] = k; // initialize array for comparison
                tempTarget = targetJ.Next(0, D_loops);

                for (int j = 0; j < D_loops; j++)
                {
                    while (ArrayForRandom[tempTarget] == -1)
                    {
                        tempTarget = targetJ.Next(0, D_loops);
                    }
                    ArrayForRandom[tempTarget] = -1;

                    input = fileProcess.getData(label_InputPath.Text, tempTarget);
                    expected = fileProcess.getData(label_OutputPath.Text, tempTarget);
                    net.FeedForward(input, P_activ);
                    net.BackProp(expected, P_activ, checkBox_adaptiveRate.Checked, tempAdaptiveCorrection, (float)numericUpDown_DecayRate.Value);
                    loopsCounter = i + previousLoopsCounter;
                    worker.ReportProgress(2);
                }
                if( i % 1000 == 0 && i!=0 )
                {
                    resultAll = "";
                    resultSingle = "";
                    resultLoops = "";
                    resultRMS = "";

                    for (int j = 0; j < D_loops; j++)
                    {
                        int N;
                        
                        float temp = 0;
                        // remove here 
                        input = fileProcess.getData(label_InputPath.Text, j);
                        expected = fileProcess.getData(label_OutputPath.Text, j);
                        result = net.FeedForward(input, P_activ);
                        temp = fileProcess.error(result, expected);
                        cost = (float)Math.Round(temp,5);
                        different = fileProcess.diff(result, expected);
                        tempAdaptiveCorrection = loopsCounter;
                        tempMaxMin[0] = tempMaxMin[1] = 0;
                        //for (N =0; N < different.Length ; N++)
                        //{
                        //    tempMaxMin[0] = (float)Math.Min(different[N], tempMaxMin[0]);
                        //    tempMaxMin[1] = (float)Math.Max(different[N], tempMaxMin[1]);
                        //    tempAdaptiveCorrection = tempMaxMin[1] - tempMaxMin[0];
                        //}
                        // tempAdaptiveCorrection = tempAdaptiveCorrection / N;
                        // if (tempAdaptiveCorrection > (float)numericUpDown_momentum.Value) tempAdaptiveCorrection = (float)numericUpDown_momentum.Value;

                        int DP = (int)numericUpDown_DP.Value;
                        for (int k = 0; k < result.Length; k++)
                        {
                            

                            resultSingle = resultSingle + String.Format("{0:f" + DP + "}", Math.Round(result[k], DP))
                                         + " (" + String.Format("{0:f" + DP + "}", Math.Round(different[k], DP)) + ")" + "\t";
                        }
                        resultSingle = resultSingle + "\r\n";
                        resultLoops = "Loops: " + loopsCounter;
                        resultRMS = "RMS Error: " + String.Format("{0:f" + 15 + "}", cost);
                    }
                    resultAll = resultParameter + "\r\n" + resultLoops + ", \t" + "N: " + N + " , \t" + resultRMS + "\r\n" + resultSingle + "\r\n";
                    resultParameter = "";
                    //net.WtoF(N, C + i, label_WeightPath.Text);
                    //net.BtoF(N, C + i, label_biasPath.Text);
                    worker.ReportProgress(1); // update error and y to screen // sent it to result tab too.
                }
                if (i % P_save == 0 && i != 0)
                {
                    resultReportWeight = @"\N" + N + "C" + loopsCounter + "L_.txt";
                    net.WtoF(N, C + i, label_WeightPath.Text);
                    net.BtoF(N, C + i, label_biasPath.Text);
                    worker.ReportProgress(4);
                }
            }
           
            worker.Dispose();

        }

        public void TimeNow()
        {
            CurrentTime = " [" + DateTime.Now.ToString("HH") + " " + DateTime.Now.ToString("mm") + " " + DateTime.Now.ToString("ss") + "]  ";
            richTextBox_Summary.SelectionColor = Color.PowderBlue;
            richTextBox_Summary.AppendText(CurrentTime);
            return;
        }
        public void ErrorText()
        {
            richTextBox_Summary.SelectionColor = Color.Yellow;
            richTextBox_Summary.AppendText("  Σ( ﾟДﾟ ?)" + "\r\n");
            return;
        }



    }
            
           

            
        
    
}
