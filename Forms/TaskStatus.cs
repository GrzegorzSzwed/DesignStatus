using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managment_Tool
{
    public partial class TaskStatus : Form
    {
        //dgv conversion 
        private int donePosition = 0;
        private int taskNamePosition = 1;
        private int VW370Position = 2;
        private int VW379Position = 3;
        private int VW380Position = 4;


        private string path;
        public TaskStatus()
        {
            InitializeComponent();
        }

        public TaskStatus(string txtPath)
        {
            InitializeComponent();
            var table = new DataTable();
            LoadColumns(table);

            path = txtPath;
            using (var stream = new StreamReader(txtPath))
            {
                var column = 0;
                while (stream.Peek() > -1)
                {
                    var line = stream.ReadLine();
                    if(line!=string.Empty)
                    {
                        var splittedLine = line.Split('|');
                        var row = table.NewRow();

                        row[column++] = splittedLine[donePosition];
                        row[column++] = splittedLine[taskNamePosition];
                        row[column++] = splittedLine[VW370Position];
                        row[column++] = splittedLine[VW379Position];
                        row[column++] = splittedLine[VW380Position];
                        column = 0;

                        table.Rows.Add(row);
                    }
                }
            }
            //txtbox
            var splittedPath = path.Split('\\');
            txtStation.Text = splittedPath[splittedPath.Length - 2].ToString();

            //datagridview
            dgvTaskStatus.DataSource = table;
            dgvTaskStatus.Refresh();
        }

        private void LoadColumns(DataTable table)
        {
            AddColumn(table, typeof(bool), "Status");
            AddColumn(table, typeof(string), "Nazwa");
            AddColumn(table, typeof(bool), "VW370");
            AddColumn(table, typeof(bool), "VW379");
            AddColumn(table, typeof(bool), "VW380");
        }

        private void AddColumn(DataTable table, Type type, string v)
        {
            var column = new DataColumn(v, type);
            table.Columns.Add(column);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //clear all text
            File.WriteAllText(path, string.Empty);

            try
            {
                using (var stream = new StreamWriter(path))
                {
                    foreach (DataGridViewRow row in dgvTaskStatus.Rows)
                    {
                        var newLine = string.Format("{0}|{1}|{2}|{3}|{4}", row.Cells[donePosition].Value.ToString(), row.Cells[taskNamePosition].Value.ToString(), row.Cells[VW370Position].Value.ToString(), row.Cells[VW379Position].Value.ToString(), row.Cells[VW380Position].Value.ToString());
                        stream.WriteLine(row.Cells[donePosition].Value.ToString() + "|" + row.Cells[taskNamePosition].Value.ToString() + "|" + row.Cells[VW370Position].Value.ToString() + "|" + row.Cells[VW379Position].Value.ToString() + "|" + row.Cells[VW380Position].Value.ToString());
                    }
                }
                MessageBox.Show("Saved.");
            }
            catch
            {
                MessageBox.Show("Something went wrong.");
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void AddNewRow(DataTable table, string line)
        //{
        //    DataRow dataRow = table.NewRow();

        //    var splittedLine = line.Split('|');
        //    var trueOrFalse = false;
        //    if (splittedLine[donePosition] == "true" || splittedLine[donePosition] == "True" || splittedLine[donePosition] == "TRUE")
        //        trueOrFalse = true;
        //    else if (splittedLine[donePosition] == "false" || splittedLine[donePosition] == "False" || splittedLine[donePosition] == "FALSE")
        //        trueOrFalse = false;

        //    dgvTaskStatus.Rows[0].Cells[0].Value = trueOrFalse;
        //    dataRow["Nazwa"] = splittedLine[taskNamePosition];
        //    dataRow["VW370"] = splittedLine[VW370Position];
        //    dataRow["VW379"] = splittedLine[VW379Position];
        //    dataRow["VW380"] = splittedLine[VW380Position];
        //    table.Rows.Add(dataRow);
        //}
    }
}
