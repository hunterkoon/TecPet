
namespace TecPet
{
    partial class Cadastro
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxRacas
            // 
            this.comboBoxRacas.FormattingEnabled = true;
            this.comboBoxRacas.Items.AddRange(new object[] {
            "Poddle"});
            this.comboBoxRacas.Location = new System.Drawing.Point(27, 120);
            this.comboBoxRacas.Name = "comboBoxRacas";
            this.comboBoxRacas.Size = new System.Drawing.Size(219, 23);
            this.comboBoxRacas.TabIndex = 0;
            this.comboBoxRacas.SelectedIndexChanged += new System.EventHandler(this.comboBoxRacas_SelectedIndexChanged);
            // 
            // cbxRacas
            // 
            this.cbxRacas.AutoSize = true;
            this.cbxRacas.Location = new System.Drawing.Point(15, 54);
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
            this.NomePeLabel.Location = new System.Drawing.Point(27, 163);
            this.NomePeLabel.Name = "NomePeLabel";
            this.NomePeLabel.Size = new System.Drawing.Size(40, 15);
            this.NomePeLabel.TabIndex = 3;
            this.NomePeLabel.Text = "Nome";
            // 
            // NomePetTextBox
            // 
            this.NomePetTextBox.Location = new System.Drawing.Point(27, 181);
            this.NomePetTextBox.Name = "NomePetTextBox";
            this.NomePetTextBox.Size = new System.Drawing.Size(219, 23);
            this.NomePetTextBox.TabIndex = 4;
            // 
            // IdadePetTextBox
            // 
            this.IdadePetTextBox.Location = new System.Drawing.Point(27, 241);
            this.IdadePetTextBox.Name = "IdadePetTextBox";
            this.IdadePetTextBox.Size = new System.Drawing.Size(62, 23);
            this.IdadePetTextBox.TabIndex = 6;
            // 
            // IdadePetLabel
            // 
            this.IdadePetLabel.AutoSize = true;
            this.IdadePetLabel.Location = new System.Drawing.Point(19, 184);
            this.IdadePetLabel.Name = "IdadePetLabel";
            this.IdadePetLabel.Size = new System.Drawing.Size(39, 15);
            this.IdadePetLabel.TabIndex = 5;
            this.IdadePetLabel.Text = "Idade ";
            // 
            // PesoPetTextBox
            // 
            this.PesoPetTextBox.Location = new System.Drawing.Point(106, 241);
            this.PesoPetTextBox.Name = "PesoPetTextBox";
            this.PesoPetTextBox.Size = new System.Drawing.Size(140, 23);
            this.PesoPetTextBox.TabIndex = 8;
            // 
            // PesoPetLabel
            // 
            this.PesoPetLabel.AutoSize = true;
            this.PesoPetLabel.Location = new System.Drawing.Point(97, 184);
            this.PesoPetLabel.Name = "PesoPetLabel";
            this.PesoPetLabel.Size = new System.Drawing.Size(32, 15);
            this.PesoPetLabel.TabIndex = 7;
            this.PesoPetLabel.Text = "Peso";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cadastrar Pet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.PesoPetLabel);
            this.groupBox1.Controls.Add(this.IdadePetLabel);
            this.groupBox1.Controls.Add(this.cbxRacas);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 356);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Pet";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(159, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Proximo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(124, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 46);
            this.button3.TabIndex = 11;
            this.button3.Text = "Limpar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 422);
            this.Controls.Add(this.PesoPetTextBox);
            this.Controls.Add(this.IdadePetTextBox);
            this.Controls.Add(this.NomePetTextBox);
            this.Controls.Add(this.NomePeLabel);
            this.Controls.Add(this.erroMenssagem);
            this.Controls.Add(this.comboBoxRacas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Cadastrar Pet";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

