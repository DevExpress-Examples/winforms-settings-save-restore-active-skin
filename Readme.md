<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128615295/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2897)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Skins - Save the name of the active skin and restore it the next time you run the application

This example demonstrates how to persist application settings between sessions. The example saves the `SkinName` property. 

```csharp
public partial class Form1 : XtraForm {
    public Form1() {
        InitializeComponent();
        SkinHelper.InitSkinGallery(galleryControl1);
        UserLookAndFeel.Default.SkinName = Settings.Default["ApplicationSkinName"].ToString();
    }
    private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
        Settings.Default["ApplicationSkinName"] = UserLookAndFeel.Default.SkinName;
        Settings.Default.Save();
    }
}
```


## Files to Review

* [Form1.cs](./CS/WindowsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication1/Form1.vb))
* [Program.cs](./CS/WindowsApplication1/Program.cs) (VB: [Program.vb](./VB/WindowsApplication1/Program.vb))


## See Also

* [How to save/restore a palette name](https://github.com/DevExpress-Examples/how-to-save-restore-a-palette-name-t581395)
* [DevExpress WinForms Troubleshooting - Skins and Skin Editor](https://go.devexpress.com/CheatSheets_WinForms_Examples_T928562.aspx)
* [DevExpress WinForms Cheat Sheet - Appearances and Skins](https://supportcenter.devexpress.com/ticket/details/t904174/devexpress-winforms-cheat-sheet-appearances-and-skins)
* [Application Settings Overview](http://msdn.microsoft.com/en-us/library/k4s6c3a0.aspx)


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-save-a-current-skin-name-and-restore-it-at-the-next-application-run-e2897&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-save-a-current-skin-name-and-restore-it-at-the-next-application-run-e2897&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
