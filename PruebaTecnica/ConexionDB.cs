using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PruebaTecnica
{
    class ConexionDB
    {
        public static DataSet Coneccion(string cmd)
        {
            string connetionString = "Data Source=sql7002.site4now.net;Initial Catalog = DB_A45724_PruebaTecnica; User ID = DB_A45724_PruebaTecnica_admin; Password = Rous1234.";
            SqlConnection Con = new SqlConnection(connetionString);
            Con.Open();
            DataSet DS = new DataSet();
            SqlDataAdapter DP = new SqlDataAdapter(cmd, Con);
            DP.Fill(DS);
            Con.Close();
            return DS;
        }
    }
}
