using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace diagrama
{
    public partial class ListaProdutoPage : ContentPage
    {
        public ObservableCollection<Produto> Produtos { get; set; }

        public ListaProdutoPage()
        {
            InitializeComponent();

            Produtos = new ObservableCollection<Produto>
            {
                new Produto { Nome = "Produto 1", Custo = 10.0, Valor = 15.0, TempoDeProducao = "2 horas" },
                new Produto { Nome = "Produto 2", Custo = 20.0, Valor = 30.0, TempoDeProducao = "3 horas" }
            };

            BindingContext = this;
        }

        private void Apagar_Clicked(object sender, EventArgs e)
        {
            if (ProdutosListView.SelectedItem != null)
            {
                var produtoSelecionado = ProdutosListView.SelectedItem as Produto;
                if (produtoSelecionado != null)
                {
                    Produtos.Remove(produtoSelecionado);
                    DisplayAlert("Apagar", $"{produtoSelecionado.Nome} foi apagado.", "OK");
                }
            }
            else
            {
                DisplayAlert("Apagar", "Selecione um produto para apagar.", "OK");
            }
        }

        private void Fim_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Finalizado", "A operação foi finalizada.", "OK");

        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public double Custo { get; set; }
        public double Valor { get; set; }
        public string TempoDeProducao { get; set; }
    }
}
