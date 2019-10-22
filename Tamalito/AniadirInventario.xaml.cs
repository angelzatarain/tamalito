using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.SqlClient;


namespace Tamalito
{
    /// <summary>
    /// Lógica de interacción para AniadirInventario.xaml
    /// </summary>
    public partial class AniadirInventario : Window
    {
        public AniadirInventario()
        {
            InitializeComponent();
        }

        private void BtConsultar_Click(object sender, RoutedEventArgs e)
        {
            if (!tbIdProducto.Equals("") )
                try
                {
                    SqlConnection con = Conexion.conectar();
                    SqlCommand cmd = new SqlCommand(String.Format("SELECT productos.inventario FROM productos WHERE idProducto={0}", int.Parse(tbIdProducto.Text)), con); 
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        lbInventarioActual1.Content = Convert.ToString(rd.GetInt32(0));
                    }
                    else
                    {
                        MessageBox.Show("Error en Query");
                    }
                    rd.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            else if (!tbNombre.Equals(""))
            {
                try
                {
                    SqlConnection con = Conexion.conectar();
                    SqlCommand cmd = new SqlCommand(String.Format("SELECT productos.inventario FROM productos WHERE nombre='{0}'", tbNombre.Text), con);
                    SqlDataReader rd;
                    rd = cmd.ExecuteReader();
                    if (rd.Read())
                    {
                        lbInventarioActual1.Content = rd.GetString(0);
                    }
                    else
                    {
                        MessageBox.Show("Error en Query");
                    }
                    rd.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error2: " + ex.Message);
                }
            }
        }

        private void BtContinuar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("UPDATE productos SET inventario= {0} WHERE idProducto={1}", (int.Parse(tbNuevoInventario.Text) + int.Parse(lbInventarioActual1.Content.ToString()) ), int.Parse(tbIdProducto.Text)), con);
                if (cmd.ExecuteNonQuery() == -1)
                    MessageBox.Show("No se pudo cambiar el precio");
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ ex.Message);
            }
        }

        private void BtCancelar_Click(object sender, RoutedEventArgs e)
        {
            if (App.Current.Properties["usuarioActivo"].Equals("Gerente"))
            {
                Gerente main = new Gerente();
                main.Show();
                this.Close();
            }
            else
            {
                Dueño main = new Dueño();
                main.Show();
                this.Close();
            }
        }
    }
}
