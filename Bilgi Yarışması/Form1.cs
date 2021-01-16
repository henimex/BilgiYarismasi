using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sorusayisi = 0;
        int dogru = 0;
        int yanlis = 0;
        int p2 = 0;
        int cd;
        Random sira = new Random();

        

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            button7.Visible = true;
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = true;
            button7.Visible = false;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            sorusayisi++;
            label2.Text = sorusayisi.ToString();

            if (sorusayisi == 1)
            {
                richTextBox1.Text = "Aşağıdakilerdem Hangisi Bilgisayar Çevre Donaımı Değildir";
                button1.Text = "Klavye & Mouse";
                button2.Text = "Monitör";
                button3.Text = "Ekran Kartı";
                button4.Text = "Kulaklık";
                label5.Text = "Ekran Kartı";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = button1.Text;
            timer1.Stop();
            if (label4.Text == label5.Text)
            {
                pictureBox1.ImageLocation = "D:\\Downloads\\Education\\Media\\tick.png"; 
                dogru++;
                label9.Text = dogru.ToString();
                p2 += 5;
                label6.Text = p2.ToString();
            }
            else
            {
                pictureBox2.ImageLocation = "D:\\Downloads\\Education\\Media\\wrong.png";
                yanlis++;
                label10.Text = yanlis.ToString();
            }


            button1.Enabled = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Text = button4.Text;
            timer1.Stop();
            if (label4.Text == label5.Text)
            {
                pictureBox1.ImageLocation = "D:\\Downloads\\Education\\Media\\tick.png";
                dogru++;
                label9.Text = dogru.ToString();
                p2 += 5;
                label6.Text = p2.ToString();

            }
            else
            {
                pictureBox2.ImageLocation = "D:\\Downloads\\Education\\Media\\wrong.png";
                yanlis++;
                label10.Text = yanlis.ToString();
            }

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label4.Text = button3.Text;
            timer1.Stop();
            if (label4.Text == label5.Text)
            {
                pictureBox1.ImageLocation = "D:\\Downloads\\Education\\Media\\tick.png";
                dogru++;
                label9.Text = dogru.ToString();
                p2 += 5;
                label6.Text = p2.ToString();

            }
            else
            {
                pictureBox2.ImageLocation = "D:\\Downloads\\Education\\Media\\wrong.png";
                yanlis++;
                label10.Text = yanlis.ToString();

            }

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
            button4.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Text = button2.Text;
            timer1.Stop();
            if (label4.Text == label5.Text)
            {
                pictureBox1.ImageLocation = "D:\\Downloads\\Education\\Media\\tick.png"; 
                dogru++;
                label9.Text = dogru.ToString();
                p2 += 5;
                label6.Text = p2.ToString();

            }
            else
            {
                pictureBox2.ImageLocation = "D:\\Downloads\\Education\\Media\\wrong.png";
                yanlis++;
                label10.Text = yanlis.ToString();

            }

            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sorusayisi++;
            
            timer1.Enabled = true;
            cd = 20;
            label11.Text = cd.ToString();

            label2.Text = sorusayisi.ToString();
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";

            if (sorusayisi == 2)
            {
                richTextBox1.Text = "Bilgisayarın Geçici Hafıza Olarak Kullandığı Donanımın Adı Nedir.";
                button1.Text = "HDD";
                button2.Text = "CPU";
                button3.Text = "RAM";
                button4.Text = "GPU";
                label5.Text = "RAM";
            }

            if (sorusayisi == 3)
            {
                richTextBox1.Text = "Aşağıdakilerden Hangisi Blizzard Oyunu Değildir.";
                button1.Text = "Heroes of the Storm";
                button2.Text = "World of Warcraft";
                button3.Text = "Destiny 2";
                button4.Text = "Overwatch";
                label5.Text = "Destiny 2";
            }

            if (sorusayisi == 4)
            {
                richTextBox1.Text = "MOBA Oyunlarında Genellikle Ulti Varsayılan Olarak Hangi Tuşta Bulunur";
                button1.Text = "Q";
                button2.Text = "W";
                button3.Text = "E";
                button4.Text = "R";
                label5.Text = "R";
            }

            if (sorusayisi == 5)
            {
                richTextBox1.Text = "Efsanevi Oyun Serisi Metal Gear Solid in Yazarı Kimdir.";
                button1.Text = "Konami";
                button2.Text = "Hideo Kojima";
                button3.Text = "Dan Houser";
                button4.Text = "Chiris Metzen";
                label5.Text = "Hideo Kojima";
            }

            if (sorusayisi == 6)
            {
                richTextBox1.Text = "Yarışma Bitmiştir. Katıldığınız İçin Teşekkürler. Toplam Puanınız:" + " " + label6.Text + " " + "Genel Başarı Sıranız: " + sira.Next(1, 99);
                button5.Enabled = false;
                timer1.Stop();
            }

            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cd = Convert.ToInt32(label11.Text);
            cd = cd - 1;
            label11.Text = cd.ToString();

            if (cd == 0)
            {
                yanlis++;
                label10.Text = yanlis.ToString();
                timer1.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
            }
        }
    }
    
}
