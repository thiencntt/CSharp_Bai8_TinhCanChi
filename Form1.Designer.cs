namespace CSharp_Bai8_TinhCanChi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDuongLich = new System.Windows.Forms.TextBox();
            this.txtAmLich = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.nudDuongLich = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuongLich)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "TÍNH CAN CHI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dương lịch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtDuongLich
            // 
            this.txtDuongLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuongLich.ForeColor = System.Drawing.Color.IndianRed;
            this.txtDuongLich.Location = new System.Drawing.Point(294, 260);
            this.txtDuongLich.Name = "txtDuongLich";
            this.txtDuongLich.Size = new System.Drawing.Size(330, 53);
            this.txtDuongLich.TabIndex = 2;
            this.txtDuongLich.Text = "2023";
            this.txtDuongLich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAmLich
            // 
            this.txtAmLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmLich.ForeColor = System.Drawing.Color.IndianRed;
            this.txtAmLich.Location = new System.Drawing.Point(294, 348);
            this.txtAmLich.Name = "txtAmLich";
            this.txtAmLich.Size = new System.Drawing.Size(330, 53);
            this.txtAmLich.TabIndex = 4;
            this.txtAmLich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 348);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 48);
            this.label3.TabIndex = 3;
            this.label3.Text = "Âm lịch";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.Yellow;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConvert.Location = new System.Drawing.Point(200, 437);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(296, 115);
            this.btnConvert.TabIndex = 5;
            this.btnConvert.Text = "CHUYỂN ĐỔI";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // nudDuongLich
            // 
            this.nudDuongLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudDuongLich.Location = new System.Drawing.Point(294, 171);
            this.nudDuongLich.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudDuongLich.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudDuongLich.Name = "nudDuongLich";
            this.nudDuongLich.Size = new System.Drawing.Size(330, 53);
            this.nudDuongLich.TabIndex = 6;
            this.nudDuongLich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudDuongLich.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.nudDuongLich.ValueChanged += new System.EventHandler(this.nudDuongLich_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 601);
            this.Controls.Add(this.nudDuongLich);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtAmLich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDuongLich);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDuongLich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDuongLich;
        private System.Windows.Forms.TextBox txtAmLich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.NumericUpDown nudDuongLich;
    }
}

