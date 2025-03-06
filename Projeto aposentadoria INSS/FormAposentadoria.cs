using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_aposentadoria_INSS
{
    public partial class FormAposentadoria : Form
    {
        public FormAposentadoria()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (cmbSexo.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecione o sexo.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idade;
            if (!int.TryParse(txtIdade.Text, out idade))
            {
                MessageBox.Show("Por favor, insira uma idade válida.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime dataIngresso = dtpIngresso.Value;
            DateTime dataAtual = dtpHoje.Value;

            int anosDeContribuicao = dataAtual.Year - dataIngresso.Year;
            if (dataAtual < dataIngresso.AddYears(anosDeContribuicao))
            {
                anosDeContribuicao--;
            }

            string sexo = cmbSexo.SelectedItem.ToString();

            int idadeMinima, tempoMinimoContribuicao, tempoContribuicaoTotal;

            if (sexo == "Masculino")
            {
                idadeMinima = 65;
                tempoMinimoContribuicao = 20;
                tempoContribuicaoTotal = 35;
            }
            else
            {
                idadeMinima = 62;
                tempoMinimoContribuicao = 15;
                tempoContribuicaoTotal = 30;
            }

            bool podeAposentarPorIdade = idade >= idadeMinima && anosDeContribuicao >= tempoMinimoContribuicao;

            bool podeAposentarPorTempo = anosDeContribuicao >= tempoContribuicaoTotal;

            if (podeAposentarPorIdade)
            {
                lblResultado.Text = "Parabéns! Você pode se aposentar por idade.";
            }
            else if (podeAposentarPorTempo)
            {
                lblResultado.Text = "Parabéns! Você pode se aposentar por tempo de contribuição.";
            }
            else
            {
                int anosFaltandoIdade = Math.Max(0, idadeMinima - idade);
                int anosFaltandoContribuicao = Math.Max(0, tempoMinimoContribuicao - anosDeContribuicao);
                int anosFaltandoTotal = Math.Max(0, tempoContribuicaoTotal - anosDeContribuicao);

                lblResultado.Text = $"Faltam aproximadamente {Math.Max(anosFaltandoIdade, Math.Min(anosFaltandoContribuicao, anosFaltandoTotal))} anos para se aposentar.";
            }
        }


    }
}
