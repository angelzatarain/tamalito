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
        List<String> carrito = new List<String>();
        String txt = "";
        

       
        Dictionary<String, Boolean> botonesActivos = new Dictionary<String, Boolean>()
        {
            ["verde"] = false,
            ["rojo"] = false,
            ["mole"] = false,
            ["dulce"] = false,
            ["arroz"] = false,
            ["vainilla"] = false,
            ["fresa"] = false,
            ["chocolate"] = false
        };
        Dictionary<String, int> cantSeleccionada = new Dictionary<String, int>()
        {
            ["verde"] = 0,
            ["rojo"] = 0,
            ["mole"] = 0,
            ["dulce"] = 0,
            ["arroz"] = 0,
            ["vainilla"] = 0,
            ["fresa"] = 0,
            ["chocolate"] = 0
        };


        public TomarOrden()
        {
            InitializeComponent();
        }
        private void Ventana_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                cbVerde.Items.Add(" " + i);
                cbRojo.Items.Add(" " + i);
                cbMole.Items.Add(" " + i);
                cbDulce.Items.Add(" " + i);
                cbArroz.Items.Add(" " + i);
                cbVainilla.Items.Add(" " + i);
                cbFresa.Items.Add(" " + i);
                cbChocolate.Items.Add(" " + i);
            }
            cbVerde.SelectedIndex = 0;
            cbRojo.SelectedIndex = 0;
            cbMole.SelectedIndex = 0;
            cbDulce.SelectedIndex = 0;
            cbArroz.SelectedIndex = 0;
            cbVainilla.SelectedIndex = 0;
            cbFresa.SelectedIndex = 0;
            cbChocolate.SelectedIndex = 0;
        }
        public void actualizaLista()
        {
            txt = "";
            foreach (var item in botonesActivos)
            {
                //carrito.Clear();
                if (item.Value)
                {
                    //carrito.Add(item.Key + "\t" + cantSeleccionada[item.Key] + "\t$" + (cantSeleccionada[item.Key]*12) );
                    txt = txt + item.Key + "\t" + cantSeleccionada[item.Key] + "\t$" + (cantSeleccionada[item.Key] * 15) + "\n";
                }
            }
            tbRecibo.Text = txt;
        }
        private void BtCancelar_Click(object sender, RoutedEventArgs e)
        {
            if (App.Current.Properties["usuarioActivo"].Equals("Empleado")) {
                Empleado main = new Empleado();
                main.Show();
                this.Close();
            }
            else{
                if (App.Current.Properties["usuarioActivo"].Equals("Gerente")) {
                    Gerente main = new Gerente();
                    main.Show();
                    this.Close();
                }
                else {
                    Dueño main = new Dueño();
                    main.Show();
                    this.Close();
                }
            }
        }

        

        private void BtFresa_Click(object sender, RoutedEventArgs e)
        {

        }
        private void CbVerde_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            cantSeleccionada["verde"]= int.Parse( cbVerde.SelectedItem.ToString() );
            
        }
        private void BtVerde_Click(object sender, RoutedEventArgs e)
        {
            if (!botonesActivos["verde"])
            {
                botonesActivos["verde"] = true;
                btVerde.BorderBrush = Brushes.Green;

            }
            else
            {
                botonesActivos["verde"] = false;
                btVerde.BorderBrush = null;
                
            }
            actualizaLista();
        }

        private void BtRojo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtMole_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }


}