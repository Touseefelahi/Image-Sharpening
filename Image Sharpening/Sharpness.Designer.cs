namespace Image_Sharpening
{
    partial class Sharpness
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
            this.components = new System.ComponentModel.Container();
            this.labelSharp = new System.Windows.Forms.Label();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.imageBoxOriginal = new Emgu.CV.UI.ImageBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.imageBoxShapen = new Emgu.CV.UI.ImageBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.textBoxErrors = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.textBoxSharpFactor = new System.Windows.Forms.TextBox();
            this.buttonBlur1 = new System.Windows.Forms.Button();
            this.textBoxBlurfactor = new System.Windows.Forms.TextBox();
            this.labelBlur = new System.Windows.Forms.Label();
            this.trackBarBlurfactor = new System.Windows.Forms.TrackBar();
            this.buttonDifference = new System.Windows.Forms.Button();
            this.buttonAverageBlur = new System.Windows.Forms.Button();
            this.buttonBlur2 = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.buttonContrastAdjustment = new System.Windows.Forms.Button();
            this.textBoxThreshold = new System.Windows.Forms.TextBox();
            this.textBoxMultiplier = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonResetImage = new System.Windows.Forms.Button();
            this.buttonSharpContrast = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox00 = new System.Windows.Forms.TextBox();
            this.textBox01 = new System.Windows.Forms.TextBox();
            this.textBox02 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.trackBarThreshold = new System.Windows.Forms.TrackBar();
            this.textBoxThreshold1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDivisor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxBinaryImage = new System.Windows.Forms.CheckBox();
            this.textBoxFirstCol = new System.Windows.Forms.TextBox();
            this.textBoxFirstRow = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxZoom = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxShapen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlurfactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSharp
            // 
            this.labelSharp.AutoSize = true;
            this.labelSharp.Location = new System.Drawing.Point(660, 522);
            this.labelSharp.Name = "labelSharp";
            this.labelSharp.Size = new System.Drawing.Size(87, 13);
            this.labelSharp.TabIndex = 0;
            this.labelSharp.Text = "Sharpness factor";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.Location = new System.Drawing.Point(10, 491);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(117, 44);
            this.buttonLoadImage.TabIndex = 1;
            this.buttonLoadImage.Text = "Open Image";
            this.buttonLoadImage.UseVisualStyleBackColor = true;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // imageBoxOriginal
            // 
            this.imageBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxOriginal.Location = new System.Drawing.Point(5, 4);
            this.imageBoxOriginal.Name = "imageBoxOriginal";
            this.imageBoxOriginal.Size = new System.Drawing.Size(640, 480);
            this.imageBoxOriginal.TabIndex = 2;
            this.imageBoxOriginal.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(651, 490);
            this.trackBar1.Maximum = 200;
            this.trackBar1.Minimum = -200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBar1.Size = new System.Drawing.Size(640, 45);
            this.trackBar1.TabIndex = 3;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // imageBoxShapen
            // 
            this.imageBoxShapen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxShapen.Location = new System.Drawing.Point(651, 4);
            this.imageBoxShapen.Name = "imageBoxShapen";
            this.imageBoxShapen.Size = new System.Drawing.Size(640, 480);
            this.imageBoxShapen.TabIndex = 4;
            this.imageBoxShapen.TabStop = false;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(524, 491);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(117, 44);
            this.buttonRefresh.TabIndex = 5;
            this.buttonRefresh.Text = "Sharp Image";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonSharp_Click);
            // 
            // textBoxErrors
            // 
            this.textBoxErrors.Location = new System.Drawing.Point(5, 611);
            this.textBoxErrors.Name = "textBoxErrors";
            this.textBoxErrors.Size = new System.Drawing.Size(634, 52);
            this.textBoxErrors.TabIndex = 6;
            this.textBoxErrors.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // textBoxSharpFactor
            // 
            this.textBoxSharpFactor.Location = new System.Drawing.Point(747, 518);
            this.textBoxSharpFactor.Name = "textBoxSharpFactor";
            this.textBoxSharpFactor.Size = new System.Drawing.Size(68, 20);
            this.textBoxSharpFactor.TabIndex = 7;
            this.textBoxSharpFactor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxSharpFactor_KeyDown);
            // 
            // buttonBlur1
            // 
            this.buttonBlur1.Location = new System.Drawing.Point(129, 491);
            this.buttonBlur1.Name = "buttonBlur1";
            this.buttonBlur1.Size = new System.Drawing.Size(117, 44);
            this.buttonBlur1.TabIndex = 8;
            this.buttonBlur1.Text = "Blur Image";
            this.buttonBlur1.UseVisualStyleBackColor = true;
            this.buttonBlur1.Click += new System.EventHandler(this.buttonBlur_Click);
            // 
            // textBoxBlurfactor
            // 
            this.textBoxBlurfactor.Location = new System.Drawing.Point(747, 575);
            this.textBoxBlurfactor.Name = "textBoxBlurfactor";
            this.textBoxBlurfactor.Size = new System.Drawing.Size(68, 20);
            this.textBoxBlurfactor.TabIndex = 11;
            this.textBoxBlurfactor.Text = "2";
            // 
            // labelBlur
            // 
            this.labelBlur.AutoSize = true;
            this.labelBlur.Location = new System.Drawing.Point(660, 579);
            this.labelBlur.Name = "labelBlur";
            this.labelBlur.Size = new System.Drawing.Size(58, 13);
            this.labelBlur.TabIndex = 9;
            this.labelBlur.Text = "Blur Factor";
            // 
            // trackBarBlurfactor
            // 
            this.trackBarBlurfactor.Location = new System.Drawing.Point(651, 547);
            this.trackBarBlurfactor.Maximum = 21;
            this.trackBarBlurfactor.Minimum = 7;
            this.trackBarBlurfactor.Name = "trackBarBlurfactor";
            this.trackBarBlurfactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarBlurfactor.Size = new System.Drawing.Size(640, 45);
            this.trackBarBlurfactor.TabIndex = 10;
            this.trackBarBlurfactor.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarBlurfactor.Value = 7;
            this.trackBarBlurfactor.Scroll += new System.EventHandler(this.trackBarBlurfactor_Scroll);
            // 
            // buttonDifference
            // 
            this.buttonDifference.Location = new System.Drawing.Point(248, 491);
            this.buttonDifference.Name = "buttonDifference";
            this.buttonDifference.Size = new System.Drawing.Size(117, 44);
            this.buttonDifference.TabIndex = 12;
            this.buttonDifference.Text = "Difference";
            this.buttonDifference.UseVisualStyleBackColor = true;
            this.buttonDifference.Click += new System.EventHandler(this.buttonDifference_Click);
            // 
            // buttonAverageBlur
            // 
            this.buttonAverageBlur.Location = new System.Drawing.Point(1199, 639);
            this.buttonAverageBlur.Name = "buttonAverageBlur";
            this.buttonAverageBlur.Size = new System.Drawing.Size(117, 44);
            this.buttonAverageBlur.TabIndex = 13;
            this.buttonAverageBlur.Text = "Apply Filter";
            this.buttonAverageBlur.UseVisualStyleBackColor = true;
            this.buttonAverageBlur.Click += new System.EventHandler(this.buttonAverageBlur_Click);
            // 
            // buttonBlur2
            // 
            this.buttonBlur2.Location = new System.Drawing.Point(129, 541);
            this.buttonBlur2.Name = "buttonBlur2";
            this.buttonBlur2.Size = new System.Drawing.Size(117, 44);
            this.buttonBlur2.TabIndex = 14;
            this.buttonBlur2.Text = "Blur Pascal";
            this.buttonBlur2.UseVisualStyleBackColor = true;
            this.buttonBlur2.Click += new System.EventHandler(this.buttonBlur2_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox2.Location = new System.Drawing.Point(1297, 4);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(640, 480);
            this.imageBox2.TabIndex = 15;
            this.imageBox2.TabStop = false;
            // 
            // buttonContrastAdjustment
            // 
            this.buttonContrastAdjustment.Location = new System.Drawing.Point(665, 672);
            this.buttonContrastAdjustment.Name = "buttonContrastAdjustment";
            this.buttonContrastAdjustment.Size = new System.Drawing.Size(75, 23);
            this.buttonContrastAdjustment.TabIndex = 16;
            this.buttonContrastAdjustment.Text = "Apply";
            this.buttonContrastAdjustment.UseVisualStyleBackColor = true;
            this.buttonContrastAdjustment.Click += new System.EventHandler(this.buttonContrastAdjustment_Click);
            // 
            // textBoxThreshold
            // 
            this.textBoxThreshold.Location = new System.Drawing.Point(663, 622);
            this.textBoxThreshold.Name = "textBoxThreshold";
            this.textBoxThreshold.Size = new System.Drawing.Size(68, 20);
            this.textBoxThreshold.TabIndex = 17;
            this.textBoxThreshold.Text = "120";
            // 
            // textBoxMultiplier
            // 
            this.textBoxMultiplier.Location = new System.Drawing.Point(747, 622);
            this.textBoxMultiplier.Name = "textBoxMultiplier";
            this.textBoxMultiplier.Size = new System.Drawing.Size(68, 20);
            this.textBoxMultiplier.TabIndex = 18;
            this.textBoxMultiplier.Text = "1.5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 650);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(744, 650);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Multiplier";
            // 
            // buttonResetImage
            // 
            this.buttonResetImage.Location = new System.Drawing.Point(747, 672);
            this.buttonResetImage.Name = "buttonResetImage";
            this.buttonResetImage.Size = new System.Drawing.Size(75, 23);
            this.buttonResetImage.TabIndex = 21;
            this.buttonResetImage.Text = "Reset";
            this.buttonResetImage.UseVisualStyleBackColor = true;
            this.buttonResetImage.Click += new System.EventHandler(this.buttonResetImage_Click);
            // 
            // buttonSharpContrast
            // 
            this.buttonSharpContrast.Location = new System.Drawing.Point(842, 611);
            this.buttonSharpContrast.Name = "buttonSharpContrast";
            this.buttonSharpContrast.Size = new System.Drawing.Size(75, 53);
            this.buttonSharpContrast.TabIndex = 22;
            this.buttonSharpContrast.Text = "Apply on Result Screen";
            this.buttonSharpContrast.UseVisualStyleBackColor = true;
            this.buttonSharpContrast.Click += new System.EventHandler(this.buttonSharpContrast_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Location = new System.Drawing.Point(929, 611);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(75, 53);
            this.buttonSaveImage.TabIndex = 23;
            this.buttonSaveImage.Text = "Save Image";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(1010, 622);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(73, 20);
            this.textBoxFileName.TabIndex = 24;
            this.textBoxFileName.Text = "FileName";
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Location = new System.Drawing.Point(1223, 575);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(68, 20);
            this.textBoxIterations.TabIndex = 25;
            this.textBoxIterations.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1133, 579);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Iterations";
            // 
            // textBox00
            // 
            this.textBox00.Location = new System.Drawing.Point(1091, 611);
            this.textBox00.Name = "textBox00";
            this.textBox00.Size = new System.Drawing.Size(30, 20);
            this.textBox00.TabIndex = 0;
            this.textBox00.Text = "1";
            // 
            // textBox01
            // 
            this.textBox01.Location = new System.Drawing.Point(1127, 611);
            this.textBox01.Name = "textBox01";
            this.textBox01.Size = new System.Drawing.Size(30, 20);
            this.textBox01.TabIndex = 1;
            this.textBox01.Text = "2";
            // 
            // textBox02
            // 
            this.textBox02.Location = new System.Drawing.Point(1163, 611);
            this.textBox02.Name = "textBox02";
            this.textBox02.Size = new System.Drawing.Size(30, 20);
            this.textBox02.TabIndex = 2;
            this.textBox02.Text = "1";
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(1163, 637);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(30, 20);
            this.textBox12.TabIndex = 5;
            this.textBox12.Text = "0";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(1127, 637);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(30, 20);
            this.textBox11.TabIndex = 4;
            this.textBox11.Text = "0";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(1091, 637);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(30, 20);
            this.textBox10.TabIndex = 3;
            this.textBox10.Text = "0";
            // 
            // textBox22
            // 
            this.textBox22.Location = new System.Drawing.Point(1163, 663);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(30, 20);
            this.textBox22.TabIndex = 8;
            this.textBox22.Text = "-1";
            // 
            // textBox21
            // 
            this.textBox21.Location = new System.Drawing.Point(1127, 663);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(30, 20);
            this.textBox21.TabIndex = 7;
            this.textBox21.Text = "-2";
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(1091, 663);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(30, 20);
            this.textBox20.TabIndex = 6;
            this.textBox20.Text = "-1";
            // 
            // trackBarThreshold
            // 
            this.trackBarThreshold.Location = new System.Drawing.Point(1297, 491);
            this.trackBarThreshold.Maximum = 255;
            this.trackBarThreshold.Name = "trackBarThreshold";
            this.trackBarThreshold.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarThreshold.Size = new System.Drawing.Size(625, 45);
            this.trackBarThreshold.TabIndex = 27;
            this.trackBarThreshold.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarThreshold.Value = 100;
            this.trackBarThreshold.Scroll += new System.EventHandler(this.trackBarThreshold_Scroll);
            // 
            // textBoxThreshold1
            // 
            this.textBoxThreshold1.Location = new System.Drawing.Point(1363, 519);
            this.textBoxThreshold1.Name = "textBoxThreshold1";
            this.textBoxThreshold1.Size = new System.Drawing.Size(68, 20);
            this.textBoxThreshold1.TabIndex = 29;
            this.textBoxThreshold1.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1307, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Threshold";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxDivisor
            // 
            this.textBoxDivisor.Location = new System.Drawing.Point(1244, 611);
            this.textBoxDivisor.Name = "textBoxDivisor";
            this.textBoxDivisor.Size = new System.Drawing.Size(72, 20);
            this.textBoxDivisor.TabIndex = 30;
            this.textBoxDivisor.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1199, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Divisor";
            // 
            // checkBoxBinaryImage
            // 
            this.checkBoxBinaryImage.AutoSize = true;
            this.checkBoxBinaryImage.Location = new System.Drawing.Point(1437, 523);
            this.checkBoxBinaryImage.Name = "checkBoxBinaryImage";
            this.checkBoxBinaryImage.Size = new System.Drawing.Size(52, 17);
            this.checkBoxBinaryImage.TabIndex = 32;
            this.checkBoxBinaryImage.Text = "Apply";
            this.checkBoxBinaryImage.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstCol
            // 
            this.textBoxFirstCol.Location = new System.Drawing.Point(1473, 636);
            this.textBoxFirstCol.Name = "textBoxFirstCol";
            this.textBoxFirstCol.Size = new System.Drawing.Size(72, 20);
            this.textBoxFirstCol.TabIndex = 33;
            this.textBoxFirstCol.Text = "300";
            // 
            // textBoxFirstRow
            // 
            this.textBoxFirstRow.Location = new System.Drawing.Point(1473, 611);
            this.textBoxFirstRow.Name = "textBoxFirstRow";
            this.textBoxFirstRow.Size = new System.Drawing.Size(72, 20);
            this.textBoxFirstRow.TabIndex = 34;
            this.textBoxFirstRow.Text = "200";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1413, 640);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "First Column";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1413, 616);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "First Row";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1413, 594);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Zooming Options";
            // 
            // comboBoxZoom
            // 
            this.comboBoxZoom.FormattingEnabled = true;
            this.comboBoxZoom.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10",
            "12",
            "14",
            "16"});
            this.comboBoxZoom.Location = new System.Drawing.Point(1473, 660);
            this.comboBoxZoom.Name = "comboBoxZoom";
            this.comboBoxZoom.Size = new System.Drawing.Size(72, 21);
            this.comboBoxZoom.TabIndex = 38;
            this.comboBoxZoom.Text = "4";
            this.comboBoxZoom.SelectedIndexChanged += new System.EventHandler(this.comboBoxZoom_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1413, 663);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Zoom Scale";
            // 
            // Sharpness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1941, 707);
            this.Controls.Add(this.comboBoxZoom);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxFirstCol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFirstRow);
            this.Controls.Add(this.checkBoxBinaryImage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxDivisor);
            this.Controls.Add(this.textBoxThreshold1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarThreshold);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.textBox20);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox02);
            this.Controls.Add(this.textBox01);
            this.Controls.Add(this.textBox00);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIterations);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.buttonSaveImage);
            this.Controls.Add(this.buttonSharpContrast);
            this.Controls.Add(this.buttonResetImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxMultiplier);
            this.Controls.Add(this.textBoxThreshold);
            this.Controls.Add(this.buttonContrastAdjustment);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.buttonBlur2);
            this.Controls.Add(this.buttonAverageBlur);
            this.Controls.Add(this.buttonDifference);
            this.Controls.Add(this.textBoxBlurfactor);
            this.Controls.Add(this.labelBlur);
            this.Controls.Add(this.trackBarBlurfactor);
            this.Controls.Add(this.buttonBlur1);
            this.Controls.Add(this.textBoxSharpFactor);
            this.Controls.Add(this.textBoxErrors);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.imageBoxShapen);
            this.Controls.Add(this.imageBoxOriginal);
            this.Controls.Add(this.buttonLoadImage);
            this.Controls.Add(this.labelSharp);
            this.Controls.Add(this.trackBar1);
            this.Name = "Sharpness";
            this.Text = "Sharpness";
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxShapen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBlurfactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThreshold)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSharp;
        private System.Windows.Forms.Button buttonLoadImage;
        private Emgu.CV.UI.ImageBox imageBoxOriginal;
        private System.Windows.Forms.TrackBar trackBar1;
        private Emgu.CV.UI.ImageBox imageBoxShapen;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.RichTextBox textBoxErrors;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox textBoxSharpFactor;
        private System.Windows.Forms.Button buttonBlur1;
        private System.Windows.Forms.TextBox textBoxBlurfactor;
        private System.Windows.Forms.Label labelBlur;
        private System.Windows.Forms.TrackBar trackBarBlurfactor;
        private System.Windows.Forms.Button buttonDifference;
        private System.Windows.Forms.Button buttonAverageBlur;
        private System.Windows.Forms.Button buttonBlur2;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button buttonContrastAdjustment;
        private System.Windows.Forms.TextBox textBoxThreshold;
        private System.Windows.Forms.TextBox textBoxMultiplier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonResetImage;
        private System.Windows.Forms.Button buttonSharpContrast;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox00;
        private System.Windows.Forms.TextBox textBox01;
        private System.Windows.Forms.TextBox textBox02;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TrackBar trackBarThreshold;
        private System.Windows.Forms.TextBox textBoxThreshold1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDivisor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxBinaryImage;
        private System.Windows.Forms.TextBox textBoxFirstCol;
        private System.Windows.Forms.TextBox textBoxFirstRow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxZoom;
        private System.Windows.Forms.Label label9;
    }
}

