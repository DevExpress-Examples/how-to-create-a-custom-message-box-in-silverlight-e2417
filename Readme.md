<!-- default file list -->
*Files to look at*:

* [AgMessageBox.cs](./CS/ModalMessageBox/AgMessageBox.cs) (VB: [AgMessageBox.vb](./VB/ModalMessageBox/AgMessageBox.vb))
* [MainPage.xaml](./CS/ModalMessageBox/MainPage.xaml) (VB: [MainPage.xaml](./VB/ModalMessageBox/MainPage.xaml))
* [MainPage.xaml.cs](./CS/ModalMessageBox/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/ModalMessageBox/MainPage.xaml.vb))
<!-- default file list end -->
# How to create a custom message box in Silverlight


<p>Silverlight has a System.Windows.MessageBox static class. It presents a dialog box with OK and Cancel buttons to enable a user to make a choice. However, this dialog is a system window, not actually Silverlight, so there is no way to change its style or to apply a theme to it.</p><p>This example demonstrates how to emulate a MessageBox by using genuine Silverlight controls. In our example, we use the DXDialog class from the DXperience for Silverlight. The DevExpress.Xpf.Core.DialogResult enumeration replicates the DialogResult enumeration of Windows Forms.</p><p>The DXDialog.ShowModal method opens a dialog window in modal mode. It compels a user to close the dialog before proceeding with UI interaction. However, unlike the MessageBox.Show method, the DXDialog.ShowModal method doesn't prevent execution of the code that follows. This is the nature of Silverlight - a Silverlight application runs within a Web browser, and is not allowed to capture all messages for exclusive handling. This also explains the necessity of a callback delegate for dialog result checking. The callback function is called on the DXDialog.Closed event. The code dependant on the dialog result should be placed into the callback function.</p>

<br/>


