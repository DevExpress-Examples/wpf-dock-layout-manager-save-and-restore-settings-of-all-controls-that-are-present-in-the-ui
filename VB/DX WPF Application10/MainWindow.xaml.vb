Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Serialization

Namespace DXWpfApplication

    Public Partial Class MainWindow
        Inherits DXWindow

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Call DXSerializer.Serialize(Me, "layout.xml", "DXWpfApplication", New DXOptionsLayout() With {.AcceptNestedObjects = AcceptNestedObjects.VisualTreeOnly})
        End Sub

        Private Sub ButtonRestore_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Call DXSerializer.Deserialize(Me, "layout.xml", "DXWpfApplication", New DXOptionsLayout() With {.AcceptNestedObjects = AcceptNestedObjects.VisualTreeOnly})
        End Sub
    End Class

    Friend Class TestData

        Public Property Text As String

        Public Property Number As Integer
    End Class
End Namespace
