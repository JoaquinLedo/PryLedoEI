using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLedoEI
{
    public partial class frmCargarProveedores : Form
    {
        public frmCargarProveedores()
        {
            InitializeComponent();

        }
        private void frmCargarProveedores_Load(object sender, EventArgs e)
        {
            lblNumProveedor.Text = numGuia.ToString();
        }

        int numGuia = 158;
        clsArchivo grabado = new clsArchivo();

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //crea una nueva matriz de strings llamada datosProveedores. 
            string[] datosProveedores = new string[] { numGuia.ToString(), txtEntidad.Text, txtApertura.Text, txtExpediente.Text, txtJuzgado.Text, txtJurisdiccion.Text, txtDireccion.Text, txtLiquidador.Text };
            //El código luego crea una nueva cadena llamada datosConcatenados. Esta cadena contiene los valores de la matriz datosProveedores, separados por comas.
            string datosConcatenados = string.Join(";", datosProveedores);
            //El código luego llama al método Grabar() de la clase grabado. Este método escribe la cadena datosConcatenados en un archivo de texto
            grabado.Grabar(datosConcatenados);

            numGuia++;
            lblNumProveedor.Text = numGuia.ToString();
            txtEntidad.Clear();
            txtApertura.Clear();
            txtExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();
            txtDireccion.Clear();
            txtLiquidador.Clear();
            MessageBox.Show("Proveedor cargado correctamente");
            frmInicio.contProv = 0;
            frmInicio.contCargar = 0;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEntidad.Clear();
            txtApertura.Clear();
            txtExpediente.Clear();
            txtJuzgado.Clear();
            txtJurisdiccion.Clear();
            txtDireccion.Clear();
            txtLiquidador.Clear();
        }
    }
}
