namespace MyDebts.interfaces
{
    public interface IDivida
    {
        double GetValor();
        string Exibir();

        void SetDados(string titulo, string descricao, double valor);
    }
}