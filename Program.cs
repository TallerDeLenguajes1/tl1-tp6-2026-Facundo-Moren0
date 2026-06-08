
Console.WriteLine("Ingresar un numero a invertir");
string numeroString = Console.ReadLine();

int numero = 0;
string numeroResult = "";



bool esNum = int.TryParse(numeroString, out numero);

if(esNum && numero > 0){
    while(numero != 0){
        numeroResult += (numero % 10);
        numero = (numero / 10);        
    }

    Console.Write($"El numero invertido es {numeroResult}");

}