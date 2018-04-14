using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroNet_Project
{
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            string currentPath;
            string FilePath;

            currentPath = Directory.GetCurrentDirectory();
            try
            {
                FilePath = currentPath + @"\Info_activation.rtf";
                richTextBox_Activation.LoadFile(FilePath);
            }
            catch (FileNotFoundException ex)
            {
                richTextBox_Activation.Text = "FILE NOT FOUND :(";
            }

            try
            {
                FilePath = currentPath + @"\Info_rate.rtf";
                richTextBox_Rate.LoadFile(FilePath);
            }
            catch (FileNotFoundException ex)
            {
                richTextBox_Rate.Text = "FILE NOT FOUND :(";
            }

            try
            {
                FilePath = currentPath + @"\Info_BackPropagation.rtf";
                richTextBox_BackPropagation.LoadFile(FilePath);
            }
            catch (FileNotFoundException ex)
            {
                richTextBox_BackPropagation.Text = "FILE NOT FOUND :(";
            }

            try
            {
                FilePath = currentPath + @"\Info_How to use.rtf";
                richTextBox_HowtoUse.LoadFile(FilePath);
            }
            catch (FileNotFoundException ex)
            {
                richTextBox_HowtoUse.Text = "FILE NOT FOUND :(";
            }
        }
    }
}
