﻿#pragma checksum "..\..\..\Pages\TypePage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7264A8F2944E91C2038912ED88C953BDA2788EC4B450419ACA871C0F64A2387D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ComService.Pages;
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


namespace ComService.Pages {
    
    
    /// <summary>
    /// TypePage
    /// </summary>
    public partial class TypePage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 16 "..\..\..\Pages\TypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid DGType;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\Pages\TypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button DelBtnT;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\..\Pages\TypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button RedBtnT;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\Pages\TypePage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddBtnT;
        
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
            System.Uri resourceLocater = new System.Uri("/ComService;component/pages/typepage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\TypePage.xaml"
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
            
            #line 9 "..\..\..\Pages\TypePage.xaml"
            ((ComService.Pages.TypePage)(target)).Loaded += new System.Windows.RoutedEventHandler(this.Page_Loaded);
            
            #line default
            #line hidden
            return;
            case 2:
            this.DGType = ((System.Windows.Controls.DataGrid)(target));
            
            #line 16 "..\..\..\Pages\TypePage.xaml"
            this.DGType.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.DGType_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DelBtnT = ((System.Windows.Controls.Button)(target));
            
            #line 22 "..\..\..\Pages\TypePage.xaml"
            this.DelBtnT.Click += new System.Windows.RoutedEventHandler(this.DelBtnT_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.RedBtnT = ((System.Windows.Controls.Button)(target));
            
            #line 23 "..\..\..\Pages\TypePage.xaml"
            this.RedBtnT.Click += new System.Windows.RoutedEventHandler(this.RedBtnT_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.AddBtnT = ((System.Windows.Controls.Button)(target));
            
            #line 24 "..\..\..\Pages\TypePage.xaml"
            this.AddBtnT.Click += new System.Windows.RoutedEventHandler(this.AddBtnT_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
