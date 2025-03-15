namespace TeamProject
{
    partial class LoginPage
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
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.password_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.username_input = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.AutoRoundedCorners = true;
            this.LoginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(482, 259);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(200, 45);
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Login";
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // password_input
            // 
            this.password_input.Animated = true;
            this.password_input.AutoRoundedCorners = true;
            this.password_input.BorderRadius = 17;
            this.password_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_input.DefaultText = "";
            this.password_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_input.Location = new System.Drawing.Point(482, 176);
            this.password_input.Name = "password_input";
            this.password_input.PlaceholderText = "Passowrd";
            this.password_input.SelectedText = "";
            this.password_input.Size = new System.Drawing.Size(200, 36);
            this.password_input.TabIndex = 1;
            this.password_input.UseSystemPasswordChar = true;
            this.password_input.TextChanged += new System.EventHandler(this.password_input_TextChanged);
            this.password_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.guna2TextBoxPassword_KeyDown);
            // 
            // username_input
            // 
            this.username_input.Animated = true;
            this.username_input.AutoRoundedCorners = true;
            this.username_input.BorderRadius = 17;
            this.username_input.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_input.DefaultText = "";
            this.username_input.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_input.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_input.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_input.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_input.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_input.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username_input.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_input.Location = new System.Drawing.Point(482, 134);
            this.username_input.Name = "username_input";
            this.username_input.PlaceholderText = "Username";
            this.username_input.SelectedText = "";
            this.username_input.Size = new System.Drawing.Size(200, 36);
            this.username_input.TabIndex = 2;
            this.username_input.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            this.username_input.KeyUp += new System.Windows.Forms.KeyEventHandler(this.guna2TextBoxUsername_KeyUp);
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(482, 218);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 3;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(523, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "show password";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.Controls.Add(this.username_input);
            this.Controls.Add(this.password_input);
            this.Controls.Add(this.LoginButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2TextBox username_input;
        private Guna.UI2.WinForms.Guna2TextBox password_input;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
    }
}

