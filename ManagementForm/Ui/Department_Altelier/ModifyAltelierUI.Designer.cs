namespace ManagementForm.Ui
{
    partial class ModifyAltelierUI
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
            this.labelAltelierName = new System.Windows.Forms.Label();
            this.textBoxAltelierName = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.groupBoxAltelier = new System.Windows.Forms.GroupBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.numericUpDownPropotion = new System.Windows.Forms.NumericUpDown();
            this.labelPropotion = new System.Windows.Forms.Label();
            this.groupBoxAltelier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPropotion)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAltelierName
            // 
            this.labelAltelierName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAltelierName.AutoSize = true;
            this.labelAltelierName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAltelierName.Location = new System.Drawing.Point(85, 38);
            this.labelAltelierName.Name = "labelAltelierName";
            this.labelAltelierName.Size = new System.Drawing.Size(48, 19);
            this.labelAltelierName.TabIndex = 0;
            this.labelAltelierName.Text = "车间名";
            // 
            // textBoxAltelierName
            // 
            this.textBoxAltelierName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAltelierName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAltelierName.Location = new System.Drawing.Point(44, 67);
            this.textBoxAltelierName.Margin = new System.Windows.Forms.Padding(10);
            this.textBoxAltelierName.Name = "textBoxAltelierName";
            this.textBoxAltelierName.Size = new System.Drawing.Size(136, 24);
            this.textBoxAltelierName.TabIndex = 1;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(258, 244);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "修改";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonReturn
            // 
            this.buttonReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(351, 243);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(79, 31);
            this.buttonReturn.TabIndex = 7;
            this.buttonReturn.Text = "返回";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.ButtonReturn_Click);
            // 
            // groupBoxAltelier
            // 
            this.groupBoxAltelier.Controls.Add(this.labelDescription);
            this.groupBoxAltelier.Controls.Add(this.textBoxDescription);
            this.groupBoxAltelier.Controls.Add(this.numericUpDownPropotion);
            this.groupBoxAltelier.Controls.Add(this.labelPropotion);
            this.groupBoxAltelier.Controls.Add(this.textBoxAltelierName);
            this.groupBoxAltelier.Controls.Add(this.labelAltelierName);
            this.groupBoxAltelier.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBoxAltelier.Location = new System.Drawing.Point(12, 27);
            this.groupBoxAltelier.Name = "groupBoxAltelier";
            this.groupBoxAltelier.Size = new System.Drawing.Size(463, 200);
            this.groupBoxAltelier.TabIndex = 13;
            this.groupBoxAltelier.TabStop = false;
            this.groupBoxAltelier.Text = "车间信息";
            // 
            // labelDescription
            // 
            this.labelDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.Location = new System.Drawing.Point(238, 38);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(35, 19);
            this.labelDescription.TabIndex = 6;
            this.labelDescription.Text = "详情";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(242, 67);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(184, 110);
            this.textBoxDescription.TabIndex = 5;
            // 
            // numericUpDownPropotion
            // 
            this.numericUpDownPropotion.DecimalPlaces = 1;
            this.numericUpDownPropotion.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownPropotion.Location = new System.Drawing.Point(47, 150);
            this.numericUpDownPropotion.Name = "numericUpDownPropotion";
            this.numericUpDownPropotion.Size = new System.Drawing.Size(130, 27);
            this.numericUpDownPropotion.TabIndex = 4;
            // 
            // labelPropotion
            // 
            this.labelPropotion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPropotion.AutoSize = true;
            this.labelPropotion.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPropotion.Location = new System.Drawing.Point(60, 114);
            this.labelPropotion.Name = "labelPropotion";
            this.labelPropotion.Size = new System.Drawing.Size(107, 19);
            this.labelPropotion.TabIndex = 2;
            this.labelPropotion.Text = "车间分配比例(%)";
            // 
            // ModifyAltelierUI
            // 
            this.AcceptButton = this.buttonAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 286);
            this.Controls.Add(this.groupBoxAltelier);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.buttonAdd);
            this.Name = "ModifyAltelierUI";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加车间";
            this.Load += new System.EventHandler(this.ModifyAltelierUI_Load);
            this.groupBoxAltelier.ResumeLayout(false);
            this.groupBoxAltelier.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPropotion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAltelierName;
        private System.Windows.Forms.TextBox textBoxAltelierName;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.GroupBox groupBoxAltelier;
        private System.Windows.Forms.Label labelPropotion;
        private System.Windows.Forms.NumericUpDown numericUpDownPropotion;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxDescription;
    }
}