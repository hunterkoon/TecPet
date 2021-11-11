
namespace TecPet.View
{
    partial class Agenda
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
            this.tabelaAgenda = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeRacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agendaCalendar = new System.Windows.Forms.MonthCalendar();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gravarBtn = new System.Windows.Forms.Button();
            this.radioUmidaBtn = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minTextBox = new System.Windows.Forms.TextBox();
            this.horaTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.limparBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAgenda)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabelaAgenda);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 503);
            this.panel1.TabIndex = 0;
            // 
            // tabelaAgenda
            // 
            this.tabelaAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.data,
            this.Hora,
            this.QuantidadeRacao,
            this.umida});
            this.tabelaAgenda.Location = new System.Drawing.Point(12, 275);
            this.tabelaAgenda.Name = "tabelaAgenda";
            this.tabelaAgenda.RowTemplate.Height = 25;
            this.tabelaAgenda.Size = new System.Drawing.Size(473, 216);
            this.tabelaAgenda.TabIndex = 0;
            // 
            // data
            // 
            this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.data.HeaderText = "Data";
            this.data.Name = "data";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // QuantidadeRacao
            // 
            this.QuantidadeRacao.HeaderText = "Quantidade Racao";
            this.QuantidadeRacao.Name = "QuantidadeRacao";
            // 
            // umida
            // 
            this.umida.HeaderText = "Umida";
            this.umida.Name = "umida";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(3, 242);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(482, 258);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamentos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.agendaCalendar);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(3, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 244);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agendar";
            // 
            // agendaCalendar
            // 
            this.agendaCalendar.Location = new System.Drawing.Point(6, 42);
            this.agendaCalendar.Name = "agendaCalendar";
            this.agendaCalendar.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.limparBtn);
            this.groupBox3.Controls.Add(this.gravarBtn);
            this.groupBox3.Controls.Add(this.radioUmidaBtn);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.minTextBox);
            this.groupBox3.Controls.Add(this.horaTextBox);
            this.groupBox3.Controls.Add(this.quantidadeTextBox);
            this.groupBox3.Location = new System.Drawing.Point(245, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 216);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Horário / Quantidade";
            // 
            // gravarBtn
            // 
            this.gravarBtn.Location = new System.Drawing.Point(126, 182);
            this.gravarBtn.Name = "gravarBtn";
            this.gravarBtn.Size = new System.Drawing.Size(105, 23);
            this.gravarBtn.TabIndex = 3;
            this.gravarBtn.Text = "Gravar";
            this.gravarBtn.UseVisualStyleBackColor = true;
            this.gravarBtn.Click += new System.EventHandler(this.gravarBtn_Click);
            // 
            // radioUmidaBtn
            // 
            this.radioUmidaBtn.AutoSize = true;
            this.radioUmidaBtn.Location = new System.Drawing.Point(126, 118);
            this.radioUmidaBtn.Name = "radioUmidaBtn";
            this.radioUmidaBtn.Size = new System.Drawing.Size(99, 19);
            this.radioUmidaBtn.TabIndex = 7;
            this.radioUmidaBtn.Text = "Ração Úmida ";
            this.radioUmidaBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digite Horas : Minutos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // minTextBox
            // 
            this.minTextBox.Location = new System.Drawing.Point(126, 60);
            this.minTextBox.Name = "minTextBox";
            this.minTextBox.PlaceholderText = "MM";
            this.minTextBox.Size = new System.Drawing.Size(100, 23);
            this.minTextBox.TabIndex = 9;
            this.minTextBox.TextChanged += new System.EventHandler(this.minTextBox_TextChanged);
            // 
            // horaTextBox
            // 
            this.horaTextBox.Location = new System.Drawing.Point(20, 60);
            this.horaTextBox.Name = "horaTextBox";
            this.horaTextBox.PlaceholderText = "HH";
            this.horaTextBox.Size = new System.Drawing.Size(100, 23);
            this.horaTextBox.TabIndex = 8;
            this.horaTextBox.TextChanged += new System.EventHandler(this.horaTextBox_TextChanged);
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.quantidadeTextBox.Location = new System.Drawing.Point(20, 140);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.PlaceholderText = "Gramas";
            this.quantidadeTextBox.Size = new System.Drawing.Size(206, 23);
            this.quantidadeTextBox.TabIndex = 5;
            this.quantidadeTextBox.TextChanged += new System.EventHandler(this.quantidadeTextBox_TextChanged);
            // 
            // limparBtn
            // 
            this.limparBtn.BackColor = System.Drawing.Color.Red;
            this.limparBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.limparBtn.ForeColor = System.Drawing.Color.White;
            this.limparBtn.Location = new System.Drawing.Point(20, 182);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(100, 23);
            this.limparBtn.TabIndex = 12;
            this.limparBtn.Text = "Limpar Agenda";
            this.limparBtn.UseVisualStyleBackColor = false;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 503);
            this.Controls.Add(this.panel1);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAgenda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.Button gravarBtn;
        private System.Windows.Forms.MonthCalendar agendaCalendar;
        private System.Windows.Forms.DataGridView tabelaAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeRacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn umida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox radioUmidaBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox minTextBox;
        private System.Windows.Forms.TextBox horaTextBox;
        private System.Windows.Forms.Button limparBtn;
    }
}