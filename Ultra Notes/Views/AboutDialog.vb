Imports SafwanUiKit.Extensions

Namespace Views
    Public Class AboutDialog

        Public Sub New()

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Me.UseShadow
            Me.Draggable
            toolbarPanel.Draggable

        End Sub

        Private Sub closeButton_Click(sender As Object, e As EventArgs) Handles closeButton.Click
            Me.Close()
        End Sub

        Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
            Me.Close()
        End Sub

    End Class
End Namespace