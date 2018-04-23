using System;
using System.Windows.Controls;
using DevExpress.Xpf.Core;

namespace ModalMessageBox {
    public static class AgMessageBox {
        public delegate void DialogResultDelegate(DialogResult result);

        public static void Show(string message, DialogResultDelegate onClosedCallback) {
            DXDialog dlg = new DXDialog();
            dlg.Content = new TextBlock() { Text = message };
            dlg.Closed += (s, e) => { onClosedCallback(((DXDialog)s).DialogResult); };
            dlg.ShowDialog();
        }
    }
}
