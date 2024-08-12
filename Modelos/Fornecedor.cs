namespace diagrama;
public class Fornecedor
{
     [BsonId]
    public String Nome {get; set;} 
    public String Email {get; set;} 
    public String Telefone {get; set;} 
    public String Codigo {get; set;} 
   
}