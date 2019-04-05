<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DX WPF Application10/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DX WPF Application10/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DX WPF Application10/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DX WPF Application10/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Save and Restore Settings of All Controls That Are Present in the UI


Methods for saving and restoring a layout implemented in specific controls (such as <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingDockLayoutManager_SaveLayoutToStreamtopic">DockLayoutManager.SaveLayoutToStream</a> and <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingDockLayoutManager_RestoreLayoutFromStreamtopic">DockLayoutManager.RestoreLayoutFromStream</a>) are intended for saving/restoring settings of a specific control and do not take into account other nested DevExpress controls. To be able to save settings of all controls on your window, use the <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfCoreWorkspaceManagertopic">WorkspaceManager</a> class. This example demonstrates how to use this class.
<p><strong>See also:</strong></p>
<p><a href="https://documentation.devexpress.com/#WPF/CustomDocument7409">Saving and Restoring Layout Basics</a></p>

<br/>


