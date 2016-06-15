using BibliotecaClasesProyecto;
using ConexionUWP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;
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
    public sealed partial class Altas : Page
    {
        public object JsonConvert { get; private set; }
        public TextBox txtCodigoCat;
        public TextBox txtDescripcionCat;
        public TextBox txtPrecioVenta;
        public TextBox txtPrecioCompra;
        public TextBox txtEstiloCat;
        public ComboBox cboMarca;
        public CalendarDatePicker fechaEntrada;
        public TextBox txtCodigoInv;
        public TextBox txtObservaciones;
        public TextBox txtCantidadInv;
        public ComboBox cboCategoria;
        public Altas()
        {
            this.InitializeComponent();
            if (Application.tema)
            {
                paginaAltas.RequestedTheme = ElementTheme.Dark;
            }
            else
            {
                paginaAltas.RequestedTheme = ElementTheme.Light;
            }
                Button btn = (Button)btnSubir.FindName("button");
            btn.Content = "Aceptar";
            txtCodigoInv = (TextBox)controlAltaInventario.FindName("txtCodigo");
            txtObservaciones = (TextBox)controlAltaInventario.FindName("txtObservaciones");
            txtCantidadInv = (TextBox)controlAltaInventario.FindName("txtCantidad");
            cboCategoria = (ComboBox)controlAltaInventario.FindName("cboCategoria");
            fechaEntrada = (CalendarDatePicker)controlAltaInventario.FindName("fechaEntrada");

            cboMarca = (ComboBox)controlAltaCatalogo.FindName("cboMarca");
            txtCodigoCat = (TextBox)controlAltaCatalogo.FindName("txtCodigo");
            txtEstiloCat = (TextBox)controlAltaCatalogo.FindName("txtEstilo");
            txtDescripcionCat = (TextBox)controlAltaCatalogo.FindName("txtDescripcion");
            txtPrecioVenta = (TextBox)controlAltaCatalogo.FindName("txtPrecioVenta");
            txtPrecioCompra = (TextBox)controlAltaCatalogo.FindName("txtPrecioMaquila");

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
        private void btnSubir_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)btnSubir.Resources["stbButton"];
            sb.Begin();
            DSL_UWP cnn = new DSL_UWP();

            if (rootPivot.SelectedIndex == 0)
            {
                Inventario inventario = new Inventario {
                    Codigo = txtCodigoInv.Text,
                    Observaciones = txtObservaciones.Text,
                    Cantidad = int.Parse(txtCantidadInv.Text),
                    Categoria = cboCategoria.SelectedIndex + 1,
                    FechaEntrada = Convert.ToDateTime(fechaEntrada.Date.Value.ToString())
                };
                cnn.postObject("http://localhost:51550/api/Inventario", inventario);
                cnn.getResponse();
            }
            else
            {
                Catalogo catalogo = new Catalogo
                {
                    Codigo = txtCodigoCat.Text,
                    Estilo = txtEstiloCat.Text,
                    PrecioCompra = float.Parse(txtPrecioCompra.Text),
                    PrecioVenta = float.Parse(txtPrecioVenta.Text),
                    Marca = cboMarca.SelectedIndex+1,
                    Descripcion = txtDescripcionCat.Text
                };
                cnn.postObject("http://localhost:51550/api/Catalogo", catalogo);

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
