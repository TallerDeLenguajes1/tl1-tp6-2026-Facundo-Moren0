
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


//Ejercicio 2

bool continuar = true;

while (continuar) {
    Console.WriteLine("\n--- CALCULADORA ---");
    Console.WriteLine("(s) - Sumar");
    Console.WriteLine("(r) - Restar");
    Console.WriteLine("(m) - Multiplicar");
    Console.WriteLine("(d) - Dividir");
    Console.Write("Seleccione una opción: ");

    string opcion = Console.ReadLine().ToLower();

    if (opcion != "s" && opcion != "r" && opcion != "m" && opcion != "d") {
        Console.WriteLine("Opción no válida.");
        continue;
    }

    Console.Write("Ingrese el primer número: ");
    string entrada1 = Console.ReadLine();

    Console.Write("Ingrese el segundo número: ");
    string entrada2 = Console.ReadLine();

    bool esNum1 = double.TryParse(entrada1, out double num1);
    bool esNum2 = double.TryParse(entrada2, out double num2);

    if (!esNum1 || !esNum2) {
        Console.WriteLine("Uno o ambos valores ingresados no son números válidos.");
        continue;
    }

    double resultado = 0;

    if (opcion == "s") resultado = num1 + num2;
    else if (opcion == "r") resultado = num1 - num2;
    else if (opcion == "m") resultado = num1 * num2;
    else if (opcion == "d") {
        if (num2 == 0) {
            Console.WriteLine("No se puede dividir por cero.");
            continue;
        }
        resultado = num1 / num2;
    }

    Console.WriteLine($"Resultado: {resultado}");

    Console.Write("\n¿Desea realizar otro cálculo? (s/n): ");
    string respuesta = Console.ReadLine().ToLower();
    continuar = respuesta == "s";
}