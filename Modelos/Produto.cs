namespace diagrama;
public class Produto
{
    prive String nome;
    Int custo;
    Int valor;
    String tempodeprodução;
    public void SetNome (String n)
    {
        nome= n;
    }
    public void SetCusto (Int c)
    {
        custo= c;
    }
    public void SetValor (Int v)
    {
        valor= v;
    }
    public void SetTempoDeProdução (String t)
    {
        tempodeprodução= t;
    }
    public String GetNome()
    {
        return nome;
    }
    public String GetCusto()
    {
        return custo;
    }
    public String GetValor()
    {
        return valor;
    }
    public String GetTempoDeProdução()
    {
        return tempodeprodução;
    }
    
}