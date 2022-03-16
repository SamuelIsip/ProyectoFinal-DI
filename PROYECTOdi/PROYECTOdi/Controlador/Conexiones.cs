using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTOdi.Controlador
{
    class Conexiones
    {


        //CONEXIÓN A ORACLE
        String stringConexion = "User Id=di2;Password=di2;Data Source=xe;";

        //OBJTOS UTILIZADOS PARA HACER CONEXIONES O COMANDOS
        public OracleConnection objConexion = new OracleConnection();
        private OracleCommand objComando;


        //MÉTODO QUE HACE LA CONEXIÓN (DEVUELVE OBJETO CON CONEXION ABIERTA, HAY QUE CERRAR DESPUES DE UTILIZAR)
        public OracleConnection hacerConexion()
        {
            objConexion.ConnectionString = stringConexion;
            objConexion.Open();

            return objConexion;
        }


        //----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS GENERALES

        //Método que rellena el ComboBox de RA
        public OracleDataReader selectRA()
        {
            //Inicializamos el comando. Para ello necesitamos un objeto OracleConnection
            objComando = hacerConexion().CreateCommand();
            objComando.CommandText = "select nombre from ra";
            objComando.CommandType = System.Data.CommandType.Text;
            OracleDataReader lector = objComando.ExecuteReader();
            return lector;
        }

        //Método que rellena el ComboBox de CEV
        public OracleDataReader selectCEV(String nombreRA)
        {
            //Inicializamos el comando. Para ello necesitamos un objeto OracleConnection
            objComando = hacerConexion().CreateCommand();
            objComando.CommandText = "select nombre from cev where cod_ra=(select cod_ra from RA where nombre='" + nombreRA + "')";
            objComando.CommandType = System.Data.CommandType.Text;
            OracleDataReader lector = objComando.ExecuteReader();
            return lector;
        }

        //Método que compuerba USUARIO y CONTRASEÑA
        public int comprobarLogin(string usuario, string contrasenia)
        {
            objComando = hacerConexion().CreateCommand();
            objComando.CommandText = "select * from profesores where usuario= '" + usuario + "' and contra = '" + contrasenia + "'";
            objComando.CommandType = System.Data.CommandType.Text;

            DataTable dt = new DataTable();
            dt.Load(objComando.ExecuteReader());

            objConexion.Close();

            //Si el select devuelve más de una fila es que ha encontrado el usuario ya registrado, si es <0 entonces no lo ha encontrado
            if (dt.Rows.Count > 0)
            {
                return 1;
            }
            else
                return 0;

        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------


        //----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS DE YURIY

        //Método que rellena el DataGrid con la preguntas
        public OracleDataReader select(String sentencia)
        {
            //Inicializamos el comando. Para ello necesitamos un objeto OracleConnection
            objComando = hacerConexion().CreateCommand();
            objComando.CommandText = sentencia;
            objComando.CommandType = System.Data.CommandType.Text;
            OracleDataReader lector = objComando.ExecuteReader();
            return lector;
        }
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------


        //----------------------------------------------------------------------------------------------------------------------------------------------------------------
        //MÉTODOS DE JOSE
        //Metodo para rellenar el dataGrid de RA

        /*public OracleConnection ora = new OracleConnection("Data Source=(DESCRIPTION ="
        + "(ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = LOCALHOST)(PORT = 1521)))"
        + "(CONNECT_DATA = (SERVICE_NAME = XE))); "
        + "User Id=di2; Password=di2;");*/

        public DataTable SelectRA(String sentencia)
        {
            objConexion = hacerConexion();
            OracleCommand oc = objConexion.CreateCommand();
            oc.CommandText = sentencia;
            oc.CommandType = System.Data.CommandType.Text;
            OracleDataReader lector = oc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(lector);
            lector.Close();
            objConexion.Close();

            return dt;
        }

        public void InsertRA(String sentencia)
        {
            try
            {
                objConexion = hacerConexion();
                OracleCommand oc = objConexion.CreateCommand();
                oc.CommandText = sentencia;
                oc.CommandType = System.Data.CommandType.Text;
                oc.ExecuteNonQuery();
                objConexion.Close();
            }
            catch (OracleException oe)
            {
                System.Windows.Forms.MessageBox.Show("Error al insertar el producto");
                objConexion.Close();
            }
        }

        public void verDatosRA(System.Windows.Forms.DataGridView dgra)
        {
            DataTable dt = SelectRA("SELECT NOMBRE, NOTA FROM RA");
            dgra.DataSource = dt;
            dgra.Show();
        }

        public void anadeRA(String nombre, double nota)
        {
            InsertRA("INSERT INTO RA(nombre, nota) VALUES('" + nombre + "'," + nota + ")");
        }

        public void modificaRA(String nombre, String nomOld)
        {
            InsertRA("UPDATE RA SET NOMBRE ='" + nombre + "' WHERE NOMBRE = '" + nomOld + "'");
        }

        public void eliminaRA(String nombre, double nota)
        {
            InsertRA("DELETE FROM RA WHERE NOMBRE = '" + nombre + "'");
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------

    }


}

