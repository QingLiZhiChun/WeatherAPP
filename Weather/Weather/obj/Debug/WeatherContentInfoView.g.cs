﻿#pragma checksum "..\..\WeatherContentInfoView.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "DFE4F36AA563B17E7C35231004286EB44BB15268"
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
using Weather;


namespace Weather {
    
    
    /// <summary>
    /// WeatherContentInfoView
    /// </summary>
    public partial class WeatherContentInfoView : System.Windows.Controls.UserControl, System.Windows.Markup.IComponentConnector {
        
        
        #line 23 "..\..\WeatherContentInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlkProvince;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\WeatherContentInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock txtBlkRegion;
        
        #line default
        #line hidden
        
        
        #line 48 "..\..\WeatherContentInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBlkShiDu;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\WeatherContentInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBlkPm25;
        
        #line default
        #line hidden
        
        
        #line 50 "..\..\WeatherContentInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBlkPm10;
        
        #line default
        #line hidden
        
        
        #line 51 "..\..\WeatherContentInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBlkKongQiZhiLiang;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\WeatherContentInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBlkWenDu;
        
        #line default
        #line hidden
        
        
        #line 53 "..\..\WeatherContentInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBlkJianKangTiXing;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\WeatherContentInfoView.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TxtBlkUpdateTime;
        
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
            System.Uri resourceLocater = new System.Uri("/Weather;component/weathercontentinfoview.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\WeatherContentInfoView.xaml"
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
            this.txtBlkProvince = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.txtBlkRegion = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TxtBlkShiDu = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TxtBlkPm25 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TxtBlkPm10 = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TxtBlkKongQiZhiLiang = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TxtBlkWenDu = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 8:
            this.TxtBlkJianKangTiXing = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.TxtBlkUpdateTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

