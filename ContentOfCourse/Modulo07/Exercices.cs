// Armazenar e iterar em sequências de dados usando Matrizes e a instrução foreach em C#

/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
*/

// string[] fraudulentOrderIDs = {"A123", "B456", "C789"};

// Console.WriteLine($"Primeiro: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Segundo: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Terceiro: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";
// Console.WriteLine($"Primeiro reatribuido: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"Existem {fraudulentOrderIDs.Length} pedidos fradulentos em processamento");

// ----------------------------------------------------------------------------------------------------

// string[] names = {"Mateus", "Arthur", "Daniel"};
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// int[] inventory = {200, 450, 700, 175, 250};
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory) 
// {
//     sum += items;
//     bin ++;
//     Console.WriteLine($"Compartimento {bin} = {items} items (total atual: {sum})");
// }
// Console.WriteLine($"Nós temos {sum} items em nosso inventário.");

// ---------------------------------------- Desafio ------------------------------------------------------

// string[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

// foreach (string orderID in orderIDs)
// {
//     if (orderID.StartsWith("B"))
//     {
//         Console.WriteLine(orderID);
//     }
// }