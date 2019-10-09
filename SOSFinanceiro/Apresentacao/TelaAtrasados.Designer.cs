namespace SOSFinanceiro.Apresentacao
{
    partial class TelaAtrasados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAtrasados));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.despesa = new System.Windows.Forms.RadioButton();
            this.receita = new System.Windows.Forms.RadioButton();
            this.valor = new System.Windows.Forms.NumericUpDown();
            this.adicionar = new System.Windows.Forms.Button();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.dataEfet = new System.Windows.Forms.DateTimePicker();
            this.dataPrev = new System.Windows.Forms.DateTimePicker();
            this.descricao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(105, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "S.O.S Financeiro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // despesa
            // 
            this.despesa.AutoSize = true;
            this.despesa.Enabled = false;
            this.despesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despesa.Location = new System.Drawing.Point(868, 338);
            this.despesa.Name = "despesa";
            this.despesa.Size = new System.Drawing.Size(82, 20);
            this.despesa.TabIndex = 69;
            this.despesa.TabStop = true;
            this.despesa.Text = "Despesa";
            this.despesa.UseVisualStyleBackColor = true;
            // 
            // receita
            // 
            this.receita.AutoSize = true;
            this.receita.Enabled = false;
            this.receita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receita.Location = new System.Drawing.Point(779, 338);
            this.receita.Name = "receita";
            this.receita.Size = new System.Drawing.Size(73, 20);
            this.receita.TabIndex = 68;
            this.receita.TabStop = true;
            this.receita.Text = "Receita";
            this.receita.UseVisualStyleBackColor = true;
            // 
            // valor
            // 
            this.valor.DecimalPlaces = 2;
            this.valor.Enabled = false;
            this.valor.Location = new System.Drawing.Point(779, 407);
            this.valor.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.valor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(167, 20);
            this.valor.TabIndex = 67;
            this.valor.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // adicionar
            // 
            this.adicionar.BackColor = System.Drawing.Color.LimeGreen;
            this.adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionar.ForeColor = System.Drawing.Color.White;
            this.adicionar.Location = new System.Drawing.Point(779, 514);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(167, 43);
            this.adicionar.TabIndex = 64;
            this.adicionar.Text = "Editar";
            this.adicionar.UseVisualStyleBackColor = false;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.tabela.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tabela.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabela.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabela.DefaultCellStyle = dataGridViewCellStyle3;
            this.tabela.GridColor = System.Drawing.Color.LightGray;
            this.tabela.Location = new System.Drawing.Point(23, 159);
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabela.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.tabela.Size = new System.Drawing.Size(734, 398);
            this.tabela.TabIndex = 63;
            this.tabela.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tabela_CellFormatting);
            this.tabela.Click += new System.EventHandler(this.tabela_DoubleClick);
            this.tabela.DoubleClick += new System.EventHandler(this.tabela_DoubleClick);
            // 
            // dataEfet
            // 
            this.dataEfet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataEfet.Location = new System.Drawing.Point(779, 266);
            this.dataEfet.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dataEfet.Name = "dataEfet";
            this.dataEfet.Size = new System.Drawing.Size(167, 20);
            this.dataEfet.TabIndex = 62;
            this.dataEfet.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            // 
            // dataPrev
            // 
            this.dataPrev.Enabled = false;
            this.dataPrev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPrev.Location = new System.Drawing.Point(779, 196);
            this.dataPrev.Name = "dataPrev";
            this.dataPrev.Size = new System.Drawing.Size(167, 20);
            this.dataPrev.TabIndex = 61;
            // 
            // descricao
            // 
            this.descricao.Enabled = false;
            this.descricao.Location = new System.Drawing.Point(779, 476);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(167, 20);
            this.descricao.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(775, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 59;
            this.label7.Text = "Descrição";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(775, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 58;
            this.label5.Text = " Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(775, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 57;
            this.label4.Text = "Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(775, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Data Efetivada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(775, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 70;
            this.label2.Text = "Data Prevista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(319, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 31);
            this.label6.TabIndex = 71;
            this.label6.Text = "Lançamentos Atrasados";
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.Red;
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.White;
            this.voltar.Location = new System.Drawing.Point(23, 586);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(119, 31);
            this.voltar.TabIndex = 73;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // TelaAtrasados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1012, 642);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.despesa);
            this.Controls.Add(this.receita);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.dataEfet);
            this.Controls.Add(this.dataPrev);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaAtrasados";
            this.Text = "S.O.S Financeiro - Tela Atrasados";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton despesa;
        private System.Windows.Forms.RadioButton receita;
        private System.Windows.Forms.NumericUpDown valor;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.DateTimePicker dataEfet;
        private System.Windows.Forms.DateTimePicker dataPrev;
        private System.Windows.Forms.TextBox descricao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button voltar;
    }
}