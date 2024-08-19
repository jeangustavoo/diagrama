using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroFuncionario2 : ContentPage
    {
        public CadastroFuncionario2()
        {
            InitializeComponent();
        }

        private void OnApagarClicked(object sender, EventArgs e)
        {
            NomeEntry.Text = string.Empty;
            CargoEntry.Text = string.Empty;
            SalarioEntry.Text = string.Empty;
        }

        private void OnFimClicked(object sender, EventArgs e)
        {
           
            DisplayAlert("Fim", "Cadastro concluído!", "OK");
        }
    }
}
