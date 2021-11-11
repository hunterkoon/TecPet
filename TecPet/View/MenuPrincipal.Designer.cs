
namespace TecPet
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.loginUsuarioTxtBox = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.GroupBox();
            this.primeiroAcesso = new System.Windows.Forms.LinkLabel();
            this.entrarBtn = new System.Windows.Forms.Button();
            this.loginSenhaTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loginUsuarioTxtBox
            // 
            this.loginUsuarioTxtBox.Location = new System.Drawing.Point(18, 64);
            this.loginUsuarioTxtBox.Name = "loginUsuarioTxtBox";
            this.loginUsuarioTxtBox.Size = new System.Drawing.Size(290, 23);
            this.loginUsuarioTxtBox.TabIndex = 1;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.primeiroAcesso);
            this.Login.Controls.Add(this.entrarBtn);
            this.Login.Controls.Add(this.loginSenhaTxtBox);
            this.Login.Controls.Add(this.label2);
            this.Login.Controls.Add(this.loginUsuarioTxtBox);
            this.Login.Controls.Add(this.label1);
            this.Login.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Login.Location = new System.Drawing.Point(12, 256);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(339, 240);
            this.Login.TabIndex = 2;
            this.Login.TabStop = false;
            this.Login.Text = "Login";
            // 
            // primeiroAcesso
            // 
            this.primeiroAcesso.AutoSize = true;
            this.primeiroAcesso.LinkColor = System.Drawing.Color.Black;
            this.primeiroAcesso.Location = new System.Drawing.Point(18, 169);
            this.primeiroAcesso.Name = "primeiroAcesso";
            this.primeiroAcesso.Size = new System.Drawing.Size(96, 15);
            this.primeiroAcesso.TabIndex = 5;
            this.primeiroAcesso.TabStop = true;
            this.primeiroAcesso.Text = "Primeiro Acesso";
            this.primeiroAcesso.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.primeiroAcesso_LinkClicked);
            // 
            // entrarBtn
            // 
            this.entrarBtn.BackColor = System.Drawing.Color.Teal;
            this.entrarBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.entrarBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.entrarBtn.Location = new System.Drawing.Point(233, 165);
            this.entrarBtn.Name = "entrarBtn";
            this.entrarBtn.Size = new System.Drawing.Size(75, 30);
            this.entrarBtn.TabIndex = 4;
            this.entrarBtn.Text = "Entrar";
            this.entrarBtn.UseVisualStyleBackColor = false;
            this.entrarBtn.Click += new System.EventHandler(this.entrarBtn_Click);
            // 
            // loginSenhaTxtBox
            // 
            this.loginSenhaTxtBox.Location = new System.Drawing.Point(18, 124);
            this.loginSenhaTxtBox.Name = "loginSenhaTxtBox";
            this.loginSenhaTxtBox.PasswordChar = '#';
            this.loginSenhaTxtBox.Size = new System.Drawing.Size(290, 23);
            this.loginSenhaTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(18, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuário";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 508);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox loginUsuarioTxtBox;
        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.TextBox loginSenhaTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button entrarBtn;
        private System.Windows.Forms.LinkLabel primeiroAcesso;
    }
}