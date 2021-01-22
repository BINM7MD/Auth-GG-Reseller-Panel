
namespace ResellerPanelAuthGG
{
    partial class 登录表单
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(登录表单));
            this.siticoneLabel1 = new Siticone.UI.WinForms.SiticoneLabel();
            this.username = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.password = new Siticone.UI.WinForms.SiticoneMaterialTextBox();
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneCustomGradientPanel1 = new Siticone.UI.WinForms.SiticoneCustomGradientPanel();
            this.siticoneControlBox1 = new Siticone.UI.WinForms.SiticoneControlBox();
            this.siticoneRoundedButton1 = new Siticone.UI.WinForms.SiticoneRoundedButton();
            this.siticoneCustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneLabel1
            // 
            this.siticoneLabel1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneLabel1.Font = new System.Drawing.Font("Microsoft YaHei UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneLabel1.ForeColor = System.Drawing.Color.White;
            this.siticoneLabel1.Location = new System.Drawing.Point(52, 60);
            this.siticoneLabel1.Name = "siticoneLabel1";
            this.siticoneLabel1.Size = new System.Drawing.Size(190, 52);
            this.siticoneLabel1.TabIndex = 1;
            this.siticoneLabel1.Text = "SMILE面板";
            // 
            // username
            // 
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.username.FocusedState.Parent = this.username;
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.HoveredState.BorderColor = System.Drawing.Color.DimGray;
            this.username.HoveredState.Parent = this.username;
            this.username.IconRight = ((System.Drawing.Image)(resources.GetObject("username.IconRight")));
            this.username.Location = new System.Drawing.Point(49, 150);
            this.username.Margin = new System.Windows.Forms.Padding(12);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.username.PlaceholderText = "代理名称";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(198, 21);
            this.username.TabIndex = 7;
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.password.FocusedState.Parent = this.password;
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HoveredState.BorderColor = System.Drawing.Color.DimGray;
            this.password.HoveredState.Parent = this.password;
            this.password.IconRight = ((System.Drawing.Image)(resources.GetObject("password.IconRight")));
            this.password.Location = new System.Drawing.Point(49, 179);
            this.password.Margin = new System.Windows.Forms.Padding(12);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.password.PlaceholderText = "代理密码";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(198, 27);
            this.password.TabIndex = 8;
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.siticoneCustomGradientPanel1;
            // 
            // siticoneCustomGradientPanel1
            // 
            this.siticoneCustomGradientPanel1.Controls.Add(this.siticoneLabel1);
            this.siticoneCustomGradientPanel1.FillColor = System.Drawing.Color.DodgerBlue;
            this.siticoneCustomGradientPanel1.FillColor2 = System.Drawing.Color.BlueViolet;
            this.siticoneCustomGradientPanel1.FillColor3 = System.Drawing.Color.DarkOrchid;
            this.siticoneCustomGradientPanel1.FillColor4 = System.Drawing.Color.Navy;
            this.siticoneCustomGradientPanel1.Location = new System.Drawing.Point(-3, -11);
            this.siticoneCustomGradientPanel1.Name = "siticoneCustomGradientPanel1";
            this.siticoneCustomGradientPanel1.ShadowDecoration.Parent = this.siticoneCustomGradientPanel1;
            this.siticoneCustomGradientPanel1.Size = new System.Drawing.Size(328, 146);
            this.siticoneCustomGradientPanel1.TabIndex = 18;
            // 
            // siticoneControlBox1
            // 
            this.siticoneControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneControlBox1.ControlBoxStyle = Siticone.UI.WinForms.Enums.ControlBoxStyle.Custom;
            this.siticoneControlBox1.FillColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White;
            this.siticoneControlBox1.HoveredState.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.IconColor = System.Drawing.Color.Gray;
            this.siticoneControlBox1.Location = new System.Drawing.Point(-3, 245);
            this.siticoneControlBox1.Margin = new System.Windows.Forms.Padding(6);
            this.siticoneControlBox1.Name = "siticoneControlBox1";
            this.siticoneControlBox1.ShadowDecoration.Parent = this.siticoneControlBox1;
            this.siticoneControlBox1.Size = new System.Drawing.Size(40, 27);
            this.siticoneControlBox1.TabIndex = 17;
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.SystemColors.HotTrack;
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoveredState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(49, 212);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(190, 24);
            this.siticoneRoundedButton1.TabIndex = 19;
            this.siticoneRoundedButton1.Text = "登录";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // 登录表单
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 270);
            this.Controls.Add(this.siticoneRoundedButton1);
            this.Controls.Add(this.siticoneCustomGradientPanel1);
            this.Controls.Add(this.siticoneControlBox1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "登录表单";
            this.Text = "登录表单";
            this.Load += new System.EventHandler(this.登录表单_Load);
            this.siticoneCustomGradientPanel1.ResumeLayout(false);
            this.siticoneCustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Siticone.UI.WinForms.SiticoneLabel siticoneLabel1;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox username;
        private Siticone.UI.WinForms.SiticoneMaterialTextBox password;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private Siticone.UI.WinForms.SiticoneControlBox siticoneControlBox1;
        private Siticone.UI.WinForms.SiticoneCustomGradientPanel siticoneCustomGradientPanel1;
        private Siticone.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
    }
}

