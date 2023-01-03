
namespace Finance_Tracker
{
    partial class UsersForm
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
            this.CreateUserBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CreateUserPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CreateUserPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CreateUserAddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CreateUserDOB = new System.Windows.Forms.DateTimePicker();
            this.Userform__label_back = new System.Windows.Forms.Label();
            this.Exit_window = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateUserBtn
            // 
            this.CreateUserBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CreateUserBtn.Location = new System.Drawing.Point(153, 692);
            this.CreateUserBtn.Name = "CreateUserBtn";
            this.CreateUserBtn.Size = new System.Drawing.Size(155, 38);
            this.CreateUserBtn.TabIndex = 79;
            this.CreateUserBtn.Text = "Add";
            this.CreateUserBtn.UseVisualStyleBackColor = true;
            this.CreateUserBtn.Click += new System.EventHandler(this.CreateUserBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(173, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 77;
            this.label3.Text = "Password";
            // 
            // CreateUserPass
            // 
            this.CreateUserPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateUserPass.Location = new System.Drawing.Point(59, 232);
            this.CreateUserPass.Name = "CreateUserPass";
            this.CreateUserPass.Size = new System.Drawing.Size(349, 39);
            this.CreateUserPass.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(173, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 75;
            this.label2.Text = "Name";
            // 
            // CreateUserName
            // 
            this.CreateUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateUserName.Location = new System.Drawing.Point(59, 133);
            this.CreateUserName.Name = "CreateUserName";
            this.CreateUserName.Size = new System.Drawing.Size(349, 39);
            this.CreateUserName.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(146, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 37);
            this.label1.TabIndex = 74;
            this.label1.Text = "Add User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(173, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 29);
            this.label4.TabIndex = 81;
            this.label4.Text = "Phone";
            // 
            // CreateUserPhone
            // 
            this.CreateUserPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateUserPhone.Location = new System.Drawing.Point(59, 453);
            this.CreateUserPhone.Name = "CreateUserPhone";
            this.CreateUserPhone.Size = new System.Drawing.Size(349, 39);
            this.CreateUserPhone.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(173, 513);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 29);
            this.label5.TabIndex = 83;
            this.label5.Text = "Address";
            // 
            // CreateUserAddress
            // 
            this.CreateUserAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateUserAddress.Location = new System.Drawing.Point(59, 556);
            this.CreateUserAddress.Multiline = true;
            this.CreateUserAddress.Name = "CreateUserAddress";
            this.CreateUserAddress.Size = new System.Drawing.Size(349, 106);
            this.CreateUserAddress.TabIndex = 84;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(160, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 29);
            this.label6.TabIndex = 86;
            this.label6.Text = "Date of Birth";
            // 
            // CreateUserDOB
            // 
            this.CreateUserDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.CreateUserDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CreateUserDOB.Location = new System.Drawing.Point(59, 339);
            this.CreateUserDOB.Name = "CreateUserDOB";
            this.CreateUserDOB.Size = new System.Drawing.Size(349, 39);
            this.CreateUserDOB.TabIndex = 85;
            // 
            // Userform__label_back
            // 
            this.Userform__label_back.AutoSize = true;
            this.Userform__label_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Userform__label_back.Location = new System.Drawing.Point(211, 745);
            this.Userform__label_back.Name = "Userform__label_back";
            this.Userform__label_back.Size = new System.Drawing.Size(45, 20);
            this.Userform__label_back.TabIndex = 87;
            this.Userform__label_back.Text = "Back";
           
            // 
            // Exit_window
            // 
            this.Exit_window.AutoSize = true;
            this.Exit_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Exit_window.Location = new System.Drawing.Point(394, 25);
            this.Exit_window.Name = "Exit_window";
            this.Exit_window.Size = new System.Drawing.Size(69, 37);
            this.Exit_window.TabIndex = 88;
            this.Exit_window.Text = "Exit";
            this.Exit_window.Click += new System.EventHandler(this.Exit_window_Click);
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 800);
            this.Controls.Add(this.Exit_window);
            this.Controls.Add(this.Userform__label_back);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreateUserDOB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreateUserAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CreateUserPhone);
            this.Controls.Add(this.CreateUserBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CreateUserPass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CreateUserName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button CreateUserBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CreateUserPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CreateUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CreateUserPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CreateUserAddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker CreateUserDOB;
        private System.Windows.Forms.Label Userform__label_back;
        private System.Windows.Forms.Label Exit_window;
    }
}