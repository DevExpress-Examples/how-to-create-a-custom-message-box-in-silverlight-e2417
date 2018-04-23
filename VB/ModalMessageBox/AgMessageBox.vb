Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Controls
Imports DevExpress.Xpf.Core

Namespace ModalMessageBox
	Public NotInheritable Class AgMessageBox
		Public Delegate Sub DialogResultDelegate(ByVal result As DialogResult)

		Private Sub New()
		End Sub
		Public Shared Sub Show(ByVal message As String, ByVal onClosedCallback As DialogResultDelegate)
			Dim dlg As New DXDialog()
			dlg.Content = New TextBlock() With {.Text = message}
			AddHandler dlg.Closed, Function(s, e) AnonymousMethod1(s, e, onClosedCallback)
			dlg.ShowDialog()
		End Sub
		
		Private Shared Function AnonymousMethod1(ByVal s As Object, ByVal e As Object, ByVal onClosedCallback As DialogResultDelegate) As Boolean
			onClosedCallback((CType(s, DXDialog)).DialogResult)
			Return True
		End Function
	End Class
End Namespace
