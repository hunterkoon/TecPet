
namespace TecPet
{
    partial class CadastroPet
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroPet));
            this.comboBoxRacas = new System.Windows.Forms.ComboBox();
            this.cbxRacas = new System.Windows.Forms.Label();
            this.erroMenssagem = new System.Windows.Forms.Label();
            this.NomePeLabel = new System.Windows.Forms.Label();
            this.NomePetTextBox = new System.Windows.Forms.TextBox();
            this.IdadePetTextBox = new System.Windows.Forms.TextBox();
            this.IdadePetLabel = new System.Windows.Forms.Label();
            this.PesoPetTextBox = new System.Windows.Forms.TextBox();
            this.PesoPetLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tipoPetCbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picturePetBox = new System.Windows.Forms.PictureBox();
            this.inserirFotoBtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePetBox)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxRacas
            // 
            this.comboBoxRacas.FormattingEnabled = true;
            this.comboBoxRacas.Items.AddRange(new object[] {
            "Sem Raça Definida"});
            this.comboBoxRacas.Location = new System.Drawing.Point(24, 271);
            this.comboBoxRacas.Name = "comboBoxRacas";
            this.comboBoxRacas.Size = new System.Drawing.Size(179, 23);
            this.comboBoxRacas.TabIndex = 0;
            this.comboBoxRacas.SelectedIndexChanged += new System.EventHandler(this.comboBoxRacas_SelectedIndexChanged);
            // 
            // cbxRacas
            // 
            this.cbxRacas.AutoSize = true;
            this.cbxRacas.Location = new System.Drawing.Point(24, 253);
            this.cbxRacas.Name = "cbxRacas";
            this.cbxRacas.Size = new System.Drawing.Size(112, 15);
            this.cbxRacas.TabIndex = 1;
            this.cbxRacas.Text = "Selecione uma Raça";
            // 
            // erroMenssagem
            // 
            this.erroMenssagem.AutoSize = true;
            this.erroMenssagem.ForeColor = System.Drawing.Color.Red;
            this.erroMenssagem.Location = new System.Drawing.Point(27, 163);
            this.erroMenssagem.Name = "erroMenssagem";
            this.erroMenssagem.Size = new System.Drawing.Size(0, 15);
            this.erroMenssagem.TabIndex = 2;
            // 
            // NomePeLabel
            // 
            this.NomePeLabel.AutoSize = true;
            this.NomePeLabel.Location = new System.Drawing.Point(24, 66);
            this.NomePeLabel.Name = "NomePeLabel";
            this.NomePeLabel.Size = new System.Drawing.Size(40, 15);
            this.NomePeLabel.TabIndex = 3;
            this.NomePeLabel.Text = "Nome";
            // 
            // NomePetTextBox
            // 
            this.NomePetTextBox.Location = new System.Drawing.Point(24, 84);
            this.NomePetTextBox.Name = "NomePetTextBox";
            this.NomePetTextBox.Size = new System.Drawing.Size(179, 23);
            this.NomePetTextBox.TabIndex = 4;
            // 
            // IdadePetTextBox
            // 
            this.IdadePetTextBox.Location = new System.Drawing.Point(24, 210);
            this.IdadePetTextBox.Name = "IdadePetTextBox";
            this.IdadePetTextBox.Size = new System.Drawing.Size(62, 23);
            this.IdadePetTextBox.TabIndex = 6;
            // 
            // IdadePetLabel
            // 
            this.IdadePetLabel.AutoSize = true;
            this.IdadePetLabel.Location = new System.Drawing.Point(24, 192);
            this.IdadePetLabel.Name = "IdadePetLabel";
            this.IdadePetLabel.Size = new System.Drawing.Size(39, 15);
            this.IdadePetLabel.TabIndex = 5;
            this.IdadePetLabel.Text = "Idade ";
            // 
            // PesoPetTextBox
            // 
            this.PesoPetTextBox.Location = new System.Drawing.Point(131, 210);
            this.PesoPetTextBox.Name = "PesoPetTextBox";
            this.PesoPetTextBox.Size = new System.Drawing.Size(72, 23);
            this.PesoPetTextBox.TabIndex = 8;
            // 
            // PesoPetLabel
            // 
            this.PesoPetLabel.AutoSize = true;
            this.PesoPetLabel.Location = new System.Drawing.Point(131, 192);
            this.PesoPetLabel.Name = "PesoPetLabel";
            this.PesoPetLabel.Size = new System.Drawing.Size(32, 15);
            this.PesoPetLabel.TabIndex = 7;
            this.PesoPetLabel.Text = "Peso";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.OliveDrab;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(240, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tipoPetCbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.NomePetTextBox);
            this.groupBox1.Controls.Add(this.NomePeLabel);
            this.groupBox1.Controls.Add(this.IdadePetTextBox);
            this.groupBox1.Controls.Add(this.picturePetBox);
            this.groupBox1.Controls.Add(this.PesoPetTextBox);
            this.groupBox1.Controls.Add(this.PesoPetLabel);
            this.groupBox1.Controls.Add(this.inserirFotoBtn);
            this.groupBox1.Controls.Add(this.IdadePetLabel);
            this.groupBox1.Controls.Add(this.cbxRacas);
            this.groupBox1.Controls.Add(this.comboBoxRacas);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 334);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Pet";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selecione um Tipo";
            // 
            // tipoPetCbx
            // 
            this.tipoPetCbx.FormattingEnabled = true;
            this.tipoPetCbx.Items.AddRange(new object[] {
            "Gato",
            "Cachorro",
            "Passaro",
            "Camundongos"});
            this.tipoPetCbx.Location = new System.Drawing.Point(24, 148);
            this.tipoPetCbx.Name = "tipoPetCbx";
            this.tipoPetCbx.Size = new System.Drawing.Size(179, 23);
            this.tipoPetCbx.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Insira uma Foto de Perfil";
            // 
            // picturePetBox
            // 
            this.picturePetBox.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.picturePetBox.Location = new System.Drawing.Point(258, 66);
            this.picturePetBox.Name = "picturePetBox";
            this.picturePetBox.Size = new System.Drawing.Size(130, 130);
            this.picturePetBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturePetBox.TabIndex = 13;
            this.picturePetBox.TabStop = false;
            // 
            // inserirFotoBtn
            // 
            this.inserirFotoBtn.Image = ((System.Drawing.Image)(resources.GetObject("inserirFotoBtn.Image")));
            this.inserirFotoBtn.Location = new System.Drawing.Point(288, 217);
            this.inserirFotoBtn.Name = "inserirFotoBtn";
            this.inserirFotoBtn.Size = new System.Drawing.Size(68, 56);
            this.inserirFotoBtn.TabIndex = 12;
            this.inserirFotoBtn.UseVisualStyleBackColor = true;
            this.inserirFotoBtn.Click += new System.EventHandler(this.inserirFotoBtn_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(107, 364);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // CadastroPet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 422);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.erroMenssagem);
            this.Controls.Add(this.groupBox1);
            this.Name = "CadastroPet";
            this.Text = "Cadastrar Pet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturePetBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRacas;
        private System.Windows.Forms.Label cbxRacas;
        private System.Windows.Forms.Label erroMenssagem;
        private System.Windows.Forms.Label NomePeLabel;
        private System.Windows.Forms.TextBox NomePetTextBox;
        private System.Windows.Forms.TextBox IdadePetTextBox;
        private System.Windows.Forms.Label IdadePetLabel;
        private System.Windows.Forms.TextBox PesoPetTextBox;
        private System.Windows.Forms.Label PesoPetLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox picturePetBox;
        private System.Windows.Forms.Button inserirFotoBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tipoPetCbx;
        private System.Windows.Forms.Label label1;
    }
}

