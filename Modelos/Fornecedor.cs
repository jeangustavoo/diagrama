cpublic class Fornecedor
{
    prive String nome;
    String email;
    String telefone;
    String codigo;
    public void SetNome (String n)
    {
        nome= n;
    }
    public void SetEmail (String e)
    {
        email= e;
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
    public String GetEmail()
    {
        return email;
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