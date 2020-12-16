using System;
using System.Collections.Generic;
using Objetos_POO.Classes;

namespace Objetos_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Produto product1 = new Produto(); // Primeiro método construtor

            // Produto product2 = new Produto(40, "Cebola", 5f); // segundo método construtor
            // Console.WriteLine(product2.Codigo);
            // Console.WriteLine(product2.Nome);
            // Console.WriteLine(product2.Preco);

            // product2.Codigo = 25;
            // product2.Nome = "Alho";
            // product2.Preco = 7f;

            // Console.WriteLine("Após as alterações");
            // Console.WriteLine(product2.Codigo);
            // Console.WriteLine(product2.Nome);
            // Console.WriteLine(product2.Preco);

            // demonstração de produtos

            List<Produto> produtos = new List<Produto>();

            Produto[] arrayProdutos = {};


            // Adicionando produtos através de instâncias com construtores
            produtos.Add(new Produto(8, "Galaxy S10 Plus", 3522.56f));
            produtos.Add(new Produto(7, "Zenfone ASUS", 3822.56f));
            produtos.Add(new Produto(62, "Apple Watch", 4022.56f));
            produtos.Add(new Produto(5, "Samsung Watch", 4822.56f));
            produtos.Add(new Produto(4, "Motorola G8", 5722.56f));

            // ou a opção de instancias básicas e suas atribuições
            Produto smartphone = new Produto();
            smartphone.Codigo = 54;
            smartphone.Nome = "Galaxy S11";
            smartphone.Preco = 9576.45f;

            produtos.Add(smartphone);

            // Mostrando produtos com o foreach
            foreach (Produto item in produtos)
            {
                Console.WriteLine($" Código: {item.Codigo} - Nome: {item.Nome} - Preço: {item.Preco} ");
            }

            produtos.RemoveAt(3);

            Console.WriteLine("\nRemoção feita: ");
             foreach (Produto item in produtos)
            {
                Console.WriteLine($" Nome: {item.Nome} ");
            }

            produtos.RemoveAll(x => x.Nome == "Motorola G8");

             Console.WriteLine("\nNova remoção feita: ");
             foreach (Produto item in produtos)
            {
                Console.WriteLine($" Nome: {item.Nome} ");
            }






        }
    }
}
