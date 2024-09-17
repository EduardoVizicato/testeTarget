static bool PertenceSequencia(int num = 0){
int a = 0;
int b = 1;

if(num == a || num == b){
    return true;
}

int proximo = a + b;

while(proximo <= num ){
    if(proximo == num){
        return true;
    }
    a = b;
    b = proximo;
    proximo = a + b;
}

return false;
}

Console.WriteLine("digite o numero para saber se ele pertence à sequência");
    int num = int.Parse(Console.ReadLine());

    if(PertenceSequencia(num)){
        Console.WriteLine($"o numero {num} pertence à sequência");
    }
    else{
        Console.WriteLine($"o numero {num} não pertence à sequência");
    }
