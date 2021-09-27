namespace _17621834_Daniela_3b
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_log_pass = new System.Windows.Forms.TextBox();
            this.tb_log_user = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(247, 76);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pass.Location = new System.Drawing.Point(11, 187);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(84, 17);
            this.pass.TabIndex = 9;
            this.pass.Text = "Password";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(9, 146);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(90, 17);
            this.lb_username.TabIndex = 8;
            this.lb_username.Text = "Username";
            // 
            // tb_log_pass
            // 
            this.tb_log_pass.Location = new System.Drawing.Point(101, 186);
            this.tb_log_pass.Name = "tb_log_pass";
            this.tb_log_pass.PasswordChar = '*';
            this.tb_log_pass.Size = new System.Drawing.Size(136, 20);
            this.tb_log_pass.TabIndex = 7;
            // 
            // tb_log_user
            // 
            this.tb_log_user.Location = new System.Drawing.Point(101, 146);
            this.tb_log_user.Name = "tb_log_user";
            this.tb_log_user.Size = new System.Drawing.Size(136, 20);
            this.tb_log_user.TabIndex = 6;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(31, 250);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(190, 40);
            this.btn_login.TabIndex = 10;
            this.btn_login.Text = "login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 353);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.lb_username);
            this.Controls.Add(this.tb_log_pass);
            this.Controls.Add(this.tb_log_user);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pass;
        private System.Windows.Forms.Label lb_username;
        private System.Windows.Forms.TextBox tb_log_pass;
        private System.Windows.Forms.TextBox tb_log_user;
        private System.Windows.Forms.Button btn_login;
    }
}