﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade5
{
    public partial class frmExercicio2 : Form
    {
        public frmExercicio2()
        {
            InitializeComponent();
        }

        private void frmExercicio2_Load(object sender, EventArgs e)
        {
            frmExercicio2 frm = new frmExercicio2();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtPalavra1.Text,txtPalavra2.Text,true)==0)
            {
                MessageBox.Show("Palavras iguais");
            }
            else
            {
                MessageBox.Show("Palavras Diferentes");
            }
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra2.Text.Length / 2;
            txtPalavra2.Text = txtPalavra2.Text.Substring(0, meio) +
                txtPalavra1.Text + txtPalavra2.Text.Substring(meio, txtPalavra2.Text.Length - meio);
        }

        private void btnInsere2_Click(object sender, EventArgs e)
        {
            int meio = txtPalavra1.Text.Length / 2;
            txtPalavra1.Text = txtPalavra1.Text.Insert(meio, "**");
        }
    }
}
