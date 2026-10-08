namespace CA_TWO_OOP.Forms
{
    partial class Transfer
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
            this.label4 = new System.Windows.Forms.Label();
            this.DErrorLabel = new System.Windows.Forms.Label();
            this.TConfirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TAmount = new System.Windows.Forms.TextBox();
            this.DACCOUNTBOX = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TAccountNumber = new System.Windows.Forms.TextBox();
            this.Tdgvtransfer = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TSor = new System.Windows.Forms.Label();
            this.TSortCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.DACCOUNTBOX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tdgvtransfer)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(466, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Transfer";
            // 
            // DErrorLabel
            // 
            this.DErrorLabel.AutoSize = true;
            this.DErrorLabel.Location = new System.Drawing.Point(369, 372);
            this.DErrorLabel.Name = "DErrorLabel";
            this.DErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.DErrorLabel.TabIndex = 34;
            this.DErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TConfirm
            // 
            this.TConfirm.Location = new System.Drawing.Point(736, 355);
            this.TConfirm.Name = "TConfirm";
            this.TConfirm.Size = new System.Drawing.Size(173, 46);
            this.TConfirm.TabIndex = 33;
            this.TConfirm.Text = "Confirm";
            this.TConfirm.UseVisualStyleBackColor = true;
            this.TConfirm.Click += new System.EventHandler(this.TConfirm_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TAmount);
            this.groupBox1.Location = new System.Drawing.Point(736, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 84);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Amount :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TAmount
            // 
            this.TAmount.Location = new System.Drawing.Point(29, 39);
            this.TAmount.Name = "TAmount";
            this.TAmount.Size = new System.Drawing.Size(120, 20);
            this.TAmount.TabIndex = 0;
            // 
            // DACCOUNTBOX
            // 
            this.DACCOUNTBOX.BackColor = System.Drawing.Color.PowderBlue;
            this.DACCOUNTBOX.Controls.Add(this.label1);
            this.DACCOUNTBOX.Controls.Add(this.TAccountNumber);
            this.DACCOUNTBOX.Location = new System.Drawing.Point(736, 52);
            this.DACCOUNTBOX.Name = "DACCOUNTBOX";
            this.DACCOUNTBOX.Size = new System.Drawing.Size(173, 84);
            this.DACCOUNTBOX.TabIndex = 30;
            this.DACCOUNTBOX.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tranfer to : (Account Number)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TAccountNumber
            // 
            this.TAccountNumber.Location = new System.Drawing.Point(30, 42);
            this.TAccountNumber.Name = "TAccountNumber";
            this.TAccountNumber.Size = new System.Drawing.Size(120, 20);
            this.TAccountNumber.TabIndex = 0;
            // 
            // Tdgvtransfer
            // 
            this.Tdgvtransfer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tdgvtransfer.Location = new System.Drawing.Point(25, 52);
            this.Tdgvtransfer.Name = "Tdgvtransfer";
            this.Tdgvtransfer.Size = new System.Drawing.Size(641, 349);
            this.Tdgvtransfer.TabIndex = 28;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.TSor);
            this.groupBox2.Controls.Add(this.TSortCode);
            this.groupBox2.Location = new System.Drawing.Point(736, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 84);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            // 
            // TSor
            // 
            this.TSor.AutoSize = true;
            this.TSor.Location = new System.Drawing.Point(59, 16);
            this.TSor.Name = "TSor";
            this.TSor.Size = new System.Drawing.Size(60, 13);
            this.TSor.TabIndex = 1;
            this.TSor.Text = "Sort Code :";
            this.TSor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TSortCode
            // 
            this.TSortCode.Location = new System.Drawing.Point(29, 39);
            this.TSortCode.Name = "TSortCode";
            this.TSortCode.Size = new System.Drawing.Size(120, 20);
            this.TSortCode.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Select an account to transfer:";
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(947, 431);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DErrorLabel);
            this.Controls.Add(this.TConfirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DACCOUNTBOX);
            this.Controls.Add(this.Tdgvtransfer);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Transfer";
            this.Text = "Transfer";
            this.Load += new System.EventHandler(this.Transfer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DACCOUNTBOX.ResumeLayout(false);
            this.DACCOUNTBOX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tdgvtransfer)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label DErrorLabel;
        private System.Windows.Forms.Button TConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TAmount;
        private System.Windows.Forms.GroupBox DACCOUNTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TAccountNumber;
        private System.Windows.Forms.DataGridView Tdgvtransfer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label TSor;
        private System.Windows.Forms.TextBox TSortCode;
        private System.Windows.Forms.Label label3;
    }
}