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
    public partial class AddUserForm : Form
    {
        Functions functions= new Functions();
        UserCrud userCrud = new UserCrud();
        public AddUserForm()
        {
            InitializeComponent();
        }

        private void userimg_btn_Click(object sender, EventArgs e)
        {
            functions.UploadImageBox(UserImg);
        }

        private void UserAdd_btn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Name = userName_txt.Text;
            user.Surname = userSurname_txt.Text;
            user.Email = userEmail_txt.Text;
            user.Password = userPassword_txt.Text;
            user.IsStatus = userStatus_chbx.Checked;
            user.RoleId = Convert.ToInt32(userRole_cmbx.SelectedValue);

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
            userStatus_chbx.Checked = false;
            UserImg = null;
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            functions.GetRoleListToCmbx(userRole_cmbx);
            UserAddMessage_lbl.Visible = false;
        }
    }
}
