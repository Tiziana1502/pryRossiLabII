using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryRossiLabII
{
    public partial class frmVector : Form
    {
        public frmVector()
        {
            InitializeComponent();
        }
        string[] Usuario = new string[10];
        Int32 indice = 0;

        private void brnCargar_Click(object sender, EventArgs e)
        {
            if (indice < 10)
            {
                Usuario[indice] = txtNombre.Text;
                indice++;
                //MessageBox.Show("El nombre se cargó correctamente");
                txtNombre.Text = "";
                Listar();
            }
            else
            {
                MessageBox.Show("No se pueden registar más datos");
            }
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
            for (int i = 0; i < indice; i++)
            {
                lstPersonas.Items.Add(Usuario[i]);
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
            int i = 0;
            while (i < indice)
            {
                lstPersonas.Items.Add(Usuario[i]);
                i++;
            }
        }

        private void Listar()
        {
            lstPersonas.Items.Clear();
            for (int i = 0; i < indice; i++)
            {
                lstPersonas.Items.Add(Usuario[i]);
            }
        }
    }
}