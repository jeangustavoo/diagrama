using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroFuncionarioPage : ContentPage
    {
        public CadastroFuncionarioPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.Text == "Apagar")
            {
                // Implementar a lógica para apagar os dados
                // Ex: Limpar os campos de entrada
                // ...
            }
            else if (button.Text == "Fim")
            {
                // Implementar a lógica para finalizar o cadastro
                // Ex: Salvar os dados em um banco de dados
                //     Navegar para outra página
                // ...
            }
        }
    }
}
