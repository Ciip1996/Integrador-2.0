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
using BibliotecaClasesProyecto;


namespace Diseño_Interfaz_Proyecto_Integrador
{
    public sealed partial class Bajas : Page
    {
        public TextBox NumAlmacen;
        public TextBox Cantidad;
        public TextBox CodigoProducto;
        public Bajas()
        {
            this.InitializeComponent();
            Button btn = (Button)btnBajar.FindName("button");
            btn.Content = "Aceptar";
            NumAlmacen = (TextBox)ctrlBajas.FindName("txtIdAlmacen");
            Cantidad = (TextBox)ctrlBajas.FindName("txtCantidad");
            CodigoProducto = (TextBox)ctrlBajas.FindName("txtCatalogo");
            if (Application.tema)
            {
                paginasBajas.RequestedTheme = ElementTheme.Dark;
            }
            else
            {
                paginasBajas.RequestedTheme = ElementTheme.Light;
            }
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
 
        private void btnBajar_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)btnBajar.Resources["stbButton"];
            sb.Begin();

            DSL_UWP cnn = new DSL_UWP();

            ToggleSwitch switcher = (ToggleSwitch)ctrlBajas.FindName("switcher");
            if (switcher.IsOn)
            {


                if (!Cantidad.Text.Equals("") && !NumAlmacen.Text.Equals(""))
                {
                    Inventario inventario = new Inventario()
                    {

                        NoEntrada = int.Parse(NumAlmacen.Text),
                        Cantidad = int.Parse(Cantidad.Text),

                    };
                    cnn.putObject("http://localhost:51550/api/Inventario", inventario);
                }
                else
                {
                    var dialogo = new Windows.UI.Popups.MessageDialog("Favor de no dejar campos vacios ","Error");
                    dialogo.Commands.Add(new Windows.UI.Popups.UICommand("OK") { Id = 0 });
                    dialogo.CancelCommandIndex = 0;
                    var result =  dialogo.ShowAsync();

                }
              
                
            }
            else
            {
                if (!CodigoProducto.Text.Equals("") && !CodigoProducto.Text.Equals(""))
                {
                    Catalogo catalogo = new Catalogo()
                    {
                        Codigo = CodigoProducto.Text
                    };
                    cnn.putObject("http://localhost:51550/api/Catalogo", catalogo);
                }
                else
                {
                    var dialogo = new Windows.UI.Popups.MessageDialog("Favor de no dejar campos vacios ", "Error");
                    dialogo.Commands.Add(new Windows.UI.Popups.UICommand("OK") { Id = 0 });
                    dialogo.CancelCommandIndex = 0;
                    var result = dialogo.ShowAsync();

                }
            }
            MostrarMensaje();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void TopAppBarAyuda(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Manual));
        }
        private async void MostrarMensaje()
        {
            var result = await MensajeAlta.ShowAsync();
        }
        private void ocultarMensaje(object sender, RoutedEventArgs e)
        {
            MensajeAlta.Hide();
        }
    }
}
