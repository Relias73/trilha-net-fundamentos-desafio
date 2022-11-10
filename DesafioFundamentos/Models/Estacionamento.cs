namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // DESAFIO CONCLUÍDO!!!
            // Solicita ao usuário que digite a placa do veículo a ser estacionado, adicionando a lista "veiculos"
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = "";
            placa = Console.ReadLine();
            veiculos.Add(placa.ToUpper());
            Console.WriteLine($"Quantidade de veículos cadastrados: {veiculos.Count}");
        }

        public void RemoverVeiculo()
        {
            // Pedir para o usuário digitar a placa e armazenar na variável placa
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = "";
            placa = Console.ReadLine();
                       
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                //Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // Realiza o cálculo da variável valorTotal: "precoInicial + precoPorHora * horas"                
                int horas = 0;
                horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0;
                valorTotal = precoInicial + precoPorHora * horas;
                
                // Remoção da placa digitada da lista de veículos
                veiculos.Remove(placa.ToUpper());
                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");

            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                // Exibição da lista de veículos estacionados
                Console.WriteLine("Os veículos estacionados são: ");
                for (int count = 0; count < veiculos.Count; count++)
                {
                    string texto = $" {count + 1}. {veiculos[count]}";
                    Console.WriteLine(texto);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
