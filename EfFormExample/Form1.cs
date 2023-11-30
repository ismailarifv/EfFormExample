using EfFormExample.Entity;
using EfFormExample.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfFormExample
{
    public partial class Form1 : Form
    {
        Functions functions = new Functions();
        public static int id = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            functions.GetRoleListToDgv(RoleDgv);
            functions.GetUserListToDgv(UserDgv);
        }

        private void AddRoleForm_btn_Click(object sender, EventArgs e)
        {
            AddRoleForm addRoleForm = new AddRoleForm();
            addRoleForm.ShowDialog();
        }

        private void AddUserForm_btn_Click(object sender, EventArgs e)
        {
            AddUserForm addUserForm = new AddUserForm();
            addUserForm.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            functions.GetRoleListToDgv(RoleDgv);
            functions.GetUserListToDgv(UserDgv);

        }

        private void UserDgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             id = Convert.ToInt32(UserDgv.CurrentRow.Cells[8].Value);

            UserDetail userDetail = new UserDetail();
            userDetail.ShowDialog();

        }
    }
}
