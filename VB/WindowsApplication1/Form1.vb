Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Helpers
Imports DevExpress.XtraEditors
Imports DevExpress.LookAndFeel

Namespace WindowsApplication1
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			SkinHelper.InitSkinGallery(galleryControl1)
            UserLookAndFeel.Default.SkinName = My.Settings.Default("ApplicationSkinName").ToString()
		End Sub

		Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As FormClosingEventArgs) Handles MyBase.FormClosing
            My.Settings.Default("ApplicationSkinName") = UserLookAndFeel.Default.SkinName
			My.Settings.Default.Save()
		End Sub
	End Class
End Namespace