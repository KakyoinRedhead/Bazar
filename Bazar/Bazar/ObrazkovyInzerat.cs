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
    public partial class ObrazkovyInzerat : Inserat
    {
        public ObrazkovyInzerat() : base()
        {
            InitializeComponent();
        }

        public override void VypisDoLabelu()
        {
            base.VypisDoLabelu();
            pictureBox1.Image = Image.FromFile("0sus.png");
        }

    }
}
