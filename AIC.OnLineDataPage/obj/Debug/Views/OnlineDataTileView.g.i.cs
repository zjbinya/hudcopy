﻿#pragma checksum "..\..\..\Views\OnlineDataTileView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4816CBF3A5270F113D39BDE0AE3CD870"
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
using AIC.OnLineDataPage.Controls;
using AIC.OnLineDataPage.Views;
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
using Wpf.VirtualizingWrapPanel;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.Toolkit.Chromes;
using Xceed.Wpf.Toolkit.Core.Converters;
using Xceed.Wpf.Toolkit.Core.Input;
using Xceed.Wpf.Toolkit.Core.Media;
using Xceed.Wpf.Toolkit.Core.Utilities;
using Xceed.Wpf.Toolkit.Panels;
using Xceed.Wpf.Toolkit.Primitives;
using Xceed.Wpf.Toolkit.PropertyGrid;
using Xceed.Wpf.Toolkit.PropertyGrid.Attributes;
using Xceed.Wpf.Toolkit.PropertyGrid.Commands;
using Xceed.Wpf.Toolkit.PropertyGrid.Converters;
using Xceed.Wpf.Toolkit.PropertyGrid.Editors;
using Xceed.Wpf.Toolkit.Zoombox;


namespace AIC.OnLineDataPage.Views {
    
    
    /// <summary>
    /// OnlineDataTileView
    /// </summary>
    public partial class OnlineDataTileView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 151 "..\..\..\Views\OnlineDataTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Grid grdWorkbench;
        
        #line default
        #line hidden
        
        
        #line 163 "..\..\..\Views\OnlineDataTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView treeview;
        
        #line default
        #line hidden
        
        
        #line 329 "..\..\..\Views\OnlineDataTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.GridSplitter gsSplitterr;
        
        #line default
        #line hidden
        
        
        #line 414 "..\..\..\Views\OnlineDataTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox filterCheckBox;
        
        #line default
        #line hidden
        
        
        #line 424 "..\..\..\Views\OnlineDataTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal Xceed.Wpf.Toolkit.DropDownButton dropDownButton;
        
        #line default
        #line hidden
        
        
        #line 434 "..\..\..\Views\OnlineDataTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton bandPassRb;
        
        #line default
        #line hidden
        
        
        #line 435 "..\..\..\Views\OnlineDataTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton highPassRb;
        
        #line default
        #line hidden
        
        
        #line 436 "..\..\..\Views\OnlineDataTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.RadioButton lowPassRb;
        
        #line default
        #line hidden
        
        
        #line 584 "..\..\..\Views\OnlineDataTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox chkbox;
        
        #line default
        #line hidden
        
        
        #line 598 "..\..\..\Views\OnlineDataTileView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox listview;
        
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
            System.Uri resourceLocater = new System.Uri("/AIC.OnLineDataPage;component/views/onlinedatatileview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Views\OnlineDataTileView.xaml"
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
            this.gsSplitterr = ((System.Windows.Controls.GridSplitter)(target));
            return;
            case 4:
            this.filterCheckBox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 5:
            this.dropDownButton = ((Xceed.Wpf.Toolkit.DropDownButton)(target));
            return;
            case 6:
            this.bandPassRb = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 7:
            this.highPassRb = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 8:
            this.lowPassRb = ((System.Windows.Controls.RadioButton)(target));
            return;
            case 9:
            this.chkbox = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 10:
            this.listview = ((System.Windows.Controls.ListBox)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

