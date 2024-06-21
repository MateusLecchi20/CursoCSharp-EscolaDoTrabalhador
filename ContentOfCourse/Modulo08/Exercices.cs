// Criar código legível com convenções, espaço em branco e comentários em C#

// char opcaoDoUsuario;

// int placarDoJogo;

// float particulasPorMilhao;

// bool consumidoresProcessados;

// string primeiroNome = "Mateus";
// int itensComprados = 7;
// // int itensVendidos = 7;
// // Console.WriteLine($"{primeiroNome} vendeu {itensVendidos} itens.");
// Console.WriteLine($"{primeiroNome} comprou {itensComprados} itens.");

/*
Comentários para
conteúdo maior
dentro do código!
*/

/*
  O código a seguir cria cinco orderIDs aleatórios
  para testar o processo de detecção de fraudes.
  As OrderIDs consistem em uma letra de A até E, e 
  três digitos numéricos. Ex. A123.
*/

// Random random = new Random();
// string[] orderIDs = new string[5];
// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");
//     orderIDs[i] = prefix + suffix;
// }
// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// ---------------------------- Desafio -----------------------------------------

/*
  O código a seguir analisa a string em str
  e conta quantas vezes a letra 'o' aparece
  na frase, então imprime no console o resultado.
*/

// string originalMessage = "The quick brown fox jumps over the lazy dog.";

// char[] message = originalMessage.ToCharArray();
// Array.Reverse(message);

// int letterCount = 0;

// foreach (char letter in message)
// {
//     if (letter == 'o')
//     {
//         letterCount++;
//     }
// }
// string newMessage = new string(message);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

// ----------------------------- Usar Espaços em Branco ------------------------

// Example 1:
/*
Console
.
WriteLine
(
"Olá, mundo!"
)
;

// Example 2:
string primeiraPalavra="Olá";string ultimaPalavra="Mundo";Console.WriteLine(primeiraPalavra+", "+ultimaPalavra+"!");
*/

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3)) 
//     {
//         Console.WriteLine("Trio de dados iguais! +6 bonus ao total!");
//         total += 6;
//     } else 
//     {
//         Console.WriteLine("Dois dados iguais! +2 bonus ao total!");
//         total += 2;
//     }
// }