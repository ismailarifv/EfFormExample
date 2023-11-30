using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfFormExample.Entity
{
    public class Functions
    {
        UserCrud userCrud = new UserCrud();
        RoleCrud roleCrud = new RoleCrud();
        public void UploadImageBox(PictureBox picture)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture.ImageLocation = openFileDialog.FileName;
            }
        }
        public void GetRoleListToCmbx(ComboBox userRole_cmbx)
        {
            userRole_cmbx.DataSource = roleCrud.GetAll();
            userRole_cmbx.DisplayMember = "Name";
            userRole_cmbx.ValueMember = "Id";

        }
        public void GetRoleListToDgv(DataGridView RoleDgv)
        {
            RoleDgv.DataSource = roleCrud.GetAll();
            
        }
        public void GetUserListToDgv(DataGridView UserDgv)
        {

            UserDgv.DataSource = userCrud.GetAll();
            UserDgv.Columns["Name"].Visible = false;
            UserDgv.Columns["Surname"].Visible = false;
            UserDgv.Columns["IsDelete"].Visible = false;
            UserDgv.Columns["Role"].Visible = false;
        }
    }
}
