namespace Managment_Tool
{
    partial class frmManagmentTool
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManagmentTool));
            this.ExportToCOJT = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportDoCOJTT = new System.Windows.Forms.ToolStripMenuItem();
            this.showStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlConstruction = new System.Windows.Forms.Panel();
            this.dgvConstruction = new System.Windows.Forms.DataGridView();
            this.cbHideFRD = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbOnlyLast = new System.Windows.Forms.CheckBox();
            this.lblPathDocu = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.bwDirectory = new System.ComponentModel.BackgroundWorker();
            this.btnLeftSite = new System.Windows.Forms.Button();
            this.btnRightSite = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnTasks = new System.Windows.Forms.Button();
            this.btnConstructionStatus = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlLeftMenu = new System.Windows.Forms.Panel();
            this.pnlTasks = new System.Windows.Forms.Panel();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnEmployeeListUsers = new System.Windows.Forms.Button();
            this.btnEmployeeNewUser = new System.Windows.Forms.Button();
            this.tblLayout = new System.Windows.Forms.TableLayoutPanel();
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.tblTopMenu = new System.Windows.Forms.TableLayoutPanel();
            this.flwTopMenuLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.flwTopMenuExit = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlFlwTasks = new System.Windows.Forms.Panel();
            this.flwTasks = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAddTask = new System.Windows.Forms.Panel();
            this.cntrlTask1 = new Managment_Tool.Forms.CntrlTask();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.pnlEmployeeAddUser = new System.Windows.Forms.Panel();
            this.txtSurnameAddUser = new System.Windows.Forms.TextBox();
            this.txtNameAddUser = new System.Windows.Forms.TextBox();
            this.txtMailAddUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddUserPnlAddUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAddEmployeeComment = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbPermissionAddUser = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlEmployeeListUsers = new System.Windows.Forms.Panel();
            this.flwEmployeeListUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.ExportToCOJT.SuspendLayout();
            this.pnlConstruction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstruction)).BeginInit();
            this.pnlLeftMenu.SuspendLayout();
            this.pnlTasks.SuspendLayout();
            this.tblLayout.SuspendLayout();
            this.tblDashboard.SuspendLayout();
            this.pnlDashboard.SuspendLayout();
            this.tblTopMenu.SuspendLayout();
            this.flwTopMenuLeft.SuspendLayout();
            this.flwTopMenuExit.SuspendLayout();
            this.pnlFlwTasks.SuspendLayout();
            this.pnlAddTask.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlEmployeeAddUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlEmployeeListUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExportToCOJT
            // 
            this.ExportToCOJT.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDoCOJTT,
            this.showStatusToolStripMenuItem});
            this.ExportToCOJT.Name = "contextMenuStrip1";
            this.ExportToCOJT.Size = new System.Drawing.Size(156, 48);
            // 
            // exportDoCOJTT
            // 
            this.exportDoCOJTT.Name = "exportDoCOJTT";
            this.exportDoCOJTT.Size = new System.Drawing.Size(155, 22);
            this.exportDoCOJTT.Text = "Export do COJT";
            this.exportDoCOJTT.Click += new System.EventHandler(this.exportDoCOJTT_Click);
            // 
            // showStatusToolStripMenuItem
            // 
            this.showStatusToolStripMenuItem.Name = "showStatusToolStripMenuItem";
            this.showStatusToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.showStatusToolStripMenuItem.Text = "Show status";
            this.showStatusToolStripMenuItem.Click += new System.EventHandler(this.showStatusToolStripMenuItem_Click);
            // 
            // pnlConstruction
            // 
            this.pnlConstruction.AutoSize = true;
            this.pnlConstruction.BackColor = System.Drawing.Color.White;
            this.pnlConstruction.Controls.Add(this.dgvConstruction);
            this.pnlConstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConstruction.Location = new System.Drawing.Point(0, 0);
            this.pnlConstruction.Name = "pnlConstruction";
            this.pnlConstruction.Size = new System.Drawing.Size(1554, 929);
            this.pnlConstruction.TabIndex = 1;
            // 
            // dgvConstruction
            // 
            this.dgvConstruction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConstruction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConstruction.Location = new System.Drawing.Point(0, 0);
            this.dgvConstruction.Name = "dgvConstruction";
            this.dgvConstruction.Size = new System.Drawing.Size(1554, 929);
            this.dgvConstruction.TabIndex = 0;
            // 
            // cbHideFRD
            // 
            this.cbHideFRD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbHideFRD.AutoSize = true;
            this.cbHideFRD.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHideFRD.Location = new System.Drawing.Point(22, 180);
            this.cbHideFRD.Name = "cbHideFRD";
            this.cbHideFRD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbHideFRD.Size = new System.Drawing.Size(147, 19);
            this.cbHideFRD.TabIndex = 6;
            this.cbHideFRD.Text = "ukryj Free for detailing";
            this.cbHideFRD.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "zawiera";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.ForeColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Location = new System.Drawing.Point(65, 215);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(47, 45);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.Location = new System.Drawing.Point(22, 154);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 0;
            // 
            // cbOnlyLast
            // 
            this.cbOnlyLast.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbOnlyLast.AutoSize = true;
            this.cbOnlyLast.Checked = true;
            this.cbOnlyLast.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbOnlyLast.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOnlyLast.Location = new System.Drawing.Point(22, 100);
            this.cbOnlyLast.Name = "cbOnlyLast";
            this.cbOnlyLast.Size = new System.Drawing.Size(138, 19);
            this.cbOnlyLast.TabIndex = 3;
            this.cbOnlyLast.Text = "Tylko ostatnie wersje";
            this.cbOnlyLast.UseVisualStyleBackColor = true;
            this.cbOnlyLast.CheckedChanged += new System.EventHandler(this.cbOnlyLast_CheckedChanged);
            // 
            // lblPathDocu
            // 
            this.lblPathDocu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPathDocu.AutoSize = true;
            this.lblPathDocu.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPathDocu.Location = new System.Drawing.Point(12, 46);
            this.lblPathDocu.Name = "lblPathDocu";
            this.lblPathDocu.Size = new System.Drawing.Size(165, 16);
            this.lblPathDocu.TabIndex = 2;
            this.lblPathDocu.Text = "Ścieżka dokumentacji";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDirectory.Location = new System.Drawing.Point(19, 74);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(147, 20);
            this.txtDirectory.TabIndex = 1;
            // 
            // bwDirectory
            // 
            this.bwDirectory.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwDirectory_DoWork);
            // 
            // btnLeftSite
            // 
            this.btnLeftSite.FlatAppearance.BorderSize = 0;
            this.btnLeftSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeftSite.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeftSite.ForeColor = System.Drawing.Color.Black;
            this.btnLeftSite.Image = ((System.Drawing.Image)(resources.GetObject("btnLeftSite.Image")));
            this.btnLeftSite.Location = new System.Drawing.Point(3, 3);
            this.btnLeftSite.Name = "btnLeftSite";
            this.btnLeftSite.Size = new System.Drawing.Size(57, 56);
            this.btnLeftSite.TabIndex = 3;
            this.btnLeftSite.UseVisualStyleBackColor = true;
            this.btnLeftSite.Click += new System.EventHandler(this.btnLeftSite_Click);
            // 
            // btnRightSite
            // 
            this.btnRightSite.FlatAppearance.BorderSize = 0;
            this.btnRightSite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRightSite.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRightSite.ForeColor = System.Drawing.Color.Black;
            this.btnRightSite.Image = ((System.Drawing.Image)(resources.GetObject("btnRightSite.Image")));
            this.btnRightSite.Location = new System.Drawing.Point(66, 3);
            this.btnRightSite.Name = "btnRightSite";
            this.btnRightSite.Size = new System.Drawing.Size(57, 56);
            this.btnRightSite.TabIndex = 4;
            this.btnRightSite.UseVisualStyleBackColor = true;
            this.btnRightSite.Click += new System.EventHandler(this.btnRightSite_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.FlatAppearance.BorderSize = 0;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Black;
            this.btnLogIn.Image = ((System.Drawing.Image)(resources.GetObject("btnLogIn.Image")));
            this.btnLogIn.Location = new System.Drawing.Point(581, 3);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnLogIn.Size = new System.Drawing.Size(56, 56);
            this.btnLogIn.TabIndex = 8;
            this.btnLogIn.UseVisualStyleBackColor = true;
            // 
            // btnTasks
            // 
            this.btnTasks.FlatAppearance.BorderSize = 0;
            this.btnTasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTasks.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.ForeColor = System.Drawing.Color.Black;
            this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
            this.btnTasks.Location = new System.Drawing.Point(192, 3);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(57, 56);
            this.btnTasks.TabIndex = 7;
            this.btnTasks.UseVisualStyleBackColor = true;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnConstructionStatus
            // 
            this.btnConstructionStatus.FlatAppearance.BorderSize = 0;
            this.btnConstructionStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConstructionStatus.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConstructionStatus.ForeColor = System.Drawing.Color.Black;
            this.btnConstructionStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnConstructionStatus.Image")));
            this.btnConstructionStatus.Location = new System.Drawing.Point(129, 3);
            this.btnConstructionStatus.Name = "btnConstructionStatus";
            this.btnConstructionStatus.Size = new System.Drawing.Size(57, 56);
            this.btnConstructionStatus.TabIndex = 6;
            this.btnConstructionStatus.UseVisualStyleBackColor = true;
            this.btnConstructionStatus.Click += new System.EventHandler(this.btnConstructionStatus_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(643, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(56, 56);
            this.btnExit.TabIndex = 5;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlLeftMenu
            // 
            this.pnlLeftMenu.BackColor = System.Drawing.Color.Silver;
            this.pnlLeftMenu.Controls.Add(this.cbHideFRD);
            this.pnlLeftMenu.Controls.Add(this.cbOnlyLast);
            this.pnlLeftMenu.Controls.Add(this.label2);
            this.pnlLeftMenu.Controls.Add(this.btnRefresh);
            this.pnlLeftMenu.Controls.Add(this.txtName);
            this.pnlLeftMenu.Controls.Add(this.lblPathDocu);
            this.pnlLeftMenu.Controls.Add(this.txtDirectory);
            this.pnlLeftMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftMenu.Margin = new System.Windows.Forms.Padding(0);
            this.pnlLeftMenu.Name = "pnlLeftMenu";
            this.pnlLeftMenu.Size = new System.Drawing.Size(200, 929);
            this.pnlLeftMenu.TabIndex = 6;
            // 
            // pnlTasks
            // 
            this.pnlTasks.BackColor = System.Drawing.Color.LightGray;
            this.pnlTasks.Controls.Add(this.pnlEmployee);
            this.pnlTasks.Controls.Add(this.pnlAddTask);
            this.pnlTasks.Controls.Add(this.pnlFlwTasks);
            this.pnlTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTasks.Location = new System.Drawing.Point(0, 0);
            this.pnlTasks.Name = "pnlTasks";
            this.pnlTasks.Size = new System.Drawing.Size(1554, 929);
            this.pnlTasks.TabIndex = 1;
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(381, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(57, 56);
            this.btnDashboard.TabIndex = 10;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.FlatAppearance.BorderSize = 0;
            this.btnAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTask.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.ForeColor = System.Drawing.Color.Black;
            this.btnAddTask.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTask.Image")));
            this.btnAddTask.Location = new System.Drawing.Point(318, 3);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(57, 56);
            this.btnAddTask.TabIndex = 9;
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.Black;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.Location = new System.Drawing.Point(255, 3);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(57, 56);
            this.btnEmployee.TabIndex = 8;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnEmployeeListUsers
            // 
            this.btnEmployeeListUsers.FlatAppearance.BorderSize = 0;
            this.btnEmployeeListUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeListUsers.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeListUsers.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeeListUsers.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeListUsers.Image")));
            this.btnEmployeeListUsers.Location = new System.Drawing.Point(444, 3);
            this.btnEmployeeListUsers.Name = "btnEmployeeListUsers";
            this.btnEmployeeListUsers.Size = new System.Drawing.Size(57, 56);
            this.btnEmployeeListUsers.TabIndex = 16;
            this.btnEmployeeListUsers.UseVisualStyleBackColor = true;
            this.btnEmployeeListUsers.Click += new System.EventHandler(this.btnEmployeeListUsers_Click);
            // 
            // btnEmployeeNewUser
            // 
            this.btnEmployeeNewUser.FlatAppearance.BorderSize = 0;
            this.btnEmployeeNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeNewUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnEmployeeNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployeeNewUser.Image")));
            this.btnEmployeeNewUser.Location = new System.Drawing.Point(507, 3);
            this.btnEmployeeNewUser.Name = "btnEmployeeNewUser";
            this.btnEmployeeNewUser.Size = new System.Drawing.Size(57, 56);
            this.btnEmployeeNewUser.TabIndex = 15;
            this.btnEmployeeNewUser.UseVisualStyleBackColor = true;
            this.btnEmployeeNewUser.Click += new System.EventHandler(this.btnEmployeeNewUser_Click);
            // 
            // tblLayout
            // 
            this.tblLayout.ColumnCount = 1;
            this.tblLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Controls.Add(this.tblDashboard, 0, 1);
            this.tblLayout.Controls.Add(this.tblTopMenu, 0, 0);
            this.tblLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblLayout.Location = new System.Drawing.Point(0, 0);
            this.tblLayout.Name = "tblLayout";
            this.tblLayout.RowCount = 2;
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tblLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblLayout.Size = new System.Drawing.Size(1754, 989);
            this.tblLayout.TabIndex = 7;
            // 
            // tblDashboard
            // 
            this.tblDashboard.ColumnCount = 2;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.pnlLeftMenu, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlDashboard, 1, 0);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 60);
            this.tblDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 1;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 738F));
            this.tblDashboard.Size = new System.Drawing.Size(1754, 929);
            this.tblDashboard.TabIndex = 0;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Controls.Add(this.pnlTasks);
            this.pnlDashboard.Controls.Add(this.pnlConstruction);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(200, 0);
            this.pnlDashboard.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1554, 929);
            this.pnlDashboard.TabIndex = 7;
            // 
            // tblTopMenu
            // 
            this.tblTopMenu.BackColor = System.Drawing.Color.Teal;
            this.tblTopMenu.ColumnCount = 2;
            this.tblTopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tblTopMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblTopMenu.Controls.Add(this.flwTopMenuLeft, 0, 0);
            this.tblTopMenu.Controls.Add(this.flwTopMenuExit, 1, 0);
            this.tblTopMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblTopMenu.Location = new System.Drawing.Point(0, 0);
            this.tblTopMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tblTopMenu.Name = "tblTopMenu";
            this.tblTopMenu.RowCount = 1;
            this.tblTopMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblTopMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblTopMenu.Size = new System.Drawing.Size(1754, 60);
            this.tblTopMenu.TabIndex = 1;
            // 
            // flwTopMenuLeft
            // 
            this.flwTopMenuLeft.Controls.Add(this.btnLeftSite);
            this.flwTopMenuLeft.Controls.Add(this.btnRightSite);
            this.flwTopMenuLeft.Controls.Add(this.btnConstructionStatus);
            this.flwTopMenuLeft.Controls.Add(this.btnTasks);
            this.flwTopMenuLeft.Controls.Add(this.btnEmployee);
            this.flwTopMenuLeft.Controls.Add(this.btnAddTask);
            this.flwTopMenuLeft.Controls.Add(this.btnDashboard);
            this.flwTopMenuLeft.Controls.Add(this.btnEmployeeListUsers);
            this.flwTopMenuLeft.Controls.Add(this.btnEmployeeNewUser);
            this.flwTopMenuLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwTopMenuLeft.Location = new System.Drawing.Point(0, 0);
            this.flwTopMenuLeft.Margin = new System.Windows.Forms.Padding(0);
            this.flwTopMenuLeft.Name = "flwTopMenuLeft";
            this.flwTopMenuLeft.Size = new System.Drawing.Size(1052, 60);
            this.flwTopMenuLeft.TabIndex = 1;
            // 
            // flwTopMenuExit
            // 
            this.flwTopMenuExit.Controls.Add(this.btnExit);
            this.flwTopMenuExit.Controls.Add(this.btnLogIn);
            this.flwTopMenuExit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwTopMenuExit.Location = new System.Drawing.Point(1052, 0);
            this.flwTopMenuExit.Margin = new System.Windows.Forms.Padding(0);
            this.flwTopMenuExit.Name = "flwTopMenuExit";
            this.flwTopMenuExit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.flwTopMenuExit.Size = new System.Drawing.Size(702, 60);
            this.flwTopMenuExit.TabIndex = 2;
            // 
            // pnlFlwTasks
            // 
            this.pnlFlwTasks.BackColor = System.Drawing.Color.DarkGray;
            this.pnlFlwTasks.Controls.Add(this.flwTasks);
            this.pnlFlwTasks.Location = new System.Drawing.Point(16, 5);
            this.pnlFlwTasks.Name = "pnlFlwTasks";
            this.pnlFlwTasks.Size = new System.Drawing.Size(1526, 912);
            this.pnlFlwTasks.TabIndex = 4;
            // 
            // flwTasks
            // 
            this.flwTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flwTasks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flwTasks.Location = new System.Drawing.Point(0, 0);
            this.flwTasks.Name = "flwTasks";
            this.flwTasks.Size = new System.Drawing.Size(1526, 912);
            this.flwTasks.TabIndex = 0;
            this.flwTasks.WrapContents = false;
            // 
            // pnlAddTask
            // 
            this.pnlAddTask.BackColor = System.Drawing.Color.DarkGray;
            this.pnlAddTask.Controls.Add(this.cntrlTask1);
            this.pnlAddTask.Location = new System.Drawing.Point(19, 11);
            this.pnlAddTask.Name = "pnlAddTask";
            this.pnlAddTask.Size = new System.Drawing.Size(455, 312);
            this.pnlAddTask.TabIndex = 3;
            // 
            // cntrlTask1
            // 
            this.cntrlTask1.BackColor = System.Drawing.Color.White;
            this.cntrlTask1.Design = false;
            this.cntrlTask1.Komentarz = null;
            this.cntrlTask1.Location = new System.Drawing.Point(3, 9);
            this.cntrlTask1.Login = null;
            this.cntrlTask1.Lokalizacja = "";
            this.cntrlTask1.Name = "cntrlTask1";
            this.cntrlTask1.Size = new System.Drawing.Size(446, 292);
            this.cntrlTask1.Status = null;
            this.cntrlTask1.TabIndex = 0;
            this.cntrlTask1.Temat = "";
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.pnlEmployeeListUsers);
            this.pnlEmployee.Controls.Add(this.pnlEmployeeAddUser);
            this.pnlEmployee.Location = new System.Drawing.Point(16, 46);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(1025, 495);
            this.pnlEmployee.TabIndex = 2;
            // 
            // pnlEmployeeAddUser
            // 
            this.pnlEmployeeAddUser.BackColor = System.Drawing.Color.Silver;
            this.pnlEmployeeAddUser.Controls.Add(this.label7);
            this.pnlEmployeeAddUser.Controls.Add(this.cmbPermissionAddUser);
            this.pnlEmployeeAddUser.Controls.Add(this.pictureBox1);
            this.pnlEmployeeAddUser.Controls.Add(this.label1);
            this.pnlEmployeeAddUser.Controls.Add(this.label6);
            this.pnlEmployeeAddUser.Controls.Add(this.lblAddEmployeeComment);
            this.pnlEmployeeAddUser.Controls.Add(this.label3);
            this.pnlEmployeeAddUser.Controls.Add(this.btnAddUserPnlAddUser);
            this.pnlEmployeeAddUser.Controls.Add(this.label4);
            this.pnlEmployeeAddUser.Controls.Add(this.label5);
            this.pnlEmployeeAddUser.Controls.Add(this.txtMailAddUser);
            this.pnlEmployeeAddUser.Controls.Add(this.txtNameAddUser);
            this.pnlEmployeeAddUser.Controls.Add(this.txtSurnameAddUser);
            this.pnlEmployeeAddUser.Location = new System.Drawing.Point(0, 57);
            this.pnlEmployeeAddUser.Name = "pnlEmployeeAddUser";
            this.pnlEmployeeAddUser.Size = new System.Drawing.Size(1021, 422);
            this.pnlEmployeeAddUser.TabIndex = 14;
            // 
            // txtSurnameAddUser
            // 
            this.txtSurnameAddUser.Location = new System.Drawing.Point(316, 126);
            this.txtSurnameAddUser.Name = "txtSurnameAddUser";
            this.txtSurnameAddUser.Size = new System.Drawing.Size(488, 20);
            this.txtSurnameAddUser.TabIndex = 10;
            // 
            // txtNameAddUser
            // 
            this.txtNameAddUser.Location = new System.Drawing.Point(316, 87);
            this.txtNameAddUser.Name = "txtNameAddUser";
            this.txtNameAddUser.Size = new System.Drawing.Size(488, 20);
            this.txtNameAddUser.TabIndex = 9;
            // 
            // txtMailAddUser
            // 
            this.txtMailAddUser.Location = new System.Drawing.Point(316, 165);
            this.txtMailAddUser.Name = "txtMailAddUser";
            this.txtMailAddUser.Size = new System.Drawing.Size(279, 20);
            this.txtMailAddUser.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(146, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Uprawnienia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(146, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mail";
            // 
            // btnAddUserPnlAddUser
            // 
            this.btnAddUserPnlAddUser.FlatAppearance.BorderSize = 0;
            this.btnAddUserPnlAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUserPnlAddUser.Font = new System.Drawing.Font("Lucida Sans Unicode", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUserPnlAddUser.ForeColor = System.Drawing.Color.Black;
            this.btnAddUserPnlAddUser.Image = ((System.Drawing.Image)(resources.GetObject("btnAddUserPnlAddUser.Image")));
            this.btnAddUserPnlAddUser.Location = new System.Drawing.Point(816, 87);
            this.btnAddUserPnlAddUser.Name = "btnAddUserPnlAddUser";
            this.btnAddUserPnlAddUser.Size = new System.Drawing.Size(68, 59);
            this.btnAddUserPnlAddUser.TabIndex = 11;
            this.btnAddUserPnlAddUser.UseVisualStyleBackColor = true;
            this.btnAddUserPnlAddUser.Click += new System.EventHandler(this.btnAddUserPnlAddUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nazwisko";
            // 
            // lblAddEmployeeComment
            // 
            this.lblAddEmployeeComment.AutoSize = true;
            this.lblAddEmployeeComment.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEmployeeComment.ForeColor = System.Drawing.Color.Red;
            this.lblAddEmployeeComment.Location = new System.Drawing.Point(146, 39);
            this.lblAddEmployeeComment.Name = "lblAddEmployeeComment";
            this.lblAddEmployeeComment.Size = new System.Drawing.Size(0, 20);
            this.lblAddEmployeeComment.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(347, 367);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dodawanie użytkownika";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Imię";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 95);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cmbPermissionAddUser
            // 
            this.cmbPermissionAddUser.FormattingEnabled = true;
            this.cmbPermissionAddUser.Items.AddRange(new object[] {
            "inżynier",
            "unit leader",
            "division leader"});
            this.cmbPermissionAddUser.Location = new System.Drawing.Point(316, 203);
            this.cmbPermissionAddUser.Name = "cmbPermissionAddUser";
            this.cmbPermissionAddUser.Size = new System.Drawing.Size(562, 21);
            this.cmbPermissionAddUser.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(610, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Wpisz jeśli inny niż domyślny";
            // 
            // pnlEmployeeListUsers
            // 
            this.pnlEmployeeListUsers.BackColor = System.Drawing.Color.Teal;
            this.pnlEmployeeListUsers.Controls.Add(this.flwEmployeeListUsers);
            this.pnlEmployeeListUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlEmployeeListUsers.Location = new System.Drawing.Point(0, 72);
            this.pnlEmployeeListUsers.Name = "pnlEmployeeListUsers";
            this.pnlEmployeeListUsers.Size = new System.Drawing.Size(1025, 423);
            this.pnlEmployeeListUsers.TabIndex = 17;
            // 
            // flwEmployeeListUsers
            // 
            this.flwEmployeeListUsers.AutoScroll = true;
            this.flwEmployeeListUsers.BackColor = System.Drawing.Color.White;
            this.flwEmployeeListUsers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flwEmployeeListUsers.Location = new System.Drawing.Point(0, 42);
            this.flwEmployeeListUsers.Name = "flwEmployeeListUsers";
            this.flwEmployeeListUsers.Size = new System.Drawing.Size(1025, 381);
            this.flwEmployeeListUsers.TabIndex = 0;
            // 
            // frmManagmentTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1754, 989);
            this.Controls.Add(this.tblLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmManagmentTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Managment Tool";
            this.ExportToCOJT.ResumeLayout(false);
            this.pnlConstruction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConstruction)).EndInit();
            this.pnlLeftMenu.ResumeLayout(false);
            this.pnlLeftMenu.PerformLayout();
            this.pnlTasks.ResumeLayout(false);
            this.tblLayout.ResumeLayout(false);
            this.tblDashboard.ResumeLayout(false);
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDashboard.PerformLayout();
            this.tblTopMenu.ResumeLayout(false);
            this.flwTopMenuLeft.ResumeLayout(false);
            this.flwTopMenuExit.ResumeLayout(false);
            this.pnlFlwTasks.ResumeLayout(false);
            this.pnlAddTask.ResumeLayout(false);
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployeeAddUser.ResumeLayout(false);
            this.pnlEmployeeAddUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlEmployeeListUsers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        //private System.Windows.Forms.DataGridView dgvConstruction;
        private System.Windows.Forms.Panel pnlConstruction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.CheckBox cbOnlyLast;
        private System.Windows.Forms.Label lblPathDocu;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.CheckBox cbHideFRD;
        private System.ComponentModel.BackgroundWorker bwDirectory;
        private System.Windows.Forms.ContextMenuStrip ExportToCOJT;
        private System.Windows.Forms.ToolStripMenuItem exportDoCOJTT;
        private System.Windows.Forms.ToolStripMenuItem showStatusToolStripMenuItem;
        private System.Windows.Forms.Button btnLeftSite;
        private System.Windows.Forms.Button btnRightSite;
        private System.Windows.Forms.Panel pnlLeftMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Button btnConstructionStatus;
        private System.Windows.Forms.Panel pnlTasks;
        private System.Windows.Forms.DataGridView dgvConstruction;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnEmployeeNewUser;
        private System.Windows.Forms.Button btnEmployeeListUsers;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TableLayoutPanel tblLayout;
        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.TableLayoutPanel tblTopMenu;
        private System.Windows.Forms.FlowLayoutPanel flwTopMenuLeft;
        private System.Windows.Forms.FlowLayoutPanel flwTopMenuExit;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Panel pnlEmployeeListUsers;
        private System.Windows.Forms.FlowLayoutPanel flwEmployeeListUsers;
        private System.Windows.Forms.Panel pnlEmployeeAddUser;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbPermissionAddUser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblAddEmployeeComment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddUserPnlAddUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMailAddUser;
        private System.Windows.Forms.TextBox txtNameAddUser;
        private System.Windows.Forms.TextBox txtSurnameAddUser;
        private System.Windows.Forms.Panel pnlAddTask;
        private Forms.CntrlTask cntrlTask1;
        private System.Windows.Forms.Panel pnlFlwTasks;
        private System.Windows.Forms.FlowLayoutPanel flwTasks;
    }
}

