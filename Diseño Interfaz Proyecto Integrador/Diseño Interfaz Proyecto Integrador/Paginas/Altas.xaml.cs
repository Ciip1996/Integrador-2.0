using Newtonsoft.Json;
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

        }

        private void AltasControl_Loaded(object sender, RoutedEventArgs e)
        {

        }

        /*static async Task funcionRunAsync()
        {
            string url = "http://localhost/MiPrimerWebService/WS1.asmx/InsertarCredencial";//ruta del servidor IIS (tipo apache)
            var httpClientHandler = new HttpClientHandler();//manejador del cliente http
            httpClientHandler.UseDefaultCredentials = true;//creamos el clinte de http
            var httpClient = new HttpClient(httpClientHandler);
            var response = await httpClient.GetAsync(url);//consumir obtener asincronamente el url lleva el await con el metodo asincrono sino es asincrono entonces no lleva el await. lo guarda en reponse (respuesta)
            //Si response es 200 trajo correctamente la info. Si trae un 400-500,etc eseta mal.
            response.EnsureSuccessStatusCode();
       }*/
    }
}
