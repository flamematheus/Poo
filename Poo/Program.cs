// POO--- Programação orientada a objetos

//classes --> molde(o que e um carro ?)

//objetos -->instancia de uma classe(intanciar - criar um objeto) - materialização  de uma classs 

//atributos -->caracteristicas  (cor , ano e modelo)

//metodos --> açoes  (freiar , acelerar )



// vareavel 
using Poo;
using System.Runtime.Intrinsics.X86;

//// instanciar
//Carro Carro1 = new Carro ();

//Carro1.Modelo = "Hb20";
//Carro1.Marca = "Hyndai";
//Carro1.Ano = 2026;

//Carro1.ExibirIformacoes();

//Carro Carro2 = new Carro();

//Carro2.Modelo = "Civic";
//Carro2.Marca = "Honda";
//Carro2.Ano = 2026;

//Carro2.ExibirIformacoes();

//Pedido NovoPedido = new Pedido();

//NovoPedido.Item = "hanburge";
//NovoPedido.Preço = 25.50;
//NovoPedido.NomeDoCiente = "Matheus";
//NovoPedido.Quantidade = 3
//    ;

//NovoPedido.ExibirDados();


////-----------------------------------------------------------POO
//// Classe Pedido
//// NomeDoCliente, Item, Quantidade, Preco
//// Objetos
//Pedido pedido1 = new Pedido();

////string item = "X-Burguer";
////pedido1.Item = "X-Burguer";

//Console.WriteLine("Digite o nome do item: ");
//pedido1.Item = Console.ReadLine();

//Console.WriteLine("Digite o nome do cliente: ");
//pedido1.NomeDoCiente = Console.ReadLine();

//Console.WriteLine("Digite a quantidade: ");
//pedido1.Quantidade = int.Parse(Console.ReadLine());

//Console.WriteLine("Digite o preco: ");
//pedido1.Preço = double.Parse(Console.ReadLine());


//Console.WriteLine(pedido1.Quantidade);
//Console.WriteLine(pedido1.Item);


//pessoa pessoa = new pessoa();

//Console.WriteLine("Digite o nome : ");
//pessoa.Nome = Console.ReadLine();


//Console.WriteLine("Digite sua idade : ");
//pessoa.Idade = int.Parse(Console.ReadLine());


//Retangulo Calculo = new Retangulo ();


//Console.WriteLine("Digite  a Altura : ");
//Calculo.Altura = double.Parse(Console.ReadLine());

//Console.WriteLine("Digite sua largura : ");
//Calculo.Largura = double.Parse(Console.ReadLine());



//Console.WriteLine($"Aria:{Calculo.CalcularArea()}");
//Console.WriteLine($"Aria:{Calculo.CalcularPerimetro()}");


//Lampada Estado = new Lampada();



//if (Estado.Ligado == true)
//{
//    Console.WriteLine($"A lâmpada está ligada.{Estado.Ligar()}");
//} else if (Estado.Ligado != true)
//{
//    Console.WriteLine($"A lâmpada está desligada.{Estado.Desligar()}");
//} else if (Estado.Ligado != false)
//{
//    Console.WriteLine($"A lâmpada está ligada.{Estado.Ligar()}");
//} else if (Estado.Ligado == false)
//{
//    Console.WriteLine($"A lâmpada está desligado.{Estado.Desligar()}");
//} else ;




//// --------------------------------->

//Calculadora calc = new Calculadora();

//int soma = calc.Somar(10, 5);
//calc.MostrarResultado(soma);

//calc.MostrarResultado(calc.Subtrair(10, 5));


//Conversor conv = new Conversor();

//double f = conv.CelsiusParaFahrenheit(25);
//Console.WriteLine($"25°C = {f}°F");

//if (conv.EstaQuente(35))
//{
//    Console.WriteLine("35°C: está quente!");
//}

//if (!conv.EstaQuente(18))
//{
//    Console.WriteLine("18°C: não está quente.");
//}

//Cofrinho cofre = new Cofrinho ("Ana");

//cofre.Guardar(50);
//cofre.Guardar(-10);
//cofre.Guardar(30);

//if (cofre.Retirar(100))
//    Console.WriteLine("Retirada feita!");
//else
//    Console.WriteLine("Saldo insuficiente.");

//if (cofre.Retirar(20))
//    Console.WriteLine("Retirada feita!");
//else
//    Console.WriteLine("Saldo insuficiente.");

//Console.WriteLine($"Saldo: R$ {cofre.Saldo:F2}");
//Console.WriteLine($"Faltam R$ {cofre.FaltaParaMeta(200):F2} para a meta.");