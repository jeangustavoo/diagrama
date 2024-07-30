using System.Collections.ObjectModel;


namespace diagrama
{
    public partial class ListaFuncionariosPage : ContentPage
    {
        public ObservableCollection<Funcionario> Funcionarios { get; set; }
        public Funcionario SelectedFuncionario { get; set; }
        public bool IsFuncionarioSelected { get { return SelectedFuncionario != null; } }

        public ListaFuncionariosPage()
        {
            InitializeComponent();
            Funcionarios = new ObservableCollection<Funcionario>();
            BindingContext = this;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (button.Text == "Apagar")
            {
                Funcionarios.Remove(SelectedFuncionario);
                SelectedFuncionario = null;
            }
            else if (button.Text == "Fim")
            {
                // Implementar a lógica para finalizar o cadastro
                // Ex: Salvar os dados em um banco de dados
                //     Navegar para outra página
            }
        }
    }

    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cargo { get; set; }
        public decimal Salario { get; set; }
    }
}
