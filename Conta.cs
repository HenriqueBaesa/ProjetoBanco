class Conta
{
    public int Codigo {get;}
    public double Saldo {get; private set;}

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor)
    {
        if (Saldo - valor < 0)
        {
            throw new ArgumentException("Saldo insuficiente");
        }
        this.Saldo -= valor;
    }

    public void Depositar(double valor)
    {
        Saldo += valor;
    }

    public bool Transferir(Conta conta, double valor)
    {
        try
        {
            this.Sacar(valor);
            conta.Depositar(valor);
        }
        catch (System.Exception)
        {
            return false;
        }
        return true;
    }

    public void VerificarValor(double valor)
    {
        if (valor < 0) throw new ArgumentException("Valor precisa ser maior que 0");
    }
}