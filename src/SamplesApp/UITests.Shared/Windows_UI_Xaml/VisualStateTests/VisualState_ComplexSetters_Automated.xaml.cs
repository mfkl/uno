﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Uno.UI.Samples.Controls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Shared.Windows_UI_Xaml.VisualStateTests
{
	[SampleControlInfo("Visual States", "VisualState_ComplexSetters_Automated")]
	public sealed partial class VisualState_ComplexSetters_Automated : UserControl
    {
        public VisualState_ComplexSetters_Automated()
        {
            this.InitializeComponent();
        }

		private void OnClick(object sender, object args)
		{
			VisualStateManager.GoToState(this, "State01", true);
		}
	}
}
