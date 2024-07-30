using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class ListaProdutoPage : ContentPage
    {
        public ObservableCollection<Produto> Produtos { get; set; } = new ObservableCollection<Produto>();

        public ListaProdutoPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        private void Apagar_Clicked(object sender, EventArgs e)
        {
            // Limpar os campos
            // ...
        }

        private void Fim_Clicked(object sender, EventArgs e)
        {
            // Adicionar o produto à lista
            Produtos.Add(new Produto
            {
                Nome = NomeEntry.Text,
                // ... outros campos
            });

            // Limpar os campos
            // ...
        }

        private class Produto
        {
            public string Nome { get; set; }
            public decimal Custo { get; set; }
            // ... outros campos
        }
    }
}
