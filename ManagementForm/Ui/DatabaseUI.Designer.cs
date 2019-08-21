namespace ManagementForm.Ui
{
    partial class DatabaseUI
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
            this.labelConnectionString = new System.Windows.Forms.Label();
            this.textBoxConnectionAdress = new System.Windows.Forms.TextBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxConnectionName = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelConnectionState = new System.Windows.Forms.Label();
            this.textBoxConnectionSecret = new System.Windows.Forms.TextBox();
            this.labelConnectionSecret = new System.Windows.Forms.Label();
            this.checkBoxWindowsAuth = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // labelConnectionString
            // 
            this.labelConnectionString.AutoSize = true;
            this.labelConnectionString.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionString.Location = new System.Drawing.Point(37, 80);
            this.labelConnectionString.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionString.Name = "labelConnectionString";
            this.labelConnectionString.Size = new System.Drawing.Size(150, 20);
            this.labelConnectionString.TabIndex = 0;
            this.labelConnectionString.Text = "服务器地址/本机地址";
            // 
            // textBoxConnectionAdress
            // 
            this.textBoxConnectionAdress.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectionAdress.Location = new System.Drawing.Point(41, 103);
            this.textBoxConnectionAdress.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.textBoxConnectionAdress.Name = "textBoxConnectionAdress";
            this.textBoxConnectionAdress.Size = new System.Drawing.Size(141, 27);
            this.textBoxConnectionAdress.TabIndex = 1;
            // 
            // buttonTest
            // 
            this.buttonTest.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTest.Location = new System.Drawing.Point(226, 163);
            this.buttonTest.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(100, 40);
            this.buttonTest.TabIndex = 2;
            this.buttonTest.Text = "测试";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "连接名字";
            // 
            // textBoxConnectionName
            // 
            this.textBoxConnectionName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectionName.Location = new System.Drawing.Point(41, 41);
            this.textBoxConnectionName.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.textBoxConnectionName.Name = "textBoxConnectionName";
            this.textBoxConnectionName.Size = new System.Drawing.Size(141, 27);
            this.textBoxConnectionName.TabIndex = 4;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(41, 237);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(157, 35);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = "保存";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(483, 237);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(157, 35);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.Text = "退出";
            this.buttonExit.UseVisualStyleBackColor = true;
            // 
            // labelConnectionState
            // 
            this.labelConnectionState.AutoSize = true;
            this.labelConnectionState.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionState.Location = new System.Drawing.Point(37, 204);
            this.labelConnectionState.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionState.Name = "labelConnectionState";
            this.labelConnectionState.Size = new System.Drawing.Size(118, 20);
            this.labelConnectionState.TabIndex = 8;
            this.labelConnectionState.Text = "数据库连接状态:";
            // 
            // textBoxConnectionSecret
            // 
            this.textBoxConnectionSecret.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxConnectionSecret.Location = new System.Drawing.Point(41, 165);
            this.textBoxConnectionSecret.Margin = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.textBoxConnectionSecret.Name = "textBoxConnectionSecret";
            this.textBoxConnectionSecret.Size = new System.Drawing.Size(141, 27);
            this.textBoxConnectionSecret.TabIndex = 10;
            // 
            // labelConnectionSecret
            // 
            this.labelConnectionSecret.AutoSize = true;
            this.labelConnectionSecret.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnectionSecret.Location = new System.Drawing.Point(37, 142);
            this.labelConnectionSecret.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelConnectionSecret.Name = "labelConnectionSecret";
            this.labelConnectionSecret.Size = new System.Drawing.Size(69, 20);
            this.labelConnectionSecret.TabIndex = 9;
            this.labelConnectionSecret.Text = "连接密钥";
            // 
            // checkBoxWindowsAuth
            // 
            this.checkBoxWindowsAuth.AutoSize = true;
            this.checkBoxWindowsAuth.Location = new System.Drawing.Point(225, 108);
            this.checkBoxWindowsAuth.Name = "checkBoxWindowsAuth";
            this.checkBoxWindowsAuth.Size = new System.Drawing.Size(145, 19);
            this.checkBoxWindowsAuth.TabIndex = 11;
            this.checkBoxWindowsAuth.Text = "windows身份登录";
            this.checkBoxWindowsAuth.UseVisualStyleBackColor = true;
            this.checkBoxWindowsAuth.CheckedChanged += new System.EventHandler(this.checkBoxWindowsAuth_CheckedChanged);
            // 
            // DatabaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 284);
            this.Controls.Add(this.checkBoxWindowsAuth);
            this.Controls.Add(this.textBoxConnectionSecret);
            this.Controls.Add(this.labelConnectionSecret);
            this.Controls.Add(this.labelConnectionState);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxConnectionName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.textBoxConnectionAdress);
            this.Controls.Add(this.labelConnectionString);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "DatabaseUI";
            this.Text = "数据库管理";
            this.Load += new System.EventHandler(this.DatabaseUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelConnectionString;
        private System.Windows.Forms.TextBox textBoxConnectionAdress;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxConnectionName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelConnectionState;
        private System.Windows.Forms.TextBox textBoxConnectionSecret;
        private System.Windows.Forms.Label labelConnectionSecret;
        private System.Windows.Forms.CheckBox checkBoxWindowsAuth;
    }
}