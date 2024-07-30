using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class ListaPedidosPage : ContentPage
    {
        public ObservableCollection<ItemPedido> Itens { get; set; } = new ObservableCollection<ItemPedido>();
        // ... outras propriedades para os campos do pedido

        public ListaPedidosPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        // ... métodos para adicionar itens, calcular total, etc.

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

    public class ItemPedido
    {
        public string Nome { get; set; }
    }
}
