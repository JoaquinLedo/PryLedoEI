using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryLedoEI
{
    internal class clsArchivo
    {
        public void Grabar(string datosConcatenados)
        {
            StreamWriter AdeD = new StreamWriter("../../Resources/Carpetas de Proveedores/Datos Proveedores/ListadoAseguradores.csv", true); 
            AdeD.WriteLine(datosConcatenados); 
            AdeD.Close();
        }
    }
}
