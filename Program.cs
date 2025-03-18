double milhas;

Console.Write("Entre com a medida (em milhas): ");
while (!double.TryParse(Console.ReadLine(), out milhas) || milhas < 0) 
{
    Console.Write("Caractere inválido! Digite um número (positivo) válido ): ");
}

milhas *= 1.609;

Console.WriteLine($"O valor em quilômetros é: {milhas}");
