using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DllFarmacia;

namespace Farmacia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int arraySize = 100;
        private Farmaco[] farmaci = new Farmaco[arraySize];
        private int num = 0;
        const string pathToData = "data.dat";

        private void Clean(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = String.Empty;
                if (c.Controls.Count > 0) Clean(c);
            }
        }

        private void View(Farmaco[] farmaci)
        {

        }

        private void btnconferma_Click(object sender, EventArgs e)
        {
            if (MyLibrary.Posizione(farmaci, num, txbcodice.Text) == -1)
            {
                farmaci[num] = new Farmaco
                {
                    categoria = txbtipologia.Text,
                    codice = txbcodice.Text,
                    descrizione = txbdescrizione.Text,
                    età = int.Parse(txbanni.Text),
                    nome = txbnome.Text,
                    prezzo = decimal.Parse(txbprezzo.Text),
                    quantità = int.Parse(txbquantita.Text),
                    scadenza = DateTime.Parse(txbdata.Text)

                };

                num++;
            }
            else
            {
                farmaci[MyLibrary.Posizione(farmaci, num, txbcodice.Text)] = new Farmaco
                {
                    categoria = txbtipologia.Text,
                    codice = txbcodice.Text,
                    descrizione = txbdescrizione.Text,
                    età = int.Parse(txbanni.Text) * int.Parse(txbmesi.Text),
                    nome = txbnome.Text,
                    prezzo = decimal.Parse(txbprezzo.Text),
                    quantità = int.Parse(txbquantita.Text),
                    scadenza = DateTime.Parse(txbdata.Text)
                };
            }

            Clean(this);
        }
                
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            MyLibrary.Aggiorna(farmaci, num, listView1);
        }

        private void btncancella_Click(object sender, EventArgs e)
        {
            try
            {
                MyLibrary.Cancella(farmaci, ref num, listView1.SelectedItems[0].SubItems[0].Text);
            }
            catch
            {
                MessageBox.Show("Seleziona un prodotto");
            }
            MyLibrary.Aggiorna(farmaci, num, listView1);
        }

        private void btncerca_Click(object sender, EventArgs e)
        {
            int newNum = 0;
            Farmaco[] newFarmaci = new Farmaco[arraySize];
            for (int i = 0; i < num; i++)
            {
                if(farmaci[i].codice.Contains(txbcerca.Text))
                {
                    newFarmaci[newNum] = farmaci[i];
                    newNum++;
                }
            }
            MyLibrary.Aggiorna(newFarmaci, newNum, listView1);
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
            MyLibrary.OrdinaPD(farmaci, num);
            MyLibrary.Aggiorna(farmaci, num, listView1);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton5.Checked = false;
                radioButton2.Checked = false;
                radioButton3.Checked = false;
            }
            MyLibrary.OrdinaQD(farmaci, num);
            MyLibrary.Aggiorna(farmaci, num, listView1);
        }

        private void btnsalva_Click(object sender, EventArgs e)
        {
            MyLibrary.Scrivi(farmaci, num, pathToData);
            MyLibrary.Aggiorna(farmaci, num, listView1);
        }

        private void btncarica_Click(object sender, EventArgs e)
        {
            MyLibrary.Leggi(farmaci, ref num, pathToData);
            MyLibrary.Aggiorna(farmaci, num, listView1);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;
                radioButton5.Checked = false;
                radioButton3.Checked = false;
            }
            MyLibrary.OrdinaPC(farmaci, num);
            MyLibrary.Aggiorna(farmaci, num, listView1);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                radioButton5.Checked = false;
                radioButton2.Checked = false;
                radioButton1.Checked = false;
            }
            MyLibrary.OrdinaQC(farmaci, num);
            MyLibrary.Aggiorna(farmaci, num, listView1);
        }
    }
