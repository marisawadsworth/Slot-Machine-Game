﻿#pragma checksum "C:\Users\10002444\source\repos\Slot Machine Game\Slot Machine Game\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "F2F38FF5DEC62A6ECF7FE658A5EBE4B3"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Slot_Machine_Game
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 12
                {
                    this.textBlockDollars = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 3: // MainPage.xaml line 13
                {
                    this.imageWheel1 = (global::Windows.UI.Xaml.Controls.Image)(target);
                    ((global::Windows.UI.Xaml.Controls.Image)this.imageWheel1).Tapped += this.imageWheel1_Tapped;
                }
                break;
            case 4: // MainPage.xaml line 14
                {
                    this.imageWheel2 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 5: // MainPage.xaml line 15
                {
                    this.imageWheel3 = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 6: // MainPage.xaml line 16
                {
                    this.imageWinLose = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            case 7: // MainPage.xaml line 17
                {
                    this.buttonAddCash = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonAddCash).Click += this.buttonAddCash_Click;
                }
                break;
            case 8: // MainPage.xaml line 18
                {
                    this.buttonPlay = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)this.buttonPlay).Click += this.buttonPlay_Click;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.18362.1")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

