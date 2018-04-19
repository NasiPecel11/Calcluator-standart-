using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulator
{
    public partial class Form1 : Form
    {

        //Create BY Makerot


        double value = 0;
        string operation = "";
        bool operation_pressed = false;
        double memori;
        double memori2;
        double maxmin;
        string pangkat1;
        double pangkat2;
        //double per;
        //string peer = "";
        string akar;



        public Form1()
        {
            InitializeComponent();
        }

        private void buttonSatu_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e) //penekanan kepada semua tombol dengan action yang sama yaitu button klik
        {
            if ((LCD.Text == "0")||(operation_pressed))
            {
                LCD.Clear();
                operation_pressed = false;
            }
                
            Button b = (Button)sender;
            if(b.Text == ".")
            {
                if (!LCD.Text.Contains("."))
                    LCD.Text = LCD.Text + b.Text;
            }
            else
            LCD.Text = LCD.Text + b.Text;
           /* LCD.Text = LCD.Text + "1";*/

        }

        private void buttonCE_Click(object sender, EventArgs e) //digunakan untuk CE pada kalkulator 
        {
            LCD.Text = "0";
            LCD2.Text = ""; //digunakan untuk membuat label tulisan kecil di atass ikut terhapus
        }

        private void operator_click(object sender, EventArgs e) ///untuk penekanan operator klik seperti +-*/
        {

            Button b = (Button)sender;

           /* if (value != 0)
            {

            }
            else
            {*/
                operation = b.Text;   
                value = Double.Parse(LCD.Text);
                operation_pressed = true;
                LCD2.Text = value + " " + operation; /// untuk menampilkan di layar kecil 
           // }
        }

        private void buttonSamaDengan_Click(object sender, EventArgs e) /// perintah jika ada penekanan tombol sama dengan
        {
            LCD2.Text = " ";
            switch(operation)
            {
                case "+":
                    LCD.Text = (value + Double.Parse(LCD.Text)).ToString();
                    break;
                case "-":
                    LCD.Text = (value - Double.Parse(LCD.Text)).ToString();
                    break;
                case "X":
                    LCD.Text = (value * Double.Parse(LCD.Text)).ToString();
                    break;
                case "/":
                    LCD.Text = (value / Double.Parse(LCD.Text)).ToString();
                    break;
                default:
                    break;



            }///swit berhenti


            value = Int32.Parse(LCD.Text); //fungsinya lupa 
            operation = "";

            //operation_pressed = false;
        }

        private void buttonC_Click(object sender, EventArgs e) //untuk button C atau clear semua 
        {
            LCD.Clear();
            value = 0;
            LCD2.Text = "";

        }

        private void buttonakar_Click(object sender, EventArgs e) //fungsi akar
        {
            
            akar = LCD.Text;
            LCD.Text = (Math.Sqrt(Convert.ToDouble(LCD.Text))).ToString();
            LCD2.Text = "√(" + akar + ")";
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e) //penekanan dari keyboard
        {
           switch(e.KeyChar.ToString())
            {
                case "1":
                    buttonSatu.PerformClick();
                    break;
                case "2":
                    buttonDua.PerformClick();
                    break;
                case "3":
                    buttonTiga.PerformClick();
                    break;
                case "4":
                    buttonEmpat.PerformClick();
                    break;
                case "5":
                    buttonLima.PerformClick();
                    break;
                case "6":
                    buttonEnam.PerformClick();
                    break;
                case "7":
                    buttontujuh.PerformClick();
                    break;
                case "8":
                    buttonLapan.PerformClick();
                    break;
                case "9":
                    buttonSembilan.PerformClick();
                    break;
                case "0":
                    buttonNol.PerformClick();
                    break;
                case "+":
                    buttonJumlah.PerformClick();
                    break;
                case "*":
                    buttonKali.PerformClick();
                    break;
                case "/":
                    buttonBagi.PerformClick();
                    break;
                case "-":
                    buttonKurang.PerformClick();
                    break;
                case "=":
                    buttonSamaDengan.PerformClick();
                    break;
                case "ESC":
                    buttonC.PerformClick();//belom  bisa 
                    break;
                case "%":
                    buttonpersen.PerformClick();
                    break;
                case ".":
                    buttonKoma.PerformClick();
                    break;                                                      
                default:
                    break;
            }
        }

        private void buttonMp_Click(object sender, EventArgs e)
        {
            memori2 = double.Parse(LCD.Text);
            memori = memori + memori2;
            LCD2.Text = "M";
        }

        private void buttonMn_Click(object sender, EventArgs e)
        {
            memori2 = double.Parse(LCD.Text);
            memori = memori - memori2;
            LCD2.Text = "M";
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            LCD2.Text = "M";
            LCD.Text = Convert.ToString(memori);
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            memori2 = double.Parse(LCD.Text);
            memori = memori2 ;
            LCD2.Text = "M";
        }

        private void buttonBackspace_Click(object sender, EventArgs e) //ini untuk backspace atau menghapus satu persatu
        {
            int panjang = LCD.Text.Length; 
            String temp = LCD.Text;
            if (panjang > 1)
            {
                LCD.Text = temp.Remove((panjang - 1), 1);
            }
            else
            {
                LCD.Text = "0";
            }
        }

        private void buttonPlusMin_Click(object sender, EventArgs e) //fungsi +-
        {
            
            maxmin = Convert.ToDouble(LCD.Text);
            maxmin = maxmin * (-1);
            LCD.Text = Convert.ToString(maxmin);
        }

        private void buttonpersen_Click(object sender, EventArgs e)
        {
            LCD.Text = (Convert.ToDouble(LCD.Text) * 0.01).ToString();
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memori = 0;
            LCD2.Text = "";
        }

        private void buttonmasihkosong_Click(object sender, EventArgs e)
        {

            LCD.Text = (1 / Double.Parse(LCD.Text)).ToString(); //mengambil data dari lcd kemudian di bagi dengan 1 
            LCD2.Text = "1/" + "(" + LCD.Text + ")";

            //double x = 1/(LCD.Text = )

            /*per = double.Parse(LCD.Text);
            LCD.Text = (1 / double.Parse(LCD.Text)).ToString();
            LCD.Text = "1 / " + per;*/
        }

        private void buttonpangkat2_Click(object sender, EventArgs e)
        {
            
            pangkat1 = LCD.Text;
            pangkat2 = (Convert.ToDouble(pangkat1)) * Convert.ToDouble(pangkat1);
           /// LCD2.Text = Convert.ToString(pangkat2);
            LCD2.Text = "sqr(" + LCD.Text + ")";
            /*if (operation_pressed)
            {
                
                LCD.Text = Convert.ToString(pangkat2);
            }
            else*/
            LCD.Text = pangkat1 + "^2";
            LCD.Text = Convert.ToString(pangkat2);



        }
    }
}
