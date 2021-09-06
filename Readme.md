<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128658734/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2272)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))
* **[MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))**
<!-- default file list end -->
# How to: Save and Restore Settings of All Controls That Are Present in the UI


Methods for saving and restoring a layout implemented in specific controls (such as <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingDockLayoutManager_SaveLayoutToStreamtopic">DockLayoutManager.SaveLayoutToStream</a> and <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfDockingDockLayoutManager_RestoreLayoutFromStreamtopic">DockLayoutManager.RestoreLayoutFromStream</a>) are intended for saving/restoring settings of a specific control and do not take into account other nested DevExpress controls. To be able to save settings of all controls on your window, use the <a href="https://documentation.devexpress.com/#WPF/clsDevExpressXpfCoreWorkspaceManagertopic">WorkspaceManager</a> class. This example demonstrates how to use this class.
<p><strong>See also:</strong></p>
<p><a href="https://documentation.devexpress.com/#WPF/CustomDocument7409">Saving and Restoring Layout Basics</a></p>

<br/>


