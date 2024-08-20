using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class ListaFuncionariosPage : ContentPage
    {
        public ListaFuncionariosPage()
        {
            InitializeComponent();

            ApagarButton.Clicked += OnApagarButtonClicked;
            FimButton.Clicked += OnFimButtonClicked;
        }

        public object SelectedFuncionario { get; private set; }

        private void OnApagarButtonClicked(object sender, EventArgs e)
        {
            if (SelectedFuncionario != null)
            {
                DisplayAlert("Ação", "Funcionário apagado", "OK");

            }
            else
            {
                DisplayAlert("Ação", "Nenhum funcionário selecionado", "OK");
            }
        }

        private void OnFimButtonClicked(object sender, EventArgs e)
        {
            DisplayAlert("Ação", "Fim da operação", "OK");
        }
    }
}
