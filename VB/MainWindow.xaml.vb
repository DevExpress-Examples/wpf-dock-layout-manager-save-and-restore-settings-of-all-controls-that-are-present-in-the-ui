Imports System
Imports DevExpress.Xpf.Core

Namespace DXSample
    Partial Public Class MainWindow
        Inherits DXWindow

        Private Const LayoutFileName As String = "layout.xml"
        Private Const WorkspaceName As String = "workspace1"
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Button_Click(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim manager As IWorkspaceManager = WorkspaceManager.GetWorkspaceManager(dockLayoutManager)
            manager.CaptureWorkspace(WorkspaceName)
            manager.SaveWorkspace(WorkspaceName, LayoutFileName)
        End Sub
        Private Sub Button_Click_1(ByVal sender As Object, ByVal e As System.Windows.RoutedEventArgs)
            Dim manager As IWorkspaceManager = WorkspaceManager.GetWorkspaceManager(dockLayoutManager)
            manager.LoadWorkspace(WorkspaceName, LayoutFileName)
            manager.ApplyWorkspace(WorkspaceName)
        End Sub
    End Class
End Namespace