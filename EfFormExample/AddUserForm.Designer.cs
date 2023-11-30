namespace EfFormExample
{
    partial class AddUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddUser_gbx = new System.Windows.Forms.GroupBox();
            this.userRole_cmbx = new System.Windows.Forms.ComboBox();
            this.UserAddMessage_lbl = new System.Windows.Forms.Label();
            this.userStatus_chbx = new System.Windows.Forms.CheckBox();
            this.UserAdd_btn = new System.Windows.Forms.Button();
            this.UserImg = new System.Windows.Forms.PictureBox();
            this.userimg_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.userPassword_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.userEmail_txt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userSurname_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AddUser_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).BeginInit();
            this.SuspendLayout();
            // 
            // AddUser_gbx
            // 
            this.AddUser_gbx.Controls.Add(this.userRole_cmbx);
            this.AddUser_gbx.Controls.Add(this.UserAddMessage_lbl);
            this.AddUser_gbx.Controls.Add(this.userStatus_chbx);
            this.AddUser_gbx.Controls.Add(this.UserAdd_btn);
            this.AddUser_gbx.Controls.Add(this.UserImg);
            this.AddUser_gbx.Controls.Add(this.userimg_btn);
            this.AddUser_gbx.Controls.Add(this.label5);
            this.AddUser_gbx.Controls.Add(this.userPassword_txt);
            this.AddUser_gbx.Controls.Add(this.label4);
            this.AddUser_gbx.Controls.Add(this.userEmail_txt);
            this.AddUser_gbx.Controls.Add(this.label3);
            this.AddUser_gbx.Controls.Add(this.userSurname_txt);
            this.AddUser_gbx.Controls.Add(this.label2);
            this.AddUser_gbx.Controls.Add(this.userName_txt);
            this.AddUser_gbx.Controls.Add(this.label1);
            this.AddUser_gbx.Location = new System.Drawing.Point(12, 12);
            this.AddUser_gbx.Name = "AddUser_gbx";
            this.AddUser_gbx.Size = new System.Drawing.Size(391, 400);
            this.AddUser_gbx.TabIndex = 2;
            this.AddUser_gbx.TabStop = false;
            this.AddUser_gbx.Text = "Add User";
            // 
            // userRole_cmbx
            // 
            this.userRole_cmbx.FormattingEnabled = true;
            this.userRole_cmbx.Location = new System.Drawing.Point(21, 313);
            this.userRole_cmbx.Name = "userRole_cmbx";
            this.userRole_cmbx.Size = new System.Drawing.Size(121, 21);
            this.userRole_cmbx.TabIndex = 19;
            // 
            // UserAddMessage_lbl
            // 
            this.UserAddMessage_lbl.AutoSize = true;
            this.UserAddMessage_lbl.Location = new System.Drawing.Point(220, 300);
            this.UserAddMessage_lbl.Name = "UserAddMessage_lbl";
            this.UserAddMessage_lbl.Size = new System.Drawing.Size(50, 13);
            this.UserAddMessage_lbl.TabIndex = 18;
            this.UserAddMessage_lbl.Text = "Message";
            // 
            // userStatus_chbx
            // 
            this.userStatus_chbx.AutoSize = true;
            this.userStatus_chbx.Location = new System.Drawing.Point(233, 202);
            this.userStatus_chbx.Name = "userStatus_chbx";
            this.userStatus_chbx.Size = new System.Drawing.Size(56, 17);
            this.userStatus_chbx.TabIndex = 12;
            this.userStatus_chbx.Text = "Status";
            this.userStatus_chbx.UseVisualStyleBackColor = true;
            // 
            // UserAdd_btn
            // 
            this.UserAdd_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.UserAdd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UserAdd_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UserAdd_btn.Location = new System.Drawing.Point(223, 251);
            this.UserAdd_btn.Name = "UserAdd_btn";
            this.UserAdd_btn.Size = new System.Drawing.Size(149, 34);
            this.UserAdd_btn.TabIndex = 17;
            this.UserAdd_btn.Text = "Add User";
            this.UserAdd_btn.UseVisualStyleBackColor = false;
            this.UserAdd_btn.Click += new System.EventHandler(this.UserAdd_btn_Click);
            // 
            // UserImg
            // 
            this.UserImg.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.UserImg.Location = new System.Drawing.Point(232, 81);
            this.UserImg.Name = "UserImg";
            this.UserImg.Size = new System.Drawing.Size(149, 102);
            this.UserImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserImg.TabIndex = 14;
            this.UserImg.TabStop = false;
            // 
            // userimg_btn
            // 
            this.userimg_btn.Location = new System.Drawing.Point(236, 52);
            this.userimg_btn.Name = "userimg_btn";
            this.userimg_btn.Size = new System.Drawing.Size(149, 23);
            this.userimg_btn.TabIndex = 13;
            this.userimg_btn.Text = "Select Image";
            this.userimg_btn.UseVisualStyleBackColor = true;
            this.userimg_btn.Click += new System.EventHandler(this.userimg_btn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Roles";
            // 
            // userPassword_txt
            // 
            this.userPassword_txt.Location = new System.Drawing.Point(21, 244);
            this.userPassword_txt.Name = "userPassword_txt";
            this.userPassword_txt.PasswordChar = '*';
            this.userPassword_txt.Size = new System.Drawing.Size(149, 20);
            this.userPassword_txt.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // userEmail_txt
            // 
            this.userEmail_txt.Location = new System.Drawing.Point(21, 180);
            this.userEmail_txt.Name = "userEmail_txt";
            this.userEmail_txt.Size = new System.Drawing.Size(149, 20);
            this.userEmail_txt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Email";
            // 
            // userSurname_txt
            // 
            this.userSurname_txt.Location = new System.Drawing.Point(21, 129);
            this.userSurname_txt.Name = "userSurname_txt";
            this.userSurname_txt.Size = new System.Drawing.Size(149, 20);
            this.userSurname_txt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Surname";
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(21, 61);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(149, 20);
            this.userName_txt.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 452);
            this.Controls.Add(this.AddUser_gbx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUser";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            this.AddUser_gbx.ResumeLayout(false);
            this.AddUser_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddUser_gbx;
        private System.Windows.Forms.ComboBox userRole_cmbx;
        private System.Windows.Forms.Label UserAddMessage_lbl;
        private System.Windows.Forms.CheckBox userStatus_chbx;
        private System.Windows.Forms.Button UserAdd_btn;
        private System.Windows.Forms.PictureBox UserImg;
        private System.Windows.Forms.Button userimg_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox userPassword_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox userEmail_txt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userSurname_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.Label label1;
    }
}