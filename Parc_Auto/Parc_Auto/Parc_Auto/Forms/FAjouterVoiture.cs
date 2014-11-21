using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metier;

namespace Parc_Auto.Forms
{
    public partial class FAjouterVoiture : Form
    {
        private Voiture uneVoiture;

        public FAjouterVoiture()
        {
            InitializeComponent();
        }

        public FAjouterVoiture(Voiture voiture)
        {
            uneVoiture = voiture;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
