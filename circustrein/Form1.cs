using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace circustrein
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var soortEter in Enum.GetValues(typeof(SoortEter)))
            {
                comboBoxSoortEter.Items.Add(soortEter.ToString());
            }

            foreach (var grootte in Enum.GetValues(typeof(Grootte)))
            {
                comboBoxGrootte.Items.Add(grootte.ToString());
            }


        }

        private void btnVerdelen_Click(object sender, EventArgs e)
        {
            dataGridViewWagon.Rows.Clear();
            Wagon.GrootteInstelling = Convert.ToInt32(txtBoxWagonGrootte.Text);

            List<Dier> listDieren = listBoxLijstDieren.Items.Cast<Dier>().ToList();

            Trein trein = new Trein(listDieren);

            DisplayTreinDataGridView(trein);
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            string soortEter = comboBoxSoortEter.Items[comboBoxSoortEter.SelectedIndex].ToString();
            string grootte = comboBoxGrootte.Items[comboBoxGrootte.SelectedIndex].ToString();

            Dier dier = new Dier(soortEter, grootte);

            listBoxLijstDieren.Items.Add(dier);
        }

        private void DisplayTreinDataGridView(Trein trein)
        {
            foreach (Wagon wagon in trein.ListWagons)
            {
                foreach (Dier dier in wagon.LijstDieren)
                {
                    dataGridViewWagon.Rows.Add(wagon.PositieInTrein, dier.SoortEter, dier.Grootte);
                }
            }
        }
    }
}
