using System;
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


namespace NeuroNet_Project
{
    public partial class Form_Main : Form
    {
        string[] inputFiles;
        string[] outputFiles;
        string[] weightFolder;


        public Form_Main()
        {
            InitializeComponent();
        }

        private void button_Go_Click(object sender, EventArgs e)
        {
            panel_Loading.BringToFront();
        }

        private void button_Stop_Click(object sender, EventArgs e)
        {
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

        private void label_OutputPath_TextChanged(object sender, EventArgs e)
        {
            outputFiles = Directory.GetFiles(label_InputPath.Text);
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
    }
}
