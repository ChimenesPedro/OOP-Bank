namespace CA_TWO_OOP.Forms
{
    partial class Transactions
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
            this.Trandgvselect = new System.Windows.Forms.DataGridView();
            this.Trandgvshow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Trandgvselect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trandgvshow)).BeginInit();
            this.SuspendLayout();
            // 
            // Trandgvselect
            // 
            this.Trandgvselect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Trandgvselect.Location = new System.Drawing.Point(16, 15);
            this.Trandgvselect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trandgvselect.Name = "Trandgvselect";
            this.Trandgvselect.RowHeadersWidth = 51;
            this.Trandgvselect.Size = new System.Drawing.Size(321, 524);
            this.Trandgvselect.TabIndex = 28;
            this.Trandgvselect.SelectionChanged += new System.EventHandler(this.Trandgvselect_SelectionChanged);
            // 
            // Trandgvshow
            // 
            this.Trandgvshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Trandgvshow.Location = new System.Drawing.Point(376, 76);
            this.Trandgvshow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Trandgvshow.Name = "Trandgvshow";
            this.Trandgvshow.RowHeadersWidth = 51;
            this.Trandgvshow.Size = new System.Drawing.Size(1263, 342);
            this.Trandgvshow.TabIndex = 29;
            this.Trandgvshow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Trandgvshow_CellContentClick);
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1655, 554);
            this.Controls.Add(this.Trandgvshow);
            this.Controls.Add(this.Trandgvselect);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Trandgvselect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Trandgvshow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Trandgvselect;
        private System.Windows.Forms.DataGridView Trandgvshow;
    }
}