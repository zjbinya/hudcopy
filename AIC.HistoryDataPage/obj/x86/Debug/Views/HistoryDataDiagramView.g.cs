﻿#pragma checksum "..\..\..\..\Views\HistoryDataDiagramView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9CD26B3887DEFD46EE86F8F513CEEC1CCE4E6AF1"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using AIC.Core;
using AIC.Core.ExCommand;
using AIC.Core.OrganizationModels;
using AIC.CoreType;
using AIC.HistoryDataPage.Models;
using BolapanControl.ItemsFilter;
using BolapanControl.ItemsFilter.Initializer;
using BolapanControl.ItemsFilter.Model;
using BolapanControl.ItemsFilter.View;
using BolapanControl.ItemsFilter.ViewModel;
using Loya.Dameer;
using Prism.Interactivity;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Regions.Behaviors;
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
using System.Windows.Interactivity;
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
using Wpf.PageNavigationControl;
using Wpf.WrapBreakPanel;


namespace AIC.HistoryDataPage.Views {
    
    
    /// <summary>
    /// HistoryDataDiagramView
    /// </summary>
    public partial class HistoryDataDiagramView : AIC.Core.DisposableUserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 242 "..\..\..\..\Views\HistoryDataDiagramView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdWorkbench;
        
        #line default
        #line hidden
        
        
        #line 260 "..\..\..\..\Views\HistoryDataDiagramView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeview;
        
        #line default
        #line hidden
        
        
        #line 342 "..\..\..\..\Views\HistoryDataDiagramView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeview2;
        
        #line default
        #line hidden
        
        
        #line 384 "..\..\..\..\Views\HistoryDataDiagramView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridSplitter gsSplitterr;
        
        #line default
        #line hidden
        
        
        #line 515 "..\..\..\..\Views\HistoryDataDiagramView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ScrollViewer scrollviewer;
        
        #line default
        #line hidden
        
        
        #line 516 "..\..\..\..\Views\HistoryDataDiagramView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ReplayListBox;
        
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
            System.Uri resourceLocater = new System.Uri("/AIC.HistoryDataPage;component/views/historydatadiagramview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Views\HistoryDataDiagramView.xaml"
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
            this.grdWorkbench = ((System.Windows.Controls.Grid)(target));
            return;
            case 2:
            this.treeview = ((System.Windows.Controls.TreeView)(target));
            return;
            case 3:
            this.treeview2 = ((System.Windows.Controls.TreeView)(target));
            return;
            case 4:
            this.gsSplitterr = ((System.Windows.Controls.GridSplitter)(target));
            return;
            case 5:
            
            #line 482 "..\..\..\..\Views\HistoryDataDiagramView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.HorizontalAlignButtonClick);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 489 "..\..\..\..\Views\HistoryDataDiagramView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.VerticalAlignButtonClick);
            
            #line default
            #line hidden
            return;
            case 7:
            
            #line 496 "..\..\..\..\Views\HistoryDataDiagramView.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AllAlignButtonClick);
            
            #line default
            #line hidden
            return;
            case 8:
            this.scrollviewer = ((System.Windows.Controls.ScrollViewer)(target));
            return;
            case 9:
            this.ReplayListBox = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

