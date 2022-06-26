using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItronicStore
{
    public partial class PovratnaInformacija : Form
    {
        public PovratnaInformacija()
        {
            InitializeComponent();
            
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {

        }

        private void PovratnaInformacija_Load(object sender, EventArgs e)
        {
            IspuniInformacijeOKorisniku();
            IspuniInformacijeOProizvodu();
        }

        private void IspuniInformacijeOProizvodu()
        {
            throw new NotImplementedException();
        }

        private void IspuniInformacijeOKorisniku()
        {
            throw new NotImplementedException();
        }
    }
}
