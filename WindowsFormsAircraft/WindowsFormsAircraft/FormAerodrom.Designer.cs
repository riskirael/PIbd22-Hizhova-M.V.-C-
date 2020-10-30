namespace WindowsFormsAircraft
{
    partial class FormAerodrom
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
            this.pictureBoxAerodrom = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeAircraft = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAerodrom = new System.Windows.Forms.TextBox();
            this.buttonAddAerodrom = new System.Windows.Forms.Button();
            this.listBoxAerodrom = new System.Windows.Forms.ListBox();
            this.buttonDelAerodrom = new System.Windows.Forms.Button();
            this.buttonAddAircraft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAerodrom
            // 
            this.pictureBoxAerodrom.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAerodrom.Name = "pictureBoxAerodrom";
            this.pictureBoxAerodrom.Size = new System.Drawing.Size(655, 620);
            this.pictureBoxAerodrom.TabIndex = 0;
            this.pictureBoxAerodrom.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeAircraft);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(668, 464);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать самолет";
            // 
            // buttonTakeAircraft
            // 
            this.buttonTakeAircraft.Location = new System.Drawing.Point(12, 68);
            this.buttonTakeAircraft.Name = "buttonTakeAircraft";
            this.buttonTakeAircraft.Size = new System.Drawing.Size(107, 27);
            this.buttonTakeAircraft.TabIndex = 2;
            this.buttonTakeAircraft.Text = "Забрать";
            this.buttonTakeAircraft.UseVisualStyleBackColor = true;
            this.buttonTakeAircraft.Click += new System.EventHandler(this.buttonTakeAircraft_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(68, 31);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(662, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Аэродромы";
            // 
            // textBoxAerodrom
            // 
            this.textBoxAerodrom.Location = new System.Drawing.Point(665, 16);
            this.textBoxAerodrom.Name = "textBoxAerodrom";
            this.textBoxAerodrom.Size = new System.Drawing.Size(161, 20);
            this.textBoxAerodrom.TabIndex = 5;
            // 
            // buttonAddAerodrom
            // 
            this.buttonAddAerodrom.Location = new System.Drawing.Point(667, 42);
            this.buttonAddAerodrom.Name = "buttonAddAerodrom";
            this.buttonAddAerodrom.Size = new System.Drawing.Size(159, 25);
            this.buttonAddAerodrom.TabIndex = 6;
            this.buttonAddAerodrom.Text = "Добавить аэродром";
            this.buttonAddAerodrom.UseVisualStyleBackColor = true;
            this.buttonAddAerodrom.Click += new System.EventHandler(this.buttonAddAerodrom_Click);
            // 
            // listBoxAerodrom
            // 
            this.listBoxAerodrom.FormattingEnabled = true;
            this.listBoxAerodrom.Location = new System.Drawing.Point(667, 73);
            this.listBoxAerodrom.Name = "listBoxAerodrom";
            this.listBoxAerodrom.Size = new System.Drawing.Size(160, 108);
            this.listBoxAerodrom.TabIndex = 7;
            this.listBoxAerodrom.SelectedIndexChanged += new System.EventHandler(this.listBoxAerodrom_SelectedIndexChanged);
            // 
            // buttonDelAerodrom
            // 
            this.buttonDelAerodrom.Location = new System.Drawing.Point(665, 187);
            this.buttonDelAerodrom.Name = "buttonDelAerodrom";
            this.buttonDelAerodrom.Size = new System.Drawing.Size(159, 25);
            this.buttonDelAerodrom.TabIndex = 8;
            this.buttonDelAerodrom.Text = "Удалить аэродром";
            this.buttonDelAerodrom.UseVisualStyleBackColor = true;
            this.buttonDelAerodrom.Click += new System.EventHandler(this.buttonDelAerodrom_Click);
            // 
            // buttonAddAircraft
            // 
            this.buttonAddAircraft.Location = new System.Drawing.Point(664, 245);
            this.buttonAddAircraft.Name = "buttonAddAircraft";
            this.buttonAddAircraft.Size = new System.Drawing.Size(159, 62);
            this.buttonAddAircraft.TabIndex = 9;
            this.buttonAddAircraft.Text = "Добавить самолет";
            this.buttonAddAircraft.UseVisualStyleBackColor = true;
            this.buttonAddAircraft.Click += new System.EventHandler(this.buttonAddAircraft_Click);
            // 
            // FormAerodrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 621);
            this.Controls.Add(this.buttonAddAircraft);
            this.Controls.Add(this.buttonDelAerodrom);
            this.Controls.Add(this.listBoxAerodrom);
            this.Controls.Add(this.buttonAddAerodrom);
            this.Controls.Add(this.textBoxAerodrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxAerodrom);
            this.Name = "FormAerodrom";
            this.Text = "Аэродром";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAerodrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeAircraft;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAerodrom;
        private System.Windows.Forms.Button buttonAddAerodrom;
        private System.Windows.Forms.ListBox listBoxAerodrom;
        private System.Windows.Forms.Button buttonDelAerodrom;
        private System.Windows.Forms.Button buttonAddAircraft;
    }
}