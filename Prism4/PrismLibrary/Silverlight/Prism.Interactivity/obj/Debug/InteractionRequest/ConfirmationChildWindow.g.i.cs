﻿#pragma checksum "C:\_MS_DEV\Prism4\PrismLibrary\Silverlight\Prism.Interactivity\InteractionRequest\ConfirmationChildWindow.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "E0053E49632FB2EDED532A4DCEE2F96D"
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


namespace Microsoft.Practices.Prism.Interactivity.InteractionRequest {
    
    
    public partial class ConfirmationChildWindow : System.Windows.Controls.ChildWindow {
        
        internal System.Windows.Controls.ChildWindow confirmationWindow;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.Button CancelButton;
        
        internal System.Windows.Controls.Button OKButton;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/Microsoft.Practices.Prism.Interactivity;component/InteractionRequest/Confirmatio" +
                        "nChildWindow.xaml", System.UriKind.Relative));
            this.confirmationWindow = ((System.Windows.Controls.ChildWindow)(this.FindName("confirmationWindow")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.CancelButton = ((System.Windows.Controls.Button)(this.FindName("CancelButton")));
            this.OKButton = ((System.Windows.Controls.Button)(this.FindName("OKButton")));
        }
    }
}

