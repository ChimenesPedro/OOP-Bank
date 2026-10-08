namespace CA_TWO_OOP.Forms
{
    partial class Withdraw
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
            this.DErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WNewBalance = new System.Windows.Forms.TextBox();
            this.WConfirm = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WWithdraw = new System.Windows.Forms.TextBox();
            this.DACCOUNTBOX = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WAccountNumber = new System.Windows.Forms.TextBox();
            this.DBALANCEBOX = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.WBalance = new System.Windows.Forms.TextBox();
            this.Wdgwithdraw = new System.Windows.Forms.DataGridView();
            this.WOverdraftBOX = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WOverdraftLimit = new System.Windows.Forms.TextBox();
            this.WErrorLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.DACCOUNTBOX.SuspendLayout();
            this.DBALANCEBOX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wdgwithdraw)).BeginInit();
            this.WOverdraftBOX.SuspendLayout();
            this.SuspendLayout();
            // 
            // DErrorLabel
            // 
            this.DErrorLabel.AutoSize = true;
            this.DErrorLabel.Location = new System.Drawing.Point(58, 401);
            this.DErrorLabel.Name = "DErrorLabel";
            this.DErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.DErrorLabel.TabIndex = 33;
            this.DErrorLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.WNewBalance);
            this.groupBox2.Location = new System.Drawing.Point(830, 443);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 84);
            this.groupBox2.TabIndex = 31;
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
            // WNewBalance
            // 
            this.WNewBalance.Location = new System.Drawing.Point(29, 39);
            this.WNewBalance.Name = "WNewBalance";
            this.WNewBalance.Size = new System.Drawing.Size(120, 20);
            this.WNewBalance.TabIndex = 0;
            // 
            // WConfirm
            // 
            this.WConfirm.Location = new System.Drawing.Point(1074, 452);
            this.WConfirm.Name = "WConfirm";
            this.WConfirm.Size = new System.Drawing.Size(108, 42);
            this.WConfirm.TabIndex = 32;
            this.WConfirm.Text = "Confirm";
            this.WConfirm.UseVisualStyleBackColor = true;
            this.WConfirm.Click += new System.EventHandler(this.WConfirm_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.WWithdraw);
            this.groupBox1.Location = new System.Drawing.Point(614, 443);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(173, 84);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Withdraw :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WWithdraw
            // 
            this.WWithdraw.Location = new System.Drawing.Point(29, 39);
            this.WWithdraw.Name = "WWithdraw";
            this.WWithdraw.Size = new System.Drawing.Size(120, 20);
            this.WWithdraw.TabIndex = 0;
            this.WWithdraw.TextChanged += new System.EventHandler(this.WWithdraw_TextChanged);
            // 
            // DACCOUNTBOX
            // 
            this.DACCOUNTBOX.BackColor = System.Drawing.Color.PowderBlue;
            this.DACCOUNTBOX.Controls.Add(this.label1);
            this.DACCOUNTBOX.Controls.Add(this.WAccountNumber);
            this.DACCOUNTBOX.Location = new System.Drawing.Point(23, 443);
            this.DACCOUNTBOX.Name = "DACCOUNTBOX";
            this.DACCOUNTBOX.Size = new System.Drawing.Size(173, 84);
            this.DACCOUNTBOX.TabIndex = 29;
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
            // WAccountNumber
            // 
            this.WAccountNumber.Location = new System.Drawing.Point(30, 42);
            this.WAccountNumber.Name = "WAccountNumber";
            this.WAccountNumber.Size = new System.Drawing.Size(120, 20);
            this.WAccountNumber.TabIndex = 0;
            // 
            // DBALANCEBOX
            // 
            this.DBALANCEBOX.BackColor = System.Drawing.Color.PowderBlue;
            this.DBALANCEBOX.Controls.Add(this.label13);
            this.DBALANCEBOX.Controls.Add(this.WBalance);
            this.DBALANCEBOX.Location = new System.Drawing.Point(226, 443);
            this.DBALANCEBOX.Name = "DBALANCEBOX";
            this.DBALANCEBOX.Size = new System.Drawing.Size(173, 84);
            this.DBALANCEBOX.TabIndex = 28;
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
            // WBalance
            // 
            this.WBalance.Location = new System.Drawing.Point(30, 42);
            this.WBalance.Name = "WBalance";
            this.WBalance.Size = new System.Drawing.Size(120, 20);
            this.WBalance.TabIndex = 0;
            // 
            // Wdgwithdraw
            // 
            this.Wdgwithdraw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Wdgwithdraw.Location = new System.Drawing.Point(23, 34);
            this.Wdgwithdraw.Name = "Wdgwithdraw";
            this.Wdgwithdraw.Size = new System.Drawing.Size(1225, 388);
            this.Wdgwithdraw.TabIndex = 27;
            this.Wdgwithdraw.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Wdgwithdraw_CellContentClick);
            this.Wdgwithdraw.SelectionChanged += new System.EventHandler(this.Wdgwithdraw_SelectionChanged);
            // 
            // WOverdraftBOX
            // 
            this.WOverdraftBOX.BackColor = System.Drawing.Color.PowderBlue;
            this.WOverdraftBOX.Controls.Add(this.label4);
            this.WOverdraftBOX.Controls.Add(this.WOverdraftLimit);
            this.WOverdraftBOX.Location = new System.Drawing.Point(426, 443);
            this.WOverdraftBOX.Name = "WOverdraftBOX";
            this.WOverdraftBOX.Size = new System.Drawing.Size(173, 84);
            this.WOverdraftBOX.TabIndex = 29;
            this.WOverdraftBOX.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Overdraft Limit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WOverdraftLimit
            // 
            this.WOverdraftLimit.Location = new System.Drawing.Point(30, 42);
            this.WOverdraftLimit.Name = "WOverdraftLimit";
            this.WOverdraftLimit.Size = new System.Drawing.Size(120, 20);
            this.WOverdraftLimit.TabIndex = 0;
            // 
            // WErrorLabel
            // 
            this.WErrorLabel.AutoSize = true;
            this.WErrorLabel.Location = new System.Drawing.Point(1039, 513);
            this.WErrorLabel.Name = "WErrorLabel";
            this.WErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.WErrorLabel.TabIndex = 34;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1271, 560);
            this.Controls.Add(this.WErrorLabel);
            this.Controls.Add(this.WOverdraftBOX);
            this.Controls.Add(this.DErrorLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.WConfirm);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DACCOUNTBOX);
            this.Controls.Add(this.DBALANCEBOX);
            this.Controls.Add(this.Wdgwithdraw);
            this.Name = "Withdraw";
            this.Text = "Withdraw";
            this.Load += new System.EventHandler(this.Withdraw_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.DACCOUNTBOX.ResumeLayout(false);
            this.DACCOUNTBOX.PerformLayout();
            this.DBALANCEBOX.ResumeLayout(false);
            this.DBALANCEBOX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Wdgwithdraw)).EndInit();
            this.WOverdraftBOX.ResumeLayout(false);
            this.WOverdraftBOX.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DErrorLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WNewBalance;
        private System.Windows.Forms.Button WConfirm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WWithdraw;
        private System.Windows.Forms.GroupBox DACCOUNTBOX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox WAccountNumber;
        private System.Windows.Forms.GroupBox DBALANCEBOX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox WBalance;
        private System.Windows.Forms.DataGridView Wdgwithdraw;
        private System.Windows.Forms.GroupBox WOverdraftBOX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WOverdraftLimit;
        private System.Windows.Forms.Label WErrorLabel;
    }
}