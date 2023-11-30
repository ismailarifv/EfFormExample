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
        RoleCrud roleCrud = new RoleCrud();
        UserCrud userCrud = new UserCrud();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addRoleMessage_lbl.Visible = false;
            GetRoleListToCmbx();
            GetUserListToDgv();
        }

        private void AddRole_btn_Click(object sender, EventArgs e)
        {
            Role role = new Role();

            role.Name = roleName_txt.Text;
            role.IsStatus = status_chck.Checked;
            string RoleImage = "";
            string imagePath = @"C:\Users\iarif\OneDrive\Masaüstü\imgs\";
            string defaultImage = "emptyRole.png";
            if(role_img.Image != null)
            {
                
                string imageName = Guid.NewGuid() + ".jpg";
                role_img.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                RoleImage = imagePath + imageName;
            }
            else
            {
                RoleImage = imagePath + defaultImage;
            }
            role.Image = RoleImage;
            addRoleMessage_lbl.Text = roleCrud.Add(role) ? "Role Ekleme Başarılı" : "Role Ekleme Başarısız";
            roleName_txt.Clear();
            status_chck.Checked = false;
            role_img.Image = null;
            GetRoleListToCmbx();
        }

        private void SelectImage_btn_Click(object sender, EventArgs e)
        {
            UploadImageBox(role_img);
        }

        private void userimg_btn_Click(object sender, EventArgs e)
        {
            UploadImageBox(UserImg);
        }

        public void UploadImageBox(PictureBox picture)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               picture.ImageLocation= openFileDialog.FileName;
            }
        }

        private void UserAdd_btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = userName_txt.Text;
            user.Surname = userSurname_txt.Text;
            user.Email= userEmail_txt.Text;
            user.Password = userPassword_txt.Text;
            user.IsStatus = userStatus_chbx.Checked;
            user.RoleId =Convert.ToInt32(userRole_cmbx.SelectedValue);

            string UserImage = "";
            string imagePath = @"C:\Users\iarif\OneDrive\Masaüstü\imgs\";
            string defaultImage = "emptyRole.png";
            if (UserImg.Image != null)
            {

                string imageName = Guid.NewGuid() + ".jpg";
                UserImg.Image.Save(imagePath + imageName, ImageFormat.Jpeg);
                UserImage = imagePath + imageName;
            }
            else
            {
                UserImage = imagePath + defaultImage;
            }
            user.Image = UserImage;
            UserAddMessage_lbl.Text = userCrud.Add(user) ? "User Ekleme Başarılı" : "User Ekleme Başarısız";
            userName_txt.Clear();
            userSurname_txt.Clear();
            userEmail_txt.Clear();
            userPassword_txt.Clear();
            userStatus_chbx.Checked=false;
            UserImg = null;
            GetUserListToDgv();
        }
        public void GetRoleListToCmbx()
        {
            userRole_cmbx.DataSource = roleCrud.GetAll();
            userRole_cmbx.DisplayMember = "Name";
            userRole_cmbx.ValueMember = "Id";

        }
        public void GetUserListToDgv()
        {
          
            UserDgv.DataSource = userCrud.GetAll();
            UserDgv.Columns["Name"].Visible = false;
            UserDgv.Columns["Surname"].Visible = false;
            UserDgv.Columns["IsDelete"].Visible = false;
            UserDgv.Columns["Role"].Visible = false;
        }
    }
}
