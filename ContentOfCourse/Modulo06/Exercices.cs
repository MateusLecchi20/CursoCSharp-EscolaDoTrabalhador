// Adicionar lógica de decisão ao código usando if-else

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Rolagem dos dados: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) {
//     if ((roll1 == roll2) && (roll2 == roll3)) {
//         Console.WriteLine("Trio de dados iguais! + 6 pontos ao total!");
//         total += 6;
//     }
//     else 
//     {
//         Console.WriteLine("Dados em dobro! + 2 pontos ao total!");
//         total += 2;
//     }
// }

// if (total >= 16) {
//     Console.WriteLine("Você ganhou um carro novo!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("Você ganhou um belo notebook!");
// }
// else if (total == 7) 
// {
//     Console.WriteLine("Você ganhou uma viagem com acompanhante!");
// }
// else 
// {
//     Console.WriteLine("Você ganhou um gatinho!");
// }

// -------------------------------------------------------------------------------

// string mensagem = "A raposa rápida pula sobre o cachorro.";
// bool resultado = mensagem.Contains("cachorro");
// Console.WriteLine(resultado);

// if (mensagem.Contains("raposa")) 
// {
//     Console.WriteLine("O que a raposa diz?");
// }

// ---------------------------------- Desafio ------------------------------------

// Random random = new Random();
// int periodoExpiracao = random.Next(12);
// int porcentDesconto = 0;

// if (periodoExpiracao == 0) 
// {
//     Console.WriteLine("Sua assnatura expirou!");
// } else if (periodoExpiracao == 1) {
//     Console.WriteLine("Sua assinatura expira dentro de 1 dia!");
//     porcentDesconto = 20;
// } else if (periodoExpiracao <= 5) {
//     Console.WriteLine($"Sua assinatura expira dentro de {periodoExpiracao} dias");
//     porcentDesconto = 10;
// } else if (periodoExpiracao <= 10) {
//     Console.WriteLine("Sua assinatura vai expirar em breve, renove agora!");
// }

// if (porcentDesconto > 10)
// {
//     Console.WriteLine($"Renove sua assinatura e ganhe um desconto de {porcentDesconto}%.");
// }