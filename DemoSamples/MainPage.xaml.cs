#if ANDROID
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif
using Microsoft.Maui.Platform;
#if IOS
using System.Drawing;
using UIKit;
#endif

namespace DemoSamples;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
		// ModifyControls();
	}

    private void ModifyControls()
    {
        // #if ANDROID
		// Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
		// {
		// 	handler.PlatformView.BackgroundTintList = 
		// 		Android.Content.Res.ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
		// });
		// #endif

		// #if MACCATALYST 
		// Microsoft.Maui.Handlers.SliderHandler.Mapper.ModifyMapping(nameof(ISlider.MaximumTrackColor), (handler, view, action) =>
		// {
		// 	handler.PlatformView.MaximumTrackTintColor = view.MaximumTrackColor.ToPlatform();
		// });
		// #endif

		// #if IOS
		// Microsoft.Maui.Handlers.EntryHandler.PlatformViewFactory = (handler) =>
		// {
		// 	var textField = new MauiTextField();
       
        //     textField.BorderStyle = UITextBorderStyle.Line;
        //     textField.Layer.MasksToBounds = true;

        //     return textField;
		// };
		// #endif

		// #if IOS
		// Microsoft.Maui.Handlers.EntryHandler.PlatformViewFactory = (handler) =>
		// {
			
		// if (handler.VirtualView is not CustomEntry)
		// 	return null;

		// var textField = new MauiTextField();
        // textField.BorderStyle = UITextBorderStyle.Line;
        // textField.Layer.MasksToBounds = true;
        // return textField;
		// };
		// #endif
    }

    private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

