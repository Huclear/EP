﻿#pragma checksum "..\..\..\pages DS\AuthorPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "D942F9496B171317F0BB4770ACE0268699950B88A6FF6CAC2E0F00C42754F64D"
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
        
        
        #line 16 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid AuthorsDGr;
        
        #line default
        #line hidden
        
        
        #line 39 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NameInput;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NameSelection;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox SurnameInput;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox SurnameSelection;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox PatronymicInput;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PatronymicSelection;
        
        #line default
        #line hidden
        
        
        #line 69 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox NicknameInput;
        
        #line default
        #line hidden
        
        
        #line 70 "..\..\..\pages DS\AuthorPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NicknameSelection;
        
        #line default
        #line hidden
        
        
        #line 75 "..\..\..\pages DS\AuthorPage.xaml"
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
            
            #line 39 "..\..\..\pages DS\AuthorPage.xaml"
            this.NameInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnSortingString_Changed);
            
            #line default
            #line hidden
            return;
            case 3:
            this.NameSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 40 "..\..\..\pages DS\AuthorPage.xaml"
            this.NameSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectedFilter_Changed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.SurnameInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 49 "..\..\..\pages DS\AuthorPage.xaml"
            this.SurnameInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnSortingString_Changed);
            
            #line default
            #line hidden
            return;
            case 5:
            this.SurnameSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 50 "..\..\..\pages DS\AuthorPage.xaml"
            this.SurnameSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectedFilter_Changed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PatronymicInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 59 "..\..\..\pages DS\AuthorPage.xaml"
            this.PatronymicInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnSortingString_Changed);
            
            #line default
            #line hidden
            return;
            case 7:
            this.PatronymicSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 60 "..\..\..\pages DS\AuthorPage.xaml"
            this.PatronymicSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectedFilter_Changed);
            
            #line default
            #line hidden
            return;
            case 8:
            this.NicknameInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 69 "..\..\..\pages DS\AuthorPage.xaml"
            this.NicknameInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnSortingString_Changed);
            
            #line default
            #line hidden
            return;
            case 9:
            this.NicknameSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 70 "..\..\..\pages DS\AuthorPage.xaml"
            this.NicknameSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectedFilter_Changed);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AgeInput = ((System.Windows.Controls.TextBox)(target));
            
            #line 75 "..\..\..\pages DS\AuthorPage.xaml"
            this.AgeInput.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.OnSortingString_Changed);
            
            #line default
            #line hidden
            return;
            case 11:
            
            #line 78 "..\..\..\pages DS\AuthorPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.OnClearFilter_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

