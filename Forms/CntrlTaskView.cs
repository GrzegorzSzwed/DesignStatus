using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Managment_Tool.Forms
{
    public partial class CntrlTaskView : UserControl
    {
        public CntrlTaskView(string status)
        {
            InitializeComponent();
            if (status == "TO DO")
                this.BackColor = Color.Coral;
            if (status == "IN WORK")
                this.BackColor = Color.Olive;
            else
                this.BackColor = Color.Teal;
        }

        #region Properties

        private string _comment;
        private string _topic;
        private string _status;
        private string _path;
        private int _id;
        private int _idEmployee;

        public int IDPracownik
        {
            get { return _idEmployee; }
            set { _idEmployee = value; }
        }


        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }


        public string SciezkaDokumentacji
        {
            get { return _path; }
            set { _path = value; }
        }


        public string Status
        {
            get { return _status; }
            set { _status = value; cmbStatus_CntrlTaskView.Text = value; }
        }


        public string Temat
        {
            get { return _topic; }
            set { _topic = value; txtName_CntrlTaskView.Text = value; }
        }


        public string Komentarz
        {
            get { return _comment; }
            set { _comment = value; rtxtComment_CntrlTaskView.Text = value; }
        }

        #endregion

        #region Events


        #endregion


    }
}
