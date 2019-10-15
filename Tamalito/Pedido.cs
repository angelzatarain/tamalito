using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows;

namespace Tamalito
{
    class Pedido
    {
        private int IdPedido { get; set; }
        private String fecha { get; set; }
        private String hora { get; set; }

        public Pedido(int idPedido, string fecha, string hora)
        {
            IdPedido = idPedido;
            this.fecha = fecha;
            this.hora = hora;
        }

        private int horaEntrega(int IdPedido)
        {
            try
            {
                SqlConnection con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("select idProducto from pedidosProductos where idPedido={0}", IdPedido), con);
                SqlDataReader rd;
                rd = cmd.ExecuteReader();
                int i = 0, tiempo = 0;
                while (rd.GetString(i) != null)
                {
                    cmd = new SqlCommand(String.Format("select cantidad from pedidosProductos where idProducto={0} and idPedido={1}", int.Parse(rd.GetString(i)), IdPedido), con);
                    SqlDataReader rd1 = cmd.ExecuteReader();
                    cmd = new SqlCommand(String.Format("select tiempoPreparacion from productos where idProducto={0}", int.Parse(rd.GetString(i))), con);
                    SqlDataReader rd2 = cmd.ExecuteReader();
                    tiempo = tiempo + int.Parse(rd1.GetString(0)) * int.Parse(rd2.GetString(0));
                    rd1.Close();
                    rd2.Close();
                    i++;
                }
                rd.Close();
                con.Close();
                return tiempo;
            } catch (Exception){
                return -1;
            }
        }
    }
}
