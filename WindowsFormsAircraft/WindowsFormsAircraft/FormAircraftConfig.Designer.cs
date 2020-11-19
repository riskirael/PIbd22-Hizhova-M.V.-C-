namespace WindowsFormsAircraft
{
    partial class FormAircraftConfig
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
            this.pictureBoxAircraft = new System.Windows.Forms.PictureBox();
            this.groupBoxLabel = new System.Windows.Forms.GroupBox();
            this.labelSeaPlane = new System.Windows.Forms.Label();
            this.labelAircraft = new System.Windows.Forms.Label();
            this.groupBoxParametr = new System.Windows.Forms.GroupBox();
            this.checkBoxStripes = new System.Windows.Forms.CheckBox();
            this.checkBoxBobber = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPicBox = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelColor = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGrey = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.buttonCancelColor = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).BeginInit();
            this.groupBoxLabel.SuspendLayout();
            this.groupBoxParametr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.panelPicBox.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.panelColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAircraft
            // 
            this.pictureBoxAircraft.Location = new System.Drawing.Point(24, 27);
            this.pictureBoxAircraft.Name = "pictureBoxAircraft";
            this.pictureBoxAircraft.Size = new System.Drawing.Size(140, 90);
            this.pictureBoxAircraft.TabIndex = 0;
            this.pictureBoxAircraft.TabStop = false;
            // 
            // groupBoxLabel
            // 
            this.groupBoxLabel.Controls.Add(this.labelSeaPlane);
            this.groupBoxLabel.Controls.Add(this.labelAircraft);
            this.groupBoxLabel.Location = new System.Drawing.Point(12, 12);
            this.groupBoxLabel.Name = "groupBoxLabel";
            this.groupBoxLabel.Size = new System.Drawing.Size(140, 139);
            this.groupBoxLabel.TabIndex = 1;
            this.groupBoxLabel.TabStop = false;
            this.groupBoxLabel.Text = "Тип самолета";
            // 
            // labelSeaPlane
            // 
            this.labelSeaPlane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSeaPlane.Location = new System.Drawing.Point(6, 78);
            this.labelSeaPlane.Name = "labelSeaPlane";
            this.labelSeaPlane.Size = new System.Drawing.Size(107, 41);
            this.labelSeaPlane.TabIndex = 2;
            this.labelSeaPlane.Text = "Гидросамолет";
            this.labelSeaPlane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSeaPlane_MouseDown);
            // 
            // labelAircraft
            // 
            this.labelAircraft.BackColor = System.Drawing.SystemColors.Control;
            this.labelAircraft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAircraft.Location = new System.Drawing.Point(6, 16);
            this.labelAircraft.Name = "labelAircraft";
            this.labelAircraft.Size = new System.Drawing.Size(107, 40);
            this.labelAircraft.TabIndex = 2;
            this.labelAircraft.Text = "Самолет";
            this.labelAircraft.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelAircraft_MouseDown);
            // 
            // groupBoxParametr
            // 
            this.groupBoxParametr.Controls.Add(this.checkBoxStripes);
            this.groupBoxParametr.Controls.Add(this.checkBoxBobber);
            this.groupBoxParametr.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParametr.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParametr.Controls.Add(this.label2);
            this.groupBoxParametr.Controls.Add(this.label1);
            this.groupBoxParametr.Location = new System.Drawing.Point(12, 216);
            this.groupBoxParametr.Name = "groupBoxParametr";
            this.groupBoxParametr.Size = new System.Drawing.Size(378, 126);
            this.groupBoxParametr.TabIndex = 2;
            this.groupBoxParametr.TabStop = false;
            this.groupBoxParametr.Text = "Параметры";
            // 
            // checkBoxStripes
            // 
            this.checkBoxStripes.AutoSize = true;
            this.checkBoxStripes.Location = new System.Drawing.Point(164, 85);
            this.checkBoxStripes.Name = "checkBoxStripes";
            this.checkBoxStripes.Size = new System.Drawing.Size(58, 17);
            this.checkBoxStripes.TabIndex = 5;
            this.checkBoxStripes.Text = "Линии";
            this.checkBoxStripes.UseVisualStyleBackColor = true;
            // 
            // checkBoxBobber
            // 
            this.checkBoxBobber.AutoSize = true;
            this.checkBoxBobber.Location = new System.Drawing.Point(164, 26);
            this.checkBoxBobber.Name = "checkBoxBobber";
            this.checkBoxBobber.Size = new System.Drawing.Size(76, 17);
            this.checkBoxBobber.TabIndex = 4;
            this.checkBoxBobber.Text = "Поплавки";
            this.checkBoxBobber.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(9, 85);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(9, 42);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Максимальная скорость";
            // 
            // panelPicBox
            // 
            this.panelPicBox.AllowDrop = true;
            this.panelPicBox.Controls.Add(this.pictureBoxAircraft);
            this.panelPicBox.Location = new System.Drawing.Point(176, 15);
            this.panelPicBox.Name = "panelPicBox";
            this.panelPicBox.Size = new System.Drawing.Size(190, 139);
            this.panelPicBox.TabIndex = 3;
            this.panelPicBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelPicBox_DragDrop);
            this.panelPicBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelPicBox_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelColor);
            this.groupBoxColor.Location = new System.Drawing.Point(404, 15);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(301, 231);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelColor
            // 
            this.panelColor.AllowDrop = true;
            this.panelColor.Controls.Add(this.panelPurple);
            this.panelColor.Controls.Add(this.labelDopColor);
            this.panelColor.Controls.Add(this.labelMainColor);
            this.panelColor.Controls.Add(this.panelBlue);
            this.panelColor.Controls.Add(this.panelGrey);
            this.panelColor.Controls.Add(this.panelWhite);
            this.panelColor.Controls.Add(this.panelRed);
            this.panelColor.Controls.Add(this.panelGreen);
            this.panelColor.Controls.Add(this.panelBlack);
            this.panelColor.Controls.Add(this.panelYellow);
            this.panelColor.Location = new System.Drawing.Point(6, 19);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(294, 194);
            this.panelColor.TabIndex = 6;
            this.panelColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panelPurple
            // 
            this.panelPurple.AllowDrop = true;
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.Location = new System.Drawing.Point(87, 123);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(57, 52);
            this.panelPurple.TabIndex = 3;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(153, 9);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(132, 41);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(17, 9);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(127, 41);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // panelBlue
            // 
            this.panelBlue.AllowDrop = true;
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(231, 65);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(57, 52);
            this.panelBlue.TabIndex = 3;
            // 
            // panelGrey
            // 
            this.panelGrey.AllowDrop = true;
            this.panelGrey.BackColor = System.Drawing.Color.Gray;
            this.panelGrey.Location = new System.Drawing.Point(157, 65);
            this.panelGrey.Name = "panelGrey";
            this.panelGrey.Size = new System.Drawing.Size(57, 52);
            this.panelGrey.TabIndex = 3;
            // 
            // panelWhite
            // 
            this.panelWhite.AllowDrop = true;
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.Location = new System.Drawing.Point(232, 123);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(57, 52);
            this.panelWhite.TabIndex = 3;
            // 
            // panelRed
            // 
            this.panelRed.AllowDrop = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(17, 123);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(57, 52);
            this.panelRed.TabIndex = 3;
            // 
            // panelGreen
            // 
            this.panelGreen.AllowDrop = true;
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(157, 123);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(57, 52);
            this.panelGreen.TabIndex = 3;
            // 
            // panelBlack
            // 
            this.panelBlack.AllowDrop = true;
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.Location = new System.Drawing.Point(87, 65);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(57, 52);
            this.panelBlack.TabIndex = 3;
            // 
            // panelYellow
            // 
            this.panelYellow.AllowDrop = true;
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(17, 65);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(57, 52);
            this.panelYellow.TabIndex = 2;
            // 
            // buttonCancelColor
            // 
            this.buttonCancelColor.Location = new System.Drawing.Point(569, 297);
            this.buttonCancelColor.Name = "buttonCancelColor";
            this.buttonCancelColor.Size = new System.Drawing.Size(135, 21);
            this.buttonCancelColor.TabIndex = 5;
            this.buttonCancelColor.Text = "Отмена";
            this.buttonCancelColor.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(570, 258);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(134, 25);
            this.buttonOk.TabIndex = 4;
            this.buttonOk.Text = "Добавить";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormAircraftConfig
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 343);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancelColor);
            this.Controls.Add(this.panelPicBox);
            this.Controls.Add(this.groupBoxParametr);
            this.Controls.Add(this.groupBoxLabel);
            this.Name = "FormAircraftConfig";
            this.Text = "Выбор самолета";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAircraft)).EndInit();
            this.groupBoxLabel.ResumeLayout(false);
            this.groupBoxParametr.ResumeLayout(false);
            this.groupBoxParametr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.panelPicBox.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.panelColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAircraft;
        private System.Windows.Forms.GroupBox groupBoxLabel;
        private System.Windows.Forms.Label labelSeaPlane;
        private System.Windows.Forms.Label labelAircraft;
        private System.Windows.Forms.GroupBox groupBoxParametr;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxStripes;
        private System.Windows.Forms.CheckBox checkBoxBobber;
        private System.Windows.Forms.Panel panelPicBox;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonCancelColor;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Panel panelColor;
    }
}