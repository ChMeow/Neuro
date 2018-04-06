namespace NeuroNet_Project
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel_Loading = new System.Windows.Forms.Panel();
            this.button_Stop = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button_Weight = new System.Windows.Forms.Button();
            this.button_Output = new System.Windows.Forms.Button();
            this.button_Input = new System.Windows.Forms.Button();
            this.button_SaveSetting = new System.Windows.Forms.Button();
            this.button_Go = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label_InputPath = new System.Windows.Forms.Label();
            this.label_OutputPath = new System.Windows.Forms.Label();
            this.label_WeightPath = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_ActivateFunction = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_layer = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nodes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_learn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_loops = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Summary = new System.Windows.Forms.RichTextBox();
            this.checkBox_UseExistW = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown_save = new System.Windows.Forms.NumericUpDown();
            this.panel_Loading.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_layer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_learn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loops)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_save)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Loading
            // 
            this.panel_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Loading.Controls.Add(this.button_Stop);
            this.panel_Loading.Location = new System.Drawing.Point(19, 20);
            this.panel_Loading.Name = "panel_Loading";
            this.panel_Loading.Size = new System.Drawing.Size(900, 561);
            this.panel_Loading.TabIndex = 0;
            // 
            // button_Stop
            // 
            this.button_Stop.Location = new System.Drawing.Point(752, 490);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(103, 28);
            this.button_Stop.TabIndex = 0;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(19, 20);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 561);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numericUpDown_save);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.checkBox_UseExistW);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.numericUpDown_loops);
            this.tabPage1.Controls.Add(this.numericUpDown_learn);
            this.tabPage1.Controls.Add(this.numericUpDown_nodes);
            this.tabPage1.Controls.Add(this.numericUpDown_layer);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox_ActivateFunction);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label_WeightPath);
            this.tabPage1.Controls.Add(this.label_OutputPath);
            this.tabPage1.Controls.Add(this.label_InputPath);
            this.tabPage1.Controls.Add(this.button_Weight);
            this.tabPage1.Controls.Add(this.button_Output);
            this.tabPage1.Controls.Add(this.button_Input);
            this.tabPage1.Controls.Add(this.button_SaveSetting);
            this.tabPage1.Controls.Add(this.button_Go);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button_Weight
            // 
            this.button_Weight.Location = new System.Drawing.Point(6, 62);
            this.button_Weight.Name = "button_Weight";
            this.button_Weight.Size = new System.Drawing.Size(90, 23);
            this.button_Weight.TabIndex = 4;
            this.button_Weight.Text = "Weight Path";
            this.button_Weight.UseVisualStyleBackColor = true;
            this.button_Weight.Click += new System.EventHandler(this.button_Weight_Click);
            // 
            // button_Output
            // 
            this.button_Output.Location = new System.Drawing.Point(6, 33);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(91, 23);
            this.button_Output.TabIndex = 3;
            this.button_Output.Text = "Output Path";
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // button_Input
            // 
            this.button_Input.Location = new System.Drawing.Point(6, 6);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(92, 21);
            this.button_Input.TabIndex = 2;
            this.button_Input.Text = "Input Path";
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            // 
            // button_SaveSetting
            // 
            this.button_SaveSetting.Location = new System.Drawing.Point(612, 498);
            this.button_SaveSetting.Name = "button_SaveSetting";
            this.button_SaveSetting.Size = new System.Drawing.Size(90, 30);
            this.button_SaveSetting.TabIndex = 1;
            this.button_SaveSetting.Text = "Save Settings";
            this.button_SaveSetting.UseVisualStyleBackColor = true;
            this.button_SaveSetting.Click += new System.EventHandler(this.button_SaveSetting_Click);
            // 
            // button_Go
            // 
            this.button_Go.Location = new System.Drawing.Point(772, 498);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(90, 30);
            this.button_Go.TabIndex = 0;
            this.button_Go.Text = "GO";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button_Go_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Results";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(892, 535);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Nodes Control";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label_InputPath
            // 
            this.label_InputPath.AutoSize = true;
            this.label_InputPath.Location = new System.Drawing.Point(104, 10);
            this.label_InputPath.Name = "label_InputPath";
            this.label_InputPath.Size = new System.Drawing.Size(43, 13);
            this.label_InputPath.TabIndex = 5;
            this.label_InputPath.Text = "Not Set";
            this.label_InputPath.TextChanged += new System.EventHandler(this.label_InputPath_TextChanged);
            // 
            // label_OutputPath
            // 
            this.label_OutputPath.AutoSize = true;
            this.label_OutputPath.Location = new System.Drawing.Point(111, 36);
            this.label_OutputPath.Name = "label_OutputPath";
            this.label_OutputPath.Size = new System.Drawing.Size(43, 13);
            this.label_OutputPath.TabIndex = 6;
            this.label_OutputPath.Text = "Not Set";
            this.label_OutputPath.TextChanged += new System.EventHandler(this.label_OutputPath_TextChanged);
            // 
            // label_WeightPath
            // 
            this.label_WeightPath.AutoSize = true;
            this.label_WeightPath.Location = new System.Drawing.Point(109, 70);
            this.label_WeightPath.Name = "label_WeightPath";
            this.label_WeightPath.Size = new System.Drawing.Size(43, 13);
            this.label_WeightPath.TabIndex = 7;
            this.label_WeightPath.Text = "Not Set";
            this.label_WeightPath.TextChanged += new System.EventHandler(this.label_WeightPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Activation Function";
            // 
            // comboBox_ActivateFunction
            // 
            this.comboBox_ActivateFunction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ActivateFunction.FormattingEnabled = true;
            this.comboBox_ActivateFunction.Items.AddRange(new object[] {
            "1. Tanh",
            "2. Logistic",
            "3. Binary Step",
            "4. ArcTan",
            "5. SoftSign",
            "6. SoftPlus",
            "7. Bent identity",
            "8. Sin",
            "9. Gaussian"});
            this.comboBox_ActivateFunction.Location = new System.Drawing.Point(130, 157);
            this.comboBox_ActivateFunction.Name = "comboBox_ActivateFunction";
            this.comboBox_ActivateFunction.Size = new System.Drawing.Size(139, 21);
            this.comboBox_ActivateFunction.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Layer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nodes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Learning Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of Loops";
            // 
            // numericUpDown_layer
            // 
            this.numericUpDown_layer.Location = new System.Drawing.Point(130, 251);
            this.numericUpDown_layer.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_layer.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_layer.Name = "numericUpDown_layer";
            this.numericUpDown_layer.Size = new System.Drawing.Size(136, 20);
            this.numericUpDown_layer.TabIndex = 14;
            this.numericUpDown_layer.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_nodes
            // 
            this.numericUpDown_nodes.Location = new System.Drawing.Point(130, 280);
            this.numericUpDown_nodes.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_nodes.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_nodes.Name = "numericUpDown_nodes";
            this.numericUpDown_nodes.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_nodes.TabIndex = 15;
            this.numericUpDown_nodes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_learn
            // 
            this.numericUpDown_learn.DecimalPlaces = 5;
            this.numericUpDown_learn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_learn.Location = new System.Drawing.Point(130, 192);
            this.numericUpDown_learn.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_learn.Name = "numericUpDown_learn";
            this.numericUpDown_learn.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_learn.TabIndex = 16;
            // 
            // numericUpDown_loops
            // 
            this.numericUpDown_loops.Location = new System.Drawing.Point(130, 220);
            this.numericUpDown_loops.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_loops.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_loops.Name = "numericUpDown_loops";
            this.numericUpDown_loops.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_loops.TabIndex = 17;
            this.numericUpDown_loops.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_Summary);
            this.groupBox1.Location = new System.Drawing.Point(312, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 391);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // richTextBox_Summary
            // 
            this.richTextBox_Summary.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox_Summary.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox_Summary.Location = new System.Drawing.Point(8, 16);
            this.richTextBox_Summary.Name = "richTextBox_Summary";
            this.richTextBox_Summary.ReadOnly = true;
            this.richTextBox_Summary.Size = new System.Drawing.Size(525, 366);
            this.richTextBox_Summary.TabIndex = 0;
            this.richTextBox_Summary.Text = "";
            // 
            // checkBox_UseExistW
            // 
            this.checkBox_UseExistW.AutoSize = true;
            this.checkBox_UseExistW.Location = new System.Drawing.Point(6, 91);
            this.checkBox_UseExistW.Name = "checkBox_UseExistW";
            this.checkBox_UseExistW.Size = new System.Drawing.Size(167, 17);
            this.checkBox_UseExistW.TabIndex = 34;
            this.checkBox_UseExistW.Text = "Continue from Existing Weight";
            this.checkBox_UseExistW.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Save weight per ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "loops";
            // 
            // numericUpDown_save
            // 
            this.numericUpDown_save.Location = new System.Drawing.Point(130, 313);
            this.numericUpDown_save.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_save.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_save.Name = "numericUpDown_save";
            this.numericUpDown_save.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_save.TabIndex = 36;
            this.numericUpDown_save.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 597);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_Loading);
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.Text = "NeuroNet Project";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel_Loading.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_layer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_learn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loops)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_save)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Loading;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button_Go;
        private System.Windows.Forms.Button button_SaveSetting;
        private System.Windows.Forms.Button button_Output;
        private System.Windows.Forms.Button button_Input;
        private System.Windows.Forms.Button button_Weight;
        private System.Windows.Forms.Label label_InputPath;
        private System.Windows.Forms.Label label_WeightPath;
        private System.Windows.Forms.Label label_OutputPath;
        private System.Windows.Forms.ComboBox comboBox_ActivateFunction;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_loops;
        private System.Windows.Forms.NumericUpDown numericUpDown_learn;
        private System.Windows.Forms.NumericUpDown numericUpDown_nodes;
        private System.Windows.Forms.NumericUpDown numericUpDown_layer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_Summary;
        private System.Windows.Forms.CheckBox checkBox_UseExistW;
        private System.Windows.Forms.NumericUpDown numericUpDown_save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

