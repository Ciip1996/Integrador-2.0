using ConexionUWP;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class Consultas : Page
    {
        public Consultas()
        {
            this.InitializeComponent();
            Task tarea = RunAsync();
         
        }
         public async Task RunAsync()//Metodo 
         {
            DSL_UWP cnn = new DSL_UWP();
            await cnn.solicitarInventario("http://localhost:51550/Api/Inventario");
            dgPersona.ItemsSource = cnn.obtenerInventario();
            dgPersona.Items.Refresh();
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
    }
}
