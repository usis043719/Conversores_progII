using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversores_progII
{
    public partial class Longitud : Form
    {
        Conversor_de_longitud objconversiones = new Conversor_de_longitud();
        public Longitud()
        {
            InitializeComponent();
        }

        private void Longitud_Load(object sender, EventArgs e)
        {
            cboTipo.Items.AddRange(objconversiones.Tipo);
            cboTipo.SelectedIndex = 0;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                lblRespuesta.Text = "El Valor Es: " + objconversiones.convertir(cboDe.SelectedIndex, cboA.SelectedIndex, double.Parse(txtCantidad.Text), cboTipo.SelectedIndex) + " " + objconversiones.etiquetas[cboTipo.SelectedIndex][cboA.SelectedIndex];
            }
            catch (Exception error)
            {
                MessageBox.Show("Error en la introduccion de Datos", "Conversores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboDe.Items.Clear();
            cboA.Items.Clear();
            cboDe.Items.AddRange(objconversiones.etiquetas[cboTipo.SelectedIndex]);
            cboA.Items.AddRange(objconversiones.etiquetas[cboTipo.SelectedIndex]);
            cboDe.SelectedIndex = 0;
            cboA.SelectedIndex = 1;
            lblRespuesta.Text = "!";
            txtCantidad.Text = "1";
        }
    }
}
    
