﻿#pragma checksum "C:\Source\Repos\BlackJack\BlackJack\BlackJack.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "D2533680947EA9737D29C3E6A0EE3440"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlackJack
{
    partial class BlackJack : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.txtTitle = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 2:
                {
                    this.btnDeal = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 18 "..\..\..\BlackJack.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnDeal).Click += this.btnDeal_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.grdMain = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 4:
                {
                    this.txtPlayerWins = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 5:
                {
                    this.txtPlayerWinsBlackJack = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.txtDealerBusts = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 7:
                {
                    this.txtPlayerBusts = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 8:
                {
                    this.txtDealerWins = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 9:
                {
                    this.txtDealerWinsBlackJack = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 10:
                {
                    this.txtPlayAgain = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 11:
                {
                    this.textBlock2 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 12:
                {
                    this.lstPlayerHand = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 13:
                {
                    this.btnPlayerHit = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 40 "..\..\..\BlackJack.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPlayerHit).Click += this.btnPlayerHit_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.btnPlayerStand = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 41 "..\..\..\BlackJack.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPlayerStand).Click += this.btnPlayerStand_Click;
                    #line default
                }
                break;
            case 15:
                {
                    this.textBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.txtPlayerTotal = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 17:
                {
                    this.textBlock3 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 18:
                {
                    this.lstDealerHand = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                }
                break;
            case 19:
                {
                    this.textBlock1 = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 20:
                {
                    this.txtDealerTotal = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
