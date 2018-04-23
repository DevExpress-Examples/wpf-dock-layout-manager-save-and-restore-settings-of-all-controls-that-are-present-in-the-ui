Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpf.Core
Imports DevExpress.Xpf.Core.Serialization

Namespace DXWpfApplication
	Partial Public Class MainWindow
		Inherits DXWindow
		Public Sub New()
			InitializeComponent()

		End Sub
		Private Sub ButtonSave_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
			DXSerializer.Serialize(Me, "layout.xml", "DXWpfApplication", New DXOptionsLayout() With {.AcceptNestedObjects = AcceptNestedObjects.VisualTreeOnly})
		End Sub
		Private Sub ButtonRestore_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
			DXSerializer.Deserialize(Me, "layout.xml", "DXWpfApplication", New DXOptionsLayout() With {.AcceptNestedObjects = AcceptNestedObjects.VisualTreeOnly})
		End Sub
	End Class
	Friend Class TestData
		Private privateText As String
		Public Property Text() As String
			Get
				Return privateText
			End Get
			Set(ByVal value As String)
				privateText = value
			End Set
		End Property
		Private privateNumber As Integer
		Public Property Number() As Integer
			Get
				Return privateNumber
			End Get
			Set(ByVal value As Integer)
				privateNumber = value
			End Set
		End Property
	End Class
End Namespace
