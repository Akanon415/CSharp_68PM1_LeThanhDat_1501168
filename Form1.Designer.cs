namespace Quản_Lý_Sinh_Viên
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hệ Thống Quản Lý Sinh Viên";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Đăng Nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(143, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu:";
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(306, 147);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(198, 22);
            this.textUser.TabIndex = 3;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(306, 199);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(198, 22);
            this.textPass.TabIndex = 4;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(348, 264);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(115, 23);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "ĐĂNG NHẬP";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button buttonLogin;
    }
}

