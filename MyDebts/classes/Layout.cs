using System;

namespace MyDebts.classes{
    public class Layout{

        private static List<Divida> dividas = new List<Divida>();
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
                    TelaAcesso();
                    break;
                case 3:
                    TelaDividasTotais();
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
            Console.Write("Os dados estão corretos? s/n -> ");
            string opcao = Console.ReadLine();
            
            if (opcao == "s"){
                Divida novaDivida = new Divida(titulo, descricao, valor);

                dividas.Add(novaDivida);
                
                Console.Clear();
                Console.WriteLine("=============================");
                Console.WriteLine($"DÍVIDA N° {Divida.Contador} CADASTRADA!");
                Console.WriteLine(novaDivida.Exibir());
                TelaBemVindo(novaDivida);
            }else{
                TelaNovaDivida();
            }
        }  

        private static void TelaAcesso(){
            Console.Clear();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("        ACESSAR DIVIDA DÍVIDA       ");
            Console.WriteLine("");

            Console.Write("* Título da Dívida: ");
            string titulo = Console.ReadLine();

            Divida divida = dividas.FirstOrDefault(div => div.Titulo == titulo);
            if (divida != null){
                TelaBemVindo(divida);
            }
        }

        private static void TelaDividasTotais(){
            double valorTotal = 0;
            Console.Clear();
            Console.WriteLine("        DÍVIDAS TOTAIS       ");
            foreach (Divida divida in dividas){
                Console.WriteLine(divida.Exibir());
                Console.WriteLine("------------------------------------");   
                valorTotal += divida.GetValor(); 
            }
            valorTotal = Math.Round(valorTotal, 2);
            Console.WriteLine($"*****Total       R${valorTotal}");

            Console.WriteLine("");
            Console.WriteLine("Voltando para o menu em 2 segundos...");
            Console.ReadKey();
            Thread.Sleep(2000);
            TelaInicial();
        }
        private static void TelaBemVindo(Divida divida){
            Console.Clear();
            Console.WriteLine($"*****DÍVIDA N° {Divida.Contador}*****");
            Console.WriteLine(divida.Exibir());
            Console.WriteLine("------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("[---OPÇÕES---]");
            Console.WriteLine("01- Pagar Dívida");
            Console.WriteLine("02- Editar Dívida");
            Console.WriteLine("03- Voltar para o Menu");
            Console.Write("Digite uma opção: ");
            int opcao = int.Parse(Console.ReadLine());
            
            switch(opcao){
                case 1:
                    dividas.Remove(divida);
                    foreach(Divida index in dividas){
                        Console.WriteLine("Dívida concluída!");
                        Thread.Sleep(1500);
                        TelaInicial();

                    }
                    break;
                case 2:
                    
                    Console.Clear();
                    Console.Write("* Título da Dívida: ");
                    string titulo = Console.ReadLine();

                    Console.Write("* Descricao da Dívida: ");
                    string descricao = Console.ReadLine();

                    Console.Write("* Valor da Dívida: ");
                    double valor = double.Parse(Console.ReadLine());

                    divida.SetDados(titulo, descricao, valor);
                    Console.WriteLine(divida.Exibir());

                    Thread.Sleep(1500);
                    TelaBemVindo(divida);
                    break;
                case 3:
                    Console.WriteLine("Voltando para o menu...");
                    Thread.Sleep(1500);
                    TelaInicial();
                    break;
                
            }

        }  
    }
}
