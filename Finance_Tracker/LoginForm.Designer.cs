
namespace Finance_Tracker
{
    partial class LoginForm
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
            this.login__userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Login__password = new System.Windows.Forms.TextBox();
            this.Login__button = new System.Windows.Forms.Button();
            this.Register_Label = new System.Windows.Forms.Label();
            this.Exit_window = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(139, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 67;
            this.label1.Text = "Tracker V1.0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(171, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 68;
            this.label2.Text = "Name";
            // 
            // login__userName
            // 
            this.login__userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.login__userName.Location = new System.Drawing.Point(57, 164);
            this.login__userName.Name = "login__userName";
            this.login__userName.Size = new System.Drawing.Size(349, 39);
            this.login__userName.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(171, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 70;
            this.label3.Text = "Password";
            // 
            // Login__password
            // 
            this.Login__password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Login__password.Location = new System.Drawing.Point(57, 272);
            this.Login__password.Name = "Login__password";
            this.Login__password.PasswordChar = '*';
            this.Login__password.Size = new System.Drawing.Size(349, 39);
            this.Login__password.TabIndex = 71;
            this.Login__password.UseSystemPasswordChar = true;
            // 
            // Login__button
            // 
            this.Login__button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login__button.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Login__button.Location = new System.Drawing.Point(146, 353);
            this.Login__button.Name = "Login__button";
            this.Login__button.Size = new System.Drawing.Size(155, 38);
            this.Login__button.TabIndex = 72;
            this.Login__button.Text = "Login";
            this.Login__button.UseVisualStyleBackColor = true;
            this.Login__button.Click += new System.EventHandler(this.Login__button_Click);
            // 
            // Register_Label
            // 
            this.Register_Label.AutoSize = true;
            this.Register_Label.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Register_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Register_Label.Location = new System.Drawing.Point(171, 408);
            this.Register_Label.Name = "Register_Label";
            this.Register_Label.Size = new System.Drawing.Size(104, 29);
            this.Register_Label.TabIndex = 73;
            this.Register_Label.Text = "Register";
            this.Register_Label.Click += new System.EventHandler(this.Register_Label_Click);
            // 
            // Exit_window
            // 
            this.Exit_window.AutoSize = true;
            this.Exit_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Exit_window.Location = new System.Drawing.Point(394, 9);
            this.Exit_window.Name = "Exit_window";
            this.Exit_window.Size = new System.Drawing.Size(69, 37);
            this.Exit_window.TabIndex = 74;
            this.Exit_window.Text = "Exit";
            this.Exit_window.Click += new System.EventHandler(this.Exit_window_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 488);
            this.Controls.Add(this.Exit_window);
            this.Controls.Add(this.Register_Label);
            this.Controls.Add(this.Login__button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Login__password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.login__userName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox login__userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Login__password;
        private System.Windows.Forms.Button Login__button;
        private System.Windows.Forms.Label Register_Label;
        private System.Windows.Forms.Label Exit_window;
    }
}