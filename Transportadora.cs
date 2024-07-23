namespace diagrama;
public class Transportadora
{
    prive String nome;
    String telefone;
    String codigo;
    public void SetNome (String n)
    {
        nome= n;
    }
    public void SetTelefone (String t)
    {
        telefone= t;
    }
    public void SetCodigo (String c)
    {
        codigo= c;
    }
    public String GetNome()
    {
        return nome;
    }
    public String GetTelefone()
    {
        return telefone;
    }
    public String GetCodigo()
    {
        return codigo;
    }


}