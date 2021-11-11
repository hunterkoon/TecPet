
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
            this.agendaCalendar = new System.Windows.Forms.MonthCalendar();
            this.tabelaAgenda = new System.Windows.Forms.DataGridView();
            this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeRacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.umida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gravarBtn = new System.Windows.Forms.Button();
            this.radioUmidaBtn = new System.Windows.Forms.RadioButton();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAgenda)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.agendaCalendar);
            this.panel1.Controls.Add(this.tabelaAgenda);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 503);
            this.panel1.TabIndex = 0;
            // 
            // agendaCalendar
            // 
            this.agendaCalendar.Location = new System.Drawing.Point(12, 33);
            this.agendaCalendar.Name = "agendaCalendar";
            this.agendaCalendar.TabIndex = 2;
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
            this.tabelaAgenda.Size = new System.Drawing.Size(509, 216);
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
            this.groupBox1.Size = new System.Drawing.Size(527, 258);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamentos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.gravarBtn);
            this.groupBox2.Controls.Add(this.radioUmidaBtn);
            this.groupBox2.Controls.Add(this.quantidadeTextBox);
            this.groupBox2.Location = new System.Drawing.Point(3, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(527, 227);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agendar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Quantidade";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // gravarBtn
            // 
            this.gravarBtn.Location = new System.Drawing.Point(423, 192);
            this.gravarBtn.Name = "gravarBtn";
            this.gravarBtn.Size = new System.Drawing.Size(98, 23);
            this.gravarBtn.TabIndex = 3;
            this.gravarBtn.Text = "Gravar";
            this.gravarBtn.UseVisualStyleBackColor = true;
            this.gravarBtn.Click += new System.EventHandler(this.gravarBtn_Click);
            // 
            // radioUmidaBtn
            // 
            this.radioUmidaBtn.AutoSize = true;
            this.radioUmidaBtn.Location = new System.Drawing.Point(423, 138);
            this.radioUmidaBtn.Name = "radioUmidaBtn";
            this.radioUmidaBtn.Size = new System.Drawing.Size(95, 19);
            this.radioUmidaBtn.TabIndex = 4;
            this.radioUmidaBtn.TabStop = true;
            this.radioUmidaBtn.Text = "Ração Umida";
            this.radioUmidaBtn.UseVisualStyleBackColor = true;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Location = new System.Drawing.Point(248, 163);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.PlaceholderText = "Gramas";
            this.quantidadeTextBox.Size = new System.Drawing.Size(270, 23);
            this.quantidadeTextBox.TabIndex = 5;
            // 
            // Agenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 503);
            this.Controls.Add(this.panel1);
            this.Name = "Agenda";
            this.Text = "Agenda";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaAgenda)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.RadioButton radioUmidaBtn;
        private System.Windows.Forms.Button gravarBtn;
        private System.Windows.Forms.MonthCalendar agendaCalendar;
        private System.Windows.Forms.DataGridView tabelaAgenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeRacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn umida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}