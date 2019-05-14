namespace Managment_Tool.Forms
{
    partial class CntrlUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CntrlUser));
            this.CntrlUserLblName = new System.Windows.Forms.Label();
            this.CntrlUserLblSurname = new System.Windows.Forms.Label();
            this.CntrlUserLblMail = new System.Windows.Forms.Label();
            this.CntrlUserLblPermission = new System.Windows.Forms.Label();
            this.CntrlUserPnl = new System.Windows.Forms.Panel();
            this.CntrlPicture = new System.Windows.Forms.PictureBox();
            this.CntrlUserPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CntrlPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // CntrlUserLblName
            // 
            this.CntrlUserLblName.AutoSize = true;
            this.CntrlUserLblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CntrlUserLblName.Location = new System.Drawing.Point(27, 19);
            this.CntrlUserLblName.Name = "CntrlUserLblName";
            this.CntrlUserLblName.Size = new System.Drawing.Size(52, 16);
            this.CntrlUserLblName.TabIndex = 0;
            this.CntrlUserLblName.Text = "label1";
            // 
            // CntrlUserLblSurname
            // 
            this.CntrlUserLblSurname.AutoSize = true;
            this.CntrlUserLblSurname.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CntrlUserLblSurname.Location = new System.Drawing.Point(27, 45);
            this.CntrlUserLblSurname.Name = "CntrlUserLblSurname";
            this.CntrlUserLblSurname.Size = new System.Drawing.Size(52, 16);
            this.CntrlUserLblSurname.TabIndex = 1;
            this.CntrlUserLblSurname.Text = "label1";
            // 
            // CntrlUserLblMail
            // 
            this.CntrlUserLblMail.AutoSize = true;
            this.CntrlUserLblMail.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CntrlUserLblMail.Location = new System.Drawing.Point(27, 71);
            this.CntrlUserLblMail.Name = "CntrlUserLblMail";
            this.CntrlUserLblMail.Size = new System.Drawing.Size(52, 16);
            this.CntrlUserLblMail.TabIndex = 2;
            this.CntrlUserLblMail.Text = "label1";
            // 
            // CntrlUserLblPermission
            // 
            this.CntrlUserLblPermission.AutoSize = true;
            this.CntrlUserLblPermission.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CntrlUserLblPermission.Location = new System.Drawing.Point(27, 99);
            this.CntrlUserLblPermission.Name = "CntrlUserLblPermission";
            this.CntrlUserLblPermission.Size = new System.Drawing.Size(52, 16);
            this.CntrlUserLblPermission.TabIndex = 3;
            this.CntrlUserLblPermission.Text = "label1";
            // 
            // CntrlUserPnl
            // 
            this.CntrlUserPnl.BackColor = System.Drawing.Color.PaleTurquoise;
            this.CntrlUserPnl.Controls.Add(this.CntrlPicture);
            this.CntrlUserPnl.Controls.Add(this.CntrlUserLblSurname);
            this.CntrlUserPnl.Controls.Add(this.CntrlUserLblPermission);
            this.CntrlUserPnl.Controls.Add(this.CntrlUserLblName);
            this.CntrlUserPnl.Controls.Add(this.CntrlUserLblMail);
            this.CntrlUserPnl.Dock = System.Windows.Forms.DockStyle.Right;
            this.CntrlUserPnl.Location = new System.Drawing.Point(48, 0);
            this.CntrlUserPnl.Name = "CntrlUserPnl";
            this.CntrlUserPnl.Size = new System.Drawing.Size(319, 137);
            this.CntrlUserPnl.TabIndex = 4;
            this.CntrlUserPnl.MouseEnter += new System.EventHandler(this.CntrlUserPnl_MouseEnter);
            this.CntrlUserPnl.MouseLeave += new System.EventHandler(this.CntrlUserPnl_MouseLeave);
            // 
            // CntrlPicture
            // 
            this.CntrlPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CntrlPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CntrlPicture.BackgroundImage")));
            this.CntrlPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CntrlPicture.Location = new System.Drawing.Point(222, 0);
            this.CntrlPicture.Name = "CntrlPicture";
            this.CntrlPicture.Size = new System.Drawing.Size(97, 87);
            this.CntrlPicture.TabIndex = 4;
            this.CntrlPicture.TabStop = false;
            // 
            // CntrlUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Controls.Add(this.CntrlUserPnl);
            this.Name = "CntrlUser";
            this.Size = new System.Drawing.Size(367, 137);
            this.CntrlUserPnl.ResumeLayout(false);
            this.CntrlUserPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CntrlPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CntrlUserLblName;
        private System.Windows.Forms.Label CntrlUserLblSurname;
        private System.Windows.Forms.Label CntrlUserLblMail;
        private System.Windows.Forms.Label CntrlUserLblPermission;
        private System.Windows.Forms.Panel CntrlUserPnl;
        private System.Windows.Forms.PictureBox CntrlPicture;
    }
}
