﻿#pragma checksum "..\..\..\PageFolder\Chapter_6_Page.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E343F75412772FA0978BA9AB831202B29ACA08922A563894D70C6D2212CD24C"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Junisha_CSharp_Zero_App0.PageFolder;
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


namespace Junisha_CSharp_Zero_App0.PageFolder {
    
    
    /// <summary>
    /// Chapter_6_Page
    /// </summary>
    public partial class Chapter_6_Page : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 31 "..\..\..\PageFolder\Chapter_6_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock ChapterName;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\PageFolder\Chapter_6_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Text1;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\PageFolder\Chapter_6_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Text2;
        
        #line default
        #line hidden
        
        
        #line 65 "..\..\..\PageFolder\Chapter_6_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock Text3;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\PageFolder\Chapter_6_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Next;
        
        #line default
        #line hidden
        
        
        #line 84 "..\..\..\PageFolder\Chapter_6_Page.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button Btn_Back;
        
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
            System.Uri resourceLocater = new System.Uri("/Junisha_CSharp_Zero_App0;component/pagefolder/chapter_6_page.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\PageFolder\Chapter_6_Page.xaml"
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
            this.ChapterName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            
            #line 33 "..\..\..\PageFolder\Chapter_6_Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Link1);
            
            #line default
            #line hidden
            return;
            case 3:
            this.Text1 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            
            #line 46 "..\..\..\PageFolder\Chapter_6_Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Link2);
            
            #line default
            #line hidden
            return;
            case 5:
            this.Text2 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            
            #line 57 "..\..\..\PageFolder\Chapter_6_Page.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Btn_Link3);
            
            #line default
            #line hidden
            return;
            case 7:
            this.Text3 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.Btn_Next = ((System.Windows.Controls.Button)(target));
            
            #line 68 "..\..\..\PageFolder\Chapter_6_Page.xaml"
            this.Btn_Next.Click += new System.Windows.RoutedEventHandler(this.Btn_Next_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.Btn_Back = ((System.Windows.Controls.Button)(target));
            
            #line 89 "..\..\..\PageFolder\Chapter_6_Page.xaml"
            this.Btn_Back.Click += new System.Windows.RoutedEventHandler(this.Btn_Back_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

