namespace EfFormExample
{
    partial class AddRoleForm
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
            this.AddRole_gbx = new System.Windows.Forms.GroupBox();
            this.roleName_txt = new System.Windows.Forms.TextBox();
            this.addRoleMessage_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AddRole_btn = new System.Windows.Forms.Button();
            this.role_img = new System.Windows.Forms.PictureBox();
            this.SelectImage_btn = new System.Windows.Forms.Button();
            this.status_chck = new System.Windows.Forms.CheckBox();
            this.AddRoleClose_btn = new System.Windows.Forms.Button();
            this.AddRole_gbx.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.role_img)).BeginInit();
            this.SuspendLayout();
            // 
            // AddRole_gbx
            // 
            this.AddRole_gbx.Controls.Add(this.AddRoleClose_btn);
            this.AddRole_gbx.Controls.Add(this.roleName_txt);
            this.AddRole_gbx.Controls.Add(this.addRoleMessage_lbl);
            this.AddRole_gbx.Controls.Add(this.label6);
            this.AddRole_gbx.Controls.Add(this.AddRole_btn);
            this.AddRole_gbx.Controls.Add(this.role_img);
            this.AddRole_gbx.Controls.Add(this.SelectImage_btn);
            this.AddRole_gbx.Controls.Add(this.status_chck);
            this.AddRole_gbx.Location = new System.Drawing.Point(12, 24);
            this.AddRole_gbx.Name = "AddRole_gbx";
            this.AddRole_gbx.Size = new System.Drawing.Size(203, 400);
            this.AddRole_gbx.TabIndex = 1;
            this.AddRole_gbx.TabStop = false;
            this.AddRole_gbx.Text = "Add Role";
            // 
            // roleName_txt
            // 
            this.roleName_txt.Location = new System.Drawing.Point(9, 60);
            this.roleName_txt.Name = "roleName_txt";
            this.roleName_txt.Size = new System.Drawing.Size(149, 20);
            this.roleName_txt.TabIndex = 15;
            // 
            // addRoleMessage_lbl
            // 
            this.addRoleMessage_lbl.AutoSize = true;
            this.addRoleMessage_lbl.Location = new System.Drawing.Point(27, 334);
            this.addRoleMessage_lbl.Name = "addRoleMessage_lbl";
            this.addRoleMessage_lbl.Size = new System.Drawing.Size(50, 13);
            this.addRoleMessage_lbl.TabIndex = 5;
            this.addRoleMessage_lbl.Text = "Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Role Name";
            // 
            // AddRole_btn
            // 
            this.AddRole_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.AddRole_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRole_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddRole_btn.Location = new System.Drawing.Point(30, 285);
            this.AddRole_btn.Name = "AddRole_btn";
            this.AddRole_btn.Size = new System.Drawing.Size(149, 34);
            this.AddRole_btn.TabIndex = 3;
            this.AddRole_btn.Text = "Add Role";
            this.AddRole_btn.UseVisualStyleBackColor = false;
            this.AddRole_btn.Click += new System.EventHandler(this.AddRole_btn_Click);
            // 
            // role_img
            // 
            this.role_img.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.role_img.Location = new System.Drawing.Point(6, 127);
            this.role_img.Name = "role_img";
            this.role_img.Size = new System.Drawing.Size(149, 102);
            this.role_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.role_img.TabIndex = 4;
            this.role_img.TabStop = false;
            // 
            // SelectImage_btn
            // 
            this.SelectImage_btn.Location = new System.Drawing.Point(6, 98);
            this.SelectImage_btn.Name = "SelectImage_btn";
            this.SelectImage_btn.Size = new System.Drawing.Size(149, 23);
            this.SelectImage_btn.TabIndex = 2;
            this.SelectImage_btn.Text = "Select Image";
            this.SelectImage_btn.UseVisualStyleBackColor = true;
            this.SelectImage_btn.Click += new System.EventHandler(this.SelectImage_btn_Click);
            // 
            // status_chck
            // 
            this.status_chck.AutoSize = true;
            this.status_chck.Location = new System.Drawing.Point(7, 248);
            this.status_chck.Name = "status_chck";
            this.status_chck.Size = new System.Drawing.Size(56, 17);
            this.status_chck.TabIndex = 2;
            this.status_chck.Text = "Status";
            this.status_chck.UseVisualStyleBackColor = true;
            // 
            // AddRoleClose_btn
            // 
            this.AddRoleClose_btn.BackColor = System.Drawing.Color.Red;
            this.AddRoleClose_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRoleClose_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.AddRoleClose_btn.Location = new System.Drawing.Point(173, 0);
            this.AddRoleClose_btn.Name = "AddRoleClose_btn";
            this.AddRoleClose_btn.Size = new System.Drawing.Size(30, 20);
            this.AddRoleClose_btn.TabIndex = 17;
            this.AddRoleClose_btn.Text = "x";
            this.AddRoleClose_btn.UseVisualStyleBackColor = false;
            this.AddRoleClose_btn.Click += new System.EventHandler(this.AddRoleClose_btn_Click);
            // 
            // AddRoleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(231, 450);
            this.ControlBox = false;
            this.Controls.Add(this.AddRole_gbx);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRoleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Role";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddRoleForm_FormClosed);
            this.Load += new System.EventHandler(this.AddRoleForm_Load);
            this.AddRole_gbx.ResumeLayout(false);
            this.AddRole_gbx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.role_img)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AddRole_gbx;
        private System.Windows.Forms.TextBox roleName_txt;
        private System.Windows.Forms.Label addRoleMessage_lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AddRole_btn;
        private System.Windows.Forms.PictureBox role_img;
        private System.Windows.Forms.Button SelectImage_btn;
        private System.Windows.Forms.CheckBox status_chck;
        private System.Windows.Forms.Button AddRoleClose_btn;
    }
}