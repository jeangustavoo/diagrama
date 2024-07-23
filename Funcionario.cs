namespace diagrama;
public class Funcionario
{
    prive String nome;
    String cargo;
    String salario;
    public void SetNome (String n)
    {
        nome= n;
    }
    public void SetCargo (String c)
    {
        cargo= c;
    }
    public void SetSalario (String s)
    {
        salario= s;
    }
    public String GetNome()
    {
        return nome;
    }
    public String GetCargo()
    {
        return cargo;
    }
    public String GetSalario()
    {
        return salario;
    }


}