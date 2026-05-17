namespace DemoRASH
{
    partial class Auth
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            pictureLabel = new PictureBox();
            labelName = new Label();
            passwordLabel = new Label();
            loginLabel = new Label();
            textBoxLogin = new TextBox();
            textBoxPassword = new TextBox();
            buttonAuth = new Button();
            buttonGuest = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureLabel).BeginInit();
            SuspendLayout();
            // 
            // pictureLabel
            // 
            pictureLabel.Image = Properties.Resources.Icon;
            pictureLabel.InitialImage = Properties.Resources.Icon;
            pictureLabel.Location = new Point(13, 99);
            pictureLabel.Margin = new Padding(4, 3, 4, 3);
            pictureLabel.Name = "pictureLabel";
            pictureLabel.Size = new Size(161, 138);
            pictureLabel.SizeMode = PictureBoxSizeMode.Zoom;
            pictureLabel.TabIndex = 0;
            pictureLabel.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(298, 30);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(139, 46);
            labelName.TabIndex = 1;
            labelName.Text = "\r\nООО «Обувь»";
            labelName.Click += labelName_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(198, 191);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(76, 23);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Пароль";
            passwordLabel.Click += passwordLabel_Click;
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Location = new Point(198, 136);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(68, 23);
            loginLabel.TabIndex = 3;
            loginLabel.Text = "Логин";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(298, 136);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(196, 30);
            textBoxLogin.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(298, 188);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(196, 30);
            textBoxPassword.TabIndex = 5;
            // 
            // buttonAuth
            // 
            buttonAuth.BackColor = Color.MediumSpringGreen;
            buttonAuth.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAuth.Location = new Point(298, 252);
            buttonAuth.Name = "buttonAuth";
            buttonAuth.Size = new Size(94, 29);
            buttonAuth.TabIndex = 6;
            buttonAuth.Text = "Войти";
            buttonAuth.UseVisualStyleBackColor = false;
            // 
            // buttonGuest
            // 
            buttonGuest.BackColor = Color.MediumSpringGreen;
            buttonGuest.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGuest.Location = new Point(400, 252);
            buttonGuest.Name = "buttonGuest";
            buttonGuest.Size = new Size(94, 29);
            buttonGuest.TabIndex = 7;
            buttonGuest.Text = "Гость";
            buttonGuest.UseVisualStyleBackColor = false;
            // 
            // Auth
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(590, 440);
            Controls.Add(buttonGuest);
            Controls.Add(buttonAuth);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxLogin);
            Controls.Add(loginLabel);
            Controls.Add(passwordLabel);
            Controls.Add(labelName);
            Controls.Add(pictureLabel);
            Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Auth";
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureLabel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureLabel;
        private Label labelName;
        private Label passwordLabel;
        private Label loginLabel;
        private TextBox textBoxLogin;
        private TextBox textBoxPassword;
        private Button buttonAuth;
        private Button buttonGuest;
    }
}
