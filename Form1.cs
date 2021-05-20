using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            cboListaDropDownList.Items.Add(txtTexto.Text);
            txtTexto.Clear();
            txtTexto.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(cboListaDropDownList.SelectedIndex == -1)
            {
                MessageBox.Show("Nenhum item foi selecionado!!!", "ComboBox", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cboListaDropDownList.Items.RemoveAt(cboListaDropDownList.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cboListaDropDownList.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtTexto.Clear();
            cboListaDropDownList.SelectedIndex = -1;
            txtPosLista.Text = "";
            txtTextoSel.Text = "";
            txtTotalItens.Text = "";
            txtTexto.Focus();
        }

        private void cboListaDropDownList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cboListaDropDownList.SelectedIndex != -1)
            {
                txtPosLista.Text = cboListaDropDownList.SelectedIndex.ToString();
                txtTextoSel.Text = cboListaDropDownList.SelectedItem.ToString();
                txtTotalItens.Text = cboListaDropDownList.Items.Count.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
