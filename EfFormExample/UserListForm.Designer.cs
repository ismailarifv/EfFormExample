namespace EfFormExample
{
    partial class UserListForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.userListe_lbl = new System.Windows.Forms.Label();
            this.pictubox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictubox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.pictubox);
            this.panel1.Controls.Add(this.userListe_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 350);
            this.panel2.TabIndex = 1;
            // 
            // userListe_lbl
            // 
            this.userListe_lbl.AutoSize = true;
            this.userListe_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userListe_lbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userListe_lbl.Location = new System.Drawing.Point(318, 21);
            this.userListe_lbl.Name = "userListe_lbl";
            this.userListe_lbl.Size = new System.Drawing.Size(106, 25);
            this.userListe_lbl.TabIndex = 0;
            this.userListe_lbl.Text = "User List";
            // 
            // pictubox
            // 
            this.pictubox.Image = global::EfFormExample.Properties.Resources.userListIco;
            this.pictubox.Location = new System.Drawing.Point(29, 21);
            this.pictubox.Name = "pictubox";
            this.pictubox.Size = new System.Drawing.Size(48, 48);
            this.pictubox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictubox.TabIndex = 1;
            this.pictubox.TabStop = false;
            // 
            // UserListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UserListForm";
            this.Text = "UserListForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserListForm_Load);
            this.SizeChanged += new System.EventHandler(this.UserListForm_SizeChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictubox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label userListe_lbl;
        private System.Windows.Forms.PictureBox pictubox;
    }
}