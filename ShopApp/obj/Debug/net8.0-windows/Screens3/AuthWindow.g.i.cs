﻿#pragma checksum "..\..\..\..\Screens3\AuthWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8CC3F79F37941184244DB8CCE3F4A39027D6EB75"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using ShopApp.Screens;
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


namespace ShopApp.Screens {
    
    
    /// <summary>
    /// AuthWindow
    /// </summary>
    public partial class AuthWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 46 "..\..\..\..\Screens3\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button closeButton;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\..\..\Screens3\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button maximizeButton;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\..\..\Screens3\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button minimizeButton;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\..\Screens3\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button aboutButton;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\..\Screens3\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox loginTextBox;
        
        #line default
        #line hidden
        
        
        #line 57 "..\..\..\..\Screens3\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox passTextBox;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\..\Screens3\AuthWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button authBtn;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/ShopApp;V1.0.0.0;component/screens3/authwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Screens3\AuthWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "8.0.7.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.closeButton = ((System.Windows.Controls.Button)(target));
            
            #line 46 "..\..\..\..\Screens3\AuthWindow.xaml"
            this.closeButton.Click += new System.Windows.RoutedEventHandler(this.closeButton_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.maximizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\..\..\Screens3\AuthWindow.xaml"
            this.maximizeButton.Click += new System.Windows.RoutedEventHandler(this.maximizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.minimizeButton = ((System.Windows.Controls.Button)(target));
            
            #line 48 "..\..\..\..\Screens3\AuthWindow.xaml"
            this.minimizeButton.Click += new System.Windows.RoutedEventHandler(this.minimizeButton_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.aboutButton = ((System.Windows.Controls.Button)(target));
            
            #line 49 "..\..\..\..\Screens3\AuthWindow.xaml"
            this.aboutButton.Click += new System.Windows.RoutedEventHandler(this.aboutButton_Click);
            
            #line default
            #line hidden
            return;
            case 5:
            this.loginTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.passTextBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.authBtn = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\..\Screens3\AuthWindow.xaml"
            this.authBtn.Click += new System.Windows.RoutedEventHandler(this.authBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

