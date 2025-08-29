using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_PassaParola_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;

       

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();

            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin Güney Kısmındaki Kıyı Bölgesi?";
                button2.BackColor = Color.Yellow;
                button1.Text = "A";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Yeşilliğiyle Ünlü Marmara İlimiz?";
                button3.BackColor = Color.Yellow;
                button1.Text = "B";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Salata Yoğurt Karışımı Yapılan Yemek?";
                button4.BackColor = Color.Yellow;
                button1.Text = "C";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla Ünlü Olan İlimiz?";
                button5.BackColor = Color.Yellow;
                button1.Text = "D";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni Kelimenin Zıt Anlamı?";
                button6.BackColor = Color.Yellow;
                button1.Text = "E";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın Emirlerinin Yazılı Hali?";
                button7.BackColor = Color.Yellow;
                button1.Text = "F";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın Isı Kaynağı?";
                button8.BackColor = Color.Yellow;
                button1.Text = "G";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Kibar Feyzo Filmi'nin Çekildiği İlimiz?";
                button9.BackColor = Color.Yellow;
                button1.Text = "H";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Gülüyle Ünlü Olan İlimiz?";
                button10.BackColor = Color.Yellow;
                button1.Text = "I";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Mersi'nin Diğer İsmi?";
                button11.BackColor = Color.Yellow;
                button1.Text = "İ";
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Askeri Bir Topluluk?";
                button12.BackColor = Color.Yellow;
                button1.Text = "J";
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Malatyanın Meşhur Meyvesi?";
                button13.BackColor = Color.Yellow;
                button1.Text = "K";
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Her Yıl Bahar Aylarında Düzenlenen Çiçek Festivali?";
                button14.BackColor = Color.Yellow;
                button1.Text = "L";
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Yılın 3.ayı?";
                button15.BackColor = Color.Yellow;
                button1.Text = "M";
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Üflemeli Bir Müzik Aleti?";
                button16.BackColor = Color.Yellow;
                button1.Text = "N";
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk Şairi?";
                button17.BackColor = Color.Yellow;
                button1.Text = "O";
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Çocukların Pek Sevmediği Pirinç Havuç Gbi Sebzelerle Yapılan Yemek?";
                button18.BackColor = Color.Yellow;
                button1.Text = "P";
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Uzaya Gitmek İçin Yada Bomba Yapımında Kullanılan?";
                button19.BackColor = Color.Yellow;
                button1.Text = "R";

            }
            if (soruno == 19)
            {
                richTextBox1.Text = "İngilizcede Yılan?";
                button20.BackColor = Color.Yellow;
                button1.Text = "S";
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin Mega Starı?";
                button21.BackColor = Color.Yellow;
                button1.Text = "T";
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Ümit Kelimesinin Eş Anlamlısı?";
                button22.BackColor = Color.Yellow;
                button1.Text = "U";
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Van Kedisi İle Meşhur İlimiz?";
                button23.BackColor = Color.Yellow;
                button1.Text = "V";
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Şimşek Kelimesinin Eş Anlamlısı?";
                button24.BackColor = Color.Yellow;
                button1.Text = "Y";
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Ege Bölgesinin En Çok Ağacı Bulunan Yağı da Yapılan Bir Kahvaltı Besini?";
                button25.BackColor = Color.Yellow;
                button1.Text = "Z";
            }
        }
       
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // key down herhangi bir tuşa tıklandığında ne olsun, KeyEventArgs dan e nesnesi ile oluşur

            if(e.KeyCode == Keys.Enter)
            {
                switch(soruno)
                {
                    case 1:
                        if(textBox1.Text.ToLower() == "akdeniz")
                        {
                            button2.BackColor = Color.Green;
                            //textBox1.Clear();
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                          
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text.ToLower() == "bursa")
                        {
                        
                            button3.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 3:
                        if (textBox1.Text.ToLower() == "cacık")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 4:
                        if (textBox1.Text.ToLower() == "diyarbakır")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 5:
                        if (textBox1.Text.ToLower() == "eski")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 6:
                        if (textBox1.Text.ToLower() == "ferman")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 7:
                        if (textBox1.Text.ToLower() == "güneş")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 8:
                        if (textBox1.Text.ToLower() == "hatay")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 9:
                        if (textBox1.Text.ToLower() == "ısparta")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 10:
                        if (textBox1.Text.ToLower() == "içel")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 11:
                        if (textBox1.Text.ToLower() == "jandarma")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 12:
                        if (textBox1.Text.ToLower() == "kayısı")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 13:
                        if (textBox1.Text.ToLower() == "lale festivali")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 14:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 15:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 16:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 17:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 18:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 19:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 20:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    case 21:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text.ToLower() == "akdeniz")
                        {
                            button25.BackColor = Color.Green;
                            dogru++;
                            lbl_dogru.Text = dogru.ToString();
                        }
                        else
                        {
                            button25.BackColor = Color.Red;
                            yanlis++;
                            lbl_yanlis.Text = yanlis.ToString();
                        }
                        break;

                    default:

                        MessageBox.Show("Geçersiz Soru Numarası");
                        break;





                }

            }


        }

    }
}
