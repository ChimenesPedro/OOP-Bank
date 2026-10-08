namespace CA_TWO_OOP.Forms
{
    partial class Deposit
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
            this.Ddgvdeposit = new System.Windows.Forms.DataGridView();
            this.DBALANCEBOX = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.DBalance = new System.Windows.Forms.TextBox();
            this.DACCOUNTBOX = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DAccountNumber = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DDeposit = new System.Windows.Forms.TextBox();
            this.DConfirm = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DNewBalance = new System.Windows.Forms.TextBox();
            this.DErrorLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ddgvdeposit)).BeginInit();
            this.DBALANCEBOX.SuspendLayout();
            this.DACCOUNTBOX.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ddgvdeposit
            // 
            this.Ddgvdeposit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Ddgvdeposit.Location = new System.Drawing.Point(26, 79);
            this.Ddgvdeposit.Name = "Ddgvdeposit";
            this.Ddgvdeposit.Size = new System.Drawing.Size(1225, 388);
            this.Ddgvdeposit.TabIndex = 0;
            this.Ddgvdeposit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Ddgvdeposit_CellContentClick);
            this.Ddgvdeposit.SelectionChanged += new System.EventHandler(this.Ddgvdeposit_SelectionChanged);
            // 
            // DBALANCEBOX
            // 
            this.DBALANCEBOX.BackColor = System.Drawing.Color.PowderBlue;
            this.DBALANCEBOX.Controls.Add(this.label13);
            this.DBALANCEBOX.Controls.Add(this.DBalance);
            this.DBALANCEBOX.Location = new System.Drawing.Point(413, 488);
            this.DBALANCEBOX.Name = "DBALANCEBOX";
            this.DBALANCEBOX.Size = new System.Drawing.Size(173, 84);
            this.DBALANCEBOX.TabIndex = 22;
            this.DBALANCEBOX.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(62, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Balance";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DBalance
            // 
            this.DBalance.Location = new System.Drawing.Point(30, 42);
            this.DBalance.Name = "DBalance";
            this.DBalance.Size = new System.Drawing.Size(120, 20);
            this.DBalance.TabIndex = 0;
            this.DBalance.Enter += new System.EventHandler(this.EInitialBalance_Enter);
            // 
            // DACCOUNTBOX
            // 
            this.DACCOUNTBOX.BackColor = System.Drawing.Color.PowderBlue;
            this.DACCOUNTBOX.Controls.Add(this.label1);
            this.DACCOUNTBOX.Controls.Add(this.DAccountNumber);
            this.DACCOUNTBOX.Location = new System.Drawing.Point(197, 488);
            this.DACCOUNTBOX.Name = "DACCOUNTBOX";
            this.DACCOUNTBOX.Size = new System.Drawing.Size(173, 84);
            this.DACCOUNTBOX.TabIndex = 23;
            this.DACCOUNTBOX.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Account Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DAccountNumber
            // 
            this.DAccountNumber.Location = new System.Drawing.Point(30, 42);
            this.DAccountNumber.Name = "DAccountNumber";
            this.DAccountNumber.Size = new System.Drawing.Size(120, 20);
            this.DAccountNumber.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.DDeposit);
            this.groupBox1.Location = new System.Drawing.Point(617, 488);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 84);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Deposit";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DDeposit
            // 
            this.DDeposit.Location = new System.Drawing.Point(29, 39);
            this.DDeposit.Name = "DDeposit";
            this.DDeposit.Size = new System.Drawing.Size(120, 20);
            this.DDeposit.TabIndex = 0;
            this.DDeposit.TextChanged += new System.EventHandler(this.DDeposit_TextChanged);
            // 
            // DConfirm
            // 
            this.DConfirm.Location = new System.Drawing.Point(1063, 515);
            this.DConfirm.Name = "DConfirm";
            this.DConfirm.Size = new System.Drawing.Size(108, 42);
            this.DConfirm.TabIndex = 25;
            this.DConfirm.Text = "Confirm";
            this.DConfirm.UseVisualStyleBackColor = true;
            this.DConfirm.Click += new System.EventHandler(this.DConfirm_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.DNewBalance);
            this.groupBox2.Location = new System.Drawing.Point(833, 488);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 84);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "New balance:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DNewBalance
            // 
            this.DNewBalance.Location = new System.Drawing.Point(29, 39);
            this.DNewBalance.Name = "DNewBalance";
            this.DNewBalance.Size = new System.Drawing.Size(120, 20);
            this.DNewBalance.TabIndex = 0;
            // 
            // DErrorLabel
            // 
            this.DErrorLabel.AutoSize = true;
            this.DErrorLabel.Location = new System.Drawing.Point(61, 446);
            this.DErrorLabel.Name = "DErrorLabel";
            this.DErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.DErrorLabel.TabIndex = 26;
            this.DErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(614, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "DEPOSIT";
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1263, 603);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DErrorLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DConfirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DACCOUNTBOX);
            this.Controls.Add(this.DBALANCEBOX);
            this.Controls.Add(this.Ddgvdeposit);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ddgvdeposit)).EndInit();
            this.DBALANCEBOX.ResumeLayout(false);
            this.DBALANCEBOX.PerformLayout();
            this.DACCOUNTBOX.ResumeLayout(false);
            this.DACCOUNTBOX.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Ddgvdeposit;
        private System.Windows.Forms.GroupBox DBALANCEBOX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox DBalance;
        private System.Windows.Forms.GroupBox DACCOUNTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DAccountNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DDeposit;
        private System.Windows.Forms.Button DConfirm;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DNewBalance;
        private System.Windows.Forms.Label DErrorLabel;
        private System.Windows.Forms.Label label4;
    }
}