using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        List<knjiga> knjige = new List<knjiga>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Spremi_Click(object sender, EventArgs e)
        {
            string naslov = Naslov.Text.Trim();
            string autor = Autor.Text.Trim();
            int godina = 0;
            int.TryParse(Godina_Izdanja.Text,out godina);

            bool postoji = false;

            foreach (knjiga x in knjige)
            {
                if (x.Naslov.Trim().ToLower() == naslov.ToLower() &&
                    x.autor.Trim().ToLower() == autor.ToLower() &&
                    x.godina == godina)
                {
                    postoji = true;
                    break;
                }
            }

            if (!postoji|| godina!=0)
            {
                knjiga k = new knjiga(naslov, autor, godina);
                knjige.Add(k);
            }

            listBox1.Items.Clear();

            foreach (knjiga x in knjige)
            {
                listBox1.Items.Add(x.Naslov + " - " + x.autor + " - " + x.godina);
            }
            spremi();

        }
        public void spremi()
        {
            StreamWriter sw = new StreamWriter("knjige.txt");
            foreach (knjiga x in knjige)
            {
                sw.WriteLine(x.Naslov + "," + x.autor + "," + x.godina);
            }
            sw.Close();
        }
        public void Ucitaj()
        {
            if (File.Exists("knjige.txt"))
            {
                StreamReader sr = new StreamReader("knjige.txt");

                knjige.Clear();
                listBox1.Items.Clear();

                while (!sr.EndOfStream)
                {
                    string red = sr.ReadLine();

                    string[] podaci = red.Split(',');

                    knjiga k = new knjiga(
                        podaci[0],
                        podaci[1],
                        int.Parse(podaci[2])
                    );

                    knjige.Add(k);

                    listBox1.Items.Add(k.Naslov + " - " + k.autor + " - " + k.godina);
                }

                sr.Close();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Ucitaj();
        }
    }
}
