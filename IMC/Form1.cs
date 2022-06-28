using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtPeso.Text != "" && txtAltura.Text != "" && txtPeso.Text != "0" && txtAltura.Text != "0")
            {
                double peso = double.Parse(txtPeso.Text.Replace(".", ","));
                double altura = double.Parse(txtAltura.Text.Replace(".", ","));
                double calculo = peso / (altura * 2);

                lblIMC.Text = $"IMC: {Math.Round(calculo, 2)}";   
                lblMensagem.Text = IndiceMassaCorporal(lblMensagem, calculo);
            }
            else
            {
                MessageBox.Show("Preencha os campos corretamente.");
            }
        }
        private string IndiceMassaCorporal(Control label, double imc)
        {
            if (imc < 18.5)
            {
                label.ForeColor = Color.Red;
                return label.Text = "Abaixo do peso";
            }
            else if (imc >= 18.6 && imc <= 24.9)
            {
                label.ForeColor = Color.Green;
                return label.Text = "Peso ideal";
            }
            else if (imc >= 25.0 && imc <= 29.9)
            {
                label.ForeColor = Color.OrangeRed;
                return label.Text = "Levemente acima do peso";
            }
            else if (imc >= 30.0 && imc <= 34.9)
            {
                label.ForeColor = Color.Red;
                return label.Text = "Obesidade grau I";
            }
            else if (imc >= 35.0 && imc <= 39.9)
            {
                label.ForeColor = Color.Red;
                return label.Text = "Obesidade grau II ";
            }
            else
            {
                label.ForeColor = Color.Brown;
                return label.Text = "Obsidade grau III";
            }



        }

    }
}
