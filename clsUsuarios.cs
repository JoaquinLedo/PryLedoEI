using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace pryLedoEI
{
   
    internal class clsUsuarios
    {
        OleDbConnection conexionBD;
        public void AbrirBSD()
        {
            conexionBD = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source =E:@.. / .. / Resources /Database11.accdb ");
            conexionBD.Open();
        }

    
    }
}
