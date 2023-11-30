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
        public UserDetail()
        {
            InitializeComponent();
        }

        private void UserDetail_Load(object sender, EventArgs e)
        {
            int id=Form1.id;
            var user1=userCrud.Get(id);
            label1.Text = user1.FullName;
            pictureBox1.ImageLocation = user1.Image;

        }
    }
}
