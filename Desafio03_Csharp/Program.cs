using Desafio03_Csharp.Model;
using System;

namespace Desafio03_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro meucarro = new Carro("Hyundai", "HB20", "33333", "Preto", true, 100, 0, 40000.0);
            Caminhao meucaminhao = new Caminhao("Scania", "R580", "25252", "Branco", true, 150, 0, 100000.0);
            Aviao meuaviao = new Aviao("AIRBUS", "A330 ", "55555", "Azul", true, 600, 0, 300000.0);

			while (true)
			{
				Console.WriteLine("Qual veículo você deseja acelerar?(Carro, Caminhão ou Avião)");
				String escolha1 = Console.ReadLine();
				Console.WriteLine("Quem você deseja abastecer?(Carro, Caminhão, Avião ou nenhum)");
				String escolha2 = Console.ReadLine();
				switch (escolha1)
				{
					case "Carro":
						meucarro.acelerar();
						break;
					case "Caminhão":
						meucaminhao.acelerar();
						break;
					case "Avião":
						meuaviao.acelerar();
						break;
				}
				switch (escolha2)
				{
					case "Carro":
						Console.WriteLine("Quanto deseja abastecer no carro?(resposta boolean)");
						int qtdAbastecerCarro = Convert.ToInt32(Console.ReadLine());
						meucarro.abastecer(qtdAbastecerCarro);
						break;
					case "Caminhão":
						Console.WriteLine("Quanto deseja abastecer no caminhão?(resposta boolean)");
						int qtdAbastecerCaminhao = Convert.ToInt32(Console.ReadLine());
						meucaminhao.abastecer(qtdAbastecerCaminhao);
						break;
					case "Avião":
						Console.WriteLine("Quanto deseja abastecer no avião?(resposta boolean)");
						int qtdAbastecerAviao = Convert.ToInt32(Console.ReadLine());
						meuaviao.abastecer(qtdAbastecerAviao);
						break;
					case "nenhum":
						break;
				}
				Console.WriteLine("___________________________________________________");
				Console.WriteLine("STATUS CARRO:");
				Console.WriteLine("Marca: " + meucarro.Marca);
				Console.WriteLine("Modelo: " + meucarro.Modelo);
				Console.WriteLine("Placa: " + meucarro.Placa);
				Console.WriteLine("Cor: " + meucarro.Cor);
				Console.WriteLine("Cor: " + meucarro.Preco);
				if (meucarro.isLigado == true)
				{
					Console.WriteLine("O veículo está ligado com velocidade de " + meucarro.Velocidade + "Km/h.");
				}
				else
				{
					Console.WriteLine("O veículo está desligado.");
				}
				Console.WriteLine("Está com " + meucarro.LitrosCombustivel + "/100 litros de combustível.");
				Console.WriteLine("___________________________________________________");
				Console.WriteLine("STATUS CAMINHÃO:");
				Console.WriteLine("Marca: " + meucaminhao.Marca);
				Console.WriteLine("Modelo: " + meucaminhao.Modelo);
				Console.WriteLine("Placa: " + meucaminhao.Placa);
				Console.WriteLine("Cor: " + meucaminhao.Cor);
				Console.WriteLine("Cor: " + meucaminhao.Preco);
				if (meucaminhao.isLigado == true)
				{
					Console.WriteLine("O veículo está ligado com velocidade de " + meucaminhao.Velocidade + "Km/h.");
				}
				else
				{
					Console.WriteLine("O veículo está desligado.");
				}
				Console.WriteLine("Está com " + meucaminhao.LitrosCombustivel + "/150 litros de combustível.");
				Console.WriteLine("___________________________________________________");
				Console.WriteLine("STATUS AVIÃO:");
				Console.WriteLine("Marca: " + meuaviao.Marca);
				Console.WriteLine("Modelo: " + meuaviao.Modelo);
				Console.WriteLine("Placa: " + meuaviao.Placa);
				Console.WriteLine("Cor: " + meuaviao.Cor);
				Console.WriteLine("Cor: " + meuaviao.Preco);
				if (meuaviao.isLigado == true)
				{
					Console.WriteLine("O veículo está ligado com velocidade de " + meuaviao.Velocidade + "Km/h.");
				}
				else
				{
					Console.WriteLine("O veículo está desligado.");
				}
				Console.WriteLine("Está com " + meuaviao.LitrosCombustivel + "/600 litros de combustível.");
				Console.WriteLine("___________________________________________________");
			}
		}
    }
}
