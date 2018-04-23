using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using DevExpress.Xpf.Core;

namespace ModalMessageBox {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            AgMessageBox.Show("Is it ok?", OnDialogClosed);
        }

        void OnDialogClosed(DialogResult dialogResult) {
            if(dialogResult == DialogResult.OK) {
                txtDialogResult.Text = "OK";
            }
            else {
                txtDialogResult.Text = dialogResult.ToString();
            }
        }
    }
}
