﻿#pragma checksum "..\..\SteamLogin.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2C524824C7EB6EADF7C7EAF6FF434CBC2EAAF0EA"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Dragablz;
using FairyVLauncher2;
using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Transitions;
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


namespace FairyVLauncher2 {
    
    
    /// <summary>
    /// SteamLogin
    /// </summary>
    public partial class SteamLogin : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 15 "..\..\SteamLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnCloseApp;
        
        #line default
        #line hidden
        
        
        #line 26 "..\..\SteamLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtSteamUsername;
        
        #line default
        #line hidden
        
        
        #line 30 "..\..\SteamLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.PasswordBox pwdSteamPassword;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\SteamLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.CheckBox ckbxRememberMe;
        
        #line default
        #line hidden
        
        
        #line 33 "..\..\SteamLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtShowMessage;
        
        #line default
        #line hidden
        
        
        #line 34 "..\..\SteamLogin.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSteamLogin;
        
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
            System.Uri resourceLocater = new System.Uri("/FairyVLauncher2;component/steamlogin.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\SteamLogin.xaml"
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
            
            #line 12 "..\..\SteamLogin.xaml"
            ((System.Windows.Controls.Grid)(target)).MouseDown += new System.Windows.Input.MouseButtonEventHandler(this.Grid_MouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnCloseApp = ((System.Windows.Controls.Button)(target));
            
            #line 15 "..\..\SteamLogin.xaml"
            this.btnCloseApp.Click += new System.Windows.RoutedEventHandler(this.BtnCloseApp_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.txtSteamUsername = ((System.Windows.Controls.TextBox)(target));
            
            #line 26 "..\..\SteamLogin.xaml"
            this.txtSteamUsername.KeyDown += new System.Windows.Input.KeyEventHandler(this.TxtSteamUsername_KeyDown);
            
            #line default
            #line hidden
            return;
            case 4:
            this.pwdSteamPassword = ((System.Windows.Controls.PasswordBox)(target));
            
            #line 30 "..\..\SteamLogin.xaml"
            this.pwdSteamPassword.KeyDown += new System.Windows.Input.KeyEventHandler(this.PwdSteamPassword_KeyDown);
            
            #line default
            #line hidden
            return;
            case 5:
            this.ckbxRememberMe = ((System.Windows.Controls.CheckBox)(target));
            return;
            case 6:
            this.txtShowMessage = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.btnSteamLogin = ((System.Windows.Controls.Button)(target));
            
            #line 34 "..\..\SteamLogin.xaml"
            this.btnSteamLogin.Click += new System.Windows.RoutedEventHandler(this.BtnSteamLogin_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

