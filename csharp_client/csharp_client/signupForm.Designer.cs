namespace csharp_client
{
    partial class signupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupForm));
            this.password_tb = new System.Windows.Forms.TextBox();
            this.email_tb = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.email_label = new System.Windows.Forms.Label();
            this.username_label = new System.Windows.Forms.Label();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(92, 82);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(211, 20);
            this.password_tb.TabIndex = 7;
            this.password_tb.UseSystemPasswordChar = true;
            // 
            // email_tb
            // 
            this.email_tb.Location = new System.Drawing.Point(92, 56);
            this.email_tb.Name = "email_tb";
            this.email_tb.Size = new System.Drawing.Size(211, 20);
            this.email_tb.TabIndex = 6;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(30, 85);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(56, 13);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Password:";
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(48, 59);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(38, 13);
            this.email_label.TabIndex = 4;
            this.email_label.Text = "E-mail:";
            this.email_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(28, 33);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(58, 13);
            this.username_label.TabIndex = 8;
            this.username_label.Text = "Username:";
            this.username_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(92, 30);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(211, 20);
            this.username_tb.TabIndex = 9;
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(121, 136);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(90, 44);
            this.register_btn.TabIndex = 10;
            this.register_btn.Text = "Sign Up";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // signupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 211);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.username_tb);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.password_tb);
            this.Controls.Add(this.email_tb);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.email_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "signupForm";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox email_tb;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Button register_btn;
    }
}