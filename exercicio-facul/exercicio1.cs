using System;
using System.Windows.Forms;

namespace DiaDaSemanaApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int numero;

            // Validação de entrada
            if (!int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show("Digite um número válido!");
                txtNumero.Clear();
                txtNumero.Focus();
                return;
            }

            string dia = "";
            string tipo = "";

            switch (numero)
            {
                case 1:
                    dia = "Domingo";
                    tipo = "Fim de semana";
                    break;
                case 2:
                    dia = "Segunda-feira";
                    tipo = "Dia útil";
                    break;
                case 3:
                    dia = "Terça-feira";
                    tipo = "Dia útil";
                    break;
                case 4:
                    dia = "Quarta-feira";
                    tipo = "Dia útil";
                    break;
                case 5:
                    dia = "Quinta-feira";
                    tipo = "Dia útil";
                    break;
                case 6:
                    dia = "Sexta-feira";
                    tipo = "Dia útil";
                    break;
                case 7:
                    dia = "Sábado";
                    tipo = "Fim de semana";
                    break;
                default:
                    MessageBox.Show("Dia inválido!");
                    txtNumero.Clear();
                    txtNumero.Focus();
                    return;
            }

            MessageBox.Show($"{dia} - {tipo}");

            // Limpeza automática
            txtNumero.Clear();
            txtNumero.Focus();
        }
    }
}