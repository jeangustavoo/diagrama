using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class CadastroPedidoPage : ContentPage
    {
        public CadastroPedidoPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private decimal _quantidade;
        private decimal _frete;
        private decimal _desconto;

        public decimal Quantidade
        {
            get => _quantidade;
            set
            {
                _quantidade = value;
                CalcularTotal();
            }
        }

        // Propriedades similares para Prazo, Frete, Desconto e outros campos

        public decimal Total { get; set; }

        private void CalcularTotal()
        {
            // Lógica para calcular o total com base nos valores inseridos
            // Exemplo simplificado:
            Total = Quantidade * Frete - Desconto;
        }

        private void Apagar_Clicked(object sender, EventArgs e)
        {
            // Limpar os campos
            // ...
        }

        private void Fim_Clicked(object sender, EventArgs e)
        {
            // Salvar o pedido
            // ...
        }
    }
}
