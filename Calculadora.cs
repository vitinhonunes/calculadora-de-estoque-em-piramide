using System;
using System.Globalization;
using System.Windows.Forms;

namespace AppCalculo
{
    public partial class Calculadora : Form
    {
        int Fre, Lat, Alt, Avu, Res = 0;
        public void Restri(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
                e.Handled = true;
        }

        private void tbLateral_KeyPress(object sender, KeyPressEventArgs e)
        {
            Restri(sender, e);
        }

        private void tbAvulso_KeyPress(object sender, KeyPressEventArgs e)
        {
            Restri(sender, e);
        }

        private void MnClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MnVers(object sender, EventArgs e)
        {
            MessageBox.Show("Desenvolvido por João Victor - Ver.1.0.1","Sobre");
        }

        private void tbFrente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Restri(sender, e);
           
        }
        public Calculadora()
        {
            InitializeComponent();
        }
        public void Calcular()
        {
            Fre = int.Parse(tbFrente.Text);
            Lat = int.Parse(tbLateral.Text);
            Alt = int.Parse(tbAlt.Text);
            Avu = int.Parse(tbAvulso.Text);
            int r = 0;

            //Loop para somar os valores conforme o número de iterações
            if (Alt == 0 || Alt == 1)
            {
                Res = (Fre * Lat) * Alt + Avu;
            }
            for (int i = 0; i < Alt; i++)
            {
                r += (Fre - i) * (Lat - i);
            }
            Res = r + Avu;

        }

        public void btCalc_Click(object sender, EventArgs e)
        {
            if (tbFrente.Text == "")
            {
                MessageBox.Show("Digite o Valor da Frente.");
            }
            else if (tbLateral.Text == "")
            {
                MessageBox.Show("Digite o Valor da Lateral.");
            }
            else if (tbAlt.Text == "")
            {
                MessageBox.Show("Digite o Valor da Altura.");
            }
            else if (tbAvulso.Text == "")
            {
                tbAvulso.Text = "0";
            }
            else
            {
                Calcular();
                //("0,0,0") converte em decimal com . a cada 3 numeros
                tbRes.Text = Res.ToString("0,0,0"); 
            }
        }
    }
}
