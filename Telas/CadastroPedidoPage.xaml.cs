using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class UsuariosPage : ContentPage
    {
        public UsuariosPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string buttonText = button.Text;

            switch (buttonText)
            {
                case "Clientes":
                    // Navegar para a página de clientes
                    await Navigation.PushAsync(new ClientesPage());
                    break;
                case "Funcionários":
                    // Navegar para a página de funcionários
                    await Navigation.PushAsync(new FuncionariosPage());
                    break;
                // ... outros casos
            }
        }
    }
}
