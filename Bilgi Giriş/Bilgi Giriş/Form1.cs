using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Giriş
{
    public partial class Form1 : Form
    {

        string Tc, Ad, Soyad, Sınıf,Arama,index; int ogr;
        
       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
          
            //Veri Alma
            Tc = textBox1.Text;
            Ad = textBox2.Text;
            Soyad = textBox3.Text;
            Sınıf = comboBox1.Text;

            //Yenileme
            if (!listBox1.Items.Contains(Tc.ToString()))
            {
               
                ////Silme
                listBox1.Items.RemoveAt(Convert.ToInt32(index));
                listBox2.Items.RemoveAt(Convert.ToInt32(index));
                listBox3.Items.RemoveAt(Convert.ToInt32(index));

                listBox1.Items.Insert(Convert.ToInt32(index), Tc);
                listBox2.Items.Insert(Convert.ToInt32(index), Ad + " " + Soyad);
                listBox3.Items.Insert(Convert.ToInt32(index), Sınıf);

            }
            else
            {
                MessageBox.Show(Tc + " TC kimlik numaralı öğrenci mevcut");

            }
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(Convert.ToInt32(index));
            listBox2.Items.RemoveAt(Convert.ToInt32(index));
            listBox3.Items.RemoveAt(Convert.ToInt32(index));
            ogr = listBox1.Items.Count;
            label8.Text = "Öğrenci Sayısı : "+ogr.ToString();

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
            Arama = Convert.ToString(textBox4.Text);
            if (radioButton1.Checked==true)
            {
                
                if (listBox1.Items.Contains(Arama.ToString()))
                {
                    index=listBox1.FindString(textBox4.Text).ToString();
                    Tc= listBox1.Items[Convert.ToInt32(index)].ToString();
                    Ad = listBox2.Items[Convert.ToInt32(index)].ToString();
                    Sınıf = listBox3.Items[Convert.ToInt32(index)].ToString();

                    textBox1.Text = Tc;
                    textBox2.Text = Ad;
                    comboBox1.Text = Sınıf;
                }
                else
                {
                    MessageBox.Show(textBox4.Text+" : TC Numaralı Öğrenci Mevcur Değil");
                }
            }
            else if (listBox2.Items.Contains(Arama.ToString()))
            {
                Arama = Convert.ToString(textBox4.Text);

                index = listBox2.FindString(textBox4.Text).ToString();
                Tc = listBox1.Items[Convert.ToInt32(index)].ToString();
                Ad = listBox2.Items[Convert.ToInt32(index)].ToString();
                Sınıf = listBox3.Items[Convert.ToInt32(index)].ToString();
                

                textBox1.Text = Tc;
                textBox2.Text = Ad;
                comboBox1.Text = Sınıf;
            }
            else
            {
                MessageBox.Show(textBox4.Text + " : Adlı  Öğrenci Mevcur Değil");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

          
            ogr=listBox1.Items.Count;
            label8.Text = "Öğrenci Sayısı : " +ogr.ToString();
            //Sınıf Eklme
            comboBox1.Items.Add("9.Sınıf");
            comboBox1.Items.Add("10.Sınıf");
            comboBox1.Items.Add("11.Sınıf");
            comboBox1.Items.Add("12.Sınıf");
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deneme;
            if (textBox1.Text.Length==11)
            {
                Tc = Convert.ToString(textBox1.Text);
                if (textBox2.Text!="")
                {
                    Ad = textBox2.Text.ToString();
                    if (textBox3.Text!="")
                    {
                        Soyad = textBox3.Text.ToString();
                        if (comboBox1.Text!="")
                        {
                            Sınıf = Convert.ToString(comboBox1.Text);


                            if (!listBox1.Items.Contains(Tc.ToString()))
                            {
                                listBox1.Items.Add(Tc.ToString());
                            }
                            else
                            {
                                MessageBox.Show(Tc.ToString() + " :TC kimlik numaralı öğrenci mevcut");
                            }
                            if (!listBox2.Items.Contains(Ad.ToString() + " " + Soyad.ToString()))
                            {
                                listBox2.Items.Add(Ad.ToString() + " " + Soyad.ToString());
                            }
                            if (!listBox3.Items.Contains(Sınıf.ToString()))
                            {
                                listBox3.Items.Add(Sınıf.ToString());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Lütfen sınıf bölümünü doldurunuz");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen soyad bölümünü doldurunuz");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Lütfen ad kısmını doldurunuz.");
                }
            }
            else
            {
                MessageBox.Show("TC kimlik no 11 Karakterli olmalidir");
            }
            //Verileri Alma

            
            ogr = listBox1.Items.Count;
            label8.Text = "Öğrenci Sayısı : " + ogr.ToString();





        }
    }
}
