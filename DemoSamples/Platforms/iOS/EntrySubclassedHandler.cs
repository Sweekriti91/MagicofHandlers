using Microsoft.Maui.Handlers;
using UIKit;
using Microsoft.Maui.Platform;

namespace DemoSamples;

public class EntrySubclassedHandler : EntryHandler
{
    // static readonly IPropertyMapper<IEntry, EntrySubclassedHandler> ScEntryMapper =
    //     new PropertyMapper<IEntry, EntrySubclassedHandler>(EntryHandler.Mapper)
    //     {
    //         // Extra property mappings here
    //     };

    // static readonly CommandMapper<IEntry, EntrySubclassedHandler> ScEntryCommandMapper = 
    //     new(EntryHandler.CommandMapper)
    //     {
    //         // Extra command mappings here
    //     };

    // public EntrySubclassedHandler()
    //     : base(ScEntryMapper, ScEntryCommandMapper) {}

    // Optionally create/modify and return the native view for the cross-platform control.
    protected override MauiTextField CreatePlatformView()
    {
        var textField = new MauiTextField
        {
            // var overlayButton = new UIButton(UIButtonType.Custom);
            // var bookmarkImage = new UIImage("bookmark.png");
            // overlayButton.SetImage(bookmarkImage, UIControlState.Normal);
            // overlayButton.SizeToFit();

            // Assign the overlay button to the text field
            // textField.RightView = textField.ClearButton;
            BorderStyle = UITextBorderStyle.Line,
            ClearButtonMode = UITextFieldViewMode.Always
        };

        return textField;
    }


    // Perform native view setup, such as event subscriptions.
    protected override void ConnectHandler(MauiTextField platformView)
    {
        base.ConnectHandler(platformView);
    }


    // // Perform native view cleanup such as unsubscribing events and disposing objects.
    // protected override void DisconnectHandler(MauiTextField platformView)
    // {
    //     base.DisconnectHandler(platformView);
    // }
}
