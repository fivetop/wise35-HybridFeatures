﻿using System;
using System.ComponentModel;
using System.Drawing;
using Wisej.Web;
using MenuItem = Wisej.Hybrid.Shared.MenuBar.MenuItem;

namespace Wisej.Hybrid.Features.Panels
{
	[Category("Navigation")]
	public partial class MenuBar : TestBase
	{
		public MenuBar()
		{
			InitializeComponent();
		}

		public override bool IsSupported()
		{
			return base.IsSupported() && Device.Info.System.Idiom == Modules.System.DeviceIdiom.Desktop;
		}

		private void MenuBar_Appear(object sender, EventArgs e)
		{
			Device.MenuBar.ItemClicked += MenuBar_ItemClicked;

			Device.MenuBar.Items = new MenuItem[]
			{
				new MenuItem
				{
					Text = "File",
					Items =
					[
						new MenuItem
						{
							Text = "Exit"
						}
					]
				},
				new MenuItem
				{
					Text = "Locations",
					Items =
					[
						new MenuItem
						{
							Text = "Change Location",
							FontImageSource = new Shared.Core.FontImageSource
							{
								Glyph = "L",
								Color = Color.Blue,
								FontFamily = "Arial",
							},
							Items = new MenuItem[]
							{
								new MenuItem
								{
									Text = "Canada", Items = new MenuItem[]
									{
										new MenuItem { Text = "Vancouver" }
									}
								},
								new MenuItem { Text = "Redmond, USA" },
								new MenuItem { Text = "London, UK" },
								new MenuItem { Text = "Berlin, DE" }
							}
						}
					]
				},
				new MenuItem
				{
					Text = "View",
					Items =
					[
						new MenuItem { Text = "Refresh" },
						new MenuItem { Text = "Change Theme" }
					]
				},
			};
		}

		private void MenuBar_Disappear(object sender, EventArgs e)
		{
			Device.MenuBar.ItemClicked -= MenuBar_ItemClicked;
			Device.MenuBar.Items = null;
		}

		private void MenuBar_ItemClicked(object sender, Shared.Communication.MenuItemClickedEventArgs e)
		{
			AlertBox.Show($"Clicked {e.MenuItem}");
		}
	}
}
