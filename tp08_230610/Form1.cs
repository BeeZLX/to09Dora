using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tp08_230610
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region lixo
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbDisciplina_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void mtxtProcura_TextChanged(object sender, EventArgs e)
        {
            switch (cbProcura.Text)
            {
                case "Disciplina":
                    alunosBindingSource1.Filter = "disciplina like '%" + mtxtProcura.Text.Trim() + "%'";
                    break;
                case "Serie":
                    alunosBindingSource1.Filter = "serie like '%" + mtxtProcura.Text.Trim() + "%'";
                    break;
                case "Matricula":
                    alunosBindingSource1.Filter = "matricula like '%" + mtxtProcura.Text.Trim() + "%'";
                    break;
                default:
                    mtxtProcura.Clear();
                    MessageBox.Show("Escolha uma opção", "Erro");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double nota1 = Convert.ToDouble(mtxtPbim.Text),
                   nota2 = Convert.ToDouble(mtxtSbimestre.Text),
                   nota3 = Convert.ToDouble(mtxtTbimestre.Text),
                   nota4 = Convert.ToDouble(mtxtQbimestre.Text);
            string situacao = "n/a";

            if (nota1 < 0)
            {
                nota1 = 0;
            }
            else if (nota1 > 10)
            {
                nota1 = 10;
            }

            if (nota2 < 0)
            {
                nota2 = 0;
            }
            else if (nota2 > 10)
            {
                nota2 = 10;
            }

            if (nota3 < 0)
            {
                nota3 = 0;
            }
            else if (nota3 > 10)
            {
                nota3 = 10;
            }

            if (nota4 < 0)
            {
                nota4 = 0;
            }
            else if (nota4 > 10)
            {
                nota4 = 10;
            }
            Double media = (nota1 + nota2 + nota3 + nota4) / 4;


            if (mtxtNome.Text.Length > 0 && mtxtPbim.Text.Length > 0 && mtxtSbimestre.Text.Length > 0 && mtxtTbimestre.Text.Length > 0 && mtxtQbimestre.Text.Length > 0
                && mtxtSerie.Text.Length > 0 && mtxtMatricula.Text.Length > 0)
            {

                dgEscola.Enabled = true;
                DataRow novalinha = dsEscola.Tables["Alunos"].NewRow();
                novalinha["Nome"] = mtxtNome.Text.ToString();
                novalinha["Matricula"] = mtxtMatricula.Text.ToString();
                novalinha["Serie"] = mtxtSerie.Text.ToString();
                novalinha["1Bim"] = nota1.ToString();
                novalinha["2Bim"] = nota2.ToString();
                novalinha["3Bim"] = nota3.ToString();
                novalinha["4Bim"] = nota4.ToString();
                novalinha["Media"] = media.ToString("F2");
                novalinha["disciplina"] = cbDisciplina.SelectedItem.ToString();


                if (media >= 6)
                {
                    situacao = "Aprovado";
                }
                else
                {
                    situacao = "Reprovado";
                }
                novalinha["situacao"] = situacao.ToString();

                mtxtNome.Clear();
                mtxtMatricula.Clear();
                mtxtSerie.Clear();
                mtxtPbim.Clear();
                mtxtSbimestre.Clear();
                mtxtTbimestre.Clear();
                mtxtQbimestre.Clear();
                dsEscola.Tables[0].Rows.Add(novalinha);
                dgEscola.Enabled = false;


            }
            else
            {
                MessageBox.Show("Todos os campos tem de estar completos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuTXTLinha_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < dsEscola.Tables["Alunos"].Rows.Count; i++)
                {
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Nome"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Serie"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Matricula"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Disciplina"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["1Bim"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["2Bim"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["3Bim"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["4Bim"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Media"]);
                    SW.WriteLine(dsEscola.Tables["Alunos"].Rows[i]["Situacao"]);
                    SW.WriteLine(string.Empty); 
                }
                SW.Dispose();
            }
        }

        private void mnuTXTColuna_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Arquivo de texto|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter SW = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < dsEscola.Tables["Alunos"].Rows.Count; i++)
                {
                    string Nome = dgEscola.Rows[i].Cells[0].Value.ToString();
                    string Serie = dgEscola.Rows[i].Cells[1].Value.ToString();
                    string Matricula= dgEscola.Rows[i].Cells[2].Value.ToString();
                    string Disciplina = dgEscola.Rows[i].Cells[3].Value.ToString();
                    string Pbim = dgEscola.Rows[i].Cells[4].Value.ToString();
                    string Sbim = dgEscola.Rows[i].Cells[5].Value.ToString();
                    string Tbim = dgEscola.Rows[i].Cells[6].Value.ToString();
                    string Qbim = dgEscola.Rows[i].Cells[7].Value.ToString();
                    string Media = dgEscola.Rows[i].Cells[8].Value.ToString();
                    string Situacao= dgEscola.Rows[i].Cells[9].Value.ToString();
                    SW.WriteLine(Nome + "|" + Serie + "|" + Matricula + "|" + Disciplina+ "|" + Pbim + "|" + Sbim + "|"+Tbim+ "|"+ Qbim+ "|"+Media+ "|"+Situacao);
                    //Raquel minha professora querida, como voce viu na sala, nao sei por qual motivo a coluna nao esta funcionando, ´sendo que esta aparentemente tudo certo
                }
                SW.Dispose();
            }
        }
    }
}
