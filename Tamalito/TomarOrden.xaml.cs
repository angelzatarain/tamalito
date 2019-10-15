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
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Data.SqlClient;

namespace Tamalito
{
    /// <summary>
    /// Lógica de interacción para TomarOrden.xaml
    /// </summary>
    public partial class TomarOrden : Window
    {
        List<Producto> lis;
        List<String> carrito = new List<String>();

        
        public TomarOrden()
        {
            InitializeComponent();
        }

        

        private void Ventana_Loaded(object sender, RoutedEventArgs e)
        {
            Producto prod;
            lis = new List<Producto>();

            //Traer todos los productos de la BD y guardarlos en una lista:
            try
            {
                
                SqlConnection con = Conexion.conectar();
                SqlCommand cmd = new SqlCommand("SELECT * FROM productos", con);
                SqlDataReader rd = cmd.ExecuteReader();
                
                while (rd.Read()){
                    prod = new Producto();
                    prod.IdProducto = rd.GetInt32(0);
                    prod.costo = rd.GetInt32(1);
                    prod.inventario = rd.GetInt32(2);
                    prod.nombre = rd.GetString(3);
                    prod.descripcion = rd.GetString(4);
                    prod.categoria = rd.GetString(5);
                    prod.tiempoPreparacion = rd.GetInt32(6);
                    prod.urlImagen = rd.GetString(7);
                    lis.Add(prod);
                }
                con.Close();

            }catch (Exception ex){
                MessageBox.Show("Error en conexion o query: " + ex.Message);
            }


            //Generar dinámicamente el menú de productos:
            try{
                //Genera el grid correspondiente de cuatro columnas por lo que dé de renglones:
                int n = lis.Count();
                grid.Columns = 4;
                if (n % 4 != 0)
                    grid.Rows = (n / 4) + 1;
                else
                    grid.Rows = (n / 4);


                for (int i = 0; i < n; i++){

                    Button bt = new Button();
                    Uri resourceUri = new Uri(lis[i].urlImagen , UriKind.Relative);
                    StreamResourceInfo streamInfo = Application.GetResourceStream(resourceUri);
                    BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                    var brush = new ImageBrush();
                    brush.ImageSource = temp;
                    bt.Background = brush;
                    grid.Children.Add(bt);

                    bt.Tag = lis[i].IdProducto;
                    //AddEvent:
                    bt.Click += delegate{
                        //carrito.Add(bt.Content.ToString);     
                    }; 
                }
            }catch(Exception ex){
                MessageBox.Show("Error al generar el menú de productos: " + ex);
            }
        }

       
    }


}