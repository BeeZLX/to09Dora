namespace tp08_230610
{
    partial class Form1
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
            this.dgEscola = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dsEscola = new System.Data.DataSet();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.dataColumn4 = new System.Data.DataColumn();
            this.dataColumn5 = new System.Data.DataColumn();
            this.dataColumn6 = new System.Data.DataColumn();
            this.dataColumn7 = new System.Data.DataColumn();
            this.dataColumn8 = new System.Data.DataColumn();
            this.dataColumn9 = new System.Data.DataColumn();
            this.dataColumn10 = new System.Data.DataColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.mtxtNome = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSerie = new System.Windows.Forms.MaskedTextBox();
            this.mtxtMatricula = new System.Windows.Forms.MaskedTextBox();
            this.mtxtPbim = new System.Windows.Forms.MaskedTextBox();
            this.mtxtSbimestre = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTbimestre = new System.Windows.Forms.MaskedTextBox();
            this.mtxtQbimestre = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Pesquisar = new System.Windows.Forms.Label();
            this.cbProcura = new System.Windows.Forms.ComboBox();
            this.mtxtProcura = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.alunosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsEscola = new System.Windows.Forms.BindingSource(this.components);
            this.alunosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mnuExportar = new System.Windows.Forms.MenuStrip();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTXTLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTXTColuna = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bimDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bimDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bimDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEscola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEscola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEscola)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).BeginInit();
            this.mnuExportar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEscola
            // 
            this.dgEscola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEscola.Location = new System.Drawing.Point(193, 121);
            this.dgEscola.Name = "dgEscola";
            this.dgEscola.Size = new System.Drawing.Size(1069, 282);
            this.dgEscola.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.serieDataGridViewTextBoxColumn,
            this.matriculaDataGridViewTextBoxColumn,
            this.disciplinaDataGridViewTextBoxColumn,
            this.bimDataGridViewTextBoxColumn,
            this.bimDataGridViewTextBoxColumn1,
            this.bimDataGridViewTextBoxColumn2,
            this.bimDataGridViewTextBoxColumn3,
            this.mediaDataGridViewTextBoxColumn,
            this.situacaoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alunosBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(206, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1046, 256);
            this.dataGridView1.TabIndex = 1;
            // 
            // dsEscola
            // 
            this.dsEscola.DataSetName = "NewDataSet";
            this.dsEscola.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10});
            this.dataTable1.TableName = "Alunos";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Nome";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "Serie";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Matricula";
            // 
            // dataColumn4
            // 
            this.dataColumn4.ColumnName = "Disciplina";
            // 
            // dataColumn5
            // 
            this.dataColumn5.ColumnName = "1Bim";
            // 
            // dataColumn6
            // 
            this.dataColumn6.ColumnName = "2Bim";
            // 
            // dataColumn7
            // 
            this.dataColumn7.ColumnName = "3Bim";
            // 
            // dataColumn8
            // 
            this.dataColumn8.ColumnName = "4Bim";
            // 
            // dataColumn9
            // 
            this.dataColumn9.ColumnName = "Media";
            // 
            // dataColumn10
            // 
            this.dataColumn10.ColumnName = "Situacao";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Série:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Matricula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "1 Bimestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "2 Bimestre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "3 Bimestre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "4 Bimestre";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1139, 427);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(90, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // mtxtNome
            // 
            this.mtxtNome.Location = new System.Drawing.Point(69, 45);
            this.mtxtNome.Name = "mtxtNome";
            this.mtxtNome.Size = new System.Drawing.Size(100, 20);
            this.mtxtNome.TabIndex = 10;
            // 
            // mtxtSerie
            // 
            this.mtxtSerie.Location = new System.Drawing.Point(69, 87);
            this.mtxtSerie.Name = "mtxtSerie";
            this.mtxtSerie.Size = new System.Drawing.Size(100, 20);
            this.mtxtSerie.TabIndex = 11;
            // 
            // mtxtMatricula
            // 
            this.mtxtMatricula.Location = new System.Drawing.Point(68, 121);
            this.mtxtMatricula.Name = "mtxtMatricula";
            this.mtxtMatricula.Size = new System.Drawing.Size(100, 20);
            this.mtxtMatricula.TabIndex = 12;
            // 
            // mtxtPbim
            // 
            this.mtxtPbim.Location = new System.Drawing.Point(68, 197);
            this.mtxtPbim.Name = "mtxtPbim";
            this.mtxtPbim.Size = new System.Drawing.Size(100, 20);
            this.mtxtPbim.TabIndex = 13;
            // 
            // mtxtSbimestre
            // 
            this.mtxtSbimestre.Location = new System.Drawing.Point(69, 234);
            this.mtxtSbimestre.Name = "mtxtSbimestre";
            this.mtxtSbimestre.Size = new System.Drawing.Size(100, 20);
            this.mtxtSbimestre.TabIndex = 14;
            // 
            // mtxtTbimestre
            // 
            this.mtxtTbimestre.Location = new System.Drawing.Point(68, 269);
            this.mtxtTbimestre.Name = "mtxtTbimestre";
            this.mtxtTbimestre.Size = new System.Drawing.Size(100, 20);
            this.mtxtTbimestre.TabIndex = 15;
            // 
            // mtxtQbimestre
            // 
            this.mtxtQbimestre.Location = new System.Drawing.Point(69, 303);
            this.mtxtQbimestre.Name = "mtxtQbimestre";
            this.mtxtQbimestre.Size = new System.Drawing.Size(100, 20);
            this.mtxtQbimestre.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 65);
            this.button1.TabIndex = 17;
            this.button1.Text = "Registrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pesquisar
            // 
            this.Pesquisar.AutoSize = true;
            this.Pesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.Pesquisar.Location = new System.Drawing.Point(251, 39);
            this.Pesquisar.Name = "Pesquisar";
            this.Pesquisar.Size = new System.Drawing.Size(95, 22);
            this.Pesquisar.TabIndex = 18;
            this.Pesquisar.Text = "Pesquisar:";
            // 
            // cbProcura
            // 
            this.cbProcura.FormattingEnabled = true;
            this.cbProcura.Items.AddRange(new object[] {
            "Disciplina",
            "Serie",
            "Matricula"});
            this.cbProcura.Location = new System.Drawing.Point(367, 39);
            this.cbProcura.Name = "cbProcura";
            this.cbProcura.Size = new System.Drawing.Size(121, 21);
            this.cbProcura.TabIndex = 19;
            // 
            // mtxtProcura
            // 
            this.mtxtProcura.Location = new System.Drawing.Point(514, 39);
            this.mtxtProcura.Name = "mtxtProcura";
            this.mtxtProcura.Size = new System.Drawing.Size(122, 20);
            this.mtxtProcura.TabIndex = 20;
            this.mtxtProcura.TextChanged += new System.EventHandler(this.mtxtProcura_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Disciplina";
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Items.AddRange(new object[] {
            "Portugues",
            "Matematica",
            "Historia",
            "Ciencias",
            "Biologia",
            "Quimica",
            "Fisica"});
            this.cbDisciplina.Location = new System.Drawing.Point(66, 163);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(103, 21);
            this.cbDisciplina.TabIndex = 22;
            this.cbDisciplina.Click += new System.EventHandler(this.cbDisciplina_Click);
            // 
            // alunosBindingSource1
            // 
            this.alunosBindingSource1.DataMember = "Alunos";
            this.alunosBindingSource1.DataSource = this.bsEscola;
            // 
            // bsEscola
            // 
            this.bsEscola.AllowNew = false;
            this.bsEscola.DataSource = this.dsEscola;
            this.bsEscola.Position = 0;
            // 
            // alunosBindingSource
            // 
            this.alunosBindingSource.DataMember = "Alunos";
            this.alunosBindingSource.DataSource = this.bsEscola;
            // 
            // mnuExportar
            // 
            this.mnuExportar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarToolStripMenuItem});
            this.mnuExportar.Location = new System.Drawing.Point(0, 0);
            this.mnuExportar.Name = "mnuExportar";
            this.mnuExportar.Size = new System.Drawing.Size(1296, 24);
            this.mnuExportar.TabIndex = 23;
            this.mnuExportar.Text = "Exportar";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTexto});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // mnuTexto
            // 
            this.mnuTexto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTXTLinha,
            this.mnuTXTColuna});
            this.mnuTexto.Name = "mnuTexto";
            this.mnuTexto.Size = new System.Drawing.Size(180, 22);
            this.mnuTexto.Text = "Texto";
            // 
            // mnuTXTLinha
            // 
            this.mnuTXTLinha.Name = "mnuTXTLinha";
            this.mnuTXTLinha.Size = new System.Drawing.Size(180, 22);
            this.mnuTXTLinha.Text = "por Linha";
            this.mnuTXTLinha.Click += new System.EventHandler(this.mnuTXTLinha_Click);
            // 
            // mnuTXTColuna
            // 
            this.mnuTXTColuna.Name = "mnuTXTColuna";
            this.mnuTXTColuna.Size = new System.Drawing.Size(180, 22);
            this.mnuTXTColuna.Text = "por Coluna";
            this.mnuTXTColuna.Click += new System.EventHandler(this.mnuTXTColuna_Click);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // serieDataGridViewTextBoxColumn
            // 
            this.serieDataGridViewTextBoxColumn.DataPropertyName = "Serie";
            this.serieDataGridViewTextBoxColumn.HeaderText = "Serie";
            this.serieDataGridViewTextBoxColumn.Name = "serieDataGridViewTextBoxColumn";
            // 
            // matriculaDataGridViewTextBoxColumn
            // 
            this.matriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.HeaderText = "Matricula";
            this.matriculaDataGridViewTextBoxColumn.Name = "matriculaDataGridViewTextBoxColumn";
            // 
            // disciplinaDataGridViewTextBoxColumn
            // 
            this.disciplinaDataGridViewTextBoxColumn.DataPropertyName = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.HeaderText = "Disciplina";
            this.disciplinaDataGridViewTextBoxColumn.Name = "disciplinaDataGridViewTextBoxColumn";
            // 
            // bimDataGridViewTextBoxColumn
            // 
            this.bimDataGridViewTextBoxColumn.DataPropertyName = "1Bim";
            this.bimDataGridViewTextBoxColumn.HeaderText = "1Bim";
            this.bimDataGridViewTextBoxColumn.Name = "bimDataGridViewTextBoxColumn";
            // 
            // bimDataGridViewTextBoxColumn1
            // 
            this.bimDataGridViewTextBoxColumn1.DataPropertyName = "2Bim";
            this.bimDataGridViewTextBoxColumn1.HeaderText = "2Bim";
            this.bimDataGridViewTextBoxColumn1.Name = "bimDataGridViewTextBoxColumn1";
            // 
            // bimDataGridViewTextBoxColumn2
            // 
            this.bimDataGridViewTextBoxColumn2.DataPropertyName = "3Bim";
            this.bimDataGridViewTextBoxColumn2.HeaderText = "3Bim";
            this.bimDataGridViewTextBoxColumn2.Name = "bimDataGridViewTextBoxColumn2";
            // 
            // bimDataGridViewTextBoxColumn3
            // 
            this.bimDataGridViewTextBoxColumn3.DataPropertyName = "4Bim";
            this.bimDataGridViewTextBoxColumn3.HeaderText = "4Bim";
            this.bimDataGridViewTextBoxColumn3.Name = "bimDataGridViewTextBoxColumn3";
            // 
            // mediaDataGridViewTextBoxColumn
            // 
            this.mediaDataGridViewTextBoxColumn.DataPropertyName = "Media";
            this.mediaDataGridViewTextBoxColumn.HeaderText = "Media";
            this.mediaDataGridViewTextBoxColumn.Name = "mediaDataGridViewTextBoxColumn";
            // 
            // situacaoDataGridViewTextBoxColumn
            // 
            this.situacaoDataGridViewTextBoxColumn.DataPropertyName = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.HeaderText = "Situacao";
            this.situacaoDataGridViewTextBoxColumn.Name = "situacaoDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 450);
            this.Controls.Add(this.cbDisciplina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtxtProcura);
            this.Controls.Add(this.cbProcura);
            this.Controls.Add(this.Pesquisar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mtxtQbimestre);
            this.Controls.Add(this.mtxtTbimestre);
            this.Controls.Add(this.mtxtSbimestre);
            this.Controls.Add(this.mtxtPbim);
            this.Controls.Add(this.mtxtMatricula);
            this.Controls.Add(this.mtxtSerie);
            this.Controls.Add(this.mtxtNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dgEscola);
            this.Controls.Add(this.mnuExportar);
            this.MainMenuStrip = this.mnuExportar;
            this.Name = "Form1";
            this.Text = "Registro Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.dgEscola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsEscola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEscola)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alunosBindingSource)).EndInit();
            this.mnuExportar.ResumeLayout(false);
            this.mnuExportar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEscola;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox mtxtNome;
        private System.Windows.Forms.MaskedTextBox mtxtSerie;
        private System.Windows.Forms.MaskedTextBox mtxtMatricula;
        private System.Windows.Forms.MaskedTextBox mtxtPbim;
        private System.Windows.Forms.MaskedTextBox mtxtSbimestre;
        private System.Windows.Forms.MaskedTextBox mtxtTbimestre;
        private System.Windows.Forms.MaskedTextBox mtxtQbimestre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Pesquisar;
        private System.Windows.Forms.ComboBox cbProcura;
        private System.Windows.Forms.MaskedTextBox mtxtProcura;
        private System.Data.DataSet dsEscola;
        private System.Data.DataTable dataTable1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.BindingSource alunosBindingSource1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private System.Data.DataColumn dataColumn4;
        private System.Data.DataColumn dataColumn5;
        private System.Data.DataColumn dataColumn6;
        private System.Data.DataColumn dataColumn7;
        private System.Data.DataColumn dataColumn8;
        private System.Data.DataColumn dataColumn9;
        private System.Windows.Forms.BindingSource bsEscola;
        private System.Windows.Forms.BindingSource alunosBindingSource;
        private System.Data.DataColumn dataColumn10;
        private System.Windows.Forms.MenuStrip mnuExportar;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuTexto;
        private System.Windows.Forms.ToolStripMenuItem mnuTXTLinha;
        private System.Windows.Forms.ToolStripMenuItem mnuTXTColuna;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn serieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn matriculaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn disciplinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bimDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bimDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bimDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacaoDataGridViewTextBoxColumn;
    }
}

