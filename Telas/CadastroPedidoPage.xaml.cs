using Microsoft.Maui.Controls;

namespace diagrama.Views
{
    public partial class CadastroPedidoPage: ContentPage
    {
        public CadastroPedidoPage()
        {
            InitializeComponent();
        }

        private void OnClientesClicked(object sender, EventArgs e)
        {
            DisplayAlert("Clientes", "Você clicou em Clientes", "OK");
        }

        private void OnFuncionariosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Funcionários", "Você clicou em Funcionários", "OK");
        }

        private void OnFornecedorClicked(object sender, EventArgs e)
        {
            DisplayAlert("Fornecedor", "Você clicou em Fornecedor", "OK");
        }

        private void OnMateriaPrimaClicked(object sender, EventArgs e)
        {
            DisplayAlert("Matéria Prima", "Você clicou em Matéria Prima", "OK");
        }

        private void OnPedidosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Pedidos", "Você clicou em Pedidos", "OK");
        }

        private void OnProdutosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Produtos", "Você clicou em Produtos", "OK");
        }

        private void OnTransportadoraClicked(object sender, EventArgs e)
        {
            DisplayAlert("Transportadora", "Você clicou em Transportadora", "OK");
        }
    }
}
