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
using Windows.UI.Xaml.Navigation;

namespace Diseño_Interfaz_Proyecto_Integrador
{
    public sealed partial class Modificaciones : Page
    {
        public Modificaciones()
        {
            this.InitializeComponent();
            string[] array = new string[3];
            array[0] = "Ivan";
            array[1] = "Cesar";
            array[2] = "Cris";
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
