using Microsoft.Maui.Controls;

namespace diagrama
{
    public partial class ListaPedidoPage : ContentPage
    {
        public ListaPedidoPage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        public object PrazoLabel { get; private set; }
        public object NameEntry { get; private set; }
        public object QuantidadeLabel { get; private set; }
        public object ItensLabel { get; private set; }
        public object FreteLabel { get; private set; }
        public object DescontoLabel { get; private set; }
        public object CodigoLabel { get; private set; }
        public object TotalLabel { get; private set; }

        private void OnClearClicked(object sender, EventArgs e)
        {
            NameEntry.Text = string.Empty;
            QuantidadeLabel.Text = string.Empty;
            PrazoLabel.Text = string.Empty;
            FreteLabel.Text = string.Empty;
            ItensLabel.Text = string.Empty;
            DescontoLabel.Text = string.Empty;
            CodigoLabel.Text = string.Empty;
            TotalLabel.Text = string.Empty;
        }

        private void OnFinishClicked(object sender, EventArgs e)
        {
            DisplayAlert("Finalizado", "O pedido foi finalizado.", "OK");

        }

        private void OnNameConfirmed(object sender, EventArgs e)
        {
            DisplayAlert("Nome Confirmado", $"O nome '{NameEntry.Text}' foi confirmado.", "OK");

        }
    }
}
