using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Managment_Tool.Forms
{
    public partial class CntrlTask : UserControl
    {
        private string connectionString = @"Data Source = LAPEKS218-025\SQLEXPRESS;Initial Catalog = StatusKonstrukcjiDB;Integrated Security = True;";
        private int id;
        public CntrlTask()
        {
            InitializeComponent();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT Name, Surname FROM EmployeeTab";
                SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
                connection.Close();
                DataTable tb = new DataTable();
                sqlData.Fill(tb);
                var amount = tb.Rows.Count;
                if (amount != 0)
                {
                    foreach (DataRow row in tb.Rows)
                        cmbCntrlTaskEmployee.Items.Add(string.Format("{0} {1}", row[0].ToString(), row[1].ToString()));
                }
                txtCntrlTaskTopic.Text = "Temat*";
                txtCntrlTaskPath.Text = "Ścieżka dokumentacji";
                cmbCntrlTaskEmployee.Text = "Zawodnik";
                cmbCntrlTaskStatus.Text = "Zadanie";
                cbCntrlTaskIfDesign.Checked = false;
            }
        }

        #region Properties

        private string _topic;
        private string _comment;
        private string _status;
        private string _login;
        private bool _ifdesign;
        private string _path;

        public string Lokalizacja
        {
            get { return _path; }
            set { _path = value; txtCntrlTaskPath.Text = value; }
        }


        public bool Design
        {
            get { return _ifdesign; }
            set { _ifdesign = value; cbCntrlTaskIfDesign.Checked = value; }
        }


        public string Login
        {
            get { return _login; }
            set { _login = value; cmbCntrlTaskEmployee.Text = value; }
        }


        public string Status
        {
            get { return _status; }
            set { _status = value; cmbCntrlTaskStatus.Text = value; }
        }


        public string Komentarz
        {
            get { return _comment; }
            set { _comment = value; rtxtCntrlTaskComment.Text = value; }
        }


        public string Temat
        {
            get { return _topic; }
            set { _topic = value; txtCntrlTaskTopic.Text = value; }
        }


        private void txtCntrlTaskTopic_TextChanged(object sender, EventArgs e)
        {
            this.Temat = txtCntrlTaskTopic.Text;
        }

        #endregion

        #region Events

        private void rtxtCntrlTaskComment_TextChanged(object sender, EventArgs e)
        {
            this.Komentarz = rtxtCntrlTaskComment.Text;
            rtxtCntrlTaskComment.SelectionStart = rtxtCntrlTaskComment.Text.Length;
            rtxtCntrlTaskComment.ScrollToCaret();
        }

        private void cbCntrlTaskIfDesign_CheckedChanged(object sender, EventArgs e)
        {
            this.Design = cbCntrlTaskIfDesign.Checked;
        }

        private void cmbCntrlTaskStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Status = cmbCntrlTaskStatus.Text;
        }

        private void cmbCntrlTaskEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Login = cmbCntrlTaskEmployee.Text;
            string name = this.Login.Remove(this.Login.IndexOf(" "));
            string surname = this.Login.Remove(0, this.Login.IndexOf(" ")+1);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                var query = "SELECT id FROM EmployeeTab WHERE Name = '" + name + "' AND Surname = '" + surname + "'";
                SqlDataAdapter sqlData = new SqlDataAdapter(query, connection);
                connection.Close();
                DataTable tb = new DataTable();
                sqlData.Fill(tb);
                if (tb.Rows.Count == 1)
                {
                    DataRow row = tb.Rows[0];
                    id = Convert.ToInt16(row[0]);
                }
            }
        }

        private void txtCntrlTaskPath_TextChanged(object sender, EventArgs e)
        {
            this.Lokalizacja = txtCntrlTaskPath.Text;
        }
        private void btnDirectoryTaskSearcher_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            folderBrowser.Description = "Podaj ścieżkę do zadania lub dokumentacji";
            folderBrowser.ShowNewFolderButton = true;
            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
            DialogResult result = folderBrowser.ShowDialog();
            if(result == DialogResult.OK)
            {
                txtCntrlTaskPath.Text = folderBrowser.SelectedPath;
            }
        }
        private void btnCntrlTaskAdd_Click(object sender, EventArgs e)
        {
            if (_topic != string.Empty && txtCntrlTaskTopic.Text != "Temat*")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    var query = "INSERT INTO TaskTable (IdEmployee, IfDesign, Topic, Comment, Status, DocPath) VALUES (@idEmployee, @ifDesign, @topic, @comment, @status, @path)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if (id != 0)
                            command.Parameters.AddWithValue("@idEmployee", id);
                        else
                            command.Parameters.AddWithValue("@idEmployee", 0);
                        command.Parameters.AddWithValue("@ifDesign", _ifdesign);
                        command.Parameters.AddWithValue("@topic", _topic);
                        if (_comment != string.Empty)
                            command.Parameters.AddWithValue("@comment", _comment);
                        else
                            command.Parameters.AddWithValue("@comment", string.Empty);
                        if (_status != "Status")
                            command.Parameters.AddWithValue("@status", _status);
                        else
                            command.Parameters.AddWithValue("@status", string.Empty);
                        if (_path != string.Empty)
                            command.Parameters.AddWithValue("@path", _path);
                        else
                            command.Parameters.AddWithValue("@path", string.Empty);

                        connection.Open();
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
                txtCntrlTaskTopic.Text = "Temat*";
                txtCntrlTaskPath.Text = "Ścieżka dokumentacji";
                cbCntrlTaskIfDesign.Checked = false;
                cmbCntrlTaskEmployee.Text = "Zawodnik";
                cmbCntrlTaskStatus.Text = "Zadanie";
                rtxtCntrlTaskComment.Text = "Dodano nowe zadanie";
            }

        }
        #endregion
    }
}
