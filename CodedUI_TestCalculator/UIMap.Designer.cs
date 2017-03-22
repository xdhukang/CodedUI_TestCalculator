﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUI_TestCalculator
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class UIMap
    {
        
        /// <summary>
        /// AssertAddResult - Use 'AssertAddResultExpectedValues' to pass parameters into this method.
        /// </summary>
        public void AssertAddResult()
        {
            #region Variable Declarations
            WinText uIItem2Text = this.UICalculatorWindow.UIItem2Window.UIItem2Text;
            #endregion

            // Verify that the 'DisplayText' property of '2' label equals '2'
            Assert.AreEqual(this.AssertAddResultExpectedValues.UIItem2TextDisplayText, uIItem2Text.DisplayText);
        }
        
        /// <summary>
        /// TestAdd
        /// </summary>
        public void TestAdd()
        {
            #region Variable Declarations
            WinButton uIClearButton = this.UICalculatorWindow.UIItemWindow.UIClearButton;
            WinButton uIItem1Button = this.UICalculatorWindow.UIItemWindow1.UIItem1Button;
            WinButton uIAddButton = this.UICalculatorWindow.UIItemWindow2.UIAddButton;
            WinButton uIItem2Button = this.UICalculatorWindow.UIItemWindow4.UIItem2Button;
            WinButton uIEqualsButton = this.UICalculatorWindow.UIItemWindow3.UIEqualsButton;
            #endregion

            // Wait for 1 seconds for user delay between actions; Click 'Clear' button
            Playback.Wait(500);
            Mouse.Click(uIClearButton, new Point(25, 18));

            // Wait for 1 seconds for user delay between actions; Click '1' button
            Playback.Wait(500);
            Mouse.Click(uIItem1Button, new Point(10, 19));

            // Wait for 1 seconds for user delay between actions; Click 'Add' button
            Playback.Wait(500);
            Mouse.Click(uIAddButton, new Point(55, 25));

            // Wait for 1 seconds for user delay between actions; Click '2' button
            Playback.Wait(500);
            Mouse.Click(uIItem2Button, new Point(25, 21));

            // Wait for 1 seconds for user delay between actions; Click 'Equals' button
            Playback.Wait(500);
            Mouse.Click(uIEqualsButton, new Point(32, 55));
        }
        
        #region Properties
        public virtual AssertAddResultExpectedValues AssertAddResultExpectedValues
        {
            get
            {
                if ((this.mAssertAddResultExpectedValues == null))
                {
                    this.mAssertAddResultExpectedValues = new AssertAddResultExpectedValues();
                }
                return this.mAssertAddResultExpectedValues;
            }
        }
        
        public UICalculatorWindow UICalculatorWindow
        {
            get
            {
                if ((this.mUICalculatorWindow == null))
                {
                    this.mUICalculatorWindow = new UICalculatorWindow();
                }
                return this.mUICalculatorWindow;
            }
        }
        #endregion
        
        #region Fields
        private AssertAddResultExpectedValues mAssertAddResultExpectedValues;
        
        private UICalculatorWindow mUICalculatorWindow;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'AssertAddResult'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class AssertAddResultExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'DisplayText' property of '2' label equals '2'
        /// </summary>
        public string UIItem2TextDisplayText = "2";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UICalculatorWindow : WinWindow
    {
        
        public UICalculatorWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Calculator";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "CalcFrame";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public UIItemWindow UIItemWindow
        {
            get
            {
                if ((this.mUIItemWindow == null))
                {
                    this.mUIItemWindow = new UIItemWindow(this);
                }
                return this.mUIItemWindow;
            }
        }
        
        public UIItemWindow1 UIItemWindow1
        {
            get
            {
                if ((this.mUIItemWindow1 == null))
                {
                    this.mUIItemWindow1 = new UIItemWindow1(this);
                }
                return this.mUIItemWindow1;
            }
        }
        
        public UIItemWindow2 UIItemWindow2
        {
            get
            {
                if ((this.mUIItemWindow2 == null))
                {
                    this.mUIItemWindow2 = new UIItemWindow2(this);
                }
                return this.mUIItemWindow2;
            }
        }
        
        public UIItemWindow3 UIItemWindow3
        {
            get
            {
                if ((this.mUIItemWindow3 == null))
                {
                    this.mUIItemWindow3 = new UIItemWindow3(this);
                }
                return this.mUIItemWindow3;
            }
        }
        
        public UIItem2Window UIItem2Window
        {
            get
            {
                if ((this.mUIItem2Window == null))
                {
                    this.mUIItem2Window = new UIItem2Window(this);
                }
                return this.mUIItem2Window;
            }
        }
        
        public UIItemWindow4 UIItemWindow4
        {
            get
            {
                if ((this.mUIItemWindow4 == null))
                {
                    this.mUIItemWindow4 = new UIItemWindow4(this);
                }
                return this.mUIItemWindow4;
            }
        }
        #endregion
        
        #region Fields
        private UIItemWindow mUIItemWindow;
        
        private UIItemWindow1 mUIItemWindow1;
        
        private UIItemWindow2 mUIItemWindow2;
        
        private UIItemWindow3 mUIItemWindow3;
        
        private UIItem2Window mUIItem2Window;
        
        private UIItemWindow4 mUIItemWindow4;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow : WinWindow
    {
        
        public UIItemWindow(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "81";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIClearButton
        {
            get
            {
                if ((this.mUIClearButton == null))
                {
                    this.mUIClearButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIClearButton.SearchProperties[WinButton.PropertyNames.Name] = "Clear";
                    this.mUIClearButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIClearButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIClearButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow1 : WinWindow
    {
        
        public UIItemWindow1(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "131";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIItem1Button
        {
            get
            {
                if ((this.mUIItem1Button == null))
                {
                    this.mUIItem1Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIItem1Button.SearchProperties[WinButton.PropertyNames.Name] = "1";
                    this.mUIItem1Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIItem1Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItem1Button;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow2 : WinWindow
    {
        
        public UIItemWindow2(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "93";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIAddButton
        {
            get
            {
                if ((this.mUIAddButton == null))
                {
                    this.mUIAddButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIAddButton.SearchProperties[WinButton.PropertyNames.Name] = "Add";
                    this.mUIAddButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIAddButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIAddButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow3 : WinWindow
    {
        
        public UIItemWindow3(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "121";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIEqualsButton
        {
            get
            {
                if ((this.mUIEqualsButton == null))
                {
                    this.mUIEqualsButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIEqualsButton.SearchProperties[WinButton.PropertyNames.Name] = "Equals";
                    this.mUIEqualsButton.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIEqualsButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIEqualsButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItem2Window : WinWindow
    {
        
        public UIItem2Window(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "150";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinText UIItem2Text
        {
            get
            {
                if ((this.mUIItem2Text == null))
                {
                    this.mUIItem2Text = new WinText(this);
                    #region Search Criteria
                    this.mUIItem2Text.SearchProperties[WinText.PropertyNames.Name] = "Result";
                    this.mUIItem2Text.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIItem2Text;
            }
        }
        #endregion
        
        #region Fields
        private WinText mUIItem2Text;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class UIItemWindow4 : WinWindow
    {
        
        public UIItemWindow4(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.ControlId] = "132";
            this.WindowTitles.Add("Calculator");
            #endregion
        }
        
        #region Properties
        public WinButton UIItem2Button
        {
            get
            {
                if ((this.mUIItem2Button == null))
                {
                    this.mUIItem2Button = new WinButton(this);
                    #region Search Criteria
                    this.mUIItem2Button.SearchProperties[WinButton.PropertyNames.Name] = "2";
                    this.mUIItem2Button.WindowTitles.Add("Calculator");
                    #endregion
                }
                return this.mUIItem2Button;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItem2Button;
        #endregion
    }
}
