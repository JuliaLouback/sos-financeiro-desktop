namespace SOSFinanceiro.Apresentacao
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saldos = new System.Windows.Forms.Button();
            this.categorias = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataPrev = new System.Windows.Forms.DateTimePicker();
            this.dataEfet = new System.Windows.Forms.DateTimePicker();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.adicionar = new System.Windows.Forms.Button();
            this.limpar = new System.Windows.Forms.Button();
            this.deletar = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.NumericUpDown();
            this.receita = new System.Windows.Forms.RadioButton();
            this.despesa = new System.Windows.Forms.RadioButton();
            this.atrasados2 = new System.Windows.Forms.Button();
            this.descricao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "S.O.S Financeiro";
            // 
            // saldos
            // 
            this.saldos.BackColor = System.Drawing.Color.Silver;
            this.saldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saldos.Location = new System.Drawing.Point(732, 104);
            this.saldos.Name = "saldos";
            this.saldos.Size = new System.Drawing.Size(101, 34);
            this.saldos.TabIndex = 6;
            this.saldos.Text = "Saldos";
            this.saldos.UseVisualStyleBackColor = false;
            this.saldos.Click += new System.EventHandler(this.saldos_Click);
            // 
            // categorias
            // 
            this.categorias.BackColor = System.Drawing.Color.Silver;
            this.categorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorias.ForeColor = System.Drawing.Color.Black;
            this.categorias.Location = new System.Drawing.Point(847, 104);
            this.categorias.Name = "categorias";
            this.categorias.Size = new System.Drawing.Size(102, 34);
            this.categorias.TabIndex = 8;
            this.categorias.Text = "Pesquisas";
            this.categorias.UseVisualStyleBackColor = false;
            this.categorias.Click += new System.EventHandler(this.categorias_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(774, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Data Prevista";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(774, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Data Efetivada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(774, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(774, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = " Valor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(774, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 24);
            this.label7.TabIndex = 41;
            this.label7.Text = "Descrição";
            // 
            // dataPrev
            // 
            this.dataPrev.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataPrev.Location = new System.Drawing.Point(778, 201);
            this.dataPrev.Name = "dataPrev";
            this.dataPrev.Size = new System.Drawing.Size(167, 20);
            this.dataPrev.TabIndex = 45;
            // 
            // dataEfet
            // 
            this.dataEfet.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataEfet.Location = new System.Drawing.Point(778, 271);
            this.dataEfet.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dataEfet.Name = "dataEfet";
            this.dataEfet.Size = new System.Drawing.Size(167, 20);
            this.dataEfet.TabIndex = 46;
            this.dataEfet.Value = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dataEfet.ValueChanged += new System.EventHandler(this.dataEfet_ValueChanged);
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
            this.tabela.Location = new System.Drawing.Point(22, 164);
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
            this.tabela.Size = new System.Drawing.Size(734, 456);
            this.tabela.TabIndex = 47;
            this.tabela.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tabela_CellFormatting);
            this.tabela.Click += new System.EventHandler(this.tabela_DoubleClick);
            this.tabela.DoubleClick += new System.EventHandler(this.tabela_DoubleClick);
            // 
            // adicionar
            // 
            this.adicionar.BackColor = System.Drawing.Color.LimeGreen;
            this.adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adicionar.ForeColor = System.Drawing.Color.White;
            this.adicionar.Location = new System.Drawing.Point(778, 519);
            this.adicionar.Name = "adicionar";
            this.adicionar.Size = new System.Drawing.Size(167, 43);
            this.adicionar.TabIndex = 48;
            this.adicionar.Text = "Adicionar";
            this.adicionar.UseVisualStyleBackColor = false;
            this.adicionar.Click += new System.EventHandler(this.adicionar_Click);
            // 
            // limpar
            // 
            this.limpar.BackColor = System.Drawing.Color.Orange;
            this.limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limpar.ForeColor = System.Drawing.Color.White;
            this.limpar.Location = new System.Drawing.Point(867, 577);
            this.limpar.Name = "limpar";
            this.limpar.Size = new System.Drawing.Size(78, 43);
            this.limpar.TabIndex = 49;
            this.limpar.Text = "Limpar";
            this.limpar.UseVisualStyleBackColor = false;
            this.limpar.Click += new System.EventHandler(this.limpar_Click);
            // 
            // deletar
            // 
            this.deletar.BackColor = System.Drawing.Color.Red;
            this.deletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletar.ForeColor = System.Drawing.Color.White;
            this.deletar.Location = new System.Drawing.Point(778, 577);
            this.deletar.Name = "deletar";
            this.deletar.Size = new System.Drawing.Size(83, 43);
            this.deletar.TabIndex = 51;
            this.deletar.Text = "Deletar";
            this.deletar.UseVisualStyleBackColor = false;
            this.deletar.Click += new System.EventHandler(this.deletar_Click);
            // 
            // valor
            // 
            this.valor.DecimalPlaces = 2;
            this.valor.Location = new System.Drawing.Point(778, 412);
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
            this.valor.TabIndex = 53;
            this.valor.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // receita
            // 
            this.receita.AutoSize = true;
            this.receita.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receita.Location = new System.Drawing.Point(778, 343);
            this.receita.Name = "receita";
            this.receita.Size = new System.Drawing.Size(73, 20);
            this.receita.TabIndex = 54;
            this.receita.TabStop = true;
            this.receita.Text = "Receita";
            this.receita.UseVisualStyleBackColor = true;
            // 
            // despesa
            // 
            this.despesa.AutoSize = true;
            this.despesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.despesa.Location = new System.Drawing.Point(867, 343);
            this.despesa.Name = "despesa";
            this.despesa.Size = new System.Drawing.Size(82, 20);
            this.despesa.TabIndex = 55;
            this.despesa.TabStop = true;
            this.despesa.Text = "Despesa";
            this.despesa.UseVisualStyleBackColor = true;
            // 
            // atrasados2
            // 
            this.atrasados2.BackColor = System.Drawing.Color.Silver;
            this.atrasados2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atrasados2.Location = new System.Drawing.Point(616, 104);
            this.atrasados2.Name = "atrasados2";
            this.atrasados2.Size = new System.Drawing.Size(101, 34);
            this.atrasados2.TabIndex = 56;
            this.atrasados2.Text = "Atrasados";
            this.atrasados2.UseVisualStyleBackColor = false;
            this.atrasados2.Click += new System.EventHandler(this.atrasados2_Click);
            // 
            // descricao
            // 
            this.descricao.FormattingEnabled = true;
            this.descricao.Items.AddRange(new object[] {
            "Sálario",
            "Aluguel",
            "Luz",
            "Água",
            "Supermercado",
            "Roupas",
            "Rémedio",
            "Passagem",
            "Combustível",
            "Outros"});
            this.descricao.Location = new System.Drawing.Point(778, 483);
            this.descricao.Name = "descricao";
            this.descricao.Size = new System.Drawing.Size(167, 21);
            this.descricao.TabIndex = 57;
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1051, 662);
            this.Controls.Add(this.descricao);
            this.Controls.Add(this.atrasados2);
            this.Controls.Add(this.despesa);
            this.Controls.Add(this.receita);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.deletar);
            this.Controls.Add(this.limpar);
            this.Controls.Add(this.adicionar);
            this.Controls.Add(this.tabela);
            this.Controls.Add(this.dataEfet);
            this.Controls.Add(this.dataPrev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categorias);
            this.Controls.Add(this.saldos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.Text = "S.O.S Financeiro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saldos;
        private System.Windows.Forms.Button categorias;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dataPrev;
        private System.Windows.Forms.DateTimePicker dataEfet;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button adicionar;
        private System.Windows.Forms.Button limpar;
        private System.Windows.Forms.Button deletar;
        private System.Windows.Forms.NumericUpDown valor;
        private System.Windows.Forms.RadioButton receita;
        private System.Windows.Forms.RadioButton despesa;
        private System.Windows.Forms.Button atrasados2;
        private System.Windows.Forms.ComboBox descricao;
    }
}