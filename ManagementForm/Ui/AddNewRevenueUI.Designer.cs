namespace ManagementForm.Ui
{
    partial class AddNewRevenueUI
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
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxRevenueNumber = new System.Windows.Forms.TextBox();
            this.buttonRegistrer = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelAuthority = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.comboBoxYear = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(289, 70);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(27, 23);
            this.labelUsername.TabIndex = 0;
            this.labelUsername.Text = "年";
            // 
            // textBoxRevenueNumber
            // 
            this.textBoxRevenueNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxRevenueNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRevenueNumber.Location = new System.Drawing.Point(221, 248);
            this.textBoxRevenueNumber.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.textBoxRevenueNumber.Name = "textBoxRevenueNumber";
            this.textBoxRevenueNumber.Size = new System.Drawing.Size(189, 28);
            this.textBoxRevenueNumber.TabIndex = 1;
            // 
            // buttonRegistrer
            // 
            this.buttonRegistrer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegistrer.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegistrer.Location = new System.Drawing.Point(389, 338);
            this.buttonRegistrer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRegistrer.Name = "buttonRegistrer";
            this.buttonRegistrer.Size = new System.Drawing.Size(116, 36);
            this.buttonRegistrer.TabIndex = 3;
            this.buttonRegistrer.Text = "注册";
            this.buttonRegistrer.UseVisualStyleBackColor = true;
            this.buttonRegistrer.Click += new System.EventHandler(this.buttonRegistrer_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(289, 150);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(27, 23);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "月";
            // 
            // labelAuthority
            // 
            this.labelAuthority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAuthority.AutoSize = true;
            this.labelAuthority.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAuthority.Location = new System.Drawing.Point(270, 223);
            this.labelAuthority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthority.Name = "labelAuthority";
            this.labelAuthority.Size = new System.Drawing.Size(78, 23);
            this.labelAuthority.TabIndex = 5;
            this.labelAuthority.Text = "当月产值";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.IntegralHeight = false;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "管理员",
            "财务",
            "文员"});
            this.comboBoxMonth.Location = new System.Drawing.Point(221, 176);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(189, 29);
            this.comboBoxMonth.TabIndex = 6;
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(513, 338);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(116, 36);
            this.buttonReturn.TabIndex = 7;
            this.buttonReturn.Text = "返回";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // comboBoxYear
            // 
            this.comboBoxYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxYear.FormattingEnabled = true;
            this.comboBoxYear.IntegralHeight = false;
            this.comboBoxYear.Items.AddRange(new object[] {
            "管理员",
            "财务",
            "文员"});
            this.comboBoxYear.Location = new System.Drawing.Point(221, 96);
            this.comboBoxYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxYear.Name = "comboBoxYear";
            this.comboBoxYear.Size = new System.Drawing.Size(189, 29);
            this.comboBoxYear.TabIndex = 8;
            // 
            // AddNewRevenueUI
            // 
            this.AcceptButton = this.buttonRegistrer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 388);
            this.Controls.Add(this.comboBoxYear);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.comboBoxMonth);
            this.Controls.Add(this.labelAuthority);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.buttonRegistrer);
            this.Controls.Add(this.textBoxRevenueNumber);
            this.Controls.Add(this.labelUsername);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddNewRevenueUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "r";
            this.Load += new System.EventHandler(this.AddNewRevenueUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxRevenueNumber;
        private System.Windows.Forms.Button buttonRegistrer;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelAuthority;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.ComboBox comboBoxYear;
    }
}