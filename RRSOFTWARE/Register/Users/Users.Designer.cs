namespace RRSOFTWARE.Register.Users
{
    partial class Users
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
            System.Windows.Forms.Label userIdLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.userIdTextBox = new System.Windows.Forms.TextBox();
            this.usuarioTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Newbutton = new System.Windows.Forms.Button();
            this.Disablebutton = new System.Windows.Forms.Button();
            this.Savebutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.UsererrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            userIdLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UsererrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // userIdLabel
            // 
            userIdLabel.AutoSize = true;
            userIdLabel.Location = new System.Drawing.Point(12, 24);
            userIdLabel.Name = "userIdLabel";
            userIdLabel.Size = new System.Drawing.Size(44, 13);
            userIdLabel.TabIndex = 1;
            userIdLabel.Text = "User Id:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Location = new System.Drawing.Point(12, 50);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(46, 13);
            usuarioLabel.TabIndex = 3;
            usuarioLabel.Text = "Usuario:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(12, 76);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(56, 13);
            passwordLabel.TabIndex = 5;
            passwordLabel.Text = "Password:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 102);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 7;
            nameLabel.Text = "Name:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Location = new System.Drawing.Point(12, 128);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(47, 13);
            apellidoLabel.TabIndex = 9;
            apellidoLabel.Text = "Apellido:";
            // 
            // userIdTextBox
            // 
            this.userIdTextBox.Location = new System.Drawing.Point(74, 21);
            this.userIdTextBox.Name = "userIdTextBox";
            this.userIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.userIdTextBox.TabIndex = 2;
            // 
            // usuarioTextBox
            // 
            this.usuarioTextBox.Location = new System.Drawing.Point(74, 47);
            this.usuarioTextBox.Name = "usuarioTextBox";
            this.usuarioTextBox.Size = new System.Drawing.Size(152, 20);
            this.usuarioTextBox.TabIndex = 4;
            this.usuarioTextBox.TextChanged += new System.EventHandler(this.usuarioTextBox_TextChanged);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(74, 73);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(152, 20);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(74, 99);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(152, 20);
            this.nameTextBox.TabIndex = 8;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.Location = new System.Drawing.Point(74, 125);
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(152, 20);
            this.apellidoTextBox.TabIndex = 10;
            this.apellidoTextBox.TextChanged += new System.EventHandler(this.apellidoTextBox_TextChanged);
            // 
            // Searchbutton
            // 
            this.Searchbutton.Image = ((System.Drawing.Image)(resources.GetObject("Searchbutton.Image")));
            this.Searchbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Searchbutton.Location = new System.Drawing.Point(194, 7);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(88, 34);
            this.Searchbutton.TabIndex = 22;
            this.Searchbutton.Text = "Search";
            this.Searchbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // Newbutton
            // 
            this.Newbutton.Image = ((System.Drawing.Image)(resources.GetObject("Newbutton.Image")));
            this.Newbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Newbutton.Location = new System.Drawing.Point(205, 185);
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(77, 40);
            this.Newbutton.TabIndex = 28;
            this.Newbutton.Text = "New";
            this.Newbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Newbutton.UseVisualStyleBackColor = true;
            this.Newbutton.Click += new System.EventHandler(this.Newbutton_Click);
            // 
            // Disablebutton
            // 
            this.Disablebutton.Image = ((System.Drawing.Image)(resources.GetObject("Disablebutton.Image")));
            this.Disablebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Disablebutton.Location = new System.Drawing.Point(109, 185);
            this.Disablebutton.Name = "Disablebutton";
            this.Disablebutton.Size = new System.Drawing.Size(77, 40);
            this.Disablebutton.TabIndex = 27;
            this.Disablebutton.Text = "Disable";
            this.Disablebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Disablebutton.UseVisualStyleBackColor = true;
            this.Disablebutton.Click += new System.EventHandler(this.Disablebutton_Click);
            // 
            // Savebutton
            // 
            this.Savebutton.Image = ((System.Drawing.Image)(resources.GetObject("Savebutton.Image")));
            this.Savebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebutton.Location = new System.Drawing.Point(12, 184);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(76, 41);
            this.Savebutton.TabIndex = 26;
            this.Savebutton.Text = "Save";
            this.Savebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Buscarbutton.Location = new System.Drawing.Point(46, -109);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(174, 32);
            this.Buscarbutton.TabIndex = 25;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // UsererrorProvider
            // 
            this.UsererrorProvider.ContainerControl = this;
            // 
            // Users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(293, 227);
            this.Controls.Add(this.Newbutton);
            this.Controls.Add(this.Disablebutton);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.Searchbutton);
            this.Controls.Add(userIdLabel);
            this.Controls.Add(this.userIdTextBox);
            this.Controls.Add(usuarioLabel);
            this.Controls.Add(this.usuarioTextBox);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsererrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userIdTextBox;
        private System.Windows.Forms.TextBox usuarioTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Button Newbutton;
        private System.Windows.Forms.Button Disablebutton;
        private System.Windows.Forms.Button Savebutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider UsererrorProvider;
    }
}