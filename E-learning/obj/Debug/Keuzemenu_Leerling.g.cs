﻿#pragma checksum "..\..\Keuzemenu_Leerling.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "C8AE1F6D818CC18542A5D25CB7F6E8FD"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
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


namespace E_learning {
    
    
    /// <summary>
    /// Keuzemenu_Leerling
    /// </summary>
    public partial class Keuzemenu_Leerling : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 5 "..\..\Keuzemenu_Leerling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grGrid;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\Keuzemenu_Leerling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Image imgLogo;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\Keuzemenu_Leerling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label lbTitel;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\Keuzemenu_Leerling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btStart;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\Keuzemenu_Leerling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btLogin_Copy3;
        
        #line default
        #line hidden
        
        
        #line 62 "..\..\Keuzemenu_Leerling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbVakken;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\Keuzemenu_Leerling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbLesOnderwerp;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\Keuzemenu_Leerling.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox lbLessen;
        
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
            System.Uri resourceLocater = new System.Uri("/E-learning;component/keuzemenu_leerling.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Keuzemenu_Leerling.xaml"
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
            this.grGrid = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.imgLogo = ((System.Windows.Controls.Image)(target));
            return;
            case 3:
            this.lbTitel = ((System.Windows.Controls.Label)(target));
            return;
            case 4:
            this.btStart = ((System.Windows.Controls.Button)(target));
            
            #line 20 "..\..\Keuzemenu_Leerling.xaml"
            this.btStart.Click += new System.Windows.RoutedEventHandler(this.btStart_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.btLogin_Copy3 = ((System.Windows.Controls.Button)(target));
            
            #line 41 "..\..\Keuzemenu_Leerling.xaml"
            this.btLogin_Copy3.Click += new System.Windows.RoutedEventHandler(this.btLogin_Copy3_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            this.lbVakken = ((System.Windows.Controls.ListBox)(target));
            
            #line 62 "..\..\Keuzemenu_Leerling.xaml"
            this.lbVakken.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbVakken_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 7:
            this.lbLesOnderwerp = ((System.Windows.Controls.ListBox)(target));
            
            #line 69 "..\..\Keuzemenu_Leerling.xaml"
            this.lbLesOnderwerp.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.lbLesOnderwerp_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.lbLessen = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

