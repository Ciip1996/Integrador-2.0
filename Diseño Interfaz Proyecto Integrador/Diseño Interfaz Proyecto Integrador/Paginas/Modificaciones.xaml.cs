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
        public bool[] swArray;
        public Modificaciones()
        {
            this.InitializeComponent();
            swArray = new bool[5];
            if (swArray[0]) swTema.IsOn = true;
            else swTema.IsOn = false;
            configurar();
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
        public void configurar()
        {
            if (swTema.IsOn)
            {
                swArray[0] = true;
                paginaModi.RequestedTheme = ElementTheme.Dark;
            }
            else
            {
                swArray[0] = false;
                paginaModi.RequestedTheme = ElementTheme.Light;

            }
        }
        private void swTema_Toggled(object sender, RoutedEventArgs e)
        {
            configurar();
        }
    }
}
