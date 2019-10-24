﻿using System;
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
    /// Lógica de interacción para IniciarSesion.xaml
    /// </summary>
    public partial class IniciarSesion : Window
    {
        
        public IniciarSesion()
        {
            InitializeComponent();
        }

        private void BtRegresar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main;
            main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void BtContinuar_Click(object sender, RoutedEventArgs e)
        {
            int idEm;
            try
            {
                idEm = int.Parse(tbUsuario.Text);
                int res = Conexion.comprobarEmpleo(idEm);
                if (res>0)
                {
                    if (Conexion.comprabarPwd(idEm, pbContra.Password))
                    {
                        SqlConnection con;
                        SqlDataReader rd;
                        con = Conexion.conectar();
                        SqlCommand cmd = new SqlCommand(String.Format("select puesto from empleados where idEmpleado= {0} and contrasenia = '{1}'", idEm, pbContra.Password), con);
                        rd = cmd.ExecuteReader();
                        App.Current.Properties["idUsuarioActivo"] = tbUsuario.Text;
                        if (rd.Read())
                        {
                            if (rd.GetString(0).Equals("Empleado"))
                            {
                                App.Current.Properties["usuarioActivo"] = "Empleado";
                                Empleado w = new Empleado();
                                w.Show();
                                this.Close();
                            }
                            else
                            {
                                if (rd.GetString(0).Equals("Gerente"))
                                {
                                    App.Current.Properties["usuarioActivo"] = "Gerente";
                                    Gerente w = new Gerente();
                                    w.Show();
                                    this.Close();
                                }
                                else
                                {
                                    if (rd.GetString(0).Equals("Dueño"))
                                    {
                                        App.Current.Properties["usuarioActivo"] = "Dueño";
                                        Dueño w = new Dueño();
                                        w.Show();
                                        this.Close();
                                    }
                                }
                            }

                        }
                        con.Close();
                        rd.Close();
                    }
                    else
                        MessageBox.Show("contraseña incorrecta");
                }
                else {
                    if(res<0)
                        MessageBox.Show("El empleado no existe");
                    else
                        MessageBox.Show("El empleado ya no trabaja aquí");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
