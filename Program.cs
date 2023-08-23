int inicio = 1, fim = 5;

Console.WriteLine($"Soma dos pares entre {inicio} e {fim}: {SomaPares(inicio, fim)}.");
Console.WriteLine($"Soma dos pares entre {inicio} e {fim}: {SomaParesRecursiva(inicio, fim)}.");
Console.WriteLine($"Soma dos pares entre {inicio} e {fim}: {SomaIntervalo(inicio, fim, 0)}.");

int SomaPares(int primeiro, int ultimo)
{
    int soma = 0;

    for (int num = primeiro; num <= ultimo; num++)
        if (num % 2 == 0)
            soma += num;
    
    return soma;
}

int SomaParesRecursiva(int primeiro, int ultimo)
{
    if (primeiro > ultimo)
        return 0;

    return (primeiro % 2 == 0 ? primeiro : 0) + SomaParesRecursiva(primeiro + 1, ultimo);
}

int SomaIntervalo(int primeiro, int ultimo, int soma)
{
    if (primeiro > ultimo)
        return 0;
    
    return primeiro + SomaIntervalo(primeiro+1, ultimo);
}

