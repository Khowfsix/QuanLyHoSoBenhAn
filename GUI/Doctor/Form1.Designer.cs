namespace GUI.Doctor
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(809, 410);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Controls.Add(this.panel12);
            this.panel10.Controls.Add(this.panel13);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Location = new System.Drawing.Point(630, 248);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1075, 421);
            this.panel10.TabIndex = 2;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel11.Controls.Add(this.label6);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.ForeColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(1, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1073, 49);
            this.panel11.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(346, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 38);
            this.label6.TabIndex = 4;
            this.label6.Text = "THÔNG TIN BỆNH NHÂN";
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1, 419);
            this.panel12.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel13.Location = new System.Drawing.Point(1074, 0);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1, 419);
            this.panel13.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 419);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1075, 2);
            this.panel14.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2334, 1159);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
    }
}

