namespace ManagementForm.Ui
{
    partial class AddNewDepartmentUI
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
            this.labelDepartmentName = new System.Windows.Forms.Label();
            this.textBoxDepartmentName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelHasAltelier = new System.Windows.Forms.Label();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.radioButtonYes = new System.Windows.Forms.RadioButton();
            this.radioButtonNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listViewAltelier = new System.Windows.Forms.ListView();
            this.buttonAddAltelier = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelDepartmentName
            // 
            this.labelDepartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDepartmentName.AutoSize = true;
            this.labelDepartmentName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDepartmentName.Location = new System.Drawing.Point(85, 38);
            this.labelDepartmentName.Name = "labelDepartmentName";
            this.labelDepartmentName.Size = new System.Drawing.Size(48, 19);
            this.labelDepartmentName.TabIndex = 0;
            this.labelDepartmentName.Text = "部门名";
            // 
            // textBoxDepartmentName
            // 
            this.textBoxDepartmentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDepartmentName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDepartmentName.Location = new System.Drawing.Point(44, 67);
            this.textBoxDepartmentName.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxDepartmentName.Name = "textBoxDepartmentName";
            this.textBoxDepartmentName.Size = new System.Drawing.Size(133, 24);
            this.textBoxDepartmentName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(292, 293);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 31);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "添加";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonRegistrer_Click);
            // 
            // labelHasAltelier
            // 
            this.labelHasAltelier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHasAltelier.AutoSize = true;
            this.labelHasAltelier.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHasAltelier.Location = new System.Drawing.Point(63, 124);
            this.labelHasAltelier.Name = "labelHasAltelier";
            this.labelHasAltelier.Size = new System.Drawing.Size(87, 19);
            this.labelHasAltelier.TabIndex = 5;
            this.labelHasAltelier.Text = "有无下属车间";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(385, 293);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(87, 31);
            this.buttonReturn.TabIndex = 7;
            this.buttonReturn.Text = "返回";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // radioButtonYes
            // 
            this.radioButtonYes.AutoSize = true;
            this.radioButtonYes.Location = new System.Drawing.Point(46, 156);
            this.radioButtonYes.Name = "radioButtonYes";
            this.radioButtonYes.Size = new System.Drawing.Size(42, 24);
            this.radioButtonYes.TabIndex = 8;
            this.radioButtonYes.TabStop = true;
            this.radioButtonYes.Text = "有";
            this.radioButtonYes.UseVisualStyleBackColor = true;
            this.radioButtonYes.CheckedChanged += new System.EventHandler(this.RadioButtonYes_CheckedChanged);
            // 
            // radioButtonNo
            // 
            this.radioButtonNo.AutoSize = true;
            this.radioButtonNo.Location = new System.Drawing.Point(135, 156);
            this.radioButtonNo.Name = "radioButtonNo";
            this.radioButtonNo.Size = new System.Drawing.Size(42, 24);
            this.radioButtonNo.TabIndex = 9;
            this.radioButtonNo.TabStop = true;
            this.radioButtonNo.Text = "无";
            this.radioButtonNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listViewAltelier);
            this.groupBox1.Controls.Add(this.buttonAddAltelier);
            this.groupBox1.Controls.Add(this.textBoxDepartmentName);
            this.groupBox1.Controls.Add(this.labelDepartmentName);
            this.groupBox1.Controls.Add(this.labelHasAltelier);
            this.groupBox1.Controls.Add(this.radioButtonNo);
            this.groupBox1.Controls.Add(this.radioButtonYes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 200);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "部门信息";
            // 
            // listViewAltelier
            // 
            this.listViewAltelier.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listViewAltelier.Location = new System.Drawing.Point(254, 67);
            this.listViewAltelier.Name = "listViewAltelier";
            this.listViewAltelier.Size = new System.Drawing.Size(167, 112);
            this.listViewAltelier.TabIndex = 11;
            this.listViewAltelier.UseCompatibleStateImageBehavior = false;
            this.listViewAltelier.View = System.Windows.Forms.View.List;
            this.listViewAltelier.Visible = false;
            // 
            // buttonAddAltelier
            // 
            this.buttonAddAltelier.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddAltelier.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddAltelier.Location = new System.Drawing.Point(254, 25);
            this.buttonAddAltelier.Name = "buttonAddAltelier";
            this.buttonAddAltelier.Size = new System.Drawing.Size(95, 32);
            this.buttonAddAltelier.TabIndex = 10;
            this.buttonAddAltelier.Text = "添加新车间";
            this.buttonAddAltelier.UseVisualStyleBackColor = true;
            this.buttonAddAltelier.Visible = false;
            this.buttonAddAltelier.Click += new System.EventHandler(this.ButtonAddAltelier_Click);
            // 
            // AddNewDepartmentUI
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAdd);
            this.MaximizeBox = false;
            this.Name = "AddNewDepartmentUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加部门";
            this.Load += new System.EventHandler(this.AddNewUserUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelDepartmentName;
        private System.Windows.Forms.TextBox textBoxDepartmentName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelHasAltelier;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.RadioButton radioButtonYes;
        private System.Windows.Forms.RadioButton radioButtonNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listViewAltelier;
        private System.Windows.Forms.Button buttonAddAltelier;
    }
}