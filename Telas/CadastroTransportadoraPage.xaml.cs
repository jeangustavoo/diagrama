using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroTransportadoraPage : ContentPage
    {
        public CadastroTransportadoraPage()
        {
            InitializeComponent();
        }

        private void OnClientesClicked(object sender, EventArgs e)
        {
            DisplayAlert("Clientes", "Navegando para a página de Clientes.", "OK");
        }

        private void OnFuncionariosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Funcionários", "Navegando para a página de Funcionários.", "OK");
        }

        private void OnFornecedorClicked(object sender, EventArgs e)
        {
            DisplayAlert("Fornecedor", "Navegando para a página de Fornecedor.", "OK");
        }

        private void OnPedidosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Pedidos", "Navegando para a página de Pedidos.", "OK");
        }

        private void OnMateriaPrimaClicked(object sender, EventArgs e)
        {
            DisplayAlert("Matéria Prima", "Navegando para a página de Matéria Prima.", "OK");
        }

        private void OnProdutosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Produtos", "Navegando para a página de Produtos.", "OK");
        }

        private void OnTransportadoraClicked(object sender, EventArgs e)
        {
            DisplayAlert("Transportadora", "Navegando para a página de Transportadora.", "OK");
        }
    }
}
