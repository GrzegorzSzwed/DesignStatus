namespace Managment_Tool.Forms
{
    partial class CntrlTask
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CntrlTask));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCntrlTaskAdd = new System.Windows.Forms.Button();
            this.txtCntrlTaskTopic = new System.Windows.Forms.TextBox();
            this.btnDirectoryTaskSearcher = new System.Windows.Forms.Button();
            this.txtCntrlTaskPath = new System.Windows.Forms.TextBox();
            this.cbCntrlTaskIfDesign = new System.Windows.Forms.CheckBox();
            this.cmbCntrlTaskStatus = new System.Windows.Forms.ComboBox();
            this.cmbCntrlTaskEmployee = new System.Windows.Forms.ComboBox();
            this.rtxtCntrlTaskComment = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnCntrlTaskAdd);
            this.panel1.Controls.Add(this.txtCntrlTaskTopic);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 58);
            this.panel1.TabIndex = 0;
            // 
            // btnCntrlTaskAdd
            // 
            this.btnCntrlTaskAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCntrlTaskAdd.BackgroundImage")));
            this.btnCntrlTaskAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCntrlTaskAdd.FlatAppearance.BorderSize = 0;
            this.btnCntrlTaskAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCntrlTaskAdd.Location = new System.Drawing.Point(408, 3);
            this.btnCntrlTaskAdd.Name = "btnCntrlTaskAdd";
            this.btnCntrlTaskAdd.Size = new System.Drawing.Size(35, 36);
            this.btnCntrlTaskAdd.TabIndex = 8;
            this.btnCntrlTaskAdd.UseVisualStyleBackColor = true;
            this.btnCntrlTaskAdd.Click += new System.EventHandler(this.btnCntrlTaskAdd_Click);
            // 
            // txtCntrlTaskTopic
            // 
            this.txtCntrlTaskTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCntrlTaskTopic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCntrlTaskTopic.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCntrlTaskTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCntrlTaskTopic.Location = new System.Drawing.Point(54, 20);
            this.txtCntrlTaskTopic.Name = "txtCntrlTaskTopic";
            this.txtCntrlTaskTopic.Size = new System.Drawing.Size(328, 19);
            this.txtCntrlTaskTopic.TabIndex = 0;
            this.txtCntrlTaskTopic.Text = "Temat";
            this.txtCntrlTaskTopic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCntrlTaskTopic.TextChanged += new System.EventHandler(this.txtCntrlTaskTopic_TextChanged);
            // 
            // btnDirectoryTaskSearcher
            // 
            this.btnDirectoryTaskSearcher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDirectoryTaskSearcher.BackgroundImage")));
            this.btnDirectoryTaskSearcher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDirectoryTaskSearcher.FlatAppearance.BorderSize = 0;
            this.btnDirectoryTaskSearcher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDirectoryTaskSearcher.Location = new System.Drawing.Point(419, 266);
            this.btnDirectoryTaskSearcher.Name = "btnDirectoryTaskSearcher";
            this.btnDirectoryTaskSearcher.Size = new System.Drawing.Size(24, 19);
            this.btnDirectoryTaskSearcher.TabIndex = 6;
            this.btnDirectoryTaskSearcher.UseVisualStyleBackColor = true;
            this.btnDirectoryTaskSearcher.Click += new System.EventHandler(this.btnDirectoryTaskSearcher_Click);
            // 
            // txtCntrlTaskPath
            // 
            this.txtCntrlTaskPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCntrlTaskPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.txtCntrlTaskPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCntrlTaskPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCntrlTaskPath.Location = new System.Drawing.Point(6, 266);
            this.txtCntrlTaskPath.Name = "txtCntrlTaskPath";
            this.txtCntrlTaskPath.Size = new System.Drawing.Size(410, 19);
            this.txtCntrlTaskPath.TabIndex = 1;
            this.txtCntrlTaskPath.Text = "Path";
            this.txtCntrlTaskPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCntrlTaskPath.TextChanged += new System.EventHandler(this.txtCntrlTaskPath_TextChanged);
            // 
            // cbCntrlTaskIfDesign
            // 
            this.cbCntrlTaskIfDesign.AutoSize = true;
            this.cbCntrlTaskIfDesign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCntrlTaskIfDesign.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCntrlTaskIfDesign.Location = new System.Drawing.Point(9, 236);
            this.cbCntrlTaskIfDesign.Name = "cbCntrlTaskIfDesign";
            this.cbCntrlTaskIfDesign.Size = new System.Drawing.Size(67, 20);
            this.cbCntrlTaskIfDesign.TabIndex = 8;
            this.cbCntrlTaskIfDesign.Text = "Design";
            this.cbCntrlTaskIfDesign.UseVisualStyleBackColor = true;
            this.cbCntrlTaskIfDesign.CheckedChanged += new System.EventHandler(this.cbCntrlTaskIfDesign_CheckedChanged);
            // 
            // cmbCntrlTaskStatus
            // 
            this.cmbCntrlTaskStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbCntrlTaskStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCntrlTaskStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCntrlTaskStatus.FormattingEnabled = true;
            this.cmbCntrlTaskStatus.Items.AddRange(new object[] {
            "TO DO",
            "IN WORK",
            "DONE"});
            this.cmbCntrlTaskStatus.Location = new System.Drawing.Point(82, 236);
            this.cmbCntrlTaskStatus.Name = "cmbCntrlTaskStatus";
            this.cmbCntrlTaskStatus.Size = new System.Drawing.Size(264, 24);
            this.cmbCntrlTaskStatus.TabIndex = 9;
            this.cmbCntrlTaskStatus.Text = "Status";
            this.cmbCntrlTaskStatus.SelectedIndexChanged += new System.EventHandler(this.cmbCntrlTaskStatus_SelectedIndexChanged);
            // 
            // cmbCntrlTaskEmployee
            // 
            this.cmbCntrlTaskEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cmbCntrlTaskEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCntrlTaskEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCntrlTaskEmployee.FormattingEnabled = true;
            this.cmbCntrlTaskEmployee.Location = new System.Drawing.Point(352, 236);
            this.cmbCntrlTaskEmployee.Name = "cmbCntrlTaskEmployee";
            this.cmbCntrlTaskEmployee.Size = new System.Drawing.Size(91, 24);
            this.cmbCntrlTaskEmployee.TabIndex = 10;
            this.cmbCntrlTaskEmployee.Text = "Zawodnik";
            this.cmbCntrlTaskEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbCntrlTaskEmployee_SelectedIndexChanged);
            // 
            // rtxtCntrlTaskComment
            // 
            this.rtxtCntrlTaskComment.AcceptsTab = true;
            this.rtxtCntrlTaskComment.BackColor = System.Drawing.Color.Silver;
            this.rtxtCntrlTaskComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtCntrlTaskComment.Location = new System.Drawing.Point(0, 64);
            this.rtxtCntrlTaskComment.Name = "rtxtCntrlTaskComment";
            this.rtxtCntrlTaskComment.Size = new System.Drawing.Size(446, 166);
            this.rtxtCntrlTaskComment.TabIndex = 11;
            this.rtxtCntrlTaskComment.Text = "";
            this.rtxtCntrlTaskComment.TextChanged += new System.EventHandler(this.rtxtCntrlTaskComment_TextChanged);
            // 
            // CntrlTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.rtxtCntrlTaskComment);
            this.Controls.Add(this.cbCntrlTaskIfDesign);
            this.Controls.Add(this.cmbCntrlTaskStatus);
            this.Controls.Add(this.txtCntrlTaskPath);
            this.Controls.Add(this.cmbCntrlTaskEmployee);
            this.Controls.Add(this.btnDirectoryTaskSearcher);
            this.Controls.Add(this.panel1);
            this.Name = "CntrlTask";
            this.Size = new System.Drawing.Size(446, 296);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCntrlTaskTopic;
        private System.Windows.Forms.Button btnDirectoryTaskSearcher;
        private System.Windows.Forms.TextBox txtCntrlTaskPath;
        private System.Windows.Forms.Button btnCntrlTaskAdd;
        private System.Windows.Forms.CheckBox cbCntrlTaskIfDesign;
        private System.Windows.Forms.ComboBox cmbCntrlTaskStatus;
        private System.Windows.Forms.ComboBox cmbCntrlTaskEmployee;
        private System.Windows.Forms.RichTextBox rtxtCntrlTaskComment;
    }
}
