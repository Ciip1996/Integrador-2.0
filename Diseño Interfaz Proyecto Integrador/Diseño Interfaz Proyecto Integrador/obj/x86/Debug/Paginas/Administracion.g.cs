﻿#pragma checksum "C:\Users\Iván Pacheco\Desktop\Integrador\Diseño Interfaz Proyecto Integrador\Diseño Interfaz Proyecto Integrador\Paginas\Administracion.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "12BC9F2CC707B37273FD3E9C9BDD5C41"
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
    partial class Administracion : 
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
                    #line 14 "..\..\..\Paginas\Administracion.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnAltas).Click += this.btnAltas_Click;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnBajas = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 15 "..\..\..\Paginas\Administracion.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnBajas).Click += this.btnBajas_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnConsultas = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 16 "..\..\..\Paginas\Administracion.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnConsultas).Click += this.btnConsultas_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnModificaciones = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 17 "..\..\..\Paginas\Administracion.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnModificaciones).Click += this.btnModificaciones_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.btnAdministracion = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 18 "..\..\..\Paginas\Administracion.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.btnAdministracion).Click += this.btnAdministracion_Click;
                    #line default
                }
                break;
            case 6:
                {
                    this.rootPivot = (global::Windows.UI.Xaml.Controls.Pivot)(target);
                }
                break;
            case 7:
                {
                    this.btnOk = (global::Windows.UI.Xaml.Controls.Button)(target);
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

