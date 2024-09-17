Console.WriteLine("escreva uma frase");
string frase = Console.ReadLine();
VerificaLetraA(frase);

static void VerificaLetraA(string frase){
    int contador = 0;
    foreach (char c in frase.ToLower())
    {
        if (c == 'a'){
            contador++;
        }
    }
    if (contador > 0){
        Console.WriteLine($"A letra 'a' foi encontrada {contador} vezes.");
    }
    else{
        Console.WriteLine("A letra 'a' não foi encontrada.");
    }
}
