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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.panel_Loading = new System.Windows.Forms.Panel();
            this.richTextBox_CurrentY = new System.Windows.Forms.RichTextBox();
            this.richTextBox_currentError = new System.Windows.Forms.RichTextBox();
            this.richTextBox_CurrentLoop = new System.Windows.Forms.RichTextBox();
            this.label_loopsCounter = new System.Windows.Forms.Label();
            this.pictureBox_Switch = new System.Windows.Forms.PictureBox();
            this.pictureBox_StopCont = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox_Info = new System.Windows.Forms.PictureBox();
            this.checkBox_adaptiveRate = new System.Windows.Forms.CheckBox();
            this.numericUpDown_momentum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label_biasPath = new System.Windows.Forms.Label();
            this.button_BiasPath = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_DP = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_Switch2 = new System.Windows.Forms.PictureBox();
            this.numericUpDown_save = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_UseExistW = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Summary = new System.Windows.Forms.RichTextBox();
            this.numericUpDown_loops = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_learn = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_nodes = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_layer = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_ActivateFunction = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_WeightPath = new System.Windows.Forms.Label();
            this.label_OutputPath = new System.Windows.Forms.Label();
            this.label_InputPath = new System.Windows.Forms.Label();
            this.button_Weight = new System.Windows.Forms.Button();
            this.button_Output = new System.Windows.Forms.Button();
            this.button_Input = new System.Windows.Forms.Button();
            this.button_SaveSetting = new System.Windows.Forms.Button();
            this.button_Go = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button_clearLog = new System.Windows.Forms.Button();
            this.button_saveLog = new System.Windows.Forms.Button();
            this.richTextBox_FinalResult = new System.Windows.Forms.RichTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label_Vbp = new System.Windows.Forms.Label();
            this.button_VBP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richTextBox_Vout = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Vact = new System.Windows.Forms.ComboBox();
            this.labelWinfo = new System.Windows.Forms.Label();
            this.label_Vw = new System.Windows.Forms.Label();
            this.label_Vin = new System.Windows.Forms.Label();
            this.button_CResult = new System.Windows.Forms.Button();
            this.button_Vsave = new System.Windows.Forms.Button();
            this.button_Vgo = new System.Windows.Forms.Button();
            this.button_Vw = new System.Windows.Forms.Button();
            this.button_Vin = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel_Loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Switch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StopCont)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_momentum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Switch2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_save)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loops)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_learn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nodes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_layer)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Loading
            // 
            this.panel_Loading.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Loading.Controls.Add(this.richTextBox_CurrentY);
            this.panel_Loading.Controls.Add(this.richTextBox_currentError);
            this.panel_Loading.Controls.Add(this.richTextBox_CurrentLoop);
            this.panel_Loading.Controls.Add(this.label_loopsCounter);
            this.panel_Loading.Controls.Add(this.pictureBox_Switch);
            this.panel_Loading.Controls.Add(this.pictureBox_StopCont);
            this.panel_Loading.Location = new System.Drawing.Point(-1, 0);
            this.panel_Loading.Name = "panel_Loading";
            this.panel_Loading.Size = new System.Drawing.Size(942, 606);
            this.panel_Loading.TabIndex = 0;
            // 
            // richTextBox_CurrentY
            // 
            this.richTextBox_CurrentY.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox_CurrentY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_CurrentY.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_CurrentY.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox_CurrentY.Location = new System.Drawing.Point(12, 99);
            this.richTextBox_CurrentY.Name = "richTextBox_CurrentY";
            this.richTextBox_CurrentY.ReadOnly = true;
            this.richTextBox_CurrentY.Size = new System.Drawing.Size(914, 441);
            this.richTextBox_CurrentY.TabIndex = 6;
            this.richTextBox_CurrentY.Text = "";
            this.richTextBox_CurrentY.WordWrap = false;
            // 
            // richTextBox_currentError
            // 
            this.richTextBox_currentError.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox_currentError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_currentError.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_currentError.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox_currentError.Location = new System.Drawing.Point(12, 53);
            this.richTextBox_currentError.Name = "richTextBox_currentError";
            this.richTextBox_currentError.ReadOnly = true;
            this.richTextBox_currentError.Size = new System.Drawing.Size(454, 46);
            this.richTextBox_currentError.TabIndex = 5;
            this.richTextBox_currentError.Text = "RMS Error: --";
            // 
            // richTextBox_CurrentLoop
            // 
            this.richTextBox_CurrentLoop.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.richTextBox_CurrentLoop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox_CurrentLoop.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_CurrentLoop.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox_CurrentLoop.Location = new System.Drawing.Point(12, 11);
            this.richTextBox_CurrentLoop.Name = "richTextBox_CurrentLoop";
            this.richTextBox_CurrentLoop.ReadOnly = true;
            this.richTextBox_CurrentLoop.Size = new System.Drawing.Size(454, 44);
            this.richTextBox_CurrentLoop.TabIndex = 4;
            this.richTextBox_CurrentLoop.Text = "Loops: --         N: --";
            // 
            // label_loopsCounter
            // 
            this.label_loopsCounter.AutoSize = true;
            this.label_loopsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_loopsCounter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_loopsCounter.Location = new System.Drawing.Point(6, 565);
            this.label_loopsCounter.Name = "label_loopsCounter";
            this.label_loopsCounter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_loopsCounter.Size = new System.Drawing.Size(128, 31);
            this.label_loopsCounter.TabIndex = 3;
            this.label_loopsCounter.Text = "Loops: -- ";
            this.label_loopsCounter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox_Switch
            // 
            this.pictureBox_Switch.Location = new System.Drawing.Point(850, 24);
            this.pictureBox_Switch.Name = "pictureBox_Switch";
            this.pictureBox_Switch.Size = new System.Drawing.Size(87, 62);
            this.pictureBox_Switch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Switch.TabIndex = 2;
            this.pictureBox_Switch.TabStop = false;
            this.pictureBox_Switch.Click += new System.EventHandler(this.pictureBox_Switch_Click);
            // 
            // pictureBox_StopCont
            // 
            this.pictureBox_StopCont.Location = new System.Drawing.Point(866, 541);
            this.pictureBox_StopCont.Name = "pictureBox_StopCont";
            this.pictureBox_StopCont.Size = new System.Drawing.Size(60, 60);
            this.pictureBox_StopCont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_StopCont.TabIndex = 1;
            this.pictureBox_StopCont.TabStop = false;
            this.pictureBox_StopCont.Click += new System.EventHandler(this.pictureBox_StopCont_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 606);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBox_Info);
            this.tabPage1.Controls.Add(this.checkBox_adaptiveRate);
            this.tabPage1.Controls.Add(this.numericUpDown_momentum);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label_biasPath);
            this.tabPage1.Controls.Add(this.button_BiasPath);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.numericUpDown_DP);
            this.tabPage1.Controls.Add(this.pictureBox_Switch2);
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
            this.tabPage1.Size = new System.Drawing.Size(934, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox_Info
            // 
            this.pictureBox_Info.Image = global::NeuroNet_Project.Properties.Resources.info;
            this.pictureBox_Info.Location = new System.Drawing.Point(10, 515);
            this.pictureBox_Info.Name = "pictureBox_Info";
            this.pictureBox_Info.Size = new System.Drawing.Size(55, 55);
            this.pictureBox_Info.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Info.TabIndex = 44;
            this.pictureBox_Info.TabStop = false;
            this.pictureBox_Info.Click += new System.EventHandler(this.pictureBox_Info_Click);
            // 
            // checkBox_adaptiveRate
            // 
            this.checkBox_adaptiveRate.AutoSize = true;
            this.checkBox_adaptiveRate.Location = new System.Drawing.Point(6, 153);
            this.checkBox_adaptiveRate.Name = "checkBox_adaptiveRate";
            this.checkBox_adaptiveRate.Size = new System.Drawing.Size(188, 17);
            this.checkBox_adaptiveRate.TabIndex = 43;
            this.checkBox_adaptiveRate.Text = "Adaptive Learning and Momentum";
            this.checkBox_adaptiveRate.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_momentum
            // 
            this.numericUpDown_momentum.DecimalPlaces = 5;
            this.numericUpDown_momentum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDown_momentum.Location = new System.Drawing.Point(115, 236);
            this.numericUpDown_momentum.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_momentum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown_momentum.Name = "numericUpDown_momentum";
            this.numericUpDown_momentum.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_momentum.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Momentum";
            // 
            // label_biasPath
            // 
            this.label_biasPath.AutoSize = true;
            this.label_biasPath.Location = new System.Drawing.Point(112, 105);
            this.label_biasPath.Name = "label_biasPath";
            this.label_biasPath.Size = new System.Drawing.Size(43, 13);
            this.label_biasPath.TabIndex = 40;
            this.label_biasPath.Text = "Not Set";
            // 
            // button_BiasPath
            // 
            this.button_BiasPath.Location = new System.Drawing.Point(6, 99);
            this.button_BiasPath.Name = "button_BiasPath";
            this.button_BiasPath.Size = new System.Drawing.Size(100, 25);
            this.button_BiasPath.TabIndex = 39;
            this.button_BiasPath.Text = "Bias Path";
            this.button_BiasPath.UseVisualStyleBackColor = true;
            this.button_BiasPath.Click += new System.EventHandler(this.button_BiasPath_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Decimal (Output)";
            // 
            // numericUpDown_DP
            // 
            this.numericUpDown_DP.Location = new System.Drawing.Point(115, 366);
            this.numericUpDown_DP.Name = "numericUpDown_DP";
            this.numericUpDown_DP.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_DP.TabIndex = 37;
            this.numericUpDown_DP.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // pictureBox_Switch2
            // 
            this.pictureBox_Switch2.Location = new System.Drawing.Point(847, 21);
            this.pictureBox_Switch2.Name = "pictureBox_Switch2";
            this.pictureBox_Switch2.Size = new System.Drawing.Size(87, 62);
            this.pictureBox_Switch2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Switch2.TabIndex = 3;
            this.pictureBox_Switch2.TabStop = false;
            this.pictureBox_Switch2.Click += new System.EventHandler(this.pictureBox_Switch2_Click);
            // 
            // numericUpDown_save
            // 
            this.numericUpDown_save.Location = new System.Drawing.Point(115, 340);
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
            this.numericUpDown_save.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_save.TabIndex = 36;
            this.numericUpDown_save.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "loops";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Save weight every";
            // 
            // checkBox_UseExistW
            // 
            this.checkBox_UseExistW.AutoSize = true;
            this.checkBox_UseExistW.Location = new System.Drawing.Point(6, 130);
            this.checkBox_UseExistW.Name = "checkBox_UseExistW";
            this.checkBox_UseExistW.Size = new System.Drawing.Size(211, 17);
            this.checkBox_UseExistW.TabIndex = 34;
            this.checkBox_UseExistW.Text = "Continue from Existing Weight and Bias";
            this.checkBox_UseExistW.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox_Summary);
            this.groupBox1.Location = new System.Drawing.Point(310, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 391);
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
            this.richTextBox_Summary.Size = new System.Drawing.Size(599, 366);
            this.richTextBox_Summary.TabIndex = 0;
            this.richTextBox_Summary.Text = "";
            this.richTextBox_Summary.WordWrap = false;
            // 
            // numericUpDown_loops
            // 
            this.numericUpDown_loops.Location = new System.Drawing.Point(115, 262);
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
            this.numericUpDown_loops.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_loops.TabIndex = 17;
            this.numericUpDown_loops.Value = new decimal(new int[] {
            1,
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
            this.numericUpDown_learn.Location = new System.Drawing.Point(115, 210);
            this.numericUpDown_learn.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_learn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDown_learn.Name = "numericUpDown_learn";
            this.numericUpDown_learn.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_learn.TabIndex = 16;
            // 
            // numericUpDown_nodes
            // 
            this.numericUpDown_nodes.Location = new System.Drawing.Point(115, 314);
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
            this.numericUpDown_nodes.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_nodes.TabIndex = 15;
            this.numericUpDown_nodes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDown_layer
            // 
            this.numericUpDown_layer.Location = new System.Drawing.Point(115, 288);
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
            this.numericUpDown_layer.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_layer.TabIndex = 14;
            this.numericUpDown_layer.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of Loops";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Learning Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Layer";
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
            "9. Gaussian",
            "10. Identity"});
            this.comboBox_ActivateFunction.Location = new System.Drawing.Point(115, 183);
            this.comboBox_ActivateFunction.Name = "comboBox_ActivateFunction";
            this.comboBox_ActivateFunction.Size = new System.Drawing.Size(140, 21);
            this.comboBox_ActivateFunction.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Activation Function";
            // 
            // label_WeightPath
            // 
            this.label_WeightPath.AutoSize = true;
            this.label_WeightPath.Location = new System.Drawing.Point(112, 74);
            this.label_WeightPath.Name = "label_WeightPath";
            this.label_WeightPath.Size = new System.Drawing.Size(43, 13);
            this.label_WeightPath.TabIndex = 7;
            this.label_WeightPath.Text = "Not Set";
            this.label_WeightPath.TextChanged += new System.EventHandler(this.label_WeightPath_TextChanged);
            // 
            // label_OutputPath
            // 
            this.label_OutputPath.AutoSize = true;
            this.label_OutputPath.Location = new System.Drawing.Point(112, 43);
            this.label_OutputPath.Name = "label_OutputPath";
            this.label_OutputPath.Size = new System.Drawing.Size(43, 13);
            this.label_OutputPath.TabIndex = 6;
            this.label_OutputPath.Text = "Not Set";
            this.label_OutputPath.TextChanged += new System.EventHandler(this.label_OutputPath_TextChanged);
            // 
            // label_InputPath
            // 
            this.label_InputPath.AutoSize = true;
            this.label_InputPath.Location = new System.Drawing.Point(112, 12);
            this.label_InputPath.Name = "label_InputPath";
            this.label_InputPath.Size = new System.Drawing.Size(43, 13);
            this.label_InputPath.TabIndex = 5;
            this.label_InputPath.Text = "Not Set";
            this.label_InputPath.TextChanged += new System.EventHandler(this.label_InputPath_TextChanged);
            // 
            // button_Weight
            // 
            this.button_Weight.Location = new System.Drawing.Point(6, 68);
            this.button_Weight.Name = "button_Weight";
            this.button_Weight.Size = new System.Drawing.Size(100, 25);
            this.button_Weight.TabIndex = 4;
            this.button_Weight.Text = "Weight Path";
            this.button_Weight.UseVisualStyleBackColor = true;
            this.button_Weight.Click += new System.EventHandler(this.button_Weight_Click);
            // 
            // button_Output
            // 
            this.button_Output.Location = new System.Drawing.Point(6, 37);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(100, 25);
            this.button_Output.TabIndex = 3;
            this.button_Output.Text = "Output Path";
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // button_Input
            // 
            this.button_Input.Location = new System.Drawing.Point(6, 6);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(100, 25);
            this.button_Input.TabIndex = 2;
            this.button_Input.Text = "Input Path";
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            // 
            // button_SaveSetting
            // 
            this.button_SaveSetting.Location = new System.Drawing.Point(728, 538);
            this.button_SaveSetting.Name = "button_SaveSetting";
            this.button_SaveSetting.Size = new System.Drawing.Size(90, 30);
            this.button_SaveSetting.TabIndex = 1;
            this.button_SaveSetting.Text = "Save Settings";
            this.button_SaveSetting.UseVisualStyleBackColor = true;
            this.button_SaveSetting.Click += new System.EventHandler(this.button_SaveSetting_Click);
            // 
            // button_Go
            // 
            this.button_Go.Location = new System.Drawing.Point(833, 538);
            this.button_Go.Name = "button_Go";
            this.button_Go.Size = new System.Drawing.Size(90, 30);
            this.button_Go.TabIndex = 0;
            this.button_Go.Text = "GO";
            this.button_Go.UseVisualStyleBackColor = true;
            this.button_Go.Click += new System.EventHandler(this.button_Go_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button_clearLog);
            this.tabPage2.Controls.Add(this.button_saveLog);
            this.tabPage2.Controls.Add(this.richTextBox_FinalResult);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(934, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Logs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_clearLog
            // 
            this.button_clearLog.Location = new System.Drawing.Point(6, 544);
            this.button_clearLog.Name = "button_clearLog";
            this.button_clearLog.Size = new System.Drawing.Size(100, 30);
            this.button_clearLog.TabIndex = 2;
            this.button_clearLog.Text = "Clear log";
            this.button_clearLog.UseVisualStyleBackColor = true;
            this.button_clearLog.Click += new System.EventHandler(this.button_clearLog_Click);
            // 
            // button_saveLog
            // 
            this.button_saveLog.Location = new System.Drawing.Point(823, 544);
            this.button_saveLog.Name = "button_saveLog";
            this.button_saveLog.Size = new System.Drawing.Size(100, 30);
            this.button_saveLog.TabIndex = 1;
            this.button_saveLog.Text = "Save log";
            this.button_saveLog.UseVisualStyleBackColor = true;
            this.button_saveLog.Click += new System.EventHandler(this.button_saveLog_Click);
            // 
            // richTextBox_FinalResult
            // 
            this.richTextBox_FinalResult.Location = new System.Drawing.Point(6, 14);
            this.richTextBox_FinalResult.Name = "richTextBox_FinalResult";
            this.richTextBox_FinalResult.ReadOnly = true;
            this.richTextBox_FinalResult.Size = new System.Drawing.Size(917, 524);
            this.richTextBox_FinalResult.TabIndex = 0;
            this.richTextBox_FinalResult.Text = "";
            this.richTextBox_FinalResult.WordWrap = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label_Vbp);
            this.tabPage3.Controls.Add(this.button_VBP);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.comboBox_Vact);
            this.tabPage3.Controls.Add(this.labelWinfo);
            this.tabPage3.Controls.Add(this.label_Vw);
            this.tabPage3.Controls.Add(this.label_Vin);
            this.tabPage3.Controls.Add(this.button_CResult);
            this.tabPage3.Controls.Add(this.button_Vsave);
            this.tabPage3.Controls.Add(this.button_Vgo);
            this.tabPage3.Controls.Add(this.button_Vw);
            this.tabPage3.Controls.Add(this.button_Vin);
            this.tabPage3.Location = new System.Drawing.Point(4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(934, 580);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Validation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label_Vbp
            // 
            this.label_Vbp.AutoSize = true;
            this.label_Vbp.Location = new System.Drawing.Point(99, 75);
            this.label_Vbp.Name = "label_Vbp";
            this.label_Vbp.Size = new System.Drawing.Size(13, 13);
            this.label_Vbp.TabIndex = 14;
            this.label_Vbp.Text = "--";
            // 
            // button_VBP
            // 
            this.button_VBP.Location = new System.Drawing.Point(12, 70);
            this.button_VBP.Name = "button_VBP";
            this.button_VBP.Size = new System.Drawing.Size(75, 23);
            this.button_VBP.TabIndex = 13;
            this.button_VBP.Text = "Bias Path";
            this.button_VBP.UseVisualStyleBackColor = true;
            this.button_VBP.Click += new System.EventHandler(this.button_VBP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox_Vout);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(7, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 435);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // richTextBox_Vout
            // 
            this.richTextBox_Vout.Location = new System.Drawing.Point(8, 17);
            this.richTextBox_Vout.Name = "richTextBox_Vout";
            this.richTextBox_Vout.Size = new System.Drawing.Size(900, 412);
            this.richTextBox_Vout.TabIndex = 5;
            this.richTextBox_Vout.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(557, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Activation Function";
            // 
            // comboBox_Vact
            // 
            this.comboBox_Vact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Vact.FormattingEnabled = true;
            this.comboBox_Vact.Items.AddRange(new object[] {
            "1. Tanh",
            "2. Logistic",
            "3. Binary Step",
            "4. ArcTan",
            "5. SoftSign",
            "6. SoftPlus",
            "7. Bent identity",
            "8. Sin",
            "9. Gaussian",
            "10. Identity"});
            this.comboBox_Vact.Location = new System.Drawing.Point(672, 21);
            this.comboBox_Vact.Name = "comboBox_Vact";
            this.comboBox_Vact.Size = new System.Drawing.Size(140, 21);
            this.comboBox_Vact.TabIndex = 10;
            // 
            // labelWinfo
            // 
            this.labelWinfo.AutoSize = true;
            this.labelWinfo.Location = new System.Drawing.Point(99, 70);
            this.labelWinfo.Name = "labelWinfo";
            this.labelWinfo.Size = new System.Drawing.Size(0, 13);
            this.labelWinfo.TabIndex = 4;
            // 
            // label_Vw
            // 
            this.label_Vw.AutoSize = true;
            this.label_Vw.Location = new System.Drawing.Point(99, 48);
            this.label_Vw.Name = "label_Vw";
            this.label_Vw.Size = new System.Drawing.Size(13, 13);
            this.label_Vw.TabIndex = 4;
            this.label_Vw.Text = "--";
            // 
            // label_Vin
            // 
            this.label_Vin.AutoSize = true;
            this.label_Vin.Location = new System.Drawing.Point(99, 19);
            this.label_Vin.Name = "label_Vin";
            this.label_Vin.Size = new System.Drawing.Size(13, 13);
            this.label_Vin.TabIndex = 3;
            this.label_Vin.Text = "--";
            // 
            // button_CResult
            // 
            this.button_CResult.Location = new System.Drawing.Point(834, 77);
            this.button_CResult.Name = "button_CResult";
            this.button_CResult.Size = new System.Drawing.Size(87, 23);
            this.button_CResult.TabIndex = 2;
            this.button_CResult.Text = "Clear results";
            this.button_CResult.UseVisualStyleBackColor = true;
            this.button_CResult.Click += new System.EventHandler(this.button_Vclear_Click);
            // 
            // button_Vsave
            // 
            this.button_Vsave.Location = new System.Drawing.Point(834, 48);
            this.button_Vsave.Name = "button_Vsave";
            this.button_Vsave.Size = new System.Drawing.Size(87, 23);
            this.button_Vsave.TabIndex = 2;
            this.button_Vsave.Text = "Save Results";
            this.button_Vsave.UseVisualStyleBackColor = true;
            this.button_Vsave.Click += new System.EventHandler(this.button_Vsave_Click);
            // 
            // button_Vgo
            // 
            this.button_Vgo.Location = new System.Drawing.Point(834, 19);
            this.button_Vgo.Name = "button_Vgo";
            this.button_Vgo.Size = new System.Drawing.Size(87, 23);
            this.button_Vgo.TabIndex = 2;
            this.button_Vgo.Text = "Feed Forward";
            this.button_Vgo.UseVisualStyleBackColor = true;
            this.button_Vgo.Click += new System.EventHandler(this.button_Vgo_Click);
            // 
            // button_Vw
            // 
            this.button_Vw.Location = new System.Drawing.Point(12, 43);
            this.button_Vw.Name = "button_Vw";
            this.button_Vw.Size = new System.Drawing.Size(75, 23);
            this.button_Vw.TabIndex = 1;
            this.button_Vw.Text = "Weight Path";
            this.button_Vw.UseVisualStyleBackColor = true;
            this.button_Vw.Click += new System.EventHandler(this.button_Vw_Click);
            // 
            // button_Vin
            // 
            this.button_Vin.Location = new System.Drawing.Point(12, 14);
            this.button_Vin.Name = "button_Vin";
            this.button_Vin.Size = new System.Drawing.Size(75, 23);
            this.button_Vin.TabIndex = 0;
            this.button_Vin.Text = "Input Path";
            this.button_Vin.UseVisualStyleBackColor = true;
            this.button_Vin.Click += new System.EventHandler(this.button_Vin_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(938, 606);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_Loading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NeuroNet Project";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.panel_Loading.ResumeLayout(false);
            this.panel_Loading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Switch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StopCont)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Info)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_momentum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Switch2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_save)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_loops)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_learn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_nodes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_layer)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Loading;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox_StopCont;
        private System.Windows.Forms.PictureBox pictureBox_Switch;
        private System.Windows.Forms.PictureBox pictureBox_Switch2;
        private System.Windows.Forms.Label label_loopsCounter;
        private System.Windows.Forms.RichTextBox richTextBox_CurrentY;
        private System.Windows.Forms.RichTextBox richTextBox_currentError;
        private System.Windows.Forms.RichTextBox richTextBox_CurrentLoop;
        private System.Windows.Forms.RichTextBox richTextBox_FinalResult;
        private System.Windows.Forms.Button button_clearLog;
        private System.Windows.Forms.Button button_saveLog;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RichTextBox richTextBox_Vout;
        private System.Windows.Forms.Label label_Vw;
        private System.Windows.Forms.Label label_Vin;
        private System.Windows.Forms.Button button_Vgo;
        private System.Windows.Forms.Button button_Vw;
        private System.Windows.Forms.Button button_Vin;
        private System.Windows.Forms.ComboBox comboBox_Vact;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Vsave;
        private System.Windows.Forms.Label labelWinfo;
        private System.Windows.Forms.Button button_CResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_DP;
        private System.Windows.Forms.Label label_biasPath;
        private System.Windows.Forms.Button button_BiasPath;
        private System.Windows.Forms.Label label_Vbp;
        private System.Windows.Forms.Button button_VBP;
        private System.Windows.Forms.NumericUpDown numericUpDown_momentum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBox_adaptiveRate;
        private System.Windows.Forms.PictureBox pictureBox_Info;
    }
}

