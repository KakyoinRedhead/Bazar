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
    public partial class TextovyInzerat : Inserat
    {
        public TextovyInzerat() :base()
        {
            InitializeComponent();
        }
        public virtual void VypisDoLabelu()
        {
            label3.Text = $"Popis: {Popis}\n";
            label4.Text = $"Cena: {Cena}";

        }

    }
}
