namespace diagrama;
public class Pedido
{
    [BsonId]
    public String Quantidade{get; set;} 
    public String Prazo {get; set;} 
    public String Frete {get; set;} 
    public String Listadeitens {get; set;} 
    public String Codigo {get; set;} 
    public String Desconto {get; set;} 
    public String Total {get; set;} 
    

}