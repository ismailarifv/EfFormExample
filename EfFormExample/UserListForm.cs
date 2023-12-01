using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfFormExample
{
    public partial class UserListForm : Form
    {
        public UserListForm()
        {
            InitializeComponent();
        }

        private void UserListForm_Load(object sender, EventArgs e)
        {
            int formWidth = (panel1.Width / 2)-(userListe_lbl.Width/2);
            int formHeight = (panel1.Height / 2)-(userListe_lbl.Height/2);
            userListe_lbl.Location = new Point(formWidth, formHeight);
        }
    }
}
