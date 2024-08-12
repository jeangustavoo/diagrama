namespace diagrama;
public class Produto
{
      [BsonId]
    public String Nome {get; set;} 
    public Int Custo {get; set;} 
    public Int Valor {get; set;} 
    public String TempoDeProdução {get; set;} 
   
    
}