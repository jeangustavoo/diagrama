using Microsoft.Maui.Controls;
using System;

namespace diagrama
{
    public partial class MateriaPrimaPage : ContentPage
    {
        public MateriaPrimaPage()
        {
            InitializeComponent();
        }

        private void OnApagarClicked(object sender, EventArgs e)
        {
            TecidoEntry.Text = string.Empty;
            DisplayAlert("Apagar", "O campo de tecido foi apagado.", "OK");
        }
    }
}
