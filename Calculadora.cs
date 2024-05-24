using System;
using System.Globalization;
using System.Windows.Forms;

namespace AppCalculo
{
    public partial class Calculadora : Form
    {
        int Fre,Lat,Alt,Avu,Res = 0;
        public Calculadora()
        {
            InitializeComponent();
        }
        public void Calcular()
        {
            Fre = int.Parse(tbFrente.Text);
            Lat = int.Parse(tbLateral.Text);
            Alt = int.Parse(cmAlt.Text);
            Avu = int.Parse(tbAvulso.Text);
            //Conjunto de IF para determinar as fiadas -1 no calculo
            if (Alt == 1)
            {
                Res = (Fre * Lat) * Alt + Avu;
            }
            else if (Alt == 2) 
            {
                int f1, f2,r;
                f1=Fre * Lat;
                f2=(Fre-1) * (Lat-1);
                r = f1 + f2;
                Res = r + Avu;
            }
            else if (Alt == 3) 
            {
                int f1, f2,f3, r;
                f1 = Fre * Lat;
                f2 = (Fre - 1) * (Lat - 1);
                f3 = (Fre - 2) * (Lat - 2);
                r = f1 + f2+f3;
                Res = r + Avu;
            }
            else if (Alt == 4) 
            {
                int f1, f2, f3,f4, r;
                f1 = Fre * Lat;
                f2 = (Fre - 1) * (Lat - 1);
                f3 = (Fre - 2) * (Lat - 2);
                f4 = (Fre - 3) * (Lat - 3);
                r = f1 + f2 + f3 + f4 ;
                Res = r + Avu;
            }
            else if (Alt == 5) 
            {
                int f1, f2, f3, f4,f5, r;
                f1 = Fre * Lat;
                f2 = (Fre - 1) * (Lat - 1);
                f3 = (Fre - 2) * (Lat - 2);
                f4 = (Fre - 3) * (Lat - 3);
                f5 = (Fre - 4) * (Lat - 4);
                r = f1 + f2 + f3 + f4 + f5;
                Res = r + Avu;
            }
            else if (Alt == 6) 
            {
                int f1, f2, f3, f4, f5,f6, r;
                f1 = Fre * Lat;
                f2 = (Fre - 1) * (Lat - 1);
                f3 = (Fre - 2) * (Lat - 2);
                f4 = (Fre - 3) * (Lat - 3);
                f5 = (Fre - 4) * (Lat - 4);
                f6 = (Fre - 5) * (Lat - 5);
                r = f1 + f2 + f3 + f4 + f5 + f6;
                Res = r + Avu;
            }
            else if (Alt == 7) 
            {
                int f1, f2, f3, f4, f5, f6,f7, r;
                f1 = Fre * Lat;
                f2 = (Fre - 1) * (Lat - 1);
                f3 = (Fre - 2) * (Lat - 2);
                f4 = (Fre - 3) * (Lat - 3);
                f5 = (Fre - 4) * (Lat - 4);
                f6 = (Fre - 5) * (Lat - 5);
                f7 = (Fre - 6) * (Lat - 6);
                r = f1 + f2 + f3 + f4 + f5 + f6 + f7;
                Res = r + Avu;
            }
            else if (Alt == 8) 
            {
                int f1, f2, f3, f4, f5, f6, f7,f8, r;
                f1 = Fre * Lat;
                f2 = (Fre - 1) * (Lat - 1);
                f3 = (Fre - 2) * (Lat - 2);
                f4 = (Fre - 3) * (Lat - 3);
                f5 = (Fre - 4) * (Lat - 4);
                f6 = (Fre - 5) * (Lat - 5);
                f7 = (Fre - 6) * (Lat - 6);
                f8 = (Fre - 7) * (Lat - 7);
                r = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8;
                Res = r + Avu;
            }
            else if (Alt == 9) 
            {
                int f1, f2, f3, f4, f5, f6, f7, f8,f9, r;
                f1 = Fre * Lat;
                f2 = (Fre - 1) * (Lat - 1);
                f3 = (Fre - 2) * (Lat - 2);
                f4 = (Fre - 3) * (Lat - 3);
                f5 = (Fre - 4) * (Lat - 4);
                f6 = (Fre - 5) * (Lat - 5);
                f7 = (Fre - 6) * (Lat - 6);
                f8 = (Fre - 7) * (Lat - 7);
                f9 = (Fre - 8) * (Lat - 8);
                r = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9;
                Res = r + Avu;
            }
            else if (Alt == 10) 
            {
                int f1, f2, f3, f4, f5, f6, f7, f8, f9,f10, r;
                f1 = Fre * Lat;
                f2 = (Fre - 1) * (Lat - 1);
                f3 = (Fre - 2) * (Lat - 2);
                f4 = (Fre - 3) * (Lat - 3);
                f5 = (Fre - 4) * (Lat - 4);
                f6 = (Fre - 5) * (Lat - 5);
                f7 = (Fre - 6) * (Lat - 6);
                f8 = (Fre - 7) * (Lat - 7);
                f9 = (Fre - 8) * (Lat - 8);
                f10 = (Fre - 9) * (Lat - 9);
                r = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9 + f10;
                Res = r + Avu;
            }
            else if (Alt == 11) 
            {
                int f1, f2, f3, f4, f5, f6, f7, f8, f9, f10,f11, r;
                f1 = Fre * Lat;
                f2 = (Fre - 1) * (Lat - 1);
                f3 = (Fre - 2) * (Lat - 2);
                f4 = (Fre - 3) * (Lat - 3);
                f5 = (Fre - 4) * (Lat - 4);
                f6 = (Fre - 5) * (Lat - 5);
                f7 = (Fre - 6) * (Lat - 6);
                f8 = (Fre - 7) * (Lat - 7);
                f9 = (Fre - 8) * (Lat - 8);
                f10 = (Fre - 9) * (Lat - 9);
                f11 = (Fre - 10) * (Lat - 10);
                r = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9 + f10 + f11;
                Res = r + Avu;
            }
            else if (Alt == 12) 
            {
                int f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11,f12, r;
                f1 = Fre * Lat;
                f2 = (Fre - 1) * (Lat - 1);
                f3 = (Fre - 2) * (Lat - 2);
                f4 = (Fre - 3) * (Lat - 3);
                f5 = (Fre - 4) * (Lat - 4);
                f6 = (Fre - 5) * (Lat - 5);
                f7 = (Fre - 6) * (Lat - 6);
                f8 = (Fre - 7) * (Lat - 7);
                f9 = (Fre - 8) * (Lat - 8);
                f10 = (Fre - 9) * (Lat - 9);
                f11 = (Fre - 10) * (Lat - 10);
                f12 = (Fre - 11) * (Lat - 11);
                r = f1 + f2 + f3 + f4 + f5 + f6 + f7 + f8 + f9 + f10 + f11 + f12;
                Res = r + Avu;
            }
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
            else if (cmAlt.Text == "")
            {
                MessageBox.Show("Indique a Altura.");
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
