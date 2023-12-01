using EfFormExample.Entity;
using EfFormExample.Models;
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
        UserCrud userCrud = new UserCrud();
        RoleCrud roleCrud = new RoleCrud();
        Label UserLbl;
        PictureBox UserImgPB;
        Button UserDetailBtn;
        GroupBox UserGb;
        public static int id = 0;
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

        private void UserListForm_SizeChanged(object sender, EventArgs e)
        {
            int formWidth = (panel1.Width / 2) - (userListe_lbl.Width / 2);
            int formHeight = (panel1.Height / 2) - (userListe_lbl.Height / 2);
            userListe_lbl.Location = new Point(formWidth, formHeight);
            panel2.Controls.Clear();
            UserListingIntoPanel();
        }

        public void UserListingIntoPanel()
        {
            int xStart = 20;
            int yStart = 20;
            int i = 0;
            int y = 0;
            int step = 170;
            int panelWidth = panel2.Width - xStart;
            int UserGbCount = (panelWidth - ((panelWidth - xStart) % step))/step;
            foreach (var user in userCrud.GetAll())
            {
                /*
               string uid = "UserGb_13";
               string[] user_id=uid.Split('_');
               int id = Convert.ToInt32(user_id[user_id.Length - 1]);
               */
                if (i==UserGbCount)
                {
                    yStart +=step+90;
                    i= 0;
                }
                UserGb = new GroupBox()
                {
                    Name = "UserGb_" + user.Id,
                    Text = roleCrud.Get(user.RoleId).Name,
                    Size = new Size(150,240),
                    BackColor=Color.White,
                    Location=new Point(xStart+(step*i),yStart)
                    
                };
                UserImgPB = new PictureBox()
                {
                    Name="UserImgPB_"+user.Id,
                    ImageLocation=user.Image,
                    Size = new Size(120,100),
                    Location=new Point(15,25),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };
                UserLbl = new Label()
                {
                    Name="UserFullName_"+user.Id,
                    Text = user.FullName.ToString(),
                    Location = new Point(15,155),
                };
                UserDetailBtn = new Button()
                {
                    Name = "UserDetailBn_"+user.Id,
                    Text = "Detail",
                    Location = new Point(15,185),
                    Size = new Size(120,40),
                    FlatStyle = FlatStyle.Popup,
                    BackColor=Color.DarkOliveGreen,
                    ForeColor=Color.White,
                    Font= new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)))
            };

                UserDetailBtn.Click += UserDetailBtn_Click;

                UserGb.Controls.Add(UserLbl);
                UserGb.Controls.Add(UserDetailBtn);
                UserGb.Controls.Add(UserImgPB);
               panel2.Controls.Add(UserGb);
                i++;
            }

            
        }

        private void UserDetailBtn_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;
            string btnName = btn.Name;
            string[] btn_id = btnName.Split('_');
            int id = Convert.ToInt32(btn_id[btn_id.Length - 1]);

            Form1.id = id;
            UserDetail userDetail = new UserDetail();
            userDetail.ShowDialog();
        }
    }
}
