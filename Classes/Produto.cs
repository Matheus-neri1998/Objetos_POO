namespace Objetos_POO.Classes
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto (){ // primeiro método construtor

        }

        public Produto(int code, string name, float price)
        {   // segundo método construtor e com atributos
            this.Codigo = code;
            this.Nome = name;
            this.Preco = price;
        }
        
        
    }
}