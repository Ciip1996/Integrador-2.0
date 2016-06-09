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
using Windows.UI.Xaml.Navigation;

namespace Diseño_Interfaz_Proyecto_Integrador
{
    public sealed partial class Altas : Page
    {
        public object JsonConvert { get; private set; }

        public Altas()
        {
            this.InitializeComponent();
          //  funcionRunAsync();
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

        private void btnSubir_Click(object sender, RoutedEventArgs e)
        {
            TextBox caja1 = (TextBox)controlAltas.["txtCodigo"];
        }
        private void AltasControl_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
