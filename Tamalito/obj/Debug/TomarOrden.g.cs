﻿#pragma checksum "..\..\TomarOrden.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2258B183C08F89AEF66F62827DA143C5DF243BA91A9B8BC3A9ED28AF2A3B5A14"
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


namespace Tamalito {
    
    
    /// <summary>
    /// TomarOrden
    /// </summary>
    public partial class TomarOrden : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 9 "..\..\TomarOrden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid ventana;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\TomarOrden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btAgregar;
        
        #line default
        #line hidden
        
        
        #line 11 "..\..\TomarOrden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btCancelar;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\TomarOrden.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Primitives.UniformGrid grid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Tamalito;component/tomarorden.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\TomarOrden.xaml"
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
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.ventana = ((System.Windows.Controls.Grid)(target));
            
            #line 9 "..\..\TomarOrden.xaml"
            this.ventana.Loaded += new System.Windows.RoutedEventHandler(this.Ventana_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btAgregar = ((System.Windows.Controls.Button)(target));
            return;
            case 3:
            this.btCancelar = ((System.Windows.Controls.Button)(target));
            return;
            case 4:
            this.grid = ((System.Windows.Controls.Primitives.UniformGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

