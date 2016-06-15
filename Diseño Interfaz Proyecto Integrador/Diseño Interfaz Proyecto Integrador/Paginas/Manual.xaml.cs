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
using System.Xml.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Windows.UI.Xaml.Media.Imaging;
namespace Diseño_Interfaz_Proyecto_Integrador
{
    public sealed partial class Manual : Page
    {
        public int contador;
        public DirectoryInfo imgManual;
        public List<Manual_Usuario> lstManualUsuario;
        public Manual()
        {
            this.InitializeComponent();
            Task cargarImagen = cargarImagenes();
            contador = 0;
        }
        public async Task cargarImagenes()
        {
            DSL_UWP cnn = new DSL_UWP();
            await cnn.getAll("http://localhost:51550/api/Manual");
            List<Object> lstObj = cnn.getContent();
            lstManualUsuario = new List<Manual_Usuario>();
            foreach (Object o in lstObj)
            {
                Manual_Usuario user = JsonConvert.DeserializeObject<Manual_Usuario>(o.ToString());
                lstManualUsuario.Add(user);
            }
            txtInfo.Text = lstManualUsuario[contador].Instruccion;
            img.Source = new BitmapImage(new Uri(this.BaseUri, "ms-appx:///Manual//" + lstManualUsuario[contador].Url)); 
        }
        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void TopAppBarAyuda(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Home));
        }

        private void AppBarSiguiente(object sender, RoutedEventArgs e)
        {
            if (contador < lstManualUsuario.Count - 1)
                contador++;
            else
                contador = 0;
            txtInfo.Text = lstManualUsuario[contador].Instruccion;
            img.Source = new BitmapImage(new Uri(this.BaseUri, "ms-appx:///Manual//" + lstManualUsuario[contador].Url)); //lstManualUsuario[contador].Url));
        }

        private void AppBarAnterior(object sender, RoutedEventArgs e)
        {
            if (contador > 0)
                contador--;
            else
                contador = (lstManualUsuario.Count - 1);
            img.Source = new BitmapImage(new Uri(this.BaseUri, "ms-appx:///Manual//" + lstManualUsuario[contador].Url)); //lstManualUsuario[contador].Url));
            txtInfo.Text = lstManualUsuario[contador].Instruccion;
        }
    }
}