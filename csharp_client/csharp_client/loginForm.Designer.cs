namespace csharp_client
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.email_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(43, 38);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(38, 13);
            this.email_label.TabIndex = 0;
            this.email_label.Text = "E-mail:";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(25, 64);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 13);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password:";
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(87, 35);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(211, 20);
            this.email_tb.TabIndex = 2;
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(87, 61);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(211, 20);
            this.password_tb.TabIndex = 3;
            this.password_tb.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(120, 125);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(90, 44);
            this.login_btn.TabIndex = 4;
            this.login_btn.Text = "Sign in";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button login_btn;
    }
}