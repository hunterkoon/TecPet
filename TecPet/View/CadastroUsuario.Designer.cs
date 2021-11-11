
namespace TecPet
{
    partial class CadastroUsuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fecharCadastroBtn = new System.Windows.Forms.Button();
            this.cadastrarUsuarioBtn = new System.Windows.Forms.Button();
            this.senhaCadastroTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usuarioCadastroTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nomeCadastroTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fecharCadastroBtn);
            this.groupBox1.Controls.Add(this.cadastrarUsuarioBtn);
            this.groupBox1.Controls.Add(this.senhaCadastroTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.usuarioCadastroTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nomeCadastroTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 272);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Usuário";
            // 
            // fecharCadastroBtn
            // 
            this.fecharCadastroBtn.Location = new System.Drawing.Point(17, 233);
            this.fecharCadastroBtn.Name = "fecharCadastroBtn";
            this.fecharCadastroBtn.Size = new System.Drawing.Size(75, 23);
            this.fecharCadastroBtn.TabIndex = 7;
            this.fecharCadastroBtn.Text = "Fechar";
            this.fecharCadastroBtn.UseVisualStyleBackColor = true;
            this.fecharCadastroBtn.Click += new System.EventHandler(this.fecharCadastroBtn_Click);
            // 
            // cadastrarUsuarioBtn
            // 
            this.cadastrarUsuarioBtn.Location = new System.Drawing.Point(110, 233);
            this.cadastrarUsuarioBtn.Name = "cadastrarUsuarioBtn";
            this.cadastrarUsuarioBtn.Size = new System.Drawing.Size(75, 23);
            this.cadastrarUsuarioBtn.TabIndex = 6;
            this.cadastrarUsuarioBtn.Text = "Cadastrar";
            this.cadastrarUsuarioBtn.UseVisualStyleBackColor = true;
            this.cadastrarUsuarioBtn.Click += new System.EventHandler(this.cadastrarUsuarioBtn_Click);
            // 
            // senhaCadastroTextBox
            // 
            this.senhaCadastroTextBox.Location = new System.Drawing.Point(17, 177);
            this.senhaCadastroTextBox.Name = "senhaCadastroTextBox";
            this.senhaCadastroTextBox.PasswordChar = '#';
            this.senhaCadastroTextBox.Size = new System.Drawing.Size(168, 23);
            this.senhaCadastroTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Senha";
            // 
            // usuarioCadastroTextBox
            // 
            this.usuarioCadastroTextBox.Location = new System.Drawing.Point(17, 119);
            this.usuarioCadastroTextBox.Name = "usuarioCadastroTextBox";
            this.usuarioCadastroTextBox.Size = new System.Drawing.Size(168, 23);
            this.usuarioCadastroTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // nomeCadastroTextBox
            // 
            this.nomeCadastroTextBox.Location = new System.Drawing.Point(17, 66);
            this.nomeCadastroTextBox.Name = "nomeCadastroTextBox";
            this.nomeCadastroTextBox.Size = new System.Drawing.Size(168, 23);
            this.nomeCadastroTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // CadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 296);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroUsuario";
            this.Text = "CadastroUsuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button fecharCadastroBtn;
        private System.Windows.Forms.Button cadastrarUsuarioBtn;
        private System.Windows.Forms.TextBox senhaCadastroTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usuarioCadastroTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nomeCadastroTextBox;
        private System.Windows.Forms.Label label1;
    }
}