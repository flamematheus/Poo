using Pilares_POO;

//Carro carro1 = new Carro("Hyundai","HB20");

//Console.WriteLine(carro1.Marca);
//Console.WriteLine(carro1.Modelo);

// metodos construtor  - obriga o objeto a ser criando de uma forma
// pilar da poo  
 
// evitar estado invalidas

//ContaBancaria conta1 = new ContaBancaria();

//conta1.Saldo = -500;


Livro livro1 = new Livro("Dom Casmurro", "Machado de Assis", 256);
Livro livro2 = new Livro("O Hobbit", "J. R. R. Tolkien", 336);

livro1.Exibir();
livro2.Exibir();


Viagem v1 = new Viagem("Salvador", 5, 200);
Viagem v2 = new Viagem("Gramado", 3, 350);

v1.Exibir();
v2.Exibir();