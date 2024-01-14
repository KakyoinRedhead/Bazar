using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bazar
{
    public partial class Inserat : UserControl
    {
        public string Nazev { get; private set; }
        public string Popis { get; private set; }
        public string Kontakt { get; private set; } 
        public double Cena { get; private set; }

        public Inserat()
        {
            InitializeComponent();
            VypisDoLabelu();
        }

        public virtual void VypisDoLabelu()
        {
            label1.Text = Nazev;

            label2.Text = $"Kontakt: {Kontakt}\n" +
                 $"Popis: {Popis}\n" +
                 $"Cena: {Cena}";
               
        }

        private void Inserat_Load(object sender, EventArgs e)
        {

        }
    }
}
 