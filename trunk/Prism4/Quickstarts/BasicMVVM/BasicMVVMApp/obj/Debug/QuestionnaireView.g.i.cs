﻿#pragma checksum "C:\_MS_DEV\Prism4\Quickstarts\BasicMVVM\BasicMVVMApp\QuestionnaireView.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9969E48963A5D3E55A9917754FEA3E33"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace BasicMVVMApp {
    
    
    public partial class QuestionnaireView : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.TextBox NameTextBox;
        
        internal System.Windows.Controls.TextBox AgeTextBox;
        
        internal System.Windows.Controls.TextBox Question1Response;
        
        internal System.Windows.Documents.Run ColorRun;
        
        internal System.Windows.Controls.ListBox Colors;
        
        internal System.Windows.Controls.Button SubmitButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/BasicMVVMApp;component/QuestionnaireView.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.NameTextBox = ((System.Windows.Controls.TextBox)(this.FindName("NameTextBox")));
            this.AgeTextBox = ((System.Windows.Controls.TextBox)(this.FindName("AgeTextBox")));
            this.Question1Response = ((System.Windows.Controls.TextBox)(this.FindName("Question1Response")));
            this.ColorRun = ((System.Windows.Documents.Run)(this.FindName("ColorRun")));
            this.Colors = ((System.Windows.Controls.ListBox)(this.FindName("Colors")));
            this.SubmitButton = ((System.Windows.Controls.Button)(this.FindName("SubmitButton")));
        }
    }
}

