
using diagrama.Modelos;

namespace diagrama;

public class FuncionarioControle : BaseControle
{
  //----------------------------------------------------------------------------

  public FuncionarioControle() : base()
  {
    NomeDaTabela = "Funcionario";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idFuncionario)
  {
    var collection = liteDB.GetCollection<Funcionario>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idFuncionario);
  }

  //----------------------------------------------------------------------------

  public virtual List<Funcionario>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Funcionario>(NomeDaTabela);
    return new List<Funcionario>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idFuncionario)
  {
    var collection = liteDB.GetCollection<Funcionario>(NomeDaTabela);
    collection.Delete(idFuncionario);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Funcionario Funcionario)
  {
    var collection = liteDB.GetCollection<Funcionario>(NomeDaTabela);
    collection.Upsert(Funcionario);
  }

  //----------------------------------------------------------------------------
}