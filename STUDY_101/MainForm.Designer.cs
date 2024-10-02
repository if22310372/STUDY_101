namespace STUDY_101
{
    partial class MainForm
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
            this.textBoxusername = new System.Windows.Forms.TextBox();
            this.textBoxpassword = new System.Windows.Forms.TextBox();
            this.buttonlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // textBoxusername
            // 
            this.textBoxusername.Location = new System.Drawing.Point(202, 192);
            this.textBoxusername.Name = "textBoxusername";
            this.textBoxusername.Size = new System.Drawing.Size(100, 26);
            this.textBoxusername.TabIndex = 2;
            // 
            // textBoxpassword
            // 
            this.textBoxpassword.Location = new System.Drawing.Point(202, 293);
            this.textBoxpassword.Name = "textBoxpassword";
            this.textBoxpassword.Size = new System.Drawing.Size(100, 26);
            this.textBoxpassword.TabIndex = 3;
            // 
            // buttonlogin
            // 
            this.buttonlogin.Location = new System.Drawing.Point(413, 241);
            this.buttonlogin.Name = "buttonlogin";
            this.buttonlogin.Size = new System.Drawing.Size(121, 51);
            this.buttonlogin.TabIndex = 4;
            this.buttonlogin.Text = "login";
            this.buttonlogin.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonlogin);
            this.Controls.Add(this.textBoxpassword);
            this.Controls.Add(this.textBoxusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxusername;
        private System.Windows.Forms.TextBox textBoxpassword;
        private System.Windows.Forms.Button buttonlogin;
    }
}