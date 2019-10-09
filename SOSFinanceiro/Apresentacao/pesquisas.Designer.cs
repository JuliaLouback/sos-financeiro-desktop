namespace SOSFinanceiro.Apresentacao
{
    partial class pesquisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisas));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pesquisarDia = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pesquisaDias = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.pesquisarMes = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pesquisarPeriodo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.inicio = new System.Windows.Forms.DateTimePicker();
            this.final = new System.Windows.Forms.DateTimePicker();
            this.tabelas = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.voltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaDias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "S.O.S Financeiro";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 73);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pesquisarDia
            // 
            this.pesquisarDia.BackColor = System.Drawing.Color.Silver;
            this.pesquisarDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarDia.ForeColor = System.Drawing.Color.Black;
            this.pesquisarDia.Location = new System.Drawing.Point(450, 163);
            this.pesquisarDia.Name = "pesquisarDia";
            this.pesquisarDia.Size = new System.Drawing.Size(119, 31);
            this.pesquisarDia.TabIndex = 53;
            this.pesquisarDia.Text = "Pesquisar";
            this.pesquisarDia.UseVisualStyleBackColor = false;
            this.pesquisarDia.Click += new System.EventHandler(this.pesquisarDia_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 55;
            this.label2.Text = "Pesquisar por Dia";
            // 
            // pesquisaDias
            // 
            this.pesquisaDias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisaDias.Location = new System.Drawing.Point(252, 165);
            this.pesquisaDias.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.pesquisaDias.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.pesquisaDias.Name = "pesquisaDias";
            this.pesquisaDias.Size = new System.Drawing.Size(165, 29);
            this.pesquisaDias.TabIndex = 56;
            this.pesquisaDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 24);
            this.label3.TabIndex = 58;
            this.label3.Text = "Pesquisar por Mês";
            // 
            // pesquisarMes
            // 
            this.pesquisarMes.BackColor = System.Drawing.Color.Silver;
            this.pesquisarMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarMes.ForeColor = System.Drawing.Color.Black;
            this.pesquisarMes.Location = new System.Drawing.Point(450, 223);
            this.pesquisarMes.Name = "pesquisarMes";
            this.pesquisarMes.Size = new System.Drawing.Size(119, 31);
            this.pesquisarMes.TabIndex = 57;
            this.pesquisarMes.Text = "Pesquisar";
            this.pesquisarMes.UseVisualStyleBackColor = false;
            this.pesquisarMes.Click += new System.EventHandler(this.pesquisarMes_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 24);
            this.label4.TabIndex = 60;
            this.label4.Text = "Pesquisar por Período";
            // 
            // pesquisarPeriodo
            // 
            this.pesquisarPeriodo.BackColor = System.Drawing.Color.Silver;
            this.pesquisarPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarPeriodo.ForeColor = System.Drawing.Color.Black;
            this.pesquisarPeriodo.Location = new System.Drawing.Point(672, 277);
            this.pesquisarPeriodo.Name = "pesquisarPeriodo";
            this.pesquisarPeriodo.Size = new System.Drawing.Size(119, 31);
            this.pesquisarPeriodo.TabIndex = 63;
            this.pesquisarPeriodo.Text = "Pesquisar";
            this.pesquisarPeriodo.UseVisualStyleBackColor = false;
            this.pesquisarPeriodo.Click += new System.EventHandler(this.pesquisarPeriodo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 24);
            this.label5.TabIndex = 65;
            this.label5.Text = "e";
            // 
            // inicio
            // 
            this.inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inicio.Location = new System.Drawing.Point(252, 279);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(165, 29);
            this.inicio.TabIndex = 66;
            // 
            // final
            // 
            this.final.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.final.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.final.Location = new System.Drawing.Point(487, 279);
            this.final.Name = "final";
            this.final.Size = new System.Drawing.Size(165, 29);
            this.final.TabIndex = 67;
            // 
            // tabelas
            // 
            this.tabelas.AllowUserToAddRows = false;
            this.tabelas.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabelas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabelas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabelas.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabelas.Location = new System.Drawing.Point(35, 331);
            this.tabelas.Name = "tabelas";
            this.tabelas.Size = new System.Drawing.Size(756, 246);
            this.tabelas.TabIndex = 68;
            this.tabelas.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.tabelas_CellFormatting);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(373, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 31);
            this.label6.TabIndex = 69;
            this.label6.Text = "Pesquisas";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.comboBox1.Location = new System.Drawing.Point(252, 225);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(165, 32);
            this.comboBox1.TabIndex = 71;
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.Red;
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.White;
            this.voltar.Location = new System.Drawing.Point(35, 594);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(119, 31);
            this.voltar.TabIndex = 72;
            this.voltar.Text = "Voltar";
            this.voltar.UseVisualStyleBackColor = false;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // pesquisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 659);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabelas);
            this.Controls.Add(this.final);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pesquisarPeriodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pesquisarMes);
            this.Controls.Add(this.pesquisaDias);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pesquisarDia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "pesquisas";
            this.Text = "S.O.S Financeiro - Pesquisas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pesquisaDias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pesquisarDia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown pesquisaDias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pesquisarMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button pesquisarPeriodo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker inicio;
        private System.Windows.Forms.DateTimePicker final;
        private System.Windows.Forms.DataGridView tabelas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button voltar;
    }
}