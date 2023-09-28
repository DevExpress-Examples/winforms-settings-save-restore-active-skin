Namespace WindowsApplication1

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.galleryControl1 = New DevExpress.XtraBars.Ribbon.GalleryControl()
            Me.galleryControlClient1 = New DevExpress.XtraBars.Ribbon.GalleryControlClient()
            CType((Me.galleryControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.galleryControl1.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' galleryControl1
            ' 
            Me.galleryControl1.Controls.Add(Me.galleryControlClient1)
            Me.galleryControl1.DesignGalleryGroupIndex = 0
            Me.galleryControl1.DesignGalleryItemIndex = 0
            Me.galleryControl1.Dock = System.Windows.Forms.DockStyle.Fill
            ' 
            ' galleryControlGallery1
            ' 
            Me.galleryControl1.Gallery.ShowItemText = True
            Me.galleryControl1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.galleryControl1.Location = New System.Drawing.Point(0, 0)
            Me.galleryControl1.Name = "galleryControl1"
            Me.galleryControl1.Size = New System.Drawing.Size(816, 452)
            Me.galleryControl1.TabIndex = 0
            Me.galleryControl1.Text = "galleryControl1"
            ' 
            ' galleryControlClient1
            ' 
            Me.galleryControlClient1.GalleryControl = Me.galleryControl1
            Me.galleryControlClient1.Location = New System.Drawing.Point(2, 2)
            Me.galleryControlClient1.Size = New System.Drawing.Size(812, 448)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7F, 16F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(816, 452)
            Me.Controls.Add(Me.galleryControl1)
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.Name = "Form1"
            Me.Text = "Form1"
            AddHandler Me.FormClosing, New System.Windows.Forms.FormClosingEventHandler(AddressOf Me.Form1_FormClosing)
            CType((Me.galleryControl1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.galleryControl1.ResumeLayout(False)
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private galleryControl1 As DevExpress.XtraBars.Ribbon.GalleryControl

        Private galleryControlClient1 As DevExpress.XtraBars.Ribbon.GalleryControlClient
    End Class
End Namespace
