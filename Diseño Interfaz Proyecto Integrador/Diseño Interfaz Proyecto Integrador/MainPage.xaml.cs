using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
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
using ConexionUWP;
using System.Threading.Tasks;

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409
namespace Diseño_Interfaz_Proyecto_Integrador
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Button btn;
        public Storyboard sb;
        public MainPage()
        {
            this.InitializeComponent();
            btn = (Button)btnIniciar.FindName("button");
            btn.Content = "Iniciar Sesión";
        }
        private void Grid_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Storyboard sb = (Storyboard)btnIniciar.Resources["stbButton"];
            //sb.Begin();
           string usuario = txtUsuario.Text;
            string contraseña = password.Password;
            DSL_UWP conexion = new DSL_UWP();
            string sUser = "usuario=" + usuario;
            string sPassword = "&contraseña=" + contraseña;
            string url = "http://localhost:51550/api/Empleado?" + sUser + sPassword;
            Task variable = evaluarContraseña(url);
        }

        private void btnAyuda_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Manual));
        }

        public async Task evaluarContraseña(string url)
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = new HttpResponseMessage();
            List<Object> content;
            String StringOutput;
            response = await httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            content = await response.Content.ReadAsAsync<List<Object>>();
            Object o = content[0];
            StringOutput = o.ToString();
            if (StringOutput == "1"){
                Frame.Navigate(typeof(Home));
            }
            else
            {

            }
        }

        private void btnSeguir_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Home));
        }

    
    }
}
