using LiteDB;

namespace diagrama;
public class Cliente
{
    [BsonId]
    public String Nome {get; set;} 
    public String Endereço {get; set;} 
    public String Telefone {get; set;} 
    public String Codigo {get; set;} 
}
   