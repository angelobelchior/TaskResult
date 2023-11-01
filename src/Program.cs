var task1 = CalcularValor(1);
var task2 = CalcularValor(2);
var task3 = CalcularValor(3);

await Task.WhenAll(task1, task2, task3);

Console.WriteLine($"Valor da tarefa 1: {task1.Result}");
Console.WriteLine($"Valor da tarefa 2: {task2.Result}");
Console.WriteLine($"Valor da tarefa 3: {task3.Result}");
return;

static async Task<int> CalcularValor(int numero)
{
    await Task.Delay(1000);
    return numero * 10;
}