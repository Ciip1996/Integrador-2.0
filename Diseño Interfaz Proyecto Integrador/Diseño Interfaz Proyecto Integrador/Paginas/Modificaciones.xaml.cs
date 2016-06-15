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
using Diseño_Interfaz_Proyecto_Integrador.Controles;
using BibliotecaClasesProyecto;
using Windows.UI;

namespace Diseño_Interfaz_Proyecto_Integrador
{
    public sealed partial class Modificaciones : Page
    {
       
        public Modificaciones()
        {
            this.InitializeComponent();
            if (Application.tema)
            {
                swTema.IsOn = true;
                
            }
            else
            {
                swTema.IsOn = false;
            }
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
                Application.tema = true;
                paginaModi.RequestedTheme = ElementTheme.Dark;
            }
            else
            {
                Application.tema = false;
                paginaModi.RequestedTheme = ElementTheme.Light;

            }
        }
        private void swTema_Toggled(object sender, RoutedEventArgs e)
        {
            configurar();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void TopAppBarAyuda(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Manual));
        }

        private void sldTransparencia_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Color.FromArgb((byte)sldTransparencia.Value, (byte)sldTransparencia.Value, (byte)sldTransparencia.Value, (byte)sldTransparencia.Value));
            this.cmbar.Background = brush;
        }
    }
}
