using System;
using System.Collections;

namespace Aula10 {
    /// <summary>Programa para testar o projeto</summary>
    public class Program {
        /// <summary>O programa começa aqui no Main</summary>
        /// <param name="args">Ignoramos os argumentos de linha de comandos neste programa</param>
        public static void Main(string[] args) {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Criar uma nova instância de Program e
            // invocar o método TestProjet na instância criada
            Program prog = new Program();
            prog.TestProject();

        }

        /// <summary>Método que testa este projeto</summary>
        private void TestProject() {
            // Instanciar um jogador com 70 quilos
            Player p = new Player(70.0f);

            Console.WriteLine(p.ToString() + "\n");

            Bag otherBag = new Bag(5);

            //
            // Adicionar vários itens à mochila do jogador:
            //

            // Pão com 2 dias, 500 gramas
            p.BagOfStuff.Add(new Food(FoodType.Bread, 2, 0.500f));
            // 300 gramas de vegetais com 5 dias
            p.BagOfStuff.Add(new Food(FoodType.Vegetables, 5, 0.300f));
            // Pistola com 1.5kg + 50 gramas por bala, carregada com 10 balas, com um custo de 250€
            p.BagOfStuff.Add(new Gun(1.5f, 0.050f, 10, 250));
            // 200 gramas de fruta fresca
            p.BagOfStuff.Add(new Food(FoodType.Fruit, 0, 0.200f));
            // Nova gun
            p.BagOfStuff.Add(new Gun(1.5f, 0.050f, 10, 250));

            otherBag.Add(new Food(FoodType.Meat, 1, 1f));
            otherBag.Add(new Food(FoodType.Vegetables, 1, 1.5f));

            Console.WriteLine(p.BagOfStuff.ToString());

            p.BagOfStuff.Add(otherBag);

            // Quantos itens tem o jogador na mochila?
            Console.WriteLine($"Nº de itens na mochila: {p.BagOfStuff.Count}");

            foreach (IStuff aThing in p.BagOfStuff) {
                Console.WriteLine(aThing.ToString());

                if (aThing is Gun) {
                    (aThing as Gun).Shoot();
                }

                Console.WriteLine();
            }

            Console.WriteLine(p.BagOfStuff.ToString());

            Console.WriteLine("\n" + p.ToString());

            Console.WriteLine("Mochila player contém guns?" + p.BagOfStuff.
                ContainsItemOfType<Gun>());

            Console.WriteLine("Mochila player contém comida?" + p.BagOfStuff.
                ContainsItemOfType<Food>());

            Console.WriteLine("Mochila player contém Bag?" + p.BagOfStuff.
                ContainsItemOfType<Bag>());

            Console.WriteLine("Mochila player contém otherbag?" + otherBag.
                ContainsItemOfType<Bag>());


        }
    }
}
