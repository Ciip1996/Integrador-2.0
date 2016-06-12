using ConexionUWP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Diseño_Interfaz_Proyecto_Integrador
{
    public sealed partial class Administracion : Page
    {
        public Administracion()
        {
            this.InitializeComponent();
            Button btn = (Button)btnAltaAdmin.FindName("button");
            btn.Content = "Aplicar";
            //rootPivot
        }
        private void btnAltas_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Altas));
        }

        private void btnBajas_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Bajas));
        }

        private void btnConsultas_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Consultas));
        }

        private void btnModificaciones_Click(object sender, RoutedEventArgs e)
        {
           Frame.Navigate(typeof(Modificaciones));

        }

        private void btnAdministracion_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Administracion));

        }
        private void BotonAnimado_Loaded(object sender, RoutedEventArgs e)
        {
          
        }

        private void btnAltaAdmin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)btnAltaAdmin.Resources["stbButton"];
            sb.Begin();
            switch (rootPivot.SelectedIndex)
            {
                case 0:
                    TextBox nombre = (TextBox)AltaEmpleado.FindName("txtNombre");
                    TextBox paterno = (TextBox)AltaEmpleado.FindName("txtPaterno");
                    TextBox materno = (TextBox)AltaEmpleado.FindName("txtMaterno");
                    PasswordBox contraseña = (PasswordBox)AltaEmpleado.FindName("txtContraseña");
                    TextBox pregunta = (TextBox)AltaEmpleado.FindName("txtPregunta");
                    TextBox respuesta = (TextBox)AltaEmpleado.FindName("txtRespuesta");
                   
                    Empleado empleadoAlta = new Empleado() {
                        Nombre = nombre.Text + " " + paterno.Text + " " + materno.Text,
                        FechaIngreso = DateTime.Now,
                        Contraseña = contraseña.Password,
                        Pregunta = pregunta.Text,
                        Respuesta = respuesta.Text
                    };
                    break; 
                case 1:
                    TextBox nombreModi = (TextBox)ModificacionEmpleado.FindName("txtNombre");
                    TextBox contraseñaModi = (TextBox)ModificacionEmpleado.FindName("txtContraseña");
                    TextBox preguntaModi = (TextBox)ModificacionEmpleado.FindName("txtPregunta");
                    TextBox respuestaModi = (TextBox)ModificacionEmpleado.FindName("txtRespuesta");
                    //DSL_UWP cnn = new DSL_UWP();
                    //cnn.getAllByParameter("localhost/Api/Empleado/","1");
                    /*LA CONEXION ME TRAE LOS DATOS Y LOS PONGO EN LOS CONTROLES ARRIBA DECLARADOS*/
                    break;
            }
        }
    }
}
