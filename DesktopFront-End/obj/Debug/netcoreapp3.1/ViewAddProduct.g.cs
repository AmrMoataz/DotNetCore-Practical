﻿#pragma checksum "..\..\..\ViewAddProduct.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "773D5FDEFB04AE377BA192C04E37ECDA83631074"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DesktopFront_End;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace DesktopFront_End {
    
    
    /// <summary>
    /// ViewAddProduct
    /// </summary>
    public partial class ViewAddProduct : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\..\ViewAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox nametxt;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\ViewAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox pricetxt;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\..\ViewAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox qtytxt;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\ViewAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button addbtn;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\ViewAddProduct.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button cancelbtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/DesktopFront-End;component/viewaddproduct.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\ViewAddProduct.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.6.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.nametxt = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.pricetxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 28 "..\..\..\ViewAddProduct.xaml"
            this.pricetxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.pricetxt_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 3:
            this.qtytxt = ((System.Windows.Controls.TextBox)(target));
            
            #line 33 "..\..\..\ViewAddProduct.xaml"
            this.qtytxt.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.qtytxt_PreviewTextInput);
            
            #line default
            #line hidden
            return;
            case 4:
            this.addbtn = ((System.Windows.Controls.Button)(target));
            
            #line 37 "..\..\..\ViewAddProduct.xaml"
            this.addbtn.Click += new System.Windows.RoutedEventHandler(this.addbtn_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.cancelbtn = ((System.Windows.Controls.Button)(target));
            
            #line 38 "..\..\..\ViewAddProduct.xaml"
            this.cancelbtn.Click += new System.Windows.RoutedEventHandler(this.cancelbtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

