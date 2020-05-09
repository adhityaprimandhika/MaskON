namespace MaskON
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Login_Register = new System.Windows.Forms.Button();
            this.lb_Username = new System.Windows.Forms.Label();
            this.tb_Login_Username = new System.Windows.Forms.TextBox();
            this.lb_Password = new System.Windows.Forms.Label();
            this.tb_Login_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "MaskON";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(118, 146);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 33);
            this.btn_Login.TabIndex = 1;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Login_Register
            // 
            this.btn_Login_Register.Location = new System.Drawing.Point(98, 194);
            this.btn_Login_Register.Name = "btn_Login_Register";
            this.btn_Login_Register.Size = new System.Drawing.Size(115, 23);
            this.btn_Login_Register.TabIndex = 2;
            this.btn_Login_Register.Text = "Create new account";
            this.btn_Login_Register.UseVisualStyleBackColor = true;
            this.btn_Login_Register.Click += new System.EventHandler(this.btn_Login_Register_Click);
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Location = new System.Drawing.Point(59, 68);
            this.lb_Username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(55, 13);
            this.lb_Username.TabIndex = 5;
            this.lb_Username.Text = "Username";
            // 
            // tb_Login_Username
            // 
            this.tb_Login_Username.Location = new System.Drawing.Point(153, 66);
            this.tb_Login_Username.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Login_Username.Name = "tb_Login_Username";
            this.tb_Login_Username.Size = new System.Drawing.Size(102, 20);
            this.tb_Login_Username.TabIndex = 6;
            // 
            // lb_Password
            // 
            this.lb_Password.AutoSize = true;
            this.lb_Password.Location = new System.Drawing.Point(59, 102);
            this.lb_Password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Password.Name = "lb_Password";
            this.lb_Password.Size = new System.Drawing.Size(53, 13);
            this.lb_Password.TabIndex = 7;
            this.lb_Password.Text = "Password";
            // 
            // tb_Login_Password
            // 
            this.tb_Login_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tb_Login_Password.Location = new System.Drawing.Point(153, 99);
            this.tb_Login_Password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Login_Password.Name = "tb_Login_Password";
            this.tb_Login_Password.Size = new System.Drawing.Size(102, 21);
            this.tb_Login_Password.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 238);
            this.Controls.Add(this.tb_Login_Password);
            this.Controls.Add(this.lb_Password);
            this.Controls.Add(this.tb_Login_Username);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.btn_Login_Register);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Login_Register;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.TextBox tb_Login_Username;
        private System.Windows.Forms.Label lb_Password;
        private System.Windows.Forms.TextBox tb_Login_Password;
    }
}