﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewProjectHopital5
{
    public partial class Statistique : Form
    {
        public Statistique()
        {
            InitializeComponent();
        }

        private void Statistique_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime s=DateTime.Parse(textBox1.Text);
            this.EtatDePassmentTableAdapter.Fill(this.ImpressionRDV.EtatDePassment,s.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
