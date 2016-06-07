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
            string url = "http://localhost:59511/Api/Customer";
            var httpClient = new HttpClient();
            var response = await httpClient.GetAsync(url);// Aqui se define si es GET, GET(n), PUT, POST y DELETE.
            response.EnsureSuccessStatusCode(); //si la respuesta tiene un 200 fue exitoso. sino no
            //Descargar MyToolkit.Extended por Rico Suter
            List<Persona> content = await response.Content.ReadAsAsync<List<Persona>>();//para correr esta linea bajar una extension del nuget: Microsoft.AspNet.webapi.client
            dgPersona.ItemsSource = content; //Descomentar cuando este listo el xaml con el toolkit:datadrid
            dgPersona.Items.Refresh();  //Descomentar cuando este listo el xaml con el toolkit:datadrid
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
