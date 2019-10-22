using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

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
            SqlCommand cmd = new SqlCommand(String.Format("insert into empleados (nombre, apellidoP, apellidoM, fechaNac, sexo, direccion, puesto, contrasenia) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')", e.nombre, e.apellidoP, e.apellidoM, e.fechaNac, e.sexo, e.direccion, e.puesto, e.contras), con);
            res = cmd.ExecuteNonQuery();
            con.Close();
            return res;
        }

        public int eliminar(int idEmpleado, String nombre, String apellidoP, String apellidoM)
        {
            try
            {
                int res = -1;
                SqlConnection con;
                con = Conexion.conectar();
                if (Conexion.comprobarEmpleo(idEmpleado)>0) {
                    SqlCommand cmd1 = new SqlCommand(String.Format("select empleados.nombre, empleados.apellidoP, empleados.apellidoM from empleados where empleados.idEmpleado={0}", idEmpleado), con);
                    SqlDataReader rd = cmd1.ExecuteReader();
                    //Para validar datos
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd.GetString(0).Equals(nombre) && rd.GetString(1).Equals(apellidoP) && rd.GetString(2).Equals(apellidoM))
                        {
                            //Se validaron los datos, ahora podemos dar de baja al empleado
                            rd.Close();
                            SqlCommand cmd2 = new SqlCommand(String.Format("update empleados set activo={0} where empleados.idEmpleado={1}", 0, idEmpleado), con);
                            res = cmd2.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return -1;
            }
        }

        public int modificarPuesto(int idEmpleado, String nombre, String apellidoP, String apellidoM, String puesto)
        {
            try
            {
                int res = -1;
                SqlConnection con;
                con = Conexion.conectar();
                if (Conexion.comprobarEmpleo(idEmpleado)>0)
                {
                    SqlCommand cmd1 = new SqlCommand(String.Format("select empleados.nombre, empleados.apellidoP, empleados.apellidoM from empleados where empleados.idEmpleado={0}", idEmpleado), con);
                    SqlDataReader rd = cmd1.ExecuteReader();
                    //Para validar datos
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd.GetString(0).Equals(nombre) && rd.GetString(1).Equals(apellidoP) && rd.GetString(2).Equals(apellidoM))
                        {
                            //Se validaron los datos, ahora podemos dar de baja al empleado
                            rd.Close();
                            SqlCommand cmd2 = new SqlCommand(String.Format("update empleados set puesto='{0}' where empleados.idEmpleado={1}", puesto, idEmpleado), con);
                            res = cmd2.ExecuteNonQuery();
                            con.Close();
                        }
                    }
                }
                return res;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return -1;
            }
        }

    }
}
