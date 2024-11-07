namespace Simple_Text_Editor
{
    partial class Findandreplace
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
            this.txtfind = new System.Windows.Forms.TextBox();
            this.txtreplace = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnreplace = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Replace";
            // 
            // txtfind
            // 
            this.txtfind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfind.Location = new System.Drawing.Point(220, 63);
            this.txtfind.Multiline = true;
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(355, 46);
            this.txtfind.TabIndex = 1;
            // 
            // txtreplace
            // 
            this.txtreplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreplace.Location = new System.Drawing.Point(220, 165);
            this.txtreplace.Multiline = true;
            this.txtreplace.Name = "txtreplace";
            this.txtreplace.Size = new System.Drawing.Size(355, 46);
            this.txtreplace.TabIndex = 1;
            // 
            // btnfind
            // 
            this.btnfind.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnfind.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfind.Location = new System.Drawing.Point(86, 292);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(231, 55);
            this.btnfind.TabIndex = 2;
            this.btnfind.Text = "Find";
            this.btnfind.UseVisualStyleBackColor = false;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnreplace
            // 
            this.btnreplace.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnreplace.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreplace.Location = new System.Drawing.Point(374, 292);
            this.btnreplace.Name = "btnreplace";
            this.btnreplace.Size = new System.Drawing.Size(231, 55);
            this.btnreplace.TabIndex = 2;
            this.btnreplace.Text = "Replace";
            this.btnreplace.UseVisualStyleBackColor = false;
            this.btnreplace.Click += new System.EventHandler(this.btnreplace_Click);
            // 
            // Findandreplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(702, 419);
            this.Controls.Add(this.btnreplace);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtreplace);
            this.Controls.Add(this.txtfind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Findandreplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Findandreplace";
            this.Load += new System.EventHandler(this.frmfindandreplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.TextBox txtreplace;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnreplace;
    }
}