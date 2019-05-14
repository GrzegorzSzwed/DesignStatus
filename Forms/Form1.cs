//Created by Grzegorz Szwed
//Only for RW SWISS
//If any questions please contact me via mail g.szwed@qt-swiss.eu

using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Managment_Tool.Properties;
using Outlook = Microsoft.Office.Interop.Outlook;
using System.Threading;
using System.Data.SqlClient;
using Managment_Tool.Forms;

namespace Managment_Tool
{
    public partial class frmManagmentTool : Form
    {
        private folderBrowser folder;
        private List<Panel> UiPanels;
        private List<Panel> TaskPanels;
        private List<Panel> TaskPanelsParticular;
        private List<Panel> UserPanels;
        private string connectionString;
        //private string ConnectionString;
        //SqlConnection connection;
        public frmManagmentTool()
        {
            InitializeComponent();

            connectionString = @"Data Source = LAPEKS218-025\SQLEXPRESS;Initial Catalog = StatusKonstrukcjiDB;Integrated Security = True;";
            folder = new folderBrowser();
            folder.HideFrd = cbHideFRD.Checked;
            folder.onlyLast = cbOnlyLast.Checked;
            folder.name = txtName.Text;
            bwDirectory.DoWork += bwDirectory_DoWork;
            bwDirectory.WorkerSupportsCancellation = true;

            UiPanels = new List<Panel>(); //panel for main managment - design and tasks
            UiPanels.Add(pnlConstruction);
            UiPanels.Add(pnlTasks);
            UiPanels[0].BringToFront();

            TaskPanels = new List<Panel>();
            TaskPanels.Add(pnlFlwTasks);
            TaskPanels.Add(pnlEmployee);
            TaskPanels.Add(pnlAddTask);

            //to delete
            TaskPanelsParticular = new List<Panel>();

            UserPanels = new List<Panel>();
            UserPanels.Add(pnlEmployeeAddUser);//LOAD EMPLOYEE PANELS
            UserPanels.Add(pnlEmployeeListUsers);//LOAD EMPLOYEE LIST

            flwTopMenuLeft.Controls.Clear();
            flwTopMenuLeft.Controls.Add(btnLeftSite);
            flwTopMenuLeft.Controls.Add(btnRightSite);
            flwTopMenuLeft.Controls.Add(btnTasks);

            //ConnectionString = @"Data Source=LAPEKS218-025\SQLEXPRESS;Initial Catalog = StatusKonstrukcjiDB;Integrated Security = True;";
        }

        #region DesignPanel

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(txtDirectory.Text))
            {
                LoadDirectory();
                LoadFilters();
                LoadDGV();
                Settings.Default.lastOpen = DateTime.Now;
                btnRefresh.BackColor = Color.White;

                if(!bwDirectory.IsBusy)
                    bwDirectory.RunWorkerAsync();

            }
            else
                MessageBox.Show("Podana sciezka nie istnieje");
        }

        private void LoadDGV()
        {
            if (folder.directory != string.Empty)
            {
                dgvConstruction.DataSource = folder.LoadDGV();
                //var columnName = string.Empty;
                //if (dgvConstruction.SortedColumn != null)
                //    columnName = dgvConstruction.SortedColumn.Name;
                //else
                //    columnName = string.Empty;

                //if (columnName != "Line" && columnName!=string.Empty) 
                //{
                //    dgvConstruction.Sort(dgvConstruction.SortedColumn, ListSortDirection.Ascending);
                //}
                //else


                dgvConstruction.Sort(dgvConstruction.Columns["Line"], ListSortDirection.Ascending);
                //else
                //    dgvConstruction.Sort(dgvConstruction.Columns[dgvConstruction.SortedColumn.Index], ListSortDirection.Ascending);

                foreach (DataGridViewRow row in dgvConstruction.Rows)
                {
                    var state = row.Cells[5].Value;
                    switch (state)
                    {
                        case "in SIM work":
                            row.DefaultCellStyle.BackColor = Settings.Default.inSimWork_colour;
                            break;
                        case "waiting for new DESIGN":
                            row.DefaultCellStyle.BackColor = Settings.Default.waitingForDesignNextLoop_colour;
                            break;
                        case "loop checked":
                            row.DefaultCellStyle.BackColor = Settings.Default.designChecked;
                            break;
                        case "ready to check in SIM":
                            row.DefaultCellStyle.BackColor = Settings.Default.readyToCheckInSim_colour;
                            break;
                        case "free for detailing":
                            row.DefaultCellStyle.BackColor = Settings.Default.freeForDetailing_colour;
                            break;
                        default:
                            row.DefaultCellStyle.BackColor = Settings.Default.notPredicterd;
                            break;
                    }
                }
                dgvConstruction.AutoResizeColumns();
                dgvConstruction.Refresh();
            }
            else
            {
                MessageBox.Show("Lokalizacja nie została wczytana\nNajpierw wybierz obszar!");
            }
        }

        private void LoadFilters()
        {
            LoadOnlyLast();
            LoadHideFRD();
            LoadByName();
        }

        private void LoadHideFRD()
        {
            if (cbHideFRD.Checked)
                folder.HideFrd = true;
            else
                folder.HideFrd = false;
        }

        private void LoadByName()
        {
            if (txtName.Text != string.Empty)
            {
                folder.name = txtName.Text;
            }
            else
                folder.name = string.Empty;
        }

        private void LoadOnlyLast()
        {
            if (cbOnlyLast.Checked)
            {
                folder.onlyLast = true;
            }
            else
                folder.onlyLast = false;
        }

        private void LoadDirectory()
        {
            if (txtDirectory.Text != string.Empty)
                folder.directory = txtDirectory.Text;
            else
                folder.directory = string.Empty;
        }

        private void dgvConstruction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var rowToCombat = txtDirectory.Text;
                for (var i = 0; i < 4; i++)
                {
                    rowToCombat = rowToCombat + "\\" + dgvConstruction[i, e.RowIndex].Value;
                }
                var openfiledialog = new OpenFileDialog();
                openfiledialog.Title = "Wybrano folder";
                openfiledialog.InitialDirectory = rowToCombat;
                var showdialog = openfiledialog.ShowDialog();
                switch (showdialog)
                {
                    case DialogResult.OK:
                        System.Diagnostics.Process.Start(openfiledialog.FileName);
                        break;
                    default:
                        break;
                }
            }
        }
        private void CheckStateOfRefresh()
        {
            MethodInvoker invoker = delegate ()
            {
                btnRefresh.BackColor = Color.Green;
            };

            var extension = "*.ppt|*.pptx";
            var splittedExtension = extension.Split('|');
            if(splittedExtension.Length>0)
            {
                var dirs = new List<string>();
                foreach (var ext in splittedExtension)
                {
                    dirs.AddRange(Directory.GetFiles(folder.directory, ext, SearchOption.AllDirectories));
                }

                foreach (var dir in dirs)
                {

                    var info = new FileInfo(dir);
                    DateTime lastMidification = info.LastAccessTime;
                    TimeSpan interval = lastMidification - Settings.Default.lastOpen;
                    if (interval.TotalSeconds > 0)
                    {
                        if (InvokeRequired)
                            Invoke(invoker);
                        else
                            invoker();
                    }
                }
            }
        }
        private void bwDirectory_DoWork(object sender, DoWorkEventArgs e)
        {
            while(!bwDirectory.CancellationPending)
            {
                if(txtDirectory.Text!=string.Empty&folder.directory!=string.Empty)
                {
                    CheckStateOfRefresh();
                }
                Thread.Sleep(1000);
            }
            if (bwDirectory.CancellationPending)
            {
                e.Cancel = true;
            }
        }
        private void exportDoCOJTT_Click(object sender, EventArgs e)
        {
            var row = dgvConstruction.SelectedRows;
            if (row.Count == 1)
            {
                //combine the directory
                var pathToExport = string.Empty;
                var fileToExport = string.Empty;
                var rowToCombat = folder.directory;
                for (var index = 0; index < 4; index++)
                rowToCombat = rowToCombat + "\\" + dgvConstruction[index, row[0].Index].Value;

                    var directory = Directory.GetFiles(rowToCombat, "*.jt", SearchOption.TopDirectoryOnly);
                    if(directory.Length!=0)
                        fileToExport = directory[0];

                    if(fileToExport!=string.Empty)
                    {
                    FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                    folderBrowserDialog.SelectedPath = @"Z:\01\LIB_ROOT\11\K1";

                        var dialogResult = folderBrowserDialog.ShowDialog();
                        switch (dialogResult)
                        {
                            case DialogResult.OK:
                            pathToExport = folderBrowserDialog.SelectedPath;
                            var newPath = pathToExport + "\\" + Path.GetFileNameWithoutExtension(fileToExport) + ".cojt";
                            Directory.CreateDirectory(newPath);
                            File.Copy(fileToExport, newPath + "\\" + Path.GetFileName(fileToExport));
                            break;
                            default:
                                break;
                        }

                    }
                    else
                        MessageBox.Show("Any JT file was found");
            }
            else
                MessageBox.Show("Please select exactly one row");
        }

        private void showStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var commentFile = string.Empty;
            var row = dgvConstruction.SelectedRows;

            if (row.Count == 1)
            {
                var rowToCombat = folder.directory;
                var comment = dgvConstruction[6, row[0].Index].Value.ToString();
                var state = dgvConstruction[5, row[0].Index].Value.ToString();
                // jesli w folderze jest komentarz i jest JT sprawdz go
                if (comment!="no comment"&&state!= "waiting for new DESIGN")
                {
                    for (var index = 0; index < 4; index++)
                        rowToCombat = rowToCombat + "\\" + dgvConstruction[index, row[0].Index].Value;

                    var directory = Directory.GetFiles(rowToCombat, "*.txt", SearchOption.TopDirectoryOnly);
                    if (directory.Length != 0)
                    {
                        var enumerator = directory.GetEnumerator();
                        while (enumerator.MoveNext())
                        {
                            var cur = enumerator.Current.ToString();
                            if (Path.GetFileNameWithoutExtension(cur) != "frd")
                                commentFile = cur;
                        }
                        try
                        {
                            var statusForm = new TaskStatus(commentFile);
                            statusForm.Refresh();
                            statusForm.Show();
                        }
                        catch
                        {
                            MessageBox.Show("Process failed...\nCheck if the .txt file is opened.");
                        }
                    }
                    else
                        MessageBox.Show("Comment file not found\nIn that case status hasn't got any sense.");
                }
                else
                    MessageBox.Show("JT file or comment file not found\nIn that case status hasn't got any sense.");
            }
            else
                MessageBox.Show("Please select exactly one row");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbOnlyLast_CheckedChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region MenuPanel

        private void btnLeftSite_Click(object sender, EventArgs e)
        {
            var path = Settings.Default.LH.ToString();
            flwTopMenuLeft.Controls.Clear();
            flwTopMenuLeft.Controls.Add(btnRightSite);
            flwTopMenuLeft.Controls.Add(btnTasks);
            txtDirectory.Text = path;
            LoadDirectory();
            UiPanels[0].BringToFront();
            UserPanels.Clear();
            flwEmployeeListUsers.Controls.Clear();
            flwTasks.Controls.Clear();
        }

        private void btnRightSite_Click(object sender, EventArgs e)
        {
            var path = Settings.Default.RH.ToString();
            flwTopMenuLeft.Controls.Clear();
            flwTopMenuLeft.Controls.Add(btnLeftSite);
            flwTopMenuLeft.Controls.Add(btnTasks);
            txtDirectory.Text = path;
            LoadDirectory();
            UiPanels[0].BringToFront();
            UserPanels.Clear();
            flwEmployeeListUsers.Controls.Clear();
            flwTasks.Controls.Clear();
        }
        private void btnConstructionStatus_Click(object sender, EventArgs e)
        {
            flwTopMenuLeft.Controls.Clear();
            flwTopMenuLeft.Controls.Add(btnLeftSite);
            flwTopMenuLeft.Controls.Add(btnRightSite);
            flwTopMenuLeft.Controls.Add(btnTasks);

            UiPanels[0].BringToFront();
            UserPanels.Clear();
            flwEmployeeListUsers.Controls.Clear();
            flwTasks.Controls.Clear();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            flwTopMenuLeft.Controls.Clear();
            flwTopMenuLeft.Controls.Add(btnConstructionStatus);
            flwTopMenuLeft.Controls.Add(btnEmployee);
            flwTopMenuLeft.Controls.Add(btnAddTask);

            //clear employee panels
            UserPanels.Clear();

            TaskPanels[0].BringToFront();//SHOW TASKS FLOW

            UiPanels[1].BringToFront();//Show DASHBOARD
        }

        #endregion

        #region TaskPanel
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            flwTopMenuLeft.Controls.Clear();
            flwTopMenuLeft.Controls.Add(btnConstructionStatus);
            flwTopMenuLeft.Controls.Add(btnEmployee);
            flwTopMenuLeft.Controls.Add(btnAddTask);

            //clear employee panels
            UserPanels.Clear();

            TaskPanels[0].BringToFront();//SHOW TASKS FLOW

            UiPanels[1].BringToFront();//Show DASHBOARD
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                var query = "SELECT * FROM TaskTable";
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, connection);
                DataTable tb = new DataTable();
                sqlDataAdapter.Fill(tb);
                var count = tb.Rows.Count;
                CntrlTaskView[] cntrls = new CntrlTaskView[count];
                if(count!=0)
                {
                    var i = 0;
                    foreach(DataRow row in tb.Rows)
                    {
                        cntrls[i] = new CntrlTaskView(row[6].ToString());
                        cntrls[i].ID = Convert.ToInt16(row[0]);
                        cntrls[i].Temat = row[3].ToString();
                        cntrls[i++].Komentarz = row[4].ToString();
                    }
                }
                flwTasks.Controls.AddRange(cntrls);
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            flwTopMenuLeft.Controls.Clear();
            flwTopMenuLeft.Controls.Add(btnConstructionStatus);
            flwTopMenuLeft.Controls.Add(btnDashboard);
            flwTopMenuLeft.Controls.Add(btnEmployeeListUsers);
            flwTopMenuLeft.Controls.Add(btnEmployeeNewUser);


            UserPanels.Clear();
            TaskPanels[1].BringToFront();
            UserPanels.Add(pnlEmployeeAddUser);
            UserPanels.Add(pnlEmployeeListUsers);
            lblAddEmployeeComment.Text = " ";
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            flwTopMenuLeft.Controls.Clear();
            flwTopMenuLeft.Controls.Add(btnConstructionStatus);
            flwTopMenuLeft.Controls.Add(btnEmployee);
            flwTopMenuLeft.Controls.Add(btnDashboard);

            if (btnAddTask.BackColor == Color.Silver)
            {
                TaskPanels[2].BringToFront();//SHOW FLW TASKS
                btnAddTask.BackColor = Color.Orange;
            }
            else
            {
                TaskPanels[0].BringToFront();//SHOW FLW TASKS
                btnAddTask.BackColor = Color.Silver;
            }
        }
        #endregion

        #region UserPanel
        private void btnAddUserPnlAddUser_Click(object sender, EventArgs e)
        {
            if(txtNameAddUser.Text!=string.Empty&&txtSurnameAddUser.Text!=string.Empty&&cmbPermissionAddUser.Text!=string.Empty)
            {
                lblAddEmployeeComment.Text = string.Empty;
                using (SqlConnection connection = new SqlConnection(@"Data Source = LAPEKS218-025\SQLEXPRESS;Initial Catalog = StatusKonstrukcjiDB;Integrated Security = True;"))
                {
                    using (SqlCommand cmd = new SqlCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandType = CommandType.Text;

                        cmd.CommandText = @"INSERT INTO EmployeeTab (Name,Surname,Mail,Permission) VALUES (@param1,@param2,@param3,@param4)";

                        cmd.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = txtNameAddUser.Text.ToString().ToLower();
                        cmd.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = txtSurnameAddUser.Text.ToString().ToLower();
                        if (txtMailAddUser.Text != string.Empty)
                            cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = txtMailAddUser.Text.ToString();
                        else
                            cmd.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = txtNameAddUser.Text[0].ToString().ToLower() + "." + txtSurnameAddUser.Text.ToString().ToLower() + @"@gt-swiss.eu";
                        cmd.Parameters.Add("@param4", SqlDbType.VarChar, 50).Value = cmbPermissionAddUser.Text.ToString().ToLower();

                        try
                        {
                            connection.Open();
                            cmd.ExecuteNonQuery();
                            txtNameAddUser.Text = string.Empty;
                            txtSurnameAddUser.Text = string.Empty;
                            txtMailAddUser.Text = string.Empty;
                            cmbPermissionAddUser.Text = string.Empty;
                        }
                        catch
                        {
                            lblAddEmployeeComment.Text = "Nie udało się poprawnie połączyć z bazą danych";
                        }

                    }
                }
            }
            else
            {
                lblAddEmployeeComment.Text = "Proszę uzupełnić przynajmiej pole Imię, Nazwisko, Stanowisko";
            }

        }
        private void btnEmployeeNewUser_Click(object sender, EventArgs e)
        {
            flwTopMenuLeft.Controls.Clear();
            flwTopMenuLeft.Controls.Add(btnConstructionStatus);
            flwTopMenuLeft.Controls.Add(btnDashboard);
            flwTopMenuLeft.Controls.Add(btnEmployeeListUsers);

            UserPanels[0].BringToFront();
        }
        private void btnEmployeeListUsers_Click(object sender, EventArgs e)
        {
            flwTopMenuLeft.Controls.Clear();
            flwTopMenuLeft.Controls.Add(btnConstructionStatus);
            flwTopMenuLeft.Controls.Add(btnDashboard);
            flwTopMenuLeft.Controls.Add(btnEmployeeNewUser);

            UserPanels[1].BringToFront();
            flwEmployeeListUsers.Controls.Clear();
            LoadListOfUsers();
        }
        private void LoadListOfUsers()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = LAPEKS218-025\SQLEXPRESS;Initial Catalog = StatusKonstrukcjiDB;Integrated Security = True;"))
            {
                var query = "SELECT id FROM EmployeeTab";
                DataTable table = new DataTable();
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                connection.Close();
                adapter.Fill(table);
                var count = table.Rows.Count;
                User[] users = new User[count];
                CntrlUser[] cntrls = new CntrlUser[count];
                int i = 0;
                if (count > 0)
                {
                    foreach (DataRow row in table.Rows)
                    {
                        users[i] = new User((int)row[0]);
                        cntrls[i] = new CntrlUser();
                        cntrls[i].GetColor = Color.PaleTurquoise;
                        cntrls[i].Imie = users[i].GetName;
                        cntrls[i].Nazwisko = users[i].GetSurname;
                        cntrls[i].Mail = users[i].GetMail;
                        cntrls[i].Pozwolenie = users[i++].GetPermission;
                    }
                }
                flwEmployeeListUsers.Controls.AddRange(cntrls);
            }
        }

        #endregion
    }
}
