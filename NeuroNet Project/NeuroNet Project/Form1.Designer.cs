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
            this.label_LRM = new System.Windows.Forms.Label();
            this.richTextBox_CurrentY = new System.Windows.Forms.RichTextBox();
            this.richTextBox_currentError = new System.Windows.Forms.RichTextBox();
            this.richTextBox_CurrentLoop = new System.Windows.Forms.RichTextBox();
            this.label_loopsCounter = new System.Windows.Forms.Label();
            this.pictureBox_Switch = new System.Windows.Forms.PictureBox();
            this.pictureBox_StopCont = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDownNorOMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNorOMin = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownNorIMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownNorIMin = new System.Windows.Forms.NumericUpDown();
            this.checkBoxCustomNor = new System.Windows.Forms.CheckBox();
            this.button_Normalize = new System.Windows.Forms.Button();
            this.numericUpDown_DecayRate = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_Info = new System.Windows.Forms.PictureBox();
            this.checkBox_adaptiveRate = new System.Windows.Forms.CheckBox();
            this.numericUpDown_momentum = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label_biasPath = new System.Windows.Forms.Label();
            this.button_BiasPath = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_DP = new System.Windows.Forms.NumericUpDown();
            this.pictureBox_Switch2 = new System.Windows.Forms.PictureBox();
            this.numericUpDown_save = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBox_UseExistW = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCopy_Main = new System.Windows.Forms.Button();
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
            this.checkBoxDeNor = new System.Windows.Forms.CheckBox();
            this.labelNorPath = new System.Windows.Forms.Label();
            this.buttonNorPath = new System.Windows.Forms.Button();
            this.numericUpDown_DPV = new System.Windows.Forms.NumericUpDown();
            this.label_Vbp = new System.Windows.Forms.Label();
            this.button_VBP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonCopy_Valid = new System.Windows.Forms.Button();
            this.richTextBox_Vout = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.richTextBox_TestDebug = new System.Windows.Forms.RichTextBox();
            this.label_EqB = new System.Windows.Forms.Label();
            this.label_EqW = new System.Windows.Forms.Label();
            this.listBox_availableWeight = new System.Windows.Forms.ListBox();
            this.button_EqGen = new System.Windows.Forms.Button();
            this.button_EqBias = new System.Windows.Forms.Button();
            this.button_EqWeight = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.textBox_MainFolder = new System.Windows.Forms.TextBox();
            this.button_MainFolder = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.numericUpDown_eqDP = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel_Loading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Switch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StopCont)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNorOMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNorOMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNorIMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNorIMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DecayRate)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DPV)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_eqDP)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Loading
            // 
            this.panel_Loading.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel_Loading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Loading.Controls.Add(this.label_LRM);
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
            // label_LRM
            // 
            this.label_LRM.AutoSize = true;
            this.label_LRM.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LRM.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label_LRM.Location = new System.Drawing.Point(12, 550);
            this.label_LRM.Name = "label_LRM";
            this.label_LRM.Size = new System.Drawing.Size(148, 13);
            this.label_LRM.TabIndex = 7;
            this.label_LRM.Text = "Momentum: -- Learning rate  --";
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
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 606);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.button_Normalize);
            this.tabPage1.Controls.Add(this.numericUpDown_DecayRate);
            this.tabPage1.Controls.Add(this.pictureBox_Info);
            this.tabPage1.Controls.Add(this.checkBox_adaptiveRate);
            this.tabPage1.Controls.Add(this.numericUpDown_momentum);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label_biasPath);
            this.tabPage1.Controls.Add(this.button_BiasPath);
            this.tabPage1.Controls.Add(this.label12);
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.numericUpDownNorOMax);
            this.panel1.Controls.Add(this.numericUpDownNorOMin);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.numericUpDownNorIMax);
            this.panel1.Controls.Add(this.numericUpDownNorIMin);
            this.panel1.Controls.Add(this.checkBoxCustomNor);
            this.panel1.Location = new System.Drawing.Point(92, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 53);
            this.panel1.TabIndex = 47;
            // 
            // numericUpDownNorOMax
            // 
            this.numericUpDownNorOMax.Location = new System.Drawing.Point(459, 27);
            this.numericUpDownNorOMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownNorOMax.Minimum = new decimal(new int[] {
            999998,
            0,
            0,
            -2147483648});
            this.numericUpDownNorOMax.Name = "numericUpDownNorOMax";
            this.numericUpDownNorOMax.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownNorOMax.TabIndex = 51;
            // 
            // numericUpDownNorOMin
            // 
            this.numericUpDownNorOMin.Location = new System.Drawing.Point(352, 27);
            this.numericUpDownNorOMin.Maximum = new decimal(new int[] {
            999998,
            0,
            0,
            0});
            this.numericUpDownNorOMin.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericUpDownNorOMin.Name = "numericUpDownNorOMin";
            this.numericUpDownNorOMin.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownNorOMin.TabIndex = 50;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.LightYellow;
            this.label15.Location = new System.Drawing.Point(6, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "IN /";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(42, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(30, 13);
            this.label14.TabIndex = 49;
            this.label14.Text = "Min :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(420, 34);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "Max :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label18.Location = new System.Drawing.Point(316, 34);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 49;
            this.label18.Text = "Min :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.LightYellow;
            this.label16.Location = new System.Drawing.Point(267, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 49;
            this.label16.Text = "OUT /";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(149, 34);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(33, 13);
            this.label13.TabIndex = 49;
            this.label13.Text = "Max :";
            // 
            // numericUpDownNorIMax
            // 
            this.numericUpDownNorIMax.Location = new System.Drawing.Point(188, 27);
            this.numericUpDownNorIMax.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDownNorIMax.Minimum = new decimal(new int[] {
            999998,
            0,
            0,
            -2147483648});
            this.numericUpDownNorIMax.Name = "numericUpDownNorIMax";
            this.numericUpDownNorIMax.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownNorIMax.TabIndex = 48;
            // 
            // numericUpDownNorIMin
            // 
            this.numericUpDownNorIMin.Location = new System.Drawing.Point(78, 27);
            this.numericUpDownNorIMin.Maximum = new decimal(new int[] {
            999998,
            0,
            0,
            0});
            this.numericUpDownNorIMin.Minimum = new decimal(new int[] {
            999999,
            0,
            0,
            -2147483648});
            this.numericUpDownNorIMin.Name = "numericUpDownNorIMin";
            this.numericUpDownNorIMin.Size = new System.Drawing.Size(62, 20);
            this.numericUpDownNorIMin.TabIndex = 1;
            // 
            // checkBoxCustomNor
            // 
            this.checkBoxCustomNor.AutoSize = true;
            this.checkBoxCustomNor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBoxCustomNor.Location = new System.Drawing.Point(9, 8);
            this.checkBoxCustomNor.Name = "checkBoxCustomNor";
            this.checkBoxCustomNor.Size = new System.Drawing.Size(107, 17);
            this.checkBoxCustomNor.TabIndex = 0;
            this.checkBoxCustomNor.Text = "Normalize Range";
            this.checkBoxCustomNor.UseVisualStyleBackColor = true;
            // 
            // button_Normalize
            // 
            this.button_Normalize.Location = new System.Drawing.Point(635, 538);
            this.button_Normalize.Name = "button_Normalize";
            this.button_Normalize.Size = new System.Drawing.Size(96, 30);
            this.button_Normalize.TabIndex = 46;
            this.button_Normalize.Text = "Normalize Data";
            this.button_Normalize.UseVisualStyleBackColor = true;
            this.button_Normalize.Click += new System.EventHandler(this.button_Normalize_Click);
            // 
            // numericUpDown_DecayRate
            // 
            this.numericUpDown_DecayRate.Location = new System.Drawing.Point(115, 392);
            this.numericUpDown_DecayRate.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown_DecayRate.Name = "numericUpDown_DecayRate";
            this.numericUpDown_DecayRate.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_DecayRate.TabIndex = 45;
            this.numericUpDown_DecayRate.Value = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            // 
            // pictureBox_Info
            // 
            this.pictureBox_Info.Image = global::NeuroNet_Project.Properties.Resources.info;
            this.pictureBox_Info.Location = new System.Drawing.Point(10, 520);
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
            this.checkBox_adaptiveRate.Size = new System.Drawing.Size(191, 17);
            this.checkBox_adaptiveRate.TabIndex = 43;
            this.checkBox_adaptiveRate.Text = "Decaying Learning and Momentum";
            this.checkBox_adaptiveRate.UseVisualStyleBackColor = true;
            this.checkBox_adaptiveRate.CheckedChanged += new System.EventHandler(this.checkBox_adaptiveRate_CheckedChanged);
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
            this.label9.Location = new System.Drawing.Point(45, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Momentum";
            // 
            // label_biasPath
            // 
            this.label_biasPath.AutoSize = true;
            this.label_biasPath.Location = new System.Drawing.Point(98, 105);
            this.label_biasPath.Name = "label_biasPath";
            this.label_biasPath.Size = new System.Drawing.Size(43, 13);
            this.label_biasPath.TabIndex = 40;
            this.label_biasPath.Text = "Not Set";
            // 
            // button_BiasPath
            // 
            this.button_BiasPath.Location = new System.Drawing.Point(6, 99);
            this.button_BiasPath.Name = "button_BiasPath";
            this.button_BiasPath.Size = new System.Drawing.Size(86, 25);
            this.button_BiasPath.TabIndex = 39;
            this.button_BiasPath.Text = "Bias Path";
            this.button_BiasPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_BiasPath.UseVisualStyleBackColor = true;
            this.button_BiasPath.Click += new System.EventHandler(this.button_BiasPath_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Decay Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 368);
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
            this.numericUpDown_save.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_save.Location = new System.Drawing.Point(115, 340);
            this.numericUpDown_save.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown_save.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_save.Name = "numericUpDown_save";
            this.numericUpDown_save.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_save.TabIndex = 36;
            this.numericUpDown_save.Value = new decimal(new int[] {
            1000,
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
            this.label6.Location = new System.Drawing.Point(9, 342);
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
            this.groupBox1.Controls.Add(this.buttonCopy_Main);
            this.groupBox1.Controls.Add(this.richTextBox_Summary);
            this.groupBox1.Location = new System.Drawing.Point(321, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(613, 404);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Summary";
            // 
            // buttonCopy_Main
            // 
            this.buttonCopy_Main.BackColor = System.Drawing.Color.Black;
            this.buttonCopy_Main.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCopy_Main.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCopy_Main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy_Main.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.buttonCopy_Main.Location = new System.Drawing.Point(512, 367);
            this.buttonCopy_Main.Name = "buttonCopy_Main";
            this.buttonCopy_Main.Size = new System.Drawing.Size(91, 27);
            this.buttonCopy_Main.TabIndex = 1;
            this.buttonCopy_Main.Text = "Copy";
            this.buttonCopy_Main.UseVisualStyleBackColor = false;
            this.buttonCopy_Main.Click += new System.EventHandler(this.buttonCopy_Main_Click);
            // 
            // richTextBox_Summary
            // 
            this.richTextBox_Summary.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox_Summary.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Summary.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.richTextBox_Summary.Location = new System.Drawing.Point(8, 16);
            this.richTextBox_Summary.Name = "richTextBox_Summary";
            this.richTextBox_Summary.ReadOnly = true;
            this.richTextBox_Summary.Size = new System.Drawing.Size(599, 382);
            this.richTextBox_Summary.TabIndex = 0;
            this.richTextBox_Summary.Text = "";
            this.richTextBox_Summary.WordWrap = false;
            // 
            // numericUpDown_loops
            // 
            this.numericUpDown_loops.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_loops.Location = new System.Drawing.Point(115, 262);
            this.numericUpDown_loops.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_loops.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown_loops.Name = "numericUpDown_loops";
            this.numericUpDown_loops.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_loops.TabIndex = 17;
            this.numericUpDown_loops.Value = new decimal(new int[] {
            1000,
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
            this.label5.Location = new System.Drawing.Point(16, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Number of Loops";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Learning Rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nodes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 290);
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
            this.label_WeightPath.Location = new System.Drawing.Point(98, 74);
            this.label_WeightPath.Name = "label_WeightPath";
            this.label_WeightPath.Size = new System.Drawing.Size(43, 13);
            this.label_WeightPath.TabIndex = 7;
            this.label_WeightPath.Text = "Not Set";
            this.label_WeightPath.TextChanged += new System.EventHandler(this.label_WeightPath_TextChanged);
            // 
            // label_OutputPath
            // 
            this.label_OutputPath.AutoSize = true;
            this.label_OutputPath.Location = new System.Drawing.Point(98, 43);
            this.label_OutputPath.Name = "label_OutputPath";
            this.label_OutputPath.Size = new System.Drawing.Size(43, 13);
            this.label_OutputPath.TabIndex = 6;
            this.label_OutputPath.Text = "Not Set";
            this.label_OutputPath.TextChanged += new System.EventHandler(this.label_OutputPath_TextChanged);
            // 
            // label_InputPath
            // 
            this.label_InputPath.AutoSize = true;
            this.label_InputPath.Location = new System.Drawing.Point(98, 12);
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
            this.button_Weight.Size = new System.Drawing.Size(86, 25);
            this.button_Weight.TabIndex = 4;
            this.button_Weight.Text = "Weight Path";
            this.button_Weight.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Weight.UseVisualStyleBackColor = true;
            this.button_Weight.Click += new System.EventHandler(this.button_Weight_Click);
            // 
            // button_Output
            // 
            this.button_Output.Location = new System.Drawing.Point(6, 37);
            this.button_Output.Name = "button_Output";
            this.button_Output.Size = new System.Drawing.Size(86, 25);
            this.button_Output.TabIndex = 3;
            this.button_Output.Text = "Output Path";
            this.button_Output.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Output.UseVisualStyleBackColor = true;
            this.button_Output.Click += new System.EventHandler(this.button_Output_Click);
            // 
            // button_Input
            // 
            this.button_Input.Location = new System.Drawing.Point(6, 6);
            this.button_Input.Name = "button_Input";
            this.button_Input.Size = new System.Drawing.Size(86, 25);
            this.button_Input.TabIndex = 2;
            this.button_Input.Text = "Input Path";
            this.button_Input.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_Input.UseVisualStyleBackColor = true;
            this.button_Input.Click += new System.EventHandler(this.button_Input_Click);
            // 
            // button_SaveSetting
            // 
            this.button_SaveSetting.Location = new System.Drawing.Point(737, 538);
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
            this.richTextBox_FinalResult.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.tabPage3.Controls.Add(this.checkBoxDeNor);
            this.tabPage3.Controls.Add(this.labelNorPath);
            this.tabPage3.Controls.Add(this.buttonNorPath);
            this.tabPage3.Controls.Add(this.numericUpDown_DPV);
            this.tabPage3.Controls.Add(this.label_Vbp);
            this.tabPage3.Controls.Add(this.button_VBP);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.label11);
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
            // checkBoxDeNor
            // 
            this.checkBoxDeNor.AutoSize = true;
            this.checkBoxDeNor.Location = new System.Drawing.Point(672, 82);
            this.checkBoxDeNor.Name = "checkBoxDeNor";
            this.checkBoxDeNor.Size = new System.Drawing.Size(151, 17);
            this.checkBoxDeNor.TabIndex = 18;
            this.checkBoxDeNor.Text = "De-normalization: Disabled";
            this.checkBoxDeNor.UseVisualStyleBackColor = true;
            this.checkBoxDeNor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxDeNor_MouseClick);
            // 
            // labelNorPath
            // 
            this.labelNorPath.AutoSize = true;
            this.labelNorPath.Location = new System.Drawing.Point(688, 103);
            this.labelNorPath.Name = "labelNorPath";
            this.labelNorPath.Size = new System.Drawing.Size(13, 13);
            this.labelNorPath.TabIndex = 17;
            this.labelNorPath.Text = "--";
            // 
            // buttonNorPath
            // 
            this.buttonNorPath.Location = new System.Drawing.Point(549, 78);
            this.buttonNorPath.Name = "buttonNorPath";
            this.buttonNorPath.Size = new System.Drawing.Size(117, 22);
            this.buttonNorPath.TabIndex = 16;
            this.buttonNorPath.Text = "Normalized Path";
            this.buttonNorPath.UseVisualStyleBackColor = true;
            this.buttonNorPath.Click += new System.EventHandler(this.buttonNorPath_Click);
            // 
            // numericUpDown_DPV
            // 
            this.numericUpDown_DPV.Location = new System.Drawing.Point(661, 48);
            this.numericUpDown_DPV.Name = "numericUpDown_DPV";
            this.numericUpDown_DPV.Size = new System.Drawing.Size(140, 20);
            this.numericUpDown_DPV.TabIndex = 15;
            this.numericUpDown_DPV.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label_Vbp
            // 
            this.label_Vbp.AutoSize = true;
            this.label_Vbp.Location = new System.Drawing.Point(139, 42);
            this.label_Vbp.Name = "label_Vbp";
            this.label_Vbp.Size = new System.Drawing.Size(13, 13);
            this.label_Vbp.TabIndex = 14;
            this.label_Vbp.Text = "--";
            // 
            // button_VBP
            // 
            this.button_VBP.Location = new System.Drawing.Point(15, 37);
            this.button_VBP.Name = "button_VBP";
            this.button_VBP.Size = new System.Drawing.Size(118, 23);
            this.button_VBP.TabIndex = 13;
            this.button_VBP.Text = "Bias Path";
            this.button_VBP.UseVisualStyleBackColor = true;
            this.button_VBP.Click += new System.EventHandler(this.button_VBP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonCopy_Valid);
            this.groupBox2.Controls.Add(this.richTextBox_Vout);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(7, 142);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(916, 435);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // buttonCopy_Valid
            // 
            this.buttonCopy_Valid.BackColor = System.Drawing.Color.Black;
            this.buttonCopy_Valid.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonCopy_Valid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonCopy_Valid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCopy_Valid.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonCopy_Valid.Location = new System.Drawing.Point(825, 399);
            this.buttonCopy_Valid.Name = "buttonCopy_Valid";
            this.buttonCopy_Valid.Size = new System.Drawing.Size(80, 27);
            this.buttonCopy_Valid.TabIndex = 6;
            this.buttonCopy_Valid.Text = "Copy";
            this.buttonCopy_Valid.UseVisualStyleBackColor = false;
            this.buttonCopy_Valid.Click += new System.EventHandler(this.buttonCopy_Valid_Click);
            // 
            // richTextBox_Vout
            // 
            this.richTextBox_Vout.BackColor = System.Drawing.Color.Black;
            this.richTextBox_Vout.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Vout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(254)))), ((int)(((byte)(232)))));
            this.richTextBox_Vout.Location = new System.Drawing.Point(8, 17);
            this.richTextBox_Vout.Name = "richTextBox_Vout";
            this.richTextBox_Vout.Size = new System.Drawing.Size(900, 412);
            this.richTextBox_Vout.TabIndex = 5;
            this.richTextBox_Vout.Text = "ALL WEIGHT FILES MUST CONTAIN SAME SET OF NODES !";
            this.richTextBox_Vout.WordWrap = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(546, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Decimal Place";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(546, 24);
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
            this.comboBox_Vact.Location = new System.Drawing.Point(661, 21);
            this.comboBox_Vact.Name = "comboBox_Vact";
            this.comboBox_Vact.Size = new System.Drawing.Size(140, 21);
            this.comboBox_Vact.TabIndex = 10;
            // 
            // labelWinfo
            // 
            this.labelWinfo.AutoSize = true;
            this.labelWinfo.Location = new System.Drawing.Point(139, 96);
            this.labelWinfo.Name = "labelWinfo";
            this.labelWinfo.Size = new System.Drawing.Size(0, 13);
            this.labelWinfo.TabIndex = 4;
            // 
            // label_Vw
            // 
            this.label_Vw.AutoSize = true;
            this.label_Vw.Location = new System.Drawing.Point(139, 72);
            this.label_Vw.Name = "label_Vw";
            this.label_Vw.Size = new System.Drawing.Size(13, 13);
            this.label_Vw.TabIndex = 4;
            this.label_Vw.Text = "--";
            this.label_Vw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label_Vin
            // 
            this.label_Vin.AutoSize = true;
            this.label_Vin.Location = new System.Drawing.Point(139, 12);
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
            this.button_Vw.Location = new System.Drawing.Point(15, 67);
            this.button_Vw.Name = "button_Vw";
            this.button_Vw.Size = new System.Drawing.Size(118, 23);
            this.button_Vw.TabIndex = 1;
            this.button_Vw.Text = "Weight Path";
            this.button_Vw.UseVisualStyleBackColor = true;
            this.button_Vw.Click += new System.EventHandler(this.button_Vw_Click);
            // 
            // button_Vin
            // 
            this.button_Vin.Location = new System.Drawing.Point(15, 7);
            this.button_Vin.Name = "button_Vin";
            this.button_Vin.Size = new System.Drawing.Size(118, 23);
            this.button_Vin.TabIndex = 0;
            this.button_Vin.Text = "Input Path";
            this.button_Vin.UseVisualStyleBackColor = true;
            this.button_Vin.Click += new System.EventHandler(this.button_Vin_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.LightGray;
            this.tabPage5.Controls.Add(this.buttonClear);
            this.tabPage5.Controls.Add(this.buttonSave);
            this.tabPage5.Controls.Add(this.richTextBox_TestDebug);
            this.tabPage5.Controls.Add(this.label19);
            this.tabPage5.Controls.Add(this.numericUpDown_eqDP);
            this.tabPage5.Controls.Add(this.label_EqB);
            this.tabPage5.Controls.Add(this.label_EqW);
            this.tabPage5.Controls.Add(this.listBox_availableWeight);
            this.tabPage5.Controls.Add(this.button_EqGen);
            this.tabPage5.Controls.Add(this.button_EqBias);
            this.tabPage5.Controls.Add(this.button_EqWeight);
            this.tabPage5.Location = new System.Drawing.Point(4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(934, 580);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Generate Equation";
            // 
            // richTextBox_TestDebug
            // 
            this.richTextBox_TestDebug.BackColor = System.Drawing.Color.LightGray;
            this.richTextBox_TestDebug.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_TestDebug.Location = new System.Drawing.Point(3, 109);
            this.richTextBox_TestDebug.Name = "richTextBox_TestDebug";
            this.richTextBox_TestDebug.Size = new System.Drawing.Size(928, 471);
            this.richTextBox_TestDebug.TabIndex = 6;
            this.richTextBox_TestDebug.Text = "";
            this.richTextBox_TestDebug.WordWrap = false;
            this.richTextBox_TestDebug.TextChanged += new System.EventHandler(this.richTextBox_TestDebug_TextChanged);
            // 
            // label_EqB
            // 
            this.label_EqB.AutoSize = true;
            this.label_EqB.Location = new System.Drawing.Point(346, 39);
            this.label_EqB.Name = "label_EqB";
            this.label_EqB.Size = new System.Drawing.Size(10, 13);
            this.label_EqB.TabIndex = 5;
            this.label_EqB.Text = "-";
            // 
            // label_EqW
            // 
            this.label_EqW.AutoSize = true;
            this.label_EqW.Location = new System.Drawing.Point(346, 8);
            this.label_EqW.Name = "label_EqW";
            this.label_EqW.Size = new System.Drawing.Size(10, 13);
            this.label_EqW.TabIndex = 4;
            this.label_EqW.Text = "-";
            // 
            // listBox_availableWeight
            // 
            this.listBox_availableWeight.FormattingEnabled = true;
            this.listBox_availableWeight.Location = new System.Drawing.Point(3, 3);
            this.listBox_availableWeight.Name = "listBox_availableWeight";
            this.listBox_availableWeight.Size = new System.Drawing.Size(221, 108);
            this.listBox_availableWeight.TabIndex = 3;
            // 
            // button_EqGen
            // 
            this.button_EqGen.Location = new System.Drawing.Point(230, 57);
            this.button_EqGen.Name = "button_EqGen";
            this.button_EqGen.Size = new System.Drawing.Size(110, 30);
            this.button_EqGen.TabIndex = 2;
            this.button_EqGen.Text = "Generate Matrices";
            this.button_EqGen.UseVisualStyleBackColor = true;
            this.button_EqGen.Click += new System.EventHandler(this.button_EqGen_Click);
            // 
            // button_EqBias
            // 
            this.button_EqBias.Location = new System.Drawing.Point(230, 29);
            this.button_EqBias.Name = "button_EqBias";
            this.button_EqBias.Size = new System.Drawing.Size(110, 30);
            this.button_EqBias.TabIndex = 1;
            this.button_EqBias.Text = "Select Bias";
            this.button_EqBias.UseVisualStyleBackColor = true;
            this.button_EqBias.Click += new System.EventHandler(this.button_EqBias_Click);
            // 
            // button_EqWeight
            // 
            this.button_EqWeight.Location = new System.Drawing.Point(230, 0);
            this.button_EqWeight.Name = "button_EqWeight";
            this.button_EqWeight.Size = new System.Drawing.Size(110, 30);
            this.button_EqWeight.TabIndex = 0;
            this.button_EqWeight.Text = "Select Weight";
            this.button_EqWeight.UseVisualStyleBackColor = true;
            this.button_EqWeight.Click += new System.EventHandler(this.button_EqWeight_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonRestart);
            this.tabPage4.Controls.Add(this.textBox_MainFolder);
            this.tabPage4.Controls.Add(this.button_MainFolder);
            this.tabPage4.Location = new System.Drawing.Point(4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(934, 580);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Others";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(36, 543);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(95, 21);
            this.buttonRestart.TabIndex = 2;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // textBox_MainFolder
            // 
            this.textBox_MainFolder.Location = new System.Drawing.Point(137, 31);
            this.textBox_MainFolder.Name = "textBox_MainFolder";
            this.textBox_MainFolder.Size = new System.Drawing.Size(667, 20);
            this.textBox_MainFolder.TabIndex = 1;
            // 
            // button_MainFolder
            // 
            this.button_MainFolder.Location = new System.Drawing.Point(36, 30);
            this.button_MainFolder.Name = "button_MainFolder";
            this.button_MainFolder.Size = new System.Drawing.Size(95, 21);
            this.button_MainFolder.TabIndex = 0;
            this.button_MainFolder.Text = "Main Folder";
            this.button_MainFolder.UseVisualStyleBackColor = true;
            this.button_MainFolder.Click += new System.EventHandler(this.button_MainFolder_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // numericUpDown_eqDP
            // 
            this.numericUpDown_eqDP.Location = new System.Drawing.Point(346, 89);
            this.numericUpDown_eqDP.Name = "numericUpDown_eqDP";
            this.numericUpDown_eqDP.Size = new System.Drawing.Size(33, 20);
            this.numericUpDown_eqDP.TabIndex = 7;
            this.numericUpDown_eqDP.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(265, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 13);
            this.label19.TabIndex = 8;
            this.label19.Text = "Decimal Place";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(882, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(52, 52);
            this.buttonSave.TabIndex = 9;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(882, 57);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(52, 51);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(938, 606);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel_Loading);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "NeuroNet Project - 200717";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            this.MouseEnter += new System.EventHandler(this.Form_Main_MouseEnter);
            this.panel_Loading.ResumeLayout(false);
            this.panel_Loading.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Switch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StopCont)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNorOMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNorOMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNorIMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNorIMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DecayRate)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_DPV)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_eqDP)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numericUpDown_DPV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox_MainFolder;
        private System.Windows.Forms.Button button_MainFolder;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label label_LRM;
        private System.Windows.Forms.NumericUpDown numericUpDown_DecayRate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button_Normalize;
        private System.Windows.Forms.Label labelNorPath;
        private System.Windows.Forms.Button buttonNorPath;
        private System.Windows.Forms.CheckBox checkBoxDeNor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownNorIMax;
        private System.Windows.Forms.NumericUpDown numericUpDownNorIMin;
        private System.Windows.Forms.CheckBox checkBoxCustomNor;
        private System.Windows.Forms.NumericUpDown numericUpDownNorOMax;
        private System.Windows.Forms.NumericUpDown numericUpDownNorOMin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button buttonCopy_Main;
        private System.Windows.Forms.Button buttonCopy_Valid;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button_EqBias;
        private System.Windows.Forms.Button button_EqWeight;
        private System.Windows.Forms.ListBox listBox_availableWeight;
        private System.Windows.Forms.Button button_EqGen;
        private System.Windows.Forms.Label label_EqB;
        private System.Windows.Forms.Label label_EqW;
        private System.Windows.Forms.RichTextBox richTextBox_TestDebug;
        private System.Windows.Forms.NumericUpDown numericUpDown_eqDP;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSave;
    }
}

