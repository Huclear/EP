﻿#pragma checksum "..\..\..\pages DS\AuthorPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "B0C67986A7CF5007FE16BC0F089A730B971BEAD0F0EEEB961AF729E4ACE6671E"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Practice4.Rules;
using Practice4.pages_DS;
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


namespace Practice4.pages_DS {
    
    
    /// <summary>
    /// AuthorPage
    /// </summary>
    public partial class AuthorPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AuthorsDGr;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameInput;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurnameInput;
        
        #line default
        #line hidden
        
        
        #line 44 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatronymicInput;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NicknameInput;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox AgeInput;
        
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
            System.Uri resourceLocater = new System.Uri("/Practice4;component/pages%20ds/authorpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages DS\AuthorPage.xaml"
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
            this.AuthorsDGr = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.NameInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 38 "..\..\..\pages DS\AuthorPage.xaml"
            this.NameInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnSortingString_Changed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.SurnameInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 41 "..\..\..\pages DS\AuthorPage.xaml"
            this.SurnameInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnSortingString_Changed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.PatronymicInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 44 "..\..\..\pages DS\AuthorPage.xaml"
            this.PatronymicInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnSortingString_Changed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.NicknameInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 47 "..\..\..\pages DS\AuthorPage.xaml"
            this.NicknameInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnSortingString_Changed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.AgeInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 51 "..\..\..\pages DS\AuthorPage.xaml"
            this.AgeInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnSortingString_Changed);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 54 "..\..\..\pages DS\AuthorPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClearFilter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

