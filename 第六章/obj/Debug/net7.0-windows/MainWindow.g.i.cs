// Updated by XamlIntelliSenseFileGenerator 2023/3/1 13:27:31
#pragma checksum "..\..\..\MainWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40B9200719EEA66C74AFCF02D6A0750082913569"
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

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
using 第六章;


namespace 第六章
{


    /// <summary>
    /// MainWindow
    /// </summary>
    public partial class MainWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {


#line 14 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.StackPanel ShowUserControl;

#line default
#line hidden


#line 16 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_PropertyChanged;

#line default
#line hidden


#line 17 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_ControlAsSource;

#line default
#line hidden


#line 18 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_WithoutPathAndSourceStackpanel;

#line default
#line hidden


#line 19 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_PropertiesPassedDown;

#line default
#line hidden


#line 20 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_CollectionAsBindingSource;

#line default
#line hidden


#line 21 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_DataTableAsBindingSource;

#line default
#line hidden


#line 22 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_XMLASBingingSource;

#line default
#line hidden


#line 23 "..\..\..\MainWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btn_XMLAsTreeview;

#line default
#line hidden

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/第六章;component/mainwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\MainWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "7.0.3.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            switch (connectionId)
            {
                case 1:
                    this.ShowUserControl = ((System.Windows.Controls.StackPanel)(target));
                    return;
                case 2:
                    this.btn_PropertyChanged = ((System.Windows.Controls.Button)(target));

#line 16 "..\..\..\MainWindow.xaml"
                    this.btn_PropertyChanged.Click += new System.Windows.RoutedEventHandler(this.btn_PropertyChanged_Click);

#line default
#line hidden
                    return;
                case 3:
                    this.btn_ControlAsSource = ((System.Windows.Controls.Button)(target));

#line 17 "..\..\..\MainWindow.xaml"
                    this.btn_ControlAsSource.Click += new System.Windows.RoutedEventHandler(this.btn_ControlAsSource_Click);

#line default
#line hidden
                    return;
                case 4:
                    this.btn_WithoutPathAndSourceStackpanel = ((System.Windows.Controls.Button)(target));

#line 18 "..\..\..\MainWindow.xaml"
                    this.btn_WithoutPathAndSourceStackpanel.Click += new System.Windows.RoutedEventHandler(this.btn_WithoutPathAndSourceStackpanel_Click);

#line default
#line hidden
                    return;
                case 5:
                    this.btn_PropertiesPassedDown = ((System.Windows.Controls.Button)(target));

#line 19 "..\..\..\MainWindow.xaml"
                    this.btn_PropertiesPassedDown.Click += new System.Windows.RoutedEventHandler(this.btn_PropertiesPassedDown_Click);

#line default
#line hidden
                    return;
                case 6:
                    this.btn_CollectionAsBindingSource = ((System.Windows.Controls.Button)(target));

#line 20 "..\..\..\MainWindow.xaml"
                    this.btn_CollectionAsBindingSource.Click += new System.Windows.RoutedEventHandler(this.btn_CollectionAsBindingSource_Click);

#line default
#line hidden
                    return;
                case 7:
                    this.btn_DataTableAsBindingSource = ((System.Windows.Controls.Button)(target));

#line 21 "..\..\..\MainWindow.xaml"
                    this.btn_DataTableAsBindingSource.Click += new System.Windows.RoutedEventHandler(this.btn_DataTableAsBindingSource_Click);

#line default
#line hidden
                    return;
                case 8:
                    this.btn_XMLASBingingSource = ((System.Windows.Controls.Button)(target));

#line 22 "..\..\..\MainWindow.xaml"
                    this.btn_XMLASBingingSource.Click += new System.Windows.RoutedEventHandler(this.btn_XMLASBingingSource_Click);

#line default
#line hidden
                    return;
                case 9:
                    this.btn_XMLAsTreeview = ((System.Windows.Controls.Button)(target));

#line 23 "..\..\..\MainWindow.xaml"
                    this.btn_XMLAsTreeview.Click += new System.Windows.RoutedEventHandler(this.btn_XMLAsTreeview_Click);

#line default
#line hidden
                    return;
            }
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.Button btn_LinqAsBindingSource;
    }
}

