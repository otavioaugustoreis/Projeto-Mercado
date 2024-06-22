/* Um simples CRUD de Mercado,
 
 Ações: Adicionar no carrinho e comprar
 Catálogo: Produtos do Mercado
 */


using RevisaoObjetos.Entities;

Console.WriteLine(" Bem Vindo ao MercadoExpress \n\n O que você deseja comprar" +
    "\n 1. Alimentos " +
    "\n 2. Conservates" +
    "\n 3. Congelados" +
    "\n 4. Bebidas");


//No C# o console readLine é apenas para string, ou seja, se eu quiser que a variavel seja de outro tipo eu tenho que converter paara o tipo que eu quero
string input = Console.ReadLine();

int escolha = int.Parse(input);

Congelados c1 = new Congelados(1, "dale", new User());









