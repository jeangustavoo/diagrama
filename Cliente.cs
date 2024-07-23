namespace diagrama;
public class Cliente
{
    prive String nome;
    String endereço;
    String telefone;
    String codigo;
    public void SetNome (String n)
    {
        nome= n;
    }
    public void SetEndereço (String e)
    {
        endereço= e;
    }
    public void SetCodigo (String c)
    {
        codigo= c;
    }
    public String GetNome()
    {
        return nome;
    }
    public String GetEndereço()
    {
        return endereço;
    }
    public String Getcodigo()
    {
        return codigo;
    }



}