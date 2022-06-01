using System;

namespace MyDebts.classes{
    public class Layout{
        public static void TelaInicial(){
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("        BEM-VINDO AO MY DEBTS       ");
            Console.WriteLine("");
            Console.WriteLine("1- Nova Dívida");
            Console.WriteLine("2- Abrir Dívida");
            Console.WriteLine("3- Dívidas totais");
            Console.WriteLine("4- Sair");
            Console.WriteLine("------------------------------------");
            Console.Write("Digite uma opção: ");
            int opção = int.Parse(Console.ReadLine());
            switch(opção){
                case 1:
                    TelaNovaDivida();
                    break;
                case 2:
                    Console.WriteLine("Abrir Dívida criada");
                    break;
                case 3:
                    Console.WriteLine("Total mostrado");
                    break;
                case 4:
                    Console.WriteLine("Sair");
                    System.Environment.Exit(1);
                    break;
            }
                
        }

        private static void TelaNovaDivida()
        {
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("        CRIAR NOVA DÍVIDA       ");
            Console.WriteLine("");

            Console.Write("* Título da Dívida: ");
            string titulo = Console.ReadLine();

            Console.Write("* Descricao da Dívida: ");
            string descricao = Console.ReadLine();

            Console.Write("* Valor da Dívida: ");
            double valor = double.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("********NOVA DÍVIDA GERADA*******");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Descrição: {descricao}");
            Console.WriteLine($"Valor: {valor}");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            Console.Write("Os dados estão corretos? s/n");
            string opcao = Console.ReadLine();
            
            if (opcao == "s"){
                Console.WriteLine("Cadastrado");
            }else{
                Console.WriteLine("Finalizado");
            }
        }    
    }
}
