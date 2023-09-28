Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel
Imports WindowsApplication1.Properties

Namespace WindowsApplication1

    Public Partial Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
            Call SkinHelper.InitSkinGallery(galleryControl1)
            UserLookAndFeel.Default.SkinName = Settings.Default(CStr("ApplicationSkinName")).ToString()
        End Sub

        Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs)
            Settings.Default("ApplicationSkinName") = UserLookAndFeel.Default.SkinName
            Call Settings.Default.Save()
        End Sub
    End Class
End Namespace
