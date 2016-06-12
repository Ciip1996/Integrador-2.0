using Newtonsoft.Json;
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
using Diseño_Interfaz_Proyecto_Integrador.Controles;
using ConexionUWP;

namespace Diseño_Interfaz_Proyecto_Integrador
{

    public sealed partial class Consultas : Page
    {
        public static DSL_UWP cnn;
        public static List<Inventario> inventario;
        public Consultas()
        {
            this.InitializeComponent();
        }
        public async Task consultarPorID()//Metodo 
        {
            cnn = new DSL_UWP();
            string numero = txtBuscar.Text;
            await cnn.getAllByParameter("http://localhost:51550/Api/Inventario/",numero);
            Parseador parseador = new Parseador();
            inventario = parseador.InventarioCast(cnn.getContent());
            dgPersona.ItemsSource = inventario;
            dgPersona.Items.Refresh();
        }
        public async Task consultarTodo()//Metodo 
        {
            cnn = new DSL_UWP();
            await cnn.getAll("http://localhost:51550/Api/Inventario");
            Parseador parseador = new Parseador();
            inventario = parseador.InventarioCast(cnn.getContent());
            dgPersona.ItemsSource = inventario;
            dgPersona.Items.Refresh();
        }
        public async Task consultarPorCodigo()//Metodo 
        {
            cnn = new DSL_UWP();
            string codigo = txtBuscar.Text;
            await cnn.getAllByParameter("http://localhost:51550/Api/Inventario?codigo=",codigo);
            Parseador parseador = new Parseador();
            inventario = parseador.InventarioCast(cnn.getContent());
            dgPersona.ItemsSource = inventario;
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
        private void btnConsulta_Click(object sender, RoutedEventArgs e)
        {
            switch (cboBuscarPor.SelectedIndex) {
                case 0:
                    Task tsk1 = consultarTodo();
                    break;
                case 1:
                    Task tsk2 = consultarPorID();
                    break;
                case 2:
                    Task tsk3 = consultarPorCodigo();
                    break;
            }
            
        }
    }
}
