namespace EcommerceCheckout.App;

public class PedidoService
{
    public string GerarCodigoRastreio(string regiao, int numeroPedido)
    {
        return $"{regiao.ToUpper()}-{numeroPedido:D4}";
    }

    public int CalcularPontosFidelidade(int valorTotal)
    {
        int parcelas = valorTotal / 10;
        return parcelas * 2;
    }

    public bool TemDireitoAFreteGratis(int valorTotal, bool eClienteVIP)
    {
        return valorTotal >= 200 || eClienteVIP;
    }
}
