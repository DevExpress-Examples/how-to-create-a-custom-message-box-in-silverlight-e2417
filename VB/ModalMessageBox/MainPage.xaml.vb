Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.Core

Namespace ModalMessageBox
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)
			AgMessageBox.Show("Is it ok?", AddressOf OnDialogClosed)
		End Sub

		Private Sub OnDialogClosed(ByVal dialogResult As DialogResult)
			If dialogResult = DialogResult.OK Then
				txtDialogResult.Text = "OK"
			Else
				txtDialogResult.Text = dialogResult.ToString()
			End If
		End Sub
	End Class
End Namespace
