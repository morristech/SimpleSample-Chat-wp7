﻿#pragma checksum "D:\Projects\QuickBlox_WindowsPhone_SuperSample\SimpleSample-Chat\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B1A139BA9BC4E3D88D6C8C69B0BE3DE4"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.261
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
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


namespace SimpleSample_Chat {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Controls.PhoneApplicationPage phoneApplicationPage;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton send;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton cancel;
        
        internal System.Windows.Controls.Canvas LayoutRoot;
        
        internal System.Windows.Controls.Grid ChatGrid;
        
        internal System.Windows.Controls.TextBox chatField;
        
        internal System.Windows.Controls.ListBox chatMessages;
        
        internal System.Windows.Controls.ProgressBar waiter;
        
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
            System.Windows.Application.LoadComponent(this, new System.Uri("/SimpleSample-Chat;component/MainPage.xaml", System.UriKind.Relative));
            this.phoneApplicationPage = ((Microsoft.Phone.Controls.PhoneApplicationPage)(this.FindName("phoneApplicationPage")));
            this.send = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("send")));
            this.cancel = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("cancel")));
            this.LayoutRoot = ((System.Windows.Controls.Canvas)(this.FindName("LayoutRoot")));
            this.ChatGrid = ((System.Windows.Controls.Grid)(this.FindName("ChatGrid")));
            this.chatField = ((System.Windows.Controls.TextBox)(this.FindName("chatField")));
            this.chatMessages = ((System.Windows.Controls.ListBox)(this.FindName("chatMessages")));
            this.waiter = ((System.Windows.Controls.ProgressBar)(this.FindName("waiter")));
        }
    }
}

