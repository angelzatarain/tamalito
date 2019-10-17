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
            try
            {
                SqlConnection con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("select inventario from producto where idProducto={0}", int.Parse(tbIdProducto.Text)), con);
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
                MessageBox.Show("Error try catch");
            }
        }

        private void BtContinuar_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnection con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand(String.Format("insert into producto (inventario) values({0}) where idProducto={1}", int.Parse(tbNuevoInventario.Text) + int.Parse(lbInventarioActual1.Content.ToString()), int.Parse(tbIdProducto.Text)), con);
                if (cmd.ExecuteNonQuery() == -1)
                    MessageBox.Show("No se pudo cambiar el precio");
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error try catch");
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
