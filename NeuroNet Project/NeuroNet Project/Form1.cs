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

namespace NeuroNet_Project
{
    public partial class Form_Main : Form
    {
        string[] inputFiles;
        string[] outputFiles;
        string[] weightFolder;
        string existingWeightPath; // with part of the name included, N and C value // C is the continue cycle, N is for seperate cycle. ie. N will increase a number if use existing weight is unchecked.
        int P_activ, P_loops, P_layer, P_nodes, P_save, D_loops, D_Compare;
        float P_learn;
        int[] layer;
        float[] input;
        float[] expected;
        float[] result = new float[1];
        int N = 0, C = 0;
        int[] checkNC = new int[3];
        Assembly _assembly;
        Stream _imageStream;
        int loopsCounter;
        bool checkPlaying = false;
        int previousLoopsCounter = 0;
        float cost;

        string resultSingle;
        string resultAll;
        string resultLoops;
        string resultRMS;




        public Form_Main()
        {
            InitializeComponent();
            // need this 4 line to initialize Worker 1////////////////

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
                if (checkNC[2] != P_layer - 2)
                {
                    richTextBox_Summary.SelectionColor = Color.Red;
                    richTextBox_Summary.AppendText("ERROR, Unable to proceed, Weight Data Not Match" + "\r\n");
                    goto endofthisbutton;
                }
                previousLoopsCounter = C;
            }
            else previousLoopsCounter = 0;

            if (D_loops != D_Compare || D_loops < 0)
            {
                richTextBox_Summary.SelectionColor = Color.Red;
                richTextBox_Summary.AppendText("ERROR, Input Output Data Not Match, -1" + "\r\n");
                goto endofthisbutton;
            }
            //get weightpath as part of the neuro construction //

            if (backgroundWorker1.IsBusy != true)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            panel_Loading.BringToFront();
            checkPlaying = true;
            setPlayStopButton(checkPlaying);
            endofthisbutton:
            int gg = 0;
            

        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
            }
            panel_Loading.SendToBack();
        }

        private void button_Input_Click(object sender, EventArgs e)
        {
            var inputSelect = new FolderSelectDialog();
            inputSelect.Title = "Select Input Path";
            inputSelect.InitialDirectory = @"c:\";
            if (inputSelect.ShowDialog(IntPtr.Zero))
            {
                label_InputPath.Text = inputSelect.FileName;
            }
        }

        private void button_Output_Click(object sender, EventArgs e)
        {
            var OutputSelect = new FolderSelectDialog();
            OutputSelect.Title = "Select Output Path";
            OutputSelect.InitialDirectory = @"c:\";
            if (OutputSelect.ShowDialog(IntPtr.Zero))
            {
                label_OutputPath.Text = OutputSelect.FileName;
            }
        }

        private void button_Weight_Click(object sender, EventArgs e)
        {
            var WeightSelect = new FolderSelectDialog();
            WeightSelect.Title = "Select Weight Path";
            WeightSelect.InitialDirectory = @"c:\";
            if (WeightSelect.ShowDialog(IntPtr.Zero))
            {
                label_WeightPath.Text = WeightSelect.FileName;
            }
        }


        private void label_InputPath_TextChanged(object sender, EventArgs e)
        {
            inputFiles = Directory.GetFiles(label_InputPath.Text);
            richTextBox_Summary.SelectionColor = Color.White;
            richTextBox_Summary.AppendText("Number of input in " + label_InputPath.Text + " ______ ");
            richTextBox_Summary.SelectionColor = Color.Aqua;
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
            richTextBox_Summary.SelectionColor = Color.White;
            richTextBox_Summary.AppendText("Number of output in " + label_OutputPath.Text + " ______ ");
            richTextBox_Summary.SelectionColor = Color.Aqua;
            richTextBox_Summary.AppendText(outputFiles.Length + "\r\n");
        }

        /// <summary>
        /// NOT YET DONE
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label_WeightPath_TextChanged(object sender, EventArgs e)
        {
            weightFolder = Directory.GetDirectories(label_WeightPath.Text);

            richTextBox_Summary.SelectionColor = Color.White;
            richTextBox_Summary.AppendText("Weight NOT YET COMPLETE");
            richTextBox_Summary.SelectionColor = Color.Aqua;
            richTextBox_Summary.AppendText(weightFolder.Length + "\r\n");
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
            file.WriteLine(numericUpDown_save.Value);
            file.WriteLine(comboBox_ActivateFunction.Text);
            file.WriteLine(numericUpDown_layer.Value);
            file.WriteLine(numericUpDown_nodes.Value);
            file.WriteLine(numericUpDown_loops.Value);
            file.WriteLine(numericUpDown_learn.Value);
            //file.WriteLine(numericUpDown_momentum.Value);

            file.Close();
            richTextBox_Summary.SelectionColor = Color.Lime;
            richTextBox_Summary.AppendText("Setting Saved" + "\r\n");
            GC.Collect();
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
                    numericUpDown_save.Value = Convert.ToDecimal(file.ReadLine());
                    comboBox_ActivateFunction.Text = file.ReadLine();
                    numericUpDown_layer.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDown_nodes.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDown_loops.Value = Convert.ToDecimal(file.ReadLine());
                    numericUpDown_learn.Value = Convert.ToDecimal(file.ReadLine());
                    // numericUpDown_momentum.Value = Convert.ToDecimal(file.ReadLine());
                }
                catch (Exception exx)
                {
                    richTextBox_Summary.SelectionColor = Color.Red;
                    richTextBox_Summary.AppendText("Setting File Error" + "\r\n");
                }

                file.Close();
                GC.Collect();

            }
        }
        
        public void setPlayStopButton(bool isPlaying)
        {
            _assembly = Assembly.GetExecutingAssembly();
            if (isPlaying == true)
                _imageStream = _assembly.GetManifestResourceStream("NeuroNet_Project.Stop.bmp");
            else
                _imageStream = _assembly.GetManifestResourceStream("NeuroNet_Project.Play.bmp");
            pictureBox_StopCont.Image = new Bitmap(_imageStream);
        }

        // WORKER HERE //////////////////////////////////////////////////////////////////////////////

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            richTextBox_Summary.SelectionColor = Color.Aqua;
            switch (e.ProgressPercentage)
            {
                case 1:
                    richTextBox_FinalResult.AppendText(resultAll);
                    richTextBox_currentError.Text = resultRMS;
                    richTextBox_CurrentLoop.Text = resultLoops;
                    richTextBox_CurrentY.Text = resultSingle;
                    break;
                case 2:
                    label_loopsCounter.Text = "Loops: " + loopsCounter;
                    break;
                case 3:
                    int ii = 1;
                    break;
                default:
                    break;
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                richTextBox_Summary.SelectionColor = Color.Red;
                richTextBox_Summary.AppendText("\r\n" + "Cancelled" + "\r\n");
                checkPlaying = false;
                setPlayStopButton(checkPlaying);
            }
            else if (e.Error != null)
            {
                richTextBox_Summary.SelectionColor = Color.Red;
                richTextBox_Summary.AppendText("\r\n" + "Error" + "\r\n");
                checkPlaying = false;
                setPlayStopButton(checkPlaying);
            }
            else
            {
                richTextBox_Summary.SelectionColor = Color.Lime;
                richTextBox_Summary.AppendText("\r\n" + "Done" + "\r\n");
                checkPlaying = false;
                checkBox_UseExistW.Checked = true;
                setPlayStopButton(checkPlaying);
            }
        }

        public void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;
            if (N != -1 && checkBox_UseExistW.Checked == false) N++;
            if (N == -1) N = 0;
            if (checkBox_UseExistW.Checked == false) C = 0;



            Neuro net = new Neuro(layer, P_learn, checkBox_UseExistW.Checked, existingWeightPath); //intiilize network
            
            for (int i = 1; i < P_loops + 1; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }

                for (int j = 0; j < D_loops; j++)
                {
                    input = fileProcess.getData(label_InputPath.Text, j);
                    expected = fileProcess.getData(label_OutputPath.Text, j);
                    net.FeedForward(input, P_activ);
                    net.BackProp(expected, P_activ);
                    loopsCounter = i + previousLoopsCounter;
                    worker.ReportProgress(2);
                }
                if( i % P_save == 0 && i!=0 )
                {
                    resultAll = "";
                    resultSingle = "";
                    resultLoops = "";
                    resultRMS = "";

                    for (int j = 0; j < D_loops; j++)
                    {
                        float temp = 0;
                        // remove here 
                        input = fileProcess.getData(label_InputPath.Text, j);
                        expected = fileProcess.getData(label_OutputPath.Text, j);
                        result = net.FeedForward(input, P_activ);
                        temp = fileProcess.error(result, expected);
                        cost = (float)Math.Round(temp,4);
                        for (int k = 0; k < result.Length; k++)
                            resultSingle = resultSingle + Math.Round(result[k], 4) + "\t";
                        resultSingle = resultSingle + "\r\n";
                        resultLoops = "Loops: " + loopsCounter;
                        resultRMS = "RMS Error: " + cost;
                        resultAll = resultLoops + " , " + resultRMS + "\r\n" + resultSingle;
                    }

                    net.WtoF(N, C + i, label_WeightPath.Text);
                    worker.ReportProgress(1); // update error and y to screen // sent it to result tab too.
                }
                    
            }
           
            worker.Dispose();

        }
    }
            
           

            
        
    
}
