using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class UsuariosPage : ContentPage
    {
        public UsuariosPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;
            string buttonText = button.Text;

            // Implementar a lógica para cada botão
            switch (buttonText)
            {
                case "Clientes":
                    // Navegar para a página de clientes
                    break;
                case "Funcionários":
                    // Navegar para a página de funcionários
                    break;
                // ... outros casos
            }
        }
    }
}
