using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Tamalito
{
    class Empleados
    {
        public int idEmpleado { get; set; }
        public String nombre { get; set; }
        public String apellidoP { get; set; }
        public String apellidoM { get; set; }
        public String fechaNac { get; set; }
        public char sexo { get; set; }
        public String direccion { get; set; }
        public String puesto { get; set; }
        public String contras { get; set; }

        public Empleados()
        {

        }


        public Empleados(int idEmpleado, String nombre, String apellidoP, String apellidoM, String fechaNac, char sexo, String direccion, String puesto, String contras)
        {
            this.idEmpleado = idEmpleado;
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.fechaNac = fechaNac;
            this.sexo = sexo;
            this.direccion = direccion;
            this.puesto = puesto;
            this.contras = contras;

        }

        public int agregar(Empleados e)
        {
            int res = 0;
            SqlConnection con;
            con = Conexion.conectar();

            SqlCommand cmd = new SqlCommand(String.Format("insert into empleados (idEmpleado, nombre, apellidoP, apellidoM, fechaNac, sexo, direccion, puesto, contrasenia) values ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')", e.idEmpleado, e.nombre, e.apellidoP, e.apellidoM, e.fechaNac, e.sexo, e.direccion, e.puesto, e.contras), con);
            res = cmd.ExecuteNonQuery();
            con.Close();

            return res;
        }

        public int eliminar(int idEmpleado, String nombre, String apellidoP, String apellidoM)
        {
            int res = 0;
            SqlConnection con;
            con = Conexion.conectar();

            SqlCommand cmd = new SqlCommand(String.Format("delete from empleados where idEmpleado = {0} and nombre = '{1}' and apellidoP = '{2}' and apellidoM = '{3}'", idEmpleado, apellidoP, apellidoM), con);
            res = cmd.ExecuteNonQuery();
            con.Close();

            return res;
        }

    }
}
