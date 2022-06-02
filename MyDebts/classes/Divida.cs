using MyDebts.interfaces;
namespace MyDebts.classes
{
    public class Divida : IDivida
    {
        public int Id { get; private set; }
        public static int Contador { get; private set; }
        public string Titulo { get; private set; }
        public string Descricao { get; private set; }
        public double Valor { get; private set; }

        public Divida(string titulo, string descricao, double valor){
            Random geradorNumero = new Random();
            this.Id = geradorNumero.Next();
            Contador ++;
            this.Titulo = titulo;
            this.Descricao = descricao;
            valor = Math.Round(valor, 2);
            this.Valor = valor;
        }
        public double GetValor()
        {
            return Valor;
        }

        public string Exibir(){
            return $"Código Único: {this.Id} \nTítulo: {this.Titulo} \nDescrição: {this.Descricao} \nValor: R${this.Valor = Math.Round(Valor,2)}";
        }

        public void SetDados(string titulo, string descricao, double valor)
        {
            this.Titulo = titulo;
            this.Descricao = descricao;
            this.Valor = valor;
        }
    }
}