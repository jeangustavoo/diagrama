namespace diagrama;
public class Produto
{
      [BsonId]
    public String Nome {get; set;} 
    public Int IdCusto {get; set;} 
    public Int IdValor {get; set;} 
    public String TempoDeProdução {get; set;} 
   
    
}