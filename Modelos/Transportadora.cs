using LiteDB;

namespace diagrama;
public class Transportadora
{
          [BsonId]
    public String Nome {get; set;}
    public String Telefone {get; set;}
    public String Codigo {get; set;}
  
}