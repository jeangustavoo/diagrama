using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void OnClientesClicked(object sender, EventArgs e)
        {
            DisplayAlert("Clientes", "Você clicou no botão Clientes!", "OK");
        }

        private void OnFuncionariosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Funcionários", "Você clicou no botão Funcionários!", "OK");
        }

        private void OnFornecedorClicked(object sender, EventArgs e)
        {
            DisplayAlert("Fornecedor", "Você clicou no botão Fornecedor!", "OK");
        }

        private void OnPedidosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Pedidos", "Você clicou no botão Pedidos!", "OK");
        }

        private void OnMateriaPrimaClicked(object sender, EventArgs e)
        {
            DisplayAlert("Matéria Prima", "Você clicou no botão Matéria Prima!", "OK");
        }

        private void OnProdutosClicked(object sender, EventArgs e)
        {
            DisplayAlert("Produtos", "Você clicou no botão Produtos!", "OK");
        }

        private void OnTransportadoraClicked(object sender, EventArgs e)
        {
            DisplayAlert("Transportadora", "Você clicou no botão Transportadora!", "OK");
        }
    }
}
