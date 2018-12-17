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

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            string soortEter = comboBoxSoortEter.Items[comboBoxSoortEter.SelectedIndex].ToString();
            string grootte = comboBoxGrootte.Items[comboBoxSoortEter.SelectedIndex].ToString();

            //Covert to enum values
            int enumValueSoortEter = comboBoxSoortEter.SelectedIndex+1;
            int enumValueGrootte = comboBoxGrootte.SelectedIndex;


            string kek = circustrein.Grootte.Groot.ToString(); 
            int enumValueSoortEter = (string)circustrein.Grootte.Groot();
            int enumValueGrootte = (int)Question.Role;

            Enum.GetName(typeof(SoortEter), soortEter);
            Enum.GetName(typeof(Grootte), grootte);

            if (enumValueGrootte == 0)
            {
                enumValueGrootte = Convert.ToInt32(circustrein.Grootte.Klein);
            }
            else
            {
                enumValueGrootte += 2;
            }

            Dier dier = new Dier(enumValueSoortEter, enumValueGrootte);

            listBoxLijstDieren.Items.Add(dier);

        }
    }
}
