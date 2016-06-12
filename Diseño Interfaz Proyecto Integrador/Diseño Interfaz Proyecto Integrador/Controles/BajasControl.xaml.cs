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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace Diseño_Interfaz_Proyecto_Integrador.Controles
{
    public sealed partial class BajasControl : UserControl
    {
        public BajasControl()
        {
            this.InitializeComponent();
            validarCajasTexto();
        }
        private void validarCajasTexto()
        {
            if (switcher.IsOn == true)
            {
                txtCantidad.IsEnabled = true;
                txtCatalogo.IsEnabled = false;
                txtIdAlmacen.IsEnabled = true;
            }
            else
            {
                this.txtCantidad.IsEnabled = false;
                this.txtCatalogo.IsEnabled = true;
                this.txtIdAlmacen.IsEnabled = false;
            }
        }

        private void toggleSwitch_Toggled(object sender, RoutedEventArgs e)
        {
            validarCajasTexto();
        }
    }
}
