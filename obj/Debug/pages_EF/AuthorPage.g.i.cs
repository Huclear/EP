﻿#pragma checksum "..\..\..\pages_EF\AuthorPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "9BE32BC969BF82523BA9F91BFC745B10792B3FF547085C2F4134162B7BB6C2AE"
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
using Practice4.pages;
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


namespace Practice4.pages {
    
    
    /// <summary>
    /// AuthorPage
    /// </summary>
    public partial class AuthorPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\pages_EF\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AuthorsDGr;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\..\pages_EF\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox NameSortEnable;
        
        #line default
        #line hidden
        
        
        #line 42 "..\..\..\pages_EF\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox SurnameSortEnable;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\pages_EF\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox PatronymicSortEnable;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\pages_EF\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox NicknameSortEnable;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\pages_EF\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox AgeSortEnable;
        
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
            System.Uri resourceLocater = new System.Uri("/Practice4;component/pages_ef/authorpage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages_EF\AuthorPage.xaml"
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
            this.NameSortEnable = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.SurnameSortEnable = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 4:
            this.PatronymicSortEnable = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.NicknameSortEnable = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.AgeSortEnable = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            
            #line 67 "..\..\..\pages_EF\AuthorPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

