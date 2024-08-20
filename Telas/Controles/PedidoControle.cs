
using diagrama.Modelos;

namespace diagrama;

public class PedidoControle : BaseControle
{
  //----------------------------------------------------------------------------

  public PedidoControle() : base()
  {
    NomeDaTabela = "Pedido";
  }

  //----------------------------------------------------------------------------

  public virtual Registro? Ler(int idMateriaPrima)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idPedido);
  }

  //----------------------------------------------------------------------------

  public virtual List<Pedido>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Pedido>(NomeDaTabela);
    return new List<Pedido>(tabela.FindAll());
  }

  //----------------------------------------------------------------------------

  public virtual void Apagar(int idPedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    collection.Delete(idPedido);
  }

  //----------------------------------------------------------------------------

  public virtual void CriarOuAtualizar(Pedido Pedido)
  {
    var collection = liteDB.GetCollection<Pedido>(NomeDaTabela);
    collection.Upsert(Pedido);
  }

  //----------------------------------------------------------------------------
}


