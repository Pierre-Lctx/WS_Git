using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PierreForms
{
    public partial class Pierre : Form
    {
        //Variables
        public int mov;
        public int movX;
        public int movY;

        public float res = 0;

        public float Nbr;
        public float otherNumber;

        public string Nombre;

        public bool alreadyVirgule = false;
        public bool isPlus = false;
        public bool isMoins = false;
        public bool isDiviser = false;
        public bool isFois = false;

        public bool isExposant = false;
        public bool isSqrt = false;
        
        

        public bool isEqual = false;

        public Pierre()
        {
            InitializeComponent();

            labelRes.Text = "0";
            labelRes.TextAlign = ContentAlignment.TopRight;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonEgal_Click(object sender, EventArgs e)
        {
            alreadyVirgule = false;

            otherNumber = float.Parse(labelRes.Text);

            res = LastCalcul(Nbr, otherNumber);

            //MessageBox.Show("res = " + res.ToString() + "\notherNumber = " + otherNumber.ToString() + "\nNbr = " + Nbr);

            labelRes.Text = res.ToString();

            isEqual = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            alreadyVirgule = false;

            isPlus = true;
            isMoins = false;
            isDiviser = false;
            isFois = false;

            isExposant = false;
            isSqrt = false;


            Nbr += float.Parse(Nombre );
            Nombre = "";

            labelRes.Text = "0";
        }

        private void buttonMoins_Click(object sender, EventArgs e)
        {
            alreadyVirgule = false;

            isPlus = false;
            isMoins = true;
            isDiviser = false;
            isFois = false;

            isExposant = false;
            isSqrt = false;

            if (Nbr == 0)
                Nbr = float.Parse(Nombre );
            else
                Nbr -= float.Parse(Nombre );
            Nombre = "";

            //MessageBox.Show(Nbr.ToString());

            labelRes.Text = "0";
        }

        private void buttonFois_Click(object sender, EventArgs e)
        {
            alreadyVirgule = false;

            isPlus = false;
            isMoins = false;
            isDiviser = false;
            isFois = true;

            isExposant = false;
            isSqrt = false;

            if (Nbr == 0)
                Nbr = float.Parse(Nombre );
            else
                Nbr *= float.Parse(Nombre );
            
            Nombre = "";

            //MessageBox.Show(Nbr.ToString());

            labelRes.Text = "0";
        }

        private void buttonDiviser_Click(object sender, EventArgs e)
        {
            alreadyVirgule = false;

            isPlus = false;
            isMoins = false;
            isDiviser = true;
            isFois = false;

            isExposant = false;
            isSqrt = false;

            if (Nbr == 0)
                Nbr = float.Parse(Nombre );
            else
                Nbr /= float.Parse(Nombre );
            
            Nombre = "";

            //MessageBox.Show(Nbr.ToString());

            labelRes.Text = "0";
        }

        private void buttonVirgule_Click(object sender, EventArgs e)
        {
            if (!alreadyVirgule)
            {
                alreadyVirgule = true;

                if (Nombre == "")
                {
                    Nombre += "0,";
                    labelRes.Text = "0" + Nombre;
                }
                
                else
                {
                    Nombre += ",";
                    labelRes.Text = Nombre;
                }
            }
            
                
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                isEqual = false;
                RESET();
            }
                
            Nombre += "3";

            labelRes.Text = Nombre;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                isEqual = false;
                RESET();
            }

            Nombre += "6";

            labelRes.Text = Nombre;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                isEqual = false;
                RESET();
            }

            Nombre += "9";

            labelRes.Text = Nombre;
        }

        private void buttonExposant_Click(object sender, EventArgs e)
        {
            isPlus = false;
            isMoins = false;
            isDiviser = false;
            isFois = false;

            isExposant = true;
            isSqrt = false;

            if (Nbr == 0)
                Nbr = float.Parse(Nombre);
            else
                Nbr = (float)Math.Pow(Nbr, float.Parse(Nombre ));

            Nombre = "";

            labelRes.Text = "0";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                isEqual = false;
                RESET();
            }
            Nombre += "0";

            labelRes.Text = Nombre;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                isEqual = false;
                RESET();
            }
            Nombre += "2";

            labelRes.Text = Nombre;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                isEqual = false;
                RESET();
            }
            Nombre += "5";

            labelRes.Text = Nombre;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                isEqual = false;
                RESET();
            }
            Nombre += "8";

            labelRes.Text = Nombre;
        }

        private void buttonCarre_Click(object sender, EventArgs e)
        {
            if (Nbr == 0)
                Nbr = (float)Math.Pow(float.Parse(Nombre),2);
            else
                Nbr *= Nbr;

            Nombre = "";

            labelRes.Text = "0";
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            Nbr = (float)Math.Log10(Nbr);

            Nombre = "";

            labelRes.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                isEqual = false;
                RESET();
            }
            Nombre += "1";

            labelRes.Text = Nombre;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                isEqual = false;
                RESET();
            }
            Nombre += "4";

            labelRes.Text = Nombre;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (isEqual)
            {
                isEqual = false;
                RESET();
            }
            Nombre += "7";

            labelRes.Text = Nombre;
        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            Nbr = (float)Math.Log(Nbr);

            Nombre = "";

            labelRes.Text = "0";
        }

        private float LastCalcul(float lastNumber, float otherLastNumber)
        {
            float resultat = 0f;

            if (isPlus)
            {
                lastNumber += otherLastNumber;
                resultat = lastNumber;
                //MessageBox.Show("Plus");
            }
            if (isMoins)
            {
                lastNumber -= otherLastNumber;
                resultat = lastNumber;
                //MessageBox.Show("Moins");
            }
            if (isFois)
            {
                lastNumber *= otherLastNumber;
                resultat = lastNumber;
                //MessageBox.Show("Fois");
            }
            if (isDiviser)
            {
                lastNumber /= otherLastNumber;
                resultat = lastNumber;
                //MessageBox.Show("Diviser");
            }
            if (isExposant)
            {
                resultat = (float)Math.Pow(lastNumber, otherLastNumber);
                //MessageBox.Show("Exposant");
            }
            if (isSqrt)
            {
                resultat = (float)Math.Sqrt(lastNumber);
                //MessageBox.Show("Racine carrée");
            }


            return resultat;
        }

        //Bouton Racine carrée
        private void button10_Click(object sender, EventArgs e)
        {
            isPlus = false;
            isMoins = false;
            isDiviser = false;
            isFois = false;

            isExposant = false;
            isSqrt = true;

            Nbr = (float)Math.Sqrt(float.Parse(Nombre ));

            Nombre = "";

            labelRes.Text = "0";
        }

        private void RESET()
        {
            Nombre = "";
            labelRes.Text = "0";
            Nbr = 0;

            alreadyVirgule = false;
            isPlus = false;
            isMoins = false;
            isDiviser = false;
            isFois = false;
            isExposant = false;
            isSqrt = false;
        }
    }
}
