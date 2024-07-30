namespace diagrama;
public class Pedido
{
    String quantidade;
    String prazo;
    String frete;
    String listadeitens;
    String codigo;
    String desconto;
    String total;
    public void SetQuantidade (String q)
    {
        quantidade= q;
    }
    public void SetPrazo (String p)
    {
        prazo= p;
    }
    public void SetFrete (String f)
    {
        frete= f;
    }
    public void SetListaDeItens (String l)
    {
        listadeitens= l;
    }
    public void SetCodigo (String c)
    {
        codigo= c;
    }
    public void SetDesconto (bString d)
    {
        desconto= d;
    }
    public void SetTotal (String t)
    {
        total= t;
    }
    public String GetQuantidade()
    {
        return quantidade;
    }
    public String GetPrazo()
    {
        return prazo;
    }
    public String GetFrete()
    {
        return frete;
    }
    public String GetListaDeItens()
    {
        return listadeitens;
    }
    public String GetCodigo()
    {
        return codigo;
    }
    public String GetDesconto()
    {
        return desconto;
    }
    public String GetTotal()
    {
        return total;
    }

}