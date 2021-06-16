using ItronicClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Itronic
{
    public partial class FrmAzurirajProizvod : Form
    {
        private Proizvod odabraniProizvod;
        public FrmAzurirajProizvod(Proizvod proizvod)
        {
            InitializeComponent();
            odabraniProizvod = proizvod;
        }
    }
}
