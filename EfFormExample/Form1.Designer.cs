namespace EfFormExample
{
    partial class Form1
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
            this.UserDgv = new System.Windows.Forms.DataGridView();
            this.AddUserForm_btn = new System.Windows.Forms.Button();
            this.AddRoleForm_btn = new System.Windows.Forms.Button();
            this.userList_lbl = new System.Windows.Forms.Label();
            this.RoleDgv = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UserDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDgv
            // 
            this.UserDgv.AllowUserToAddRows = false;
            this.UserDgv.AllowUserToDeleteRows = false;
            this.UserDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDgv.Location = new System.Drawing.Point(12, 23);
            this.UserDgv.Name = "UserDgv";
            this.UserDgv.ReadOnly = true;
            this.UserDgv.Size = new System.Drawing.Size(583, 363);
            this.UserDgv.TabIndex = 2;
            this.UserDgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDgv_CellDoubleClick);
            // 
            // AddUserForm_btn
            // 
            this.AddUserForm_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.AddUserForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddUserForm_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddUserForm_btn.Location = new System.Drawing.Point(439, 406);
            this.AddUserForm_btn.Name = "AddUserForm_btn";
            this.AddUserForm_btn.Size = new System.Drawing.Size(156, 32);
            this.AddUserForm_btn.TabIndex = 20;
            this.AddUserForm_btn.Text = "Add User";
            this.AddUserForm_btn.UseVisualStyleBackColor = false;
            this.AddUserForm_btn.Click += new System.EventHandler(this.AddUserForm_btn_Click);
            // 
            // AddRoleForm_btn
            // 
            this.AddRoleForm_btn.BackColor = System.Drawing.Color.DarkGreen;
            this.AddRoleForm_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddRoleForm_btn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AddRoleForm_btn.Location = new System.Drawing.Point(875, 406);
            this.AddRoleForm_btn.Name = "AddRoleForm_btn";
            this.AddRoleForm_btn.Size = new System.Drawing.Size(136, 32);
            this.AddRoleForm_btn.TabIndex = 17;
            this.AddRoleForm_btn.Text = "Add Role";
            this.AddRoleForm_btn.UseVisualStyleBackColor = false;
            this.AddRoleForm_btn.Click += new System.EventHandler(this.AddRoleForm_btn_Click);
            // 
            // userList_lbl
            // 
            this.userList_lbl.AutoSize = true;
            this.userList_lbl.Location = new System.Drawing.Point(9, 7);
            this.userList_lbl.Name = "userList_lbl";
            this.userList_lbl.Size = new System.Drawing.Size(48, 13);
            this.userList_lbl.TabIndex = 21;
            this.userList_lbl.Text = "User List";
            // 
            // RoleDgv
            // 
            this.RoleDgv.AllowUserToAddRows = false;
            this.RoleDgv.AllowUserToDeleteRows = false;
            this.RoleDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RoleDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RoleDgv.Location = new System.Drawing.Point(625, 23);
            this.RoleDgv.Name = "RoleDgv";
            this.RoleDgv.ReadOnly = true;
            this.RoleDgv.Size = new System.Drawing.Size(386, 363);
            this.RoleDgv.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(625, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Role List";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RoleDgv);
            this.Controls.Add(this.userList_lbl);
            this.Controls.Add(this.AddRoleForm_btn);
            this.Controls.Add(this.AddUserForm_btn);
            this.Controls.Add(this.UserDgv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RoleDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView UserDgv;
        private System.Windows.Forms.Button AddUserForm_btn;
        private System.Windows.Forms.Button AddRoleForm_btn;
        private System.Windows.Forms.Label userList_lbl;
        private System.Windows.Forms.DataGridView RoleDgv;
        private System.Windows.Forms.Label label1;
    }
}

