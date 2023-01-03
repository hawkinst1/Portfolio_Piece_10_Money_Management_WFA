
namespace Finance_Tracker
{
    partial class ViewExpensesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ExpensesDGV = new System.Windows.Forms.DataGridView();
            this.logoutlabel = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.ExpensesBreakdownLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.incomeBreakdown = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.expenseLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.incomeLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dashboardLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.moneyIconPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ViewExp__cat_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.viewExp__itemName_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_window = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpensesDGV
            // 
            this.ExpensesDGV.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.ExpensesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(34)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExpensesDGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.ExpensesDGV.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ExpensesDGV.Location = new System.Drawing.Point(351, 210);
            this.ExpensesDGV.Name = "ExpensesDGV";
            this.ExpensesDGV.RowHeadersWidth = 62;
            this.ExpensesDGV.RowTemplate.Height = 28;
            this.ExpensesDGV.Size = new System.Drawing.Size(1169, 680);
            this.ExpensesDGV.TabIndex = 70;
            // 
            // logoutlabel
            // 
            this.logoutlabel.AutoSize = true;
            this.logoutlabel.Location = new System.Drawing.Point(111, 846);
            this.logoutlabel.Name = "logoutlabel";
            this.logoutlabel.Size = new System.Drawing.Size(59, 20);
            this.logoutlabel.TabIndex = 13;
            this.logoutlabel.Text = "Logout";
            this.logoutlabel.Click += new System.EventHandler(this.logoutlabel_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(18, 814);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(87, 79);
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // ExpensesBreakdownLabel
            // 
            this.ExpensesBreakdownLabel.AutoSize = true;
            this.ExpensesBreakdownLabel.Location = new System.Drawing.Point(111, 644);
            this.ExpensesBreakdownLabel.Name = "ExpensesBreakdownLabel";
            this.ExpensesBreakdownLabel.Size = new System.Drawing.Size(163, 20);
            this.ExpensesBreakdownLabel.TabIndex = 11;
            this.ExpensesBreakdownLabel.Text = "Expenses Breakdown\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.logoutlabel);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.ExpensesBreakdownLabel);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.incomeBreakdown);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.expenseLabel);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.incomeLabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.dashboardLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.TitleLabel);
            this.panel1.Controls.Add(this.moneyIconPictureBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 924);
            this.panel1.TabIndex = 65;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(18, 612);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(87, 79);
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // incomeBreakdown
            // 
            this.incomeBreakdown.AutoSize = true;
            this.incomeBreakdown.Location = new System.Drawing.Point(111, 548);
            this.incomeBreakdown.Name = "incomeBreakdown";
            this.incomeBreakdown.Size = new System.Drawing.Size(146, 20);
            this.incomeBreakdown.TabIndex = 9;
            this.incomeBreakdown.Text = "Income Breakdown";
            this.incomeBreakdown.Click += new System.EventHandler(this.incomeBreakdown_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(18, 516);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(87, 79);
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // expenseLabel
            // 
            this.expenseLabel.AutoSize = true;
            this.expenseLabel.Location = new System.Drawing.Point(111, 449);
            this.expenseLabel.Name = "expenseLabel";
            this.expenseLabel.Size = new System.Drawing.Size(79, 20);
            this.expenseLabel.TabIndex = 7;
            this.expenseLabel.Text = "Expenses";
            this.expenseLabel.Click += new System.EventHandler(this.expenseLabel_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(18, 417);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(87, 79);
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // incomeLabel
            // 
            this.incomeLabel.AutoSize = true;
            this.incomeLabel.Location = new System.Drawing.Point(118, 241);
            this.incomeLabel.Name = "incomeLabel";
            this.incomeLabel.Size = new System.Drawing.Size(62, 20);
            this.incomeLabel.TabIndex = 5;
            this.incomeLabel.Text = "Income";
            this.incomeLabel.Click += new System.EventHandler(this.incomeLabel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(18, 320);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(87, 79);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // dashboardLabel
            // 
            this.dashboardLabel.AutoSize = true;
            this.dashboardLabel.Location = new System.Drawing.Point(118, 354);
            this.dashboardLabel.Name = "dashboardLabel";
            this.dashboardLabel.Size = new System.Drawing.Size(88, 20);
            this.dashboardLabel.TabIndex = 3;
            this.dashboardLabel.Text = "Dashboard";
            this.dashboardLabel.Click += new System.EventHandler(this.dashboardLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 211);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 79);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(111, 62);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(95, 20);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Tracker v1.0";
            // 
            // moneyIconPictureBox
            // 
            this.moneyIconPictureBox.Location = new System.Drawing.Point(18, 30);
            this.moneyIconPictureBox.Name = "moneyIconPictureBox";
            this.moneyIconPictureBox.Size = new System.Drawing.Size(87, 79);
            this.moneyIconPictureBox.TabIndex = 0;
            this.moneyIconPictureBox.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(1049, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 29);
            this.label3.TabIndex = 68;
            this.label3.Text = "Categories";
            // 
            // ViewExp__cat_tb
            // 
            this.ViewExp__cat_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ViewExp__cat_tb.Location = new System.Drawing.Point(935, 147);
            this.ViewExp__cat_tb.Name = "ViewExp__cat_tb";
            this.ViewExp__cat_tb.Size = new System.Drawing.Size(349, 39);
            this.ViewExp__cat_tb.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(648, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Item Name";
            // 
            // viewExp__itemName_tb
            // 
            this.viewExp__itemName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.viewExp__itemName_tb.Location = new System.Drawing.Point(534, 147);
            this.viewExp__itemName_tb.Name = "viewExp__itemName_tb";
            this.viewExp__itemName_tb.Size = new System.Drawing.Size(349, 39);
            this.viewExp__itemName_tb.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(494, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 37);
            this.label1.TabIndex = 66;
            this.label1.Text = "Expenses Breakdown";
            // 
            // Exit_window
            // 
            this.Exit_window.AutoSize = true;
            this.Exit_window.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Exit_window.Location = new System.Drawing.Point(1468, 9);
            this.Exit_window.Name = "Exit_window";
            this.Exit_window.Size = new System.Drawing.Size(69, 37);
            this.Exit_window.TabIndex = 75;
            this.Exit_window.Text = "Exit";
            this.Exit_window.Click += new System.EventHandler(this.Exit_window_Click);
            // 
            // ViewExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 924);
            this.Controls.Add(this.Exit_window);
            this.Controls.Add(this.ExpensesDGV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ViewExp__cat_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viewExp__itemName_tb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewExpensesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewExpensesForm";
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moneyIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label logoutlabel;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label ExpensesBreakdownLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label incomeBreakdown;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label expenseLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label incomeLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label dashboardLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox moneyIconPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ViewExp__cat_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox viewExp__itemName_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Exit_window;
        private System.Windows.Forms.DataGridView ExpensesDGV;
    }
}