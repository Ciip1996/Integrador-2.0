﻿#pragma checksum "C:\Users\Iván Pacheco\Desktop\Integrador-2.0\Diseño Interfaz Proyecto Integrador\Diseño Interfaz Proyecto Integrador\Paginas\Consultas.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "93C363FFBC3FAAAF56AED4D04DF1ECDF"
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
    partial class Consultas : 
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
                    this.paginaConsultas = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2:
                {
                    this.btnAltas = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 17 "..\..\..\Paginas\Consultas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnAltas).Click += this.btnAltas_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnBajas = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 18 "..\..\..\Paginas\Consultas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnBajas).Click += this.btnBajas_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnConsultas = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 19 "..\..\..\Paginas\Consultas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnConsultas).Click += this.btnConsultas_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnModificaciones = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 20 "..\..\..\Paginas\Consultas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnModificaciones).Click += this.btnModificaciones_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.btnAdministracion = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 21 "..\..\..\Paginas\Consultas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnAdministracion).Click += this.btnAdministracion_Click;
                    #line default
                }
                break;
            case 7:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.txtBuscar = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 9:
                {
                    this.cboBuscarPor = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 10:
                {
                    this.btnConsulta = (global::Diseño_Interfaz_Proyecto_Integrador.Controles.BotonAnimado)(target);
                    #line 113 "..\..\..\Paginas\Consultas.xaml"
                    ((global::Diseño_Interfaz_Proyecto_Integrador.Controles.BotonAnimado)this.btnConsulta).Tapped += this.btnConsulta_Click;
                    #line default
                }
                break;
            case 11:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element11 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 110 "..\..\..\Paginas\Consultas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element11).Click += this.AppBarButton_Click;
                    #line default
                }
                break;
            case 12:
                {
                    global::Windows.UI.Xaml.Controls.AppBarButton element12 = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 111 "..\..\..\Paginas\Consultas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)element12).Click += this.TopAppBarAyuda;
                    #line default
                }
                break;
            case 13:
                {
                    this.dgPersona = (global::MyToolkit.Controls.DataGrid)(target);
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

