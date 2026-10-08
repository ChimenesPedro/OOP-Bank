namespace CA_TWO_OOP.Forms
{
    partial class SignUp
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.wronglabel = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordtxbreg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.usernametxbreg = new System.Windows.Forms.TextBox();
            this.registerbtn = new System.Windows.Forms.Button();
            this.userregistered = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.userregistered);
            this.groupBox1.Controls.Add(this.wronglabel);
            this.groupBox1.Controls.Add(this.backbtn);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.registerbtn);
            this.groupBox1.Location = new System.Drawing.Point(252, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 364);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // wronglabel
            // 
            this.wronglabel.AutoSize = true;
            this.wronglabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.wronglabel.Location = new System.Drawing.Point(132, 341);
            this.wronglabel.Name = "wronglabel";
            this.wronglabel.Size = new System.Drawing.Size(0, 13);
            this.wronglabel.TabIndex = 5;
            // 
            // backbtn
            // 
            this.backbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.backbtn.Location = new System.Drawing.Point(34, 297);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(233, 41);
            this.backbtn.TabIndex = 4;
            this.backbtn.Text = "Back to Login";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.AutoSize = true;
            this.groupBox3.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.passwordtxbreg);
            this.groupBox3.Location = new System.Drawing.Point(34, 136);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 98);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(15, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // passwordtxbreg
            // 
            this.passwordtxbreg.Location = new System.Drawing.Point(6, 59);
            this.passwordtxbreg.Name = "passwordtxbreg";
            this.passwordtxbreg.PasswordChar = '*';
            this.passwordtxbreg.Size = new System.Drawing.Size(215, 20);
            this.passwordtxbreg.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.usernametxbreg);
            this.groupBox2.Location = new System.Drawing.Point(34, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(15, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username :";
            // 
            // usernametxbreg
            // 
            this.usernametxbreg.Location = new System.Drawing.Point(6, 60);
            this.usernametxbreg.Name = "usernametxbreg";
            this.usernametxbreg.Size = new System.Drawing.Size(215, 20);
            this.usernametxbreg.TabIndex = 0;
            this.usernametxbreg.TextChanged += new System.EventHandler(this.usernametxbreg_TextChanged);
            // 
            // registerbtn
            // 
            this.registerbtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.registerbtn.Location = new System.Drawing.Point(34, 250);
            this.registerbtn.Name = "registerbtn";
            this.registerbtn.Size = new System.Drawing.Size(233, 41);
            this.registerbtn.TabIndex = 0;
            this.registerbtn.Text = "Register";
            this.registerbtn.UseVisualStyleBackColor = true;
            this.registerbtn.Click += new System.EventHandler(this.registerbtn_Click);
            // 
            // userregistered
            // 
            this.userregistered.AutoSize = true;
            this.userregistered.Location = new System.Drawing.Point(135, 341);
            this.userregistered.Name = "userregistered";
            this.userregistered.Size = new System.Drawing.Size(0, 13);
            this.userregistered.TabIndex = 6;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label wronglabel;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordtxbreg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernametxbreg;
        private System.Windows.Forms.Button registerbtn;
        private System.Windows.Forms.Label userregistered;
    }
}