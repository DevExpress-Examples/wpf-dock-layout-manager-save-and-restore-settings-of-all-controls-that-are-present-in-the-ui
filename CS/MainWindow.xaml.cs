using System;
using DevExpress.Xpf.Core;

namespace DXSample {
    public partial class MainWindow : DXWindow {
        const string LayoutFileName = "layout.xml";
        const string WorkspaceName = "workspace1";
        public MainWindow() {
            InitializeComponent();
        }
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e) {
            IWorkspaceManager manager = WorkspaceManager.GetWorkspaceManager(dockLayoutManager);
            manager.CaptureWorkspace(WorkspaceName);
            manager.SaveWorkspace(WorkspaceName, LayoutFileName);
        }
        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e) {
            IWorkspaceManager manager = WorkspaceManager.GetWorkspaceManager(dockLayoutManager);
            manager.LoadWorkspace(WorkspaceName, LayoutFileName);
            manager.ApplyWorkspace(WorkspaceName);
        }
    }
}