using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class ListaMateriaPrimaPage : ContentPage
    {
        public ListaMateriaPrimaPage()
        {
            InitializeComponent();

            ApagarButton.Clicked += OnApagarButtonClicked;
            FimButton.Clicked += OnFimButtonClicked;
        }

        private void OnApagarButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Ação", "Botão Apagar clicado", "OK");
        }

        private void OnFimButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Ação", "Botão Fim clicado", "OK");
        }
    }
}
