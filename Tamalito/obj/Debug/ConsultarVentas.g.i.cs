#pragma checksum "..\..\ConsultarVentas.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "514A4194ECB759A53A1209AED5D2D7FC8CD6DF28B5726519CD9246C5CC26F158"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using Tamalito;


namespace Tamalito
{


    /// <summary>
    /// ConsultarVentas
    /// </summary>
    public partial class ConsultarVentas : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tamalito;component/consultarventas.xaml", System.UriKind.Relative);

#line 1 "..\..\ConsultarVentas.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:

#line 13 "..\..\ConsultarVentas.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click_1);

#line default
#line hidden
                    return;
                case 2:

#line 14 "..\..\ConsultarVentas.xaml"
                    ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Label lbFechaInicio;
        internal System.Windows.Controls.Label lbFechaFinal;
        internal System.Windows.Controls.Label lbAnio1;
        internal System.Windows.Controls.Label lbAnio2;
        internal System.Windows.Controls.ComboBox cbAnio1;
        internal System.Windows.Controls.ComboBox cbAnio2;
        internal System.Windows.Controls.Label lbMes1;
        internal System.Windows.Controls.Label lbMes2;
        internal System.Windows.Controls.ComboBox cbMes1;
        internal System.Windows.Controls.ComboBox cbMes2;
        internal System.Windows.Controls.Label lbDia1;
        internal System.Windows.Controls.Label lbDia2;
        internal System.Windows.Controls.ComboBox cbDia1;
        internal System.Windows.Controls.ComboBox cbDia2;
        internal System.Windows.Controls.Button btCancelar;
        internal System.Windows.Controls.Button btConsultar;
    }
}

