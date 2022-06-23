Imports DevExpress.Xpf.Core

Namespace DXSample

    Public Partial Class MainWindow
        Inherits DXWindow

        Const LayoutFileName As String = "layout.xml"

        Const WorkspaceName As String = "workspace1"

        Public Sub New()
            Me.InitializeComponent()
        End Sub

        Private Sub Button_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim manager As IWorkspaceManager = WorkspaceManager.GetWorkspaceManager(Me.dockLayoutManager)
            manager.CaptureWorkspace(WorkspaceName)
            manager.SaveWorkspace(WorkspaceName, LayoutFileName)
        End Sub

        Private Sub Button_Click_1(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim manager As IWorkspaceManager = WorkspaceManager.GetWorkspaceManager(Me.dockLayoutManager)
            manager.LoadWorkspace(WorkspaceName, LayoutFileName)
            manager.ApplyWorkspace(WorkspaceName)
        End Sub
    End Class
End Namespace
