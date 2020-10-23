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
            this.buttonSetAircraft = new System.Windows.Forms.Button();
            this.buttonSetSeaPlane = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeAircraft = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrom)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAerodrom
            // 
            this.pictureBoxAerodrom.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAerodrom.Name = "pictureBoxAerodrom";
            this.pictureBoxAerodrom.Size = new System.Drawing.Size(655, 451);
            this.pictureBoxAerodrom.TabIndex = 0;
            this.pictureBoxAerodrom.TabStop = false;
            // 
            // buttonSetAircraft
            // 
            this.buttonSetAircraft.Location = new System.Drawing.Point(689, 12);
            this.buttonSetAircraft.Name = "buttonSetAircraft";
            this.buttonSetAircraft.Size = new System.Drawing.Size(127, 42);
            this.buttonSetAircraft.TabIndex = 1;
            this.buttonSetAircraft.Text = "Приземлить самолет";
            this.buttonSetAircraft.UseVisualStyleBackColor = true;
            this.buttonSetAircraft.Click += new System.EventHandler(this.buttonSetAircraft_Click);
            // 
            // buttonSetSeaPlane
            // 
            this.buttonSetSeaPlane.Location = new System.Drawing.Point(689, 107);
            this.buttonSetSeaPlane.Name = "buttonSetSeaPlane";
            this.buttonSetSeaPlane.Size = new System.Drawing.Size(127, 42);
            this.buttonSetSeaPlane.TabIndex = 2;
            this.buttonSetSeaPlane.Text = "Приземлить гидросамолет";
            this.buttonSetSeaPlane.UseVisualStyleBackColor = true;
            this.buttonSetSeaPlane.Click += new System.EventHandler(this.buttonSetSeaPlane_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeAircraft);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(661, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 246);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Забрать самолет";
            // 
            // buttonTakeAircraft
            // 
            this.buttonTakeAircraft.Location = new System.Drawing.Point(23, 51);
            this.buttonTakeAircraft.Name = "buttonTakeAircraft";
            this.buttonTakeAircraft.Size = new System.Drawing.Size(107, 27);
            this.buttonTakeAircraft.TabIndex = 2;
            this.buttonTakeAircraft.Text = "Забрать";
            this.buttonTakeAircraft.UseVisualStyleBackColor = true;
            this.buttonTakeAircraft.Click += new System.EventHandler(this.buttonTakeAircraft_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(77, 25);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(42, 20);
            this.maskedTextBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место";
            // 
            // FormAerodrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 456);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonSetSeaPlane);
            this.Controls.Add(this.buttonSetAircraft);
            this.Controls.Add(this.pictureBoxAerodrom);
            this.Name = "FormAerodrom";
            this.Text = "Аэродром";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAerodrom)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAerodrom;
        private System.Windows.Forms.Button buttonSetAircraft;
        private System.Windows.Forms.Button buttonSetSeaPlane;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonTakeAircraft;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label1;
    }
}