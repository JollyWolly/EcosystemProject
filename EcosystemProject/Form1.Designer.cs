using System.Drawing;

namespace EcosystemProject
{
    partial class Form1
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
            this.CreateEcosystem_Button = new System.Windows.Forms.Button();
            this.height_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.width_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.foodRate = new System.Windows.Forms.TrackBar();
            this.sheepRate = new System.Windows.Forms.TrackBar();
            this.wolfRate = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.nextDay_Button = new System.Windows.Forms.Button();
            this.day_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grassCount_Label = new System.Windows.Forms.Label();
            this.colorCheckBox = new System.Windows.Forms.CheckBox();
            this.nightCheckBox = new System.Windows.Forms.CheckBox();
            this.sheepCountLabel = new System.Windows.Forms.Label();
            this.wolfCountLabel = new System.Windows.Forms.Label();
            this.popGraph_Button = new System.Windows.Forms.Button();
            this.grassPopCheckBox = new System.Windows.Forms.CheckBox();
            this.sheepPopCheckBox = new System.Windows.Forms.CheckBox();
            this.wolfPopCheckBox = new System.Windows.Forms.CheckBox();
            this.groGraph_Button = new System.Windows.Forms.Button();
            this.grassGroCheckBox = new System.Windows.Forms.CheckBox();
            this.sheepGroCheckBox = new System.Windows.Forms.CheckBox();
            this.wolfGroCheckBox = new System.Windows.Forms.CheckBox();
            this.antiExtinction_Checkbox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.wolfGrowth_Label = new System.Windows.Forms.Label();
            this.sheepGrowth_Label = new System.Windows.Forms.Label();
            this.grassGrowth_Label = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.skipDays_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.skipDays_Button = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.height_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheepRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolfRate)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skipDays_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // CreateEcosystem_Button
            // 
            this.CreateEcosystem_Button.Location = new System.Drawing.Point(11, 114);
            this.CreateEcosystem_Button.Name = "CreateEcosystem_Button";
            this.CreateEcosystem_Button.Size = new System.Drawing.Size(252, 23);
            this.CreateEcosystem_Button.TabIndex = 0;
            this.CreateEcosystem_Button.Text = "Create Eco";
            this.CreateEcosystem_Button.UseVisualStyleBackColor = true;
            this.CreateEcosystem_Button.Click += new System.EventHandler(this.createEco_Click);
            // 
            // height_NumericUpDown
            // 
            this.height_NumericUpDown.Location = new System.Drawing.Point(9, 32);
            this.height_NumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.height_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.height_NumericUpDown.Name = "height_NumericUpDown";
            this.height_NumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.height_NumericUpDown.TabIndex = 1;
            this.height_NumericUpDown.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // width_NumericUpDown
            // 
            this.width_NumericUpDown.Location = new System.Drawing.Point(56, 32);
            this.width_NumericUpDown.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.width_NumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.width_NumericUpDown.Name = "width_NumericUpDown";
            this.width_NumericUpDown.Size = new System.Drawing.Size(38, 20);
            this.width_NumericUpDown.TabIndex = 2;
            this.width_NumericUpDown.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.width_NumericUpDown.ValueChanged += new System.EventHandler(this.wNumber_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Grass :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // foodRate
            // 
            this.foodRate.Location = new System.Drawing.Point(142, 29);
            this.foodRate.Maximum = 20;
            this.foodRate.Name = "foodRate";
            this.foodRate.Size = new System.Drawing.Size(119, 45);
            this.foodRate.TabIndex = 8;
            // 
            // sheepRate
            // 
            this.sheepRate.Location = new System.Drawing.Point(142, 53);
            this.sheepRate.Maximum = 20;
            this.sheepRate.Name = "sheepRate";
            this.sheepRate.Size = new System.Drawing.Size(119, 45);
            this.sheepRate.TabIndex = 9;
            this.sheepRate.Scroll += new System.EventHandler(this.sheepRate_Scroll);
            // 
            // wolfRate
            // 
            this.wolfRate.Location = new System.Drawing.Point(142, 77);
            this.wolfRate.Maximum = 20;
            this.wolfRate.Name = "wolfRate";
            this.wolfRate.Size = new System.Drawing.Size(119, 45);
            this.wolfRate.TabIndex = 10;
            this.wolfRate.Scroll += new System.EventHandler(this.wolfRate_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sheep :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Wolf :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // displayBox
            // 
            this.displayBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.displayBox.BackColor = System.Drawing.SystemColors.Info;
            this.displayBox.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.displayBox.Location = new System.Drawing.Point(12, 152);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(796, 331);
            this.displayBox.TabIndex = 13;
            this.displayBox.Text = "";
            this.displayBox.WordWrap = false;
            this.displayBox.ZoomFactor = 1.25F;
            // 
            // nextDay_Button
            // 
            this.nextDay_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nextDay_Button.Enabled = false;
            this.nextDay_Button.Location = new System.Drawing.Point(6, 112);
            this.nextDay_Button.Name = "nextDay_Button";
            this.nextDay_Button.Size = new System.Drawing.Size(188, 23);
            this.nextDay_Button.TabIndex = 14;
            this.nextDay_Button.Text = "Next Day";
            this.nextDay_Button.UseVisualStyleBackColor = true;
            this.nextDay_Button.Click += new System.EventHandler(this.nextDay_Button_Click);
            this.nextDay_Button.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            // 
            // day_Label
            // 
            this.day_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.day_Label.Location = new System.Drawing.Point(177, 122);
            this.day_Label.Name = "day_Label";
            this.day_Label.Size = new System.Drawing.Size(33, 13);
            this.day_Label.TabIndex = 15;
            this.day_Label.Text = "0";
            this.day_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.day_Label.Click += new System.EventHandler(this.yearLabel_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Day";
            // 
            // grassCount_Label
            // 
            this.grassCount_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grassCount_Label.Location = new System.Drawing.Point(95, 85);
            this.grassCount_Label.Name = "grassCount_Label";
            this.grassCount_Label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grassCount_Label.Size = new System.Drawing.Size(33, 13);
            this.grassCount_Label.TabIndex = 18;
            this.grassCount_Label.Text = "0";
            this.grassCount_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colorCheckBox
            // 
            this.colorCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.colorCheckBox.AutoSize = true;
            this.colorCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.colorCheckBox.Location = new System.Drawing.Point(724, 31);
            this.colorCheckBox.Name = "colorCheckBox";
            this.colorCheckBox.Size = new System.Drawing.Size(84, 17);
            this.colorCheckBox.TabIndex = 19;
            this.colorCheckBox.Text = "colored grid:";
            this.colorCheckBox.UseVisualStyleBackColor = true;
            this.colorCheckBox.CheckStateChanged += new System.EventHandler(this.colorCheckBox_CheckStateChanged);
            // 
            // nightCheckBox
            // 
            this.nightCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightCheckBox.AutoSize = true;
            this.nightCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.nightCheckBox.Location = new System.Drawing.Point(727, 12);
            this.nightCheckBox.Name = "nightCheckBox";
            this.nightCheckBox.Size = new System.Drawing.Size(81, 17);
            this.nightCheckBox.TabIndex = 20;
            this.nightCheckBox.Text = "night mode:";
            this.nightCheckBox.UseVisualStyleBackColor = true;
            this.nightCheckBox.CheckStateChanged += new System.EventHandler(this.nightCheckBox_CheckStateChanged);
            // 
            // sheepCountLabel
            // 
            this.sheepCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sheepCountLabel.Location = new System.Drawing.Point(95, 104);
            this.sheepCountLabel.Name = "sheepCountLabel";
            this.sheepCountLabel.Size = new System.Drawing.Size(33, 13);
            this.sheepCountLabel.TabIndex = 22;
            this.sheepCountLabel.Text = "0";
            this.sheepCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wolfCountLabel
            // 
            this.wolfCountLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wolfCountLabel.Location = new System.Drawing.Point(95, 123);
            this.wolfCountLabel.Name = "wolfCountLabel";
            this.wolfCountLabel.Size = new System.Drawing.Size(33, 13);
            this.wolfCountLabel.TabIndex = 24;
            this.wolfCountLabel.Text = "0";
            this.wolfCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // popGraph_Button
            // 
            this.popGraph_Button.Enabled = false;
            this.popGraph_Button.Location = new System.Drawing.Point(8, 16);
            this.popGraph_Button.Name = "popGraph_Button";
            this.popGraph_Button.Size = new System.Drawing.Size(75, 23);
            this.popGraph_Button.TabIndex = 25;
            this.popGraph_Button.Text = "Pop. Graph";
            this.popGraph_Button.UseVisualStyleBackColor = true;
            this.popGraph_Button.Click += new System.EventHandler(this.popGraph_Button_Click);
            // 
            // grassPopCheckBox
            // 
            this.grassPopCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grassPopCheckBox.AutoSize = true;
            this.grassPopCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.grassPopCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grassPopCheckBox.Checked = true;
            this.grassPopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grassPopCheckBox.Location = new System.Drawing.Point(6, 11);
            this.grassPopCheckBox.Name = "grassPopCheckBox";
            this.grassPopCheckBox.Size = new System.Drawing.Size(32, 17);
            this.grassPopCheckBox.TabIndex = 26;
            this.grassPopCheckBox.Text = "g";
            this.grassPopCheckBox.UseVisualStyleBackColor = false;
            // 
            // sheepPopCheckBox
            // 
            this.sheepPopCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sheepPopCheckBox.AutoSize = true;
            this.sheepPopCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.sheepPopCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sheepPopCheckBox.Checked = true;
            this.sheepPopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sheepPopCheckBox.Location = new System.Drawing.Point(44, 11);
            this.sheepPopCheckBox.Name = "sheepPopCheckBox";
            this.sheepPopCheckBox.Size = new System.Drawing.Size(31, 17);
            this.sheepPopCheckBox.TabIndex = 27;
            this.sheepPopCheckBox.Text = "s";
            this.sheepPopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sheepPopCheckBox.UseVisualStyleBackColor = false;
            // 
            // wolfPopCheckBox
            // 
            this.wolfPopCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wolfPopCheckBox.AutoSize = true;
            this.wolfPopCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wolfPopCheckBox.Checked = true;
            this.wolfPopCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wolfPopCheckBox.Location = new System.Drawing.Point(81, 11);
            this.wolfPopCheckBox.Name = "wolfPopCheckBox";
            this.wolfPopCheckBox.Size = new System.Drawing.Size(34, 17);
            this.wolfPopCheckBox.TabIndex = 28;
            this.wolfPopCheckBox.Text = "w";
            this.wolfPopCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wolfPopCheckBox.UseVisualStyleBackColor = true;
            // 
            // groGraph_Button
            // 
            this.groGraph_Button.Enabled = false;
            this.groGraph_Button.Location = new System.Drawing.Point(8, 40);
            this.groGraph_Button.Name = "groGraph_Button";
            this.groGraph_Button.Size = new System.Drawing.Size(75, 23);
            this.groGraph_Button.TabIndex = 29;
            this.groGraph_Button.Text = "Gro. Graph";
            this.groGraph_Button.UseVisualStyleBackColor = true;
            this.groGraph_Button.Click += new System.EventHandler(this.groGraph_Button_Click);
            // 
            // grassGroCheckBox
            // 
            this.grassGroCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.grassGroCheckBox.AutoSize = true;
            this.grassGroCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grassGroCheckBox.Checked = true;
            this.grassGroCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.grassGroCheckBox.Location = new System.Drawing.Point(4, 35);
            this.grassGroCheckBox.Name = "grassGroCheckBox";
            this.grassGroCheckBox.Size = new System.Drawing.Size(34, 17);
            this.grassGroCheckBox.TabIndex = 30;
            this.grassGroCheckBox.Text = "g\'";
            this.grassGroCheckBox.UseVisualStyleBackColor = true;
            // 
            // sheepGroCheckBox
            // 
            this.sheepGroCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sheepGroCheckBox.AutoSize = true;
            this.sheepGroCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sheepGroCheckBox.Checked = true;
            this.sheepGroCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.sheepGroCheckBox.Location = new System.Drawing.Point(42, 35);
            this.sheepGroCheckBox.Name = "sheepGroCheckBox";
            this.sheepGroCheckBox.Size = new System.Drawing.Size(33, 17);
            this.sheepGroCheckBox.TabIndex = 31;
            this.sheepGroCheckBox.Text = "s\'";
            this.sheepGroCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sheepGroCheckBox.UseVisualStyleBackColor = true;
            // 
            // wolfGroCheckBox
            // 
            this.wolfGroCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.wolfGroCheckBox.AutoSize = true;
            this.wolfGroCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wolfGroCheckBox.Checked = true;
            this.wolfGroCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.wolfGroCheckBox.Location = new System.Drawing.Point(79, 35);
            this.wolfGroCheckBox.Name = "wolfGroCheckBox";
            this.wolfGroCheckBox.Size = new System.Drawing.Size(36, 17);
            this.wolfGroCheckBox.TabIndex = 32;
            this.wolfGroCheckBox.Text = "w\'";
            this.wolfGroCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wolfGroCheckBox.UseVisualStyleBackColor = true;
            // 
            // antiExtinction_Checkbox
            // 
            this.antiExtinction_Checkbox.AutoSize = true;
            this.antiExtinction_Checkbox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.antiExtinction_Checkbox.Location = new System.Drawing.Point(16, 65);
            this.antiExtinction_Checkbox.Name = "antiExtinction_Checkbox";
            this.antiExtinction_Checkbox.Size = new System.Drawing.Size(72, 30);
            this.antiExtinction_Checkbox.TabIndex = 33;
            this.antiExtinction_Checkbox.Text = "Prevent\r\nExtinction";
            this.antiExtinction_Checkbox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.antiExtinction_Checkbox.UseVisualStyleBackColor = true;
            this.antiExtinction_Checkbox.CheckedChanged += new System.EventHandler(this.antiExtinction_Checkbox_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CreateEcosystem_Button);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.height_NumericUpDown);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.width_NumericUpDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.wolfRate);
            this.groupBox1.Controls.Add(this.sheepRate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.foodRate);
            this.groupBox1.Controls.Add(this.antiExtinction_Checkbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 143);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creation";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Spawn Rate";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.wolfGrowth_Label);
            this.groupBox2.Controls.Add(this.sheepGrowth_Label);
            this.groupBox2.Controls.Add(this.grassGrowth_Label);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.day_Label);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.popGraph_Button);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.groGraph_Button);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.grassCount_Label);
            this.groupBox2.Controls.Add(this.sheepCountLabel);
            this.groupBox2.Controls.Add(this.wolfCountLabel);
            this.groupBox2.Location = new System.Drawing.Point(287, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 143);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Info";
            // 
            // wolfGrowth_Label
            // 
            this.wolfGrowth_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.wolfGrowth_Label.Location = new System.Drawing.Point(45, 123);
            this.wolfGrowth_Label.Name = "wolfGrowth_Label";
            this.wolfGrowth_Label.Size = new System.Drawing.Size(33, 13);
            this.wolfGrowth_Label.TabIndex = 36;
            this.wolfGrowth_Label.Text = "0";
            this.wolfGrowth_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sheepGrowth_Label
            // 
            this.sheepGrowth_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sheepGrowth_Label.Location = new System.Drawing.Point(45, 104);
            this.sheepGrowth_Label.Name = "sheepGrowth_Label";
            this.sheepGrowth_Label.Size = new System.Drawing.Size(33, 13);
            this.sheepGrowth_Label.TabIndex = 36;
            this.sheepGrowth_Label.Text = "0";
            this.sheepGrowth_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grassGrowth_Label
            // 
            this.grassGrowth_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.grassGrowth_Label.Location = new System.Drawing.Point(45, 85);
            this.grassGrowth_Label.Name = "grassGrowth_Label";
            this.grassGrowth_Label.Size = new System.Drawing.Size(33, 13);
            this.grassGrowth_Label.TabIndex = 36;
            this.grassGrowth_Label.Text = "0";
            this.grassGrowth_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(37, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Growth";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Wolf :";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Sheep :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.wolfPopCheckBox);
            this.groupBox3.Controls.Add(this.grassPopCheckBox);
            this.groupBox3.Controls.Add(this.wolfGroCheckBox);
            this.groupBox3.Controls.Add(this.sheepPopCheckBox);
            this.groupBox3.Controls.Add(this.grassGroCheckBox);
            this.groupBox3.Controls.Add(this.sheepGroCheckBox);
            this.groupBox3.Location = new System.Drawing.Point(90, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 57);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "graph settings";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(93, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Count";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Grass :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.skipDays_NumericUpDown);
            this.groupBox4.Controls.Add(this.skipDays_Button);
            this.groupBox4.Controls.Add(this.nextDay_Button);
            this.groupBox4.Location = new System.Drawing.Point(520, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 143);
            this.groupBox4.TabIndex = 36;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Progession";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 70);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "Skip Days";
            // 
            // skipDays_NumericUpDown
            // 
            this.skipDays_NumericUpDown.Location = new System.Drawing.Point(9, 86);
            this.skipDays_NumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.skipDays_NumericUpDown.Name = "skipDays_NumericUpDown";
            this.skipDays_NumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.skipDays_NumericUpDown.TabIndex = 16;
            this.skipDays_NumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // skipDays_Button
            // 
            this.skipDays_Button.Enabled = false;
            this.skipDays_Button.Location = new System.Drawing.Point(67, 84);
            this.skipDays_Button.Name = "skipDays_Button";
            this.skipDays_Button.Size = new System.Drawing.Size(127, 24);
            this.skipDays_Button.TabIndex = 15;
            this.skipDays_Button.Text = "Skip";
            this.skipDays_Button.UseVisualStyleBackColor = true;
            this.skipDays_Button.Click += new System.EventHandler(this.skipDays_Button_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar1.ForeColor = System.Drawing.Color.OliveDrab;
            this.progressBar1.Location = new System.Drawing.Point(6, 112);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(188, 23);
            this.progressBar1.TabIndex = 37;
            this.progressBar1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 495);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.nightCheckBox);
            this.Controls.Add(this.colorCheckBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.displayBox);
            this.Name = "Form1";
            this.Text = "Project Ecosystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.height_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.width_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheepRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wolfRate)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skipDays_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateEcosystem_Button;
        private System.Windows.Forms.NumericUpDown height_NumericUpDown;
        private System.Windows.Forms.NumericUpDown width_NumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar foodRate;
        private System.Windows.Forms.TrackBar sheepRate;
        private System.Windows.Forms.TrackBar wolfRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox displayBox;
        private System.Windows.Forms.Button nextDay_Button;
        private System.Windows.Forms.Label day_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label grassCount_Label;
        private System.Windows.Forms.CheckBox colorCheckBox;
        private System.Windows.Forms.CheckBox nightCheckBox;
        private System.Windows.Forms.Label sheepCountLabel;
        private System.Windows.Forms.Label wolfCountLabel;
        private System.Windows.Forms.Button popGraph_Button;
        private System.Windows.Forms.CheckBox grassPopCheckBox;
        private System.Windows.Forms.CheckBox sheepPopCheckBox;
        private System.Windows.Forms.CheckBox wolfPopCheckBox;
        private System.Windows.Forms.Button groGraph_Button;
        private System.Windows.Forms.CheckBox grassGroCheckBox;
        private System.Windows.Forms.CheckBox sheepGroCheckBox;
        private System.Windows.Forms.CheckBox wolfGroCheckBox;
        private System.Windows.Forms.CheckBox antiExtinction_Checkbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label grassGrowth_Label;
        private System.Windows.Forms.Label wolfGrowth_Label;
        private System.Windows.Forms.Label sheepGrowth_Label;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.NumericUpDown skipDays_NumericUpDown;
        private System.Windows.Forms.Button skipDays_Button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

