﻿#pragma checksum "D:\Rpa\NoviKontrolniki\NoviKontrolniki\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "1C0E00AEF2BBE36951F45F2D5266B38F"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NoviKontrolniki
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(global::Windows.UI.Xaml.Controls.Primitives.RangeBase obj, global::System.Double value)
            {
                obj.Value = value;
            }
        };

        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::NoviKontrolniki.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ProgressBar obj3;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 3:
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ProgressBar)target;
                        break;
                    default:
                        break;
                }
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            // MainPage_obj1_Bindings

            public void SetDataRoot(global::NoviKontrolniki.MainPage newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::NoviKontrolniki.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_sldMoj(obj.sldMoj, phase);
                    }
                }
            }
            private void Update_sldMoj(global::Windows.UI.Xaml.Controls.Slider obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_sldMoj(obj);
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_sldMoj_Value(obj.Value, phase);
                    }
                }
            }
            private void Update_sldMoj_Value(global::System.Double obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_Primitives_RangeBase_Value(this.obj3, obj);
                }
            }

            private class MainPage_obj1_BindingsTracking
            {
                global::System.WeakReference<MainPage_obj1_Bindings> WeakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    WeakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_sldMoj(null);
                }

                public void DependencyPropertyChanged_sldMoj_Value(global::Windows.UI.Xaml.DependencyObject sender, global::Windows.UI.Xaml.DependencyProperty prop)
                {
                    MainPage_obj1_Bindings bindings;
                    if(WeakRefToBindingObj.TryGetTarget(out bindings))
                    {
                        global::Windows.UI.Xaml.Controls.Slider obj = sender as global::Windows.UI.Xaml.Controls.Slider;
        if (obj != null)
        {
            bindings.Update_sldMoj_Value(obj.Value, DATA_CHANGED);
        }
                    }
                }
                private global::Windows.UI.Xaml.Controls.Slider cache_sldMoj = null;
                private long tokenDPC_sldMoj_Value = 0;
                public void UpdateChildListeners_sldMoj(global::Windows.UI.Xaml.Controls.Slider obj)
                {
                    if (obj != cache_sldMoj)
                    {
                        if (cache_sldMoj != null)
                        {
                            cache_sldMoj.UnregisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Slider.ValueProperty, tokenDPC_sldMoj_Value);
                            cache_sldMoj = null;
                        }
                        if (obj != null)
                        {
                            cache_sldMoj = obj;
                            tokenDPC_sldMoj_Value = obj.RegisterPropertyChangedCallback(global::Windows.UI.Xaml.Controls.Slider.ValueProperty, DependencyPropertyChanged_sldMoj_Value);
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    this.sldMoj = (global::Windows.UI.Xaml.Controls.Slider)(target);
                }
                break;
            case 4:
                {
                    global::Windows.UI.Xaml.Controls.AutoSuggestBox element4 = (global::Windows.UI.Xaml.Controls.AutoSuggestBox)(target);
                    #line 120 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AutoSuggestBox)element4).TextChanged += this.AutoSuggestBox_TextChanged;
                    #line default
                }
                break;
            case 5:
                {
                    this.mojFlyout = (global::Windows.UI.Xaml.Controls.Flyout)(target);
                }
                break;
            case 6:
                {
                    this.btnNotranji = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 55 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnNotranji).Click += this.btnNotranji_Click;
                    #line default
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
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            }
            return returnValue;
        }
    }
}
