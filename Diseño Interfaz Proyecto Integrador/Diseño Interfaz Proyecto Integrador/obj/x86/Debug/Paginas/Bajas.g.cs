﻿#pragma checksum "C:\Users\Iván Pacheco\Desktop\Integrador-2.0\Diseño Interfaz Proyecto Integrador\Diseño Interfaz Proyecto Integrador\Paginas\Bajas.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E74B9244CF661579722BAE46C7D8EDCF"
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
    partial class Bajas : 
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
                    #line 14 "..\..\..\Paginas\Bajas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnAltas).Click += this.btnAltas_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnBajas = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 15 "..\..\..\Paginas\Bajas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnBajas).Click += this.btnBajas_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnConsultas = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 16 "..\..\..\Paginas\Bajas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnConsultas).Click += this.btnConsultas_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnModificaciones = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 17 "..\..\..\Paginas\Bajas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnModificaciones).Click += this.btnModificaciones_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnAdministracion = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 18 "..\..\..\Paginas\Bajas.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnAdministracion).Click += this.btnAdministracion_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.btnBajar = (global::Diseño_Interfaz_Proyecto_Integrador.Controles.BotonAnimado)(target);
                    #line 40 "..\..\..\Paginas\Bajas.xaml"
                    ((global::Diseño_Interfaz_Proyecto_Integrador.Controles.BotonAnimado)this.btnBajar).Tapped += this.btnBajar_Tapped;
                    #line default
                }
                break;
            case 7:
                {
                    this.ctrlBajas = (global::Diseño_Interfaz_Proyecto_Integrador.Controles.BajasControl)(target);
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

