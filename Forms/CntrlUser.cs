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
    public partial class CntrlUser : UserControl
    {
        public CntrlUser()
        {
            InitializeComponent();
        }

        #region Properties
        private string NameUser;
        private string SurnameUser;
        private string MailUser;
        private string PermissionUser;
        private Color ColorUser;

        [Category("Custom Props")]
        public Color GetColor
        {
            get { return ColorUser; }
            set { ColorUser = value; CntrlUserPnl.BackColor = value; }
        }

        [Category("Custom Props")]
        public string Pozwolenie
        {
            get { return PermissionUser; }
            set { PermissionUser = value; CntrlUserLblPermission.Text = value; }
        }

        [Category("Custom Props")]
        public string Mail
        {
            get { return MailUser; }
            set { MailUser = value; CntrlUserLblMail.Text = value; }
        }

        [Category("Custom Props")]
        public string Imie
        {
            get { return NameUser; }
            set { NameUser = value; CntrlUserLblName.Text = value; }
        }

        [Category("Custom Props")]
        public string Nazwisko
        {
            get { return SurnameUser; }
            set { SurnameUser = value; CntrlUserLblSurname.Text = value; }
        }

        #endregion

        private void CntrlUserPnl_MouseEnter(object sender, EventArgs e)
        {
            this.GetColor = Color.Teal;
        }

        private void CntrlUserPnl_MouseLeave(object sender, EventArgs e)
        {
            this.GetColor = Color.PaleTurquoise;
        }
    }
}
