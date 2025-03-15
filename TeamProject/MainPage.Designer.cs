namespace TeamProject
{
    partial class MainPage
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
            this.components = new System.ComponentModel.Container();
            this.logoutbutton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.menuContainer = new System.Windows.Forms.Panel();
            this.menu = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.guna2Panel1.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // logoutbutton
            // 
            this.logoutbutton.Animated = true;
            this.logoutbutton.AutoRoundedCorners = true;
            this.logoutbutton.BackColor = System.Drawing.Color.Transparent;
            this.logoutbutton.BorderRadius = 21;
            this.logoutbutton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.logoutbutton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.logoutbutton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.logoutbutton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.logoutbutton.FillColor = System.Drawing.Color.Transparent;
            this.logoutbutton.ForeColor = System.Drawing.Color.White;
            this.logoutbutton.Location = new System.Drawing.Point(0, 406);
            this.logoutbutton.Name = "logoutbutton";
            this.logoutbutton.Size = new System.Drawing.Size(159, 45);
            this.logoutbutton.TabIndex = 0;
            this.logoutbutton.Text = "Log out";
            this.logoutbutton.UseTransparentBackground = true;
            this.logoutbutton.Click += new System.EventHandler(this.guna2Button1_Click);
            this.logoutbutton.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.logoutbutton.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.menuContainer);
            this.guna2Panel1.Controls.Add(this.logoutbutton);
            this.guna2Panel1.Controls.Add(this.guna2Button4);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.guna2Button3);
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.Desktop;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(159, 451);
            this.guna2Panel1.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.SystemColors.Desktop;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(0, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Home";
            // 
            // guna2Button3
            // 
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.SystemColors.Desktop;
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(0, 100);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(180, 45);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "About";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click_1);
            // 
            // guna2Button4
            // 
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.SystemColors.Desktop;
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(0, 151);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(180, 45);
            this.guna2Button4.TabIndex = 5;
            this.guna2Button4.Text = "Settings";
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuContainer.Controls.Add(this.guna2Button6);
            this.menuContainer.Controls.Add(this.guna2Button5);
            this.menuContainer.Controls.Add(this.menu);
            this.menuContainer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.menuContainer.Location = new System.Drawing.Point(-9, 51);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(168, 45);
            this.menuContainer.TabIndex = 6;
            // 
            // menu
            // 
            this.menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menu.FillColor = System.Drawing.SystemColors.Desktop;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Location = new System.Drawing.Point(9, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(180, 45);
            this.menu.TabIndex = 7;
            this.menu.Text = "Menu";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(0, 51);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(180, 45);
            this.guna2Button5.TabIndex = 8;
            this.guna2Button5.Text = "Sub Menu 1";
            // 
            // guna2Button6
            // 
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(0, 100);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(180, 45);
            this.guna2Button6.TabIndex = 9;
            this.guna2Button6.Text = "Sub Menu 2";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button logoutbutton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private System.Windows.Forms.Panel menuContainer;
        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button menu;
        private System.Windows.Forms.Timer menuTransition;
    }
}