namespace dio.Models // Cria o namespace dio.Models
{
    public class Pessoa // Cria a classe pessoa
    {
        public string nome { get; set; } // Define os atributos da classe com seus respectivos get e set
        public int idade { get; set; }
        public void apresentar() // Define os métodos da classe
        {
            Console.WriteLine($"Olá! Me chamo {nome} e tenho {idade} anos.");
        }

    }
}   