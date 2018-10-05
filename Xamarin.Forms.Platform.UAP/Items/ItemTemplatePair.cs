﻿namespace Xamarin.Forms.Platform.UWP
{
	internal class ItemTemplatePair
	{
		public ItemTemplatePair(DataTemplate formsDataTemplate, object item)
		{
			FormsDataTemplate = formsDataTemplate;
			Item = item;

			System.Diagnostics.Debug.WriteLine($">>>>> New ItemTemplatePair, item: {item}");
		}

		public DataTemplate FormsDataTemplate { get; }
		public object Item { get; }
	}
}