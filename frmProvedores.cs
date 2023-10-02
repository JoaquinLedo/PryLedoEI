﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryLedoEI
{
    public partial class frmProvedores : Form
    {
        public frmProvedores()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void frmProvedores_Load(object sender, EventArgs e)
        {

        }
        
        public static string rutaArchivo = "../../Resources/Carpetas de Proveedores/Datos Proveedores/ListadoAseguradores.csv";

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtModificarEntidad.Clear();
            txtModificarApertura.Clear();
            txtModificarExpediente.Clear();
            txtModificarJuzgado.Clear();
            txtModificarJurisdiccion.Clear();
            txtModificarDireccion.Clear();
            txtModificarLiquidador.Clear();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            string posicion = frmMostrarProvedores.pos.ToString();
            List<string> lista = new List<string>();
            using (StreamReader leer = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = leer.ReadLine()) != null)
                {
                    string[] parametros = linea.Split(';');

                    if (parametros[0] != frmMostrarProvedores.pos.ToString())
                    {
                        lista.Add(linea);
                    }
                    else
                    {
                        string lineaDos = lblModificarNumProveedor.Text + ";" + txtModificarEntidad.Text + ";" + txtModificarApertura.Text + ";" + txtModificarExpediente.Text + ";" + txtModificarJuzgado.Text + ";" + txtModificarJurisdiccion.Text + ";" + txtModificarDireccion.Text + ";" + txtModificarLiquidador.Text + ";";
                        lista.Add(lineaDos);
                    }
                }
            }

            using (StreamWriter escribir = new StreamWriter(rutaArchivo))
            {
                foreach (string linea in lista)
                {
                    escribir.WriteLine(linea);
                }
            }

            MessageBox.Show("Proveedor Modificado con exito");
            this.Hide();
        }

        private void btnBorrarProveedor_Click_1(object sender, EventArgs e)
        {
            string posicion = frmMostrarProvedores.pos.ToString();
            List<string> lista = new List<string>();
            using (StreamReader leer = new StreamReader(rutaArchivo))
            {
                string linea;
                while ((linea = leer.ReadLine()) != null)
                {
                    string[] parametros = linea.Split(';');

                    if (parametros[0] != frmMostrarProvedores.pos.ToString())
                    {
                        lista.Add(linea);
                    }
                }
                MessageBox.Show("Proveedor Borrado con exito");
                frmInicio.contProv = 0;
                frmInicio.contCargar = 0;
                this.Hide();
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {

        }
    }
}


