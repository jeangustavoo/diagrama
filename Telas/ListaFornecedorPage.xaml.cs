using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class FornecedorListPage : ContentPage
    {
        public FornecedorListPage()
        {
            InitializeComponent();

            ApagarButton.Clicked += OnApagarClicked;
            FimButton.Clicked += OnFimClicked;
        }

        private void OnApagarClicked(object sender, EventArgs e)
        {
            DisplayAlert("Apagar", "Os dados foram apagados.", "OK");
        }

        private void OnFimClicked(object sender, EventArgs e)
        {
            DisplayAlert("Finalizado", "A operação foi finalizada.", "OK");

        }
    }
}
