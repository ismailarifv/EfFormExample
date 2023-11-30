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
    public partial class AddRoleForm : Form
    {
        Functions functions = new Functions();
        RoleCrud roleCrud = new RoleCrud();

        public AddRoleForm()
        {
            InitializeComponent();
        }

        private void SelectImage_btn_Click(object sender, EventArgs e)
        {
            functions.UploadImageBox(role_img);
        }

        private void AddRole_btn_Click(object sender, EventArgs e)
        {
            DialogResult AddQuestion = MessageBox.Show("Rol Eklensin mı?", "Rol ekleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (AddQuestion == DialogResult.Yes)
            {
                Role role = new Role();

                role.Name = roleName_txt.Text;
                role.IsStatus = status_chck.Checked;
                string RoleImage = "";
                string imagePath = @"C:\Users\iarif\OneDrive\Masaüstü\imgs\";
                string defaultImage = "emptyRole.png";
                if (role_img.Image != null)
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
            }
            else
            {
                MessageBox.Show("Rol ekleme iptal edildi");
            }


        }

        private void AddRoleForm_Load(object sender, EventArgs e)
        {
            addRoleMessage_lbl.Visible = false;
        }

        private void AddRoleForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Form Kapanıyor");
             
        }

        private void AddRoleClose_btn_Click(object sender, EventArgs e)
        {
            


            DialogResult CloseQuestion = MessageBox.Show("Form Kapansın mı?", "Form kapatma", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (CloseQuestion == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
