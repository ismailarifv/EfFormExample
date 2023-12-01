using EfFormExample.Entity;
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
    public partial class UserDetail : Form
    {
        UserCrud userCrud = new UserCrud();
        RoleCrud roleCrud = new RoleCrud();
        public UserDetail()
        {
            InitializeComponent();
        }

        private void UserDetail_Load(object sender, EventArgs e)
        {
            int id=Form1.id;
            var user1=userCrud.Get(id);
            pictureBox1.ImageLocation = user1.Image;
            UserFullName_lbl.Text += user1.FullName;

            userName_lbl.Text = user1.Name;
            userSurname_lbl.Text=user1.Surname;
            UserEmail_lbl.Text = user1.Email;
            UserRole_lbl.Text = roleCrud.Get(user1.RoleId).Name;
            UserStatu_lbl.Text = user1.IsStatus ? "Active" : "Passive";
            UserStatu_lbl.ForeColor = user1.IsStatus ? Color.Green : Color.Red; 
        }

        private void userName_lbl_Click(object sender, EventArgs e)
        {

        }
    }
}
