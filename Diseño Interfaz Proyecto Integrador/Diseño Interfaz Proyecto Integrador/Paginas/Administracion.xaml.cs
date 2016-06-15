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
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using BibliotecaClasesProyecto;


namespace Diseño_Interfaz_Proyecto_Integrador
{
    public sealed partial class Administracion : Page
    {
        public TextBox nombre;
        public TextBox paterno;
        public TextBox materno;
        public PasswordBox contraseña;
        public TextBox pregunta;
        public TextBox respuesta;
        public TextBox nombreModi;
        public TextBox contraseñaModi;
        public TextBox confirmarModi;
        public TextBox preguntaModi;
        public TextBox respuestaModi;
        public ComboBox cbo;
        public ComboBox cboPuesto;
        public CalendarDatePicker fechaIngreso;
        public CalendarDatePicker fechaEgreso;
        public ToggleSwitch swEstatus;

        public Administracion()
        {
            this.InitializeComponent();
            if (Application.tema)
            {
                paginaAdmin.RequestedTheme = ElementTheme.Dark;
            }
            else
            {
                paginaAdmin.RequestedTheme = ElementTheme.Light;
            }
            cargarControles();
            Task v = cargarEmpleados();
        }
        public void cargarControles()
        {
            Button btn = (Button)btnAltaAdmin.FindName("button");
            btn.Content = "Aplicar";
            nombre = (TextBox)AltaEmpleado.FindName("txtNombre");
            paterno = (TextBox)AltaEmpleado.FindName("txtPaterno");
            materno = (TextBox)AltaEmpleado.FindName("txtMaterno");
            contraseña = (PasswordBox)AltaEmpleado.FindName("txtContraseña");
            pregunta = (TextBox)AltaEmpleado.FindName("txtPregunta");
            respuesta = (TextBox)AltaEmpleado.FindName("txtRespuesta");
            cboPuesto = (ComboBox)ModificacionEmpleado.FindName("cboPuesto");

            cbo = (ComboBox)ModificacionEmpleado.FindName("cboEmpleados");
            cbo.SelectionChanged += (o, s) =>
            {
                Task cargar = cargarEmpleado();
            };
            nombreModi = (TextBox)ModificacionEmpleado.FindName("txtNombre");
            contraseñaModi = (TextBox)ModificacionEmpleado.FindName("txtContraseña");
            confirmarModi = (TextBox)ModificacionEmpleado.FindName("txtConfirmar");
            fechaIngreso = (CalendarDatePicker)ModificacionEmpleado.FindName("fechaIngreso");
            fechaEgreso = (CalendarDatePicker)ModificacionEmpleado.FindName("fechaEgreso");
            fechaEgreso.Date = DateTime.Now;
            swEstatus = (ToggleSwitch)ModificacionEmpleado.FindName("switchLaborando");
            swEstatus.Toggled += (o, s) => 
            {
                cambioSwithc();
            };
            nombreModi.IsEnabled = false;
            contraseñaModi.IsEnabled = false;
            fechaIngreso.IsEnabled = false;
            fechaEgreso.IsEnabled = false;
            swEstatus.IsEnabled = false;
            cboPuesto.IsEnabled = false;
            confirmarModi.IsEnabled = false;
        }
        public void cambioSwithc()
        {
            if (swEstatus.IsOn)
                fechaEgreso.IsEnabled = false;
            else
                fechaEgreso.IsEnabled = true;
        }
        private async Task cargarEmpleado()
        {
            nombreModi.IsEnabled = true;
            contraseñaModi.IsEnabled = true;
            fechaIngreso.IsEnabled = true;
            fechaEgreso.IsEnabled = true;
            swEstatus.IsEnabled = true;
            cboPuesto.IsEnabled = true;
            DSL_UWP cnn = new DSL_UWP();
            Parseador parseador = new Parseador();
            int pID = cbo.SelectedIndex + 1;
            await cnn.getAllByParameter("http://localhost:51550/api/Empleado?pId=", pID.ToString());
            List<Object> list = cnn.getContent();
            List<Empleado> empleado = parseador.EmpleadosCast(list);
            if (empleado[0].Estatus == 1)
            {
                swEstatus.IsOn = true;
                fechaEgreso.IsEnabled = false;
            }
            else
            {
                swEstatus.IsOn = false;
                fechaEgreso.IsEnabled = true;
            }
            nombreModi.Text = empleado[0].Nombre;
            contraseñaModi.Text = empleado[0].Contraseña;//this.txtDate.Text = this.cpkControl1.Date.Value.ToString("yyyy-MM-dd");
            fechaIngreso.Date = empleado[0].FechaIngreso;
            fechaEgreso.Date = empleado[0].FechaEgreso;
            int index = empleado[0].Puesto - 1;
            cboPuesto.SelectedIndex = index;
        }
        public async Task cargarEmpleados()
        {
            DSL_UWP cnn = new DSL_UWP();
            Parseador parseador = new Parseador();
            await cnn.getAll("http://localhost:51550/api/Empleado");
            List<Object> list = cnn.getContent();
            cbo.Items.Clear();
            cbo.ItemsSource = list;
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
        private void BotonAnimado_Loaded(object sender, RoutedEventArgs e)
        {

        }
        private void btnAltaAdmin_Tapped(object sender, TappedRoutedEventArgs e)
        {
            Storyboard sb = (Storyboard)btnAltaAdmin.Resources["stbButton"];
            sb.Begin();
            switch (rootPivot.SelectedIndex)
            {
                case 0:
                    Empleado empleadoAlta = new Empleado()
                    {
                        Nombre = nombre.Text + " " + paterno.Text + " " + materno.Text,
                        FechaIngreso = DateTime.Now,
                        Contraseña = contraseña.Password,
                        Pregunta = pregunta.Text,
                        Respuesta = respuesta.Text,
                        Puesto = cboPuesto.SelectedIndex + 1
                    };
                   
                    DSL_UWP cnn = new DSL_UWP();
                    cnn.postObject("http://localhost:51550/api/Empleado", empleadoAlta);
                    var response  = cnn.getResponse();
                    break;
                case 1:
                    Empleado empleadoUpdate = new Empleado();
                    empleadoUpdate.IdEmpleado = cbo.SelectedIndex + 1;
                    empleadoUpdate.Nombre = nombreModi.Text;
                    empleadoUpdate.FechaIngreso = Convert.ToDateTime(fechaIngreso.Date.ToString());
                    if (fechaEgreso.IsEnabled)
                        empleadoUpdate.FechaEgreso = Convert.ToDateTime(fechaEgreso.Date.ToString());
                    else
                        empleadoUpdate.FechaEgreso = Convert.ToDateTime("9999-01-01");
                    empleadoUpdate.Contraseña = contraseñaModi.Text;
                    empleadoUpdate.Pregunta = pregunta.Text;
                    empleadoUpdate.Respuesta = respuesta.Text;
                    empleadoUpdate.Puesto = cboPuesto.SelectedIndex + 1;
                    if (swEstatus.IsOn)
                        empleadoUpdate.Estatus = 1;
                    else
                        empleadoUpdate.Estatus = 0;

                    DSL_UWP cnn2 = new DSL_UWP();
                    cnn2.putObject("http://localhost:51550/api/Empleado", empleadoUpdate);
                    var response2 = cnn2.getResponse();
                    break;
            }
            MostrarMensaje();
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
        private void TopAppBarAyuda(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Manual));
        }
        private async void MostrarMensaje()
        {
            var result = await MensajeAlta.ShowAsync();
        }
        private void ocultarMensaje(object sender, RoutedEventArgs e)
        {
            MensajeAlta.Hide();
        }
    }
}

