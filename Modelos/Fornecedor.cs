using LiteDB;

namespace diagrama;
public class Fornecedor
{
    internal int idFornecedor;

    [BsonId]
    public String Nome {get; set;} 
    public String Email {get; set;} 
    public String Telefone {get; set;} 
    public String Codigo {get; set;}
    public int Id { get; internal set; }
}