﻿#pragma checksum "..\..\ApplyCarLoan.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5AF5A593576146E6F8AD86B2D12C5765EEA930A4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Pecunia.WPFpresentation;
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


namespace Pecunia.WPFpresentation {
    
    
    /// <summary>
    /// ApplyCarLoan
    /// </summary>
    public partial class ApplyCarLoan : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 13 "..\..\ApplyCarLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox customerIDTxtBox;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\ApplyCarLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox amountAppliedTxtBox;
        
        #line default
        #line hidden
        
        
        #line 19 "..\..\ApplyCarLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox repaymentPeriodTxtBox;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\ApplyCarLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox occupationComboBox;
        
        #line default
        #line hidden
        
        
        #line 32 "..\..\ApplyCarLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox grossIncomeTxtBox;
        
        #line default
        #line hidden
        
        
        #line 35 "..\..\ApplyCarLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox salaryDecductionTxtBox;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\ApplyCarLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox vehicleComboBox;
        
        #line default
        #line hidden
        
        
        #line 45 "..\..\ApplyCarLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button applyBtn;
        
        #line default
        #line hidden
        
        
        #line 47 "..\..\ApplyCarLoan.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button backBtn;
        
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
            System.Uri resourceLocater = new System.Uri("/Pecunia.WPFpresentation;component/applycarloan.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\ApplyCarLoan.xaml"
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
            this.customerIDTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.amountAppliedTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.repaymentPeriodTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.occupationComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.grossIncomeTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.salaryDecductionTxtBox = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.vehicleComboBox = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this.applyBtn = ((System.Windows.Controls.Button)(target));
            
            #line 45 "..\..\ApplyCarLoan.xaml"
            this.applyBtn.Click += new System.Windows.RoutedEventHandler(this.ApplyBtn_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.backBtn = ((System.Windows.Controls.Button)(target));
            
            #line 47 "..\..\ApplyCarLoan.xaml"
            this.backBtn.Click += new System.Windows.RoutedEventHandler(this.BackBtn_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

