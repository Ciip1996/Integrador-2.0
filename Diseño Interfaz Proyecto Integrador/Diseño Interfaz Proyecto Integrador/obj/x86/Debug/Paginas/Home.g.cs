﻿#pragma checksum "C:\Users\Iván Pacheco\Desktop\Integrador-2.0\Diseño Interfaz Proyecto Integrador\Diseño Interfaz Proyecto Integrador\Paginas\Home.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "735AD34F111511B0E795BECB96DFD658"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Diseño_Interfaz_Proyecto_Integrador
{
    partial class Home : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.btnAltas = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 14 "..\..\..\Paginas\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnAltas).Click += this.btnAltas_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnBajas = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 15 "..\..\..\Paginas\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnBajas).Click += this.btnBajas_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnConsultas = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 16 "..\..\..\Paginas\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnConsultas).Click += this.btnConsultas_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnModificaciones = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 17 "..\..\..\Paginas\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnModificaciones).Click += this.btnModificaciones_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnAdministracion = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 18 "..\..\..\Paginas\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnAdministracion).Click += this.btnAdministracion_Click;
                    #line default
                }
                break;
            case 6:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element6 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 39 "..\..\..\Paginas\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element6).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 7:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element7 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 40 "..\..\..\Paginas\Home.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element7).Click += this.TopAppBarAyuda;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

