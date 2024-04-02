﻿#pragma checksum "..\..\..\pages_EF\EpisodePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "E083BD1A85D79E36A34BB79CE76846B0757F9705205D3B2B24A6895826F0C41B"
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
    /// EpisodePage
    /// </summary>
    public partial class EpisodePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\..\pages_EF\EpisodePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid EpisodesDGr;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\..\pages_EF\EpisodePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox NameSortEnable;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\..\pages_EF\EpisodePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox NameSelection;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\pages_EF\EpisodePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DescriptionSortEnable;
        
        #line default
        #line hidden
        
        
        #line 56 "..\..\..\pages_EF\EpisodePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox DescriptionSelection;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\pages_EF\EpisodePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox PodcastSortEnable;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\pages_EF\EpisodePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PodcastIDSelector;
        
        #line default
        #line hidden
        
        
        #line 63 "..\..\..\pages_EF\EpisodePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox DurationSortEnable;
        
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
            System.Uri resourceLocater = new System.Uri("/Practice4;component/pages_ef/episodepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\pages_EF\EpisodePage.xaml"
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
            this.EpisodesDGr = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 2:
            this.NameSortEnable = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 3:
            this.NameSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 45 "..\..\..\pages_EF\EpisodePage.xaml"
            this.NameSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectedFilter_Changed);
            
            #line default
            #line hidden
            return;
            case 4:
            this.DescriptionSortEnable = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.DescriptionSelection = ((System.Windows.Controls.ComboBox)(target));
            
            #line 56 "..\..\..\pages_EF\EpisodePage.xaml"
            this.DescriptionSelection.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.OnSelectedFilter_Changed);
            
            #line default
            #line hidden
            return;
            case 6:
            this.PodcastSortEnable = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 7:
            this.PodcastIDSelector = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.DurationSortEnable = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 9:
            
            #line 76 "..\..\..\pages_EF\EpisodePage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

