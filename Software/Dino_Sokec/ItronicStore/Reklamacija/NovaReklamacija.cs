﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ItronicStore;

namespace ItronicStore
{
    public partial class NovaReklamacija : Form
    {
        private string korisnickoIme;
        public NovaReklamacija(string korisnickoIme)
        {
            InitializeComponent();
            this.korisnickoIme = korisnickoIme;
        }
        
        // Odustani
        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            Hide();
        }
    }
}
