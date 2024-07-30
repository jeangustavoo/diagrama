using System.Collections.Generic;
using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class MateriaPrimaPage : ContentPage
    {
        public MateriaPrimaPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Implementar a lógica para remover o item
            // Exemplo: Remover o texto do Entry correspondente
            var button = (Button)sender;
            var entry = (Entry)button.Parent.Children[0];
            entry.Text = "";
        }
    }
}
