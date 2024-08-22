using LiteDB;

namespace diagrama;
public class Funcionario
{
      [BsonId]
    public String Nome {get; set;} 
    public String Cargo {get; set;} 
    public String Salario {get; set;} 
   

}