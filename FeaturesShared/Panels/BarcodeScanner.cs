﻿using System;
using System.ComponentModel;
using Wisej.Hybrid;
using Wisej.Hybrid.Features;
using Wisej.Hybrid.MLKit;
using Wisej.Hybrid.MLKit.Shared;
using Wisej.Hybrid.Modules.System;
using Wisej.Web;

namespace FeaturesShared.Panels
{
	[Category("Hardware")]
	public partial class BarcodeScanner : TestBase
	{
		public BarcodeScanner()
		{
			InitializeComponent();
		}

		private void buttonNative_Click(object sender, EventArgs e)
		{
			Device.Use<DeviceML>().ScanBarcode(new CaptureConfiguration());
		}

		private void buttonEmbedded_Click(object sender, EventArgs e)
		{
			new BarcodeWindow().Show();
		}

		public override bool IsSupported()
		{
			return base.IsSupported() && 
				(Device.Info.System.Platform == DevicePlatform.iOS ||
				Device.Info.System.Platform == DevicePlatform.Android);
		}
	}
}