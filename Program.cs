
Console.WriteLine("Ingresar un numero a invertir");
string numeroString = Console.ReadLine();

int numero = 0;
string numeroResult = "";



bool esNumm = int.TryParse(numeroString, out numero);

if(esNumm && numero > 0){
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
    Console.WriteLine("1 - Sumar");
    Console.WriteLine("2 - Restar");
    Console.WriteLine("3 - Multiplicar");
    Console.WriteLine("4 - Dividir");
    Console.WriteLine("5 - Valor absoluto");
    Console.WriteLine("6 - Cuadrado");
    Console.WriteLine("7 - Raíz cuadrada");
    Console.WriteLine("8 - Seno");
    Console.WriteLine("9 - Coseno");
    Console.WriteLine("10 - Parte entera");
    Console.WriteLine("11 - Máximo entre dos números");
    Console.WriteLine("12 - Mínimo entre dos números");
    Console.Write("Seleccione una opción: ");

    bool esOpcion = int.TryParse(Console.ReadLine(), out int opcion);

    if (!esOpcion || opcion < 1 || opcion > 12) {
        Console.WriteLine("Opción no válida.");
        continue;
    }

    // operaciones que piden dos números
    if (opcion >= 1 && opcion <= 4 || opcion == 11 || opcion == 12) {
        Console.Write("Ingrese el primer número: ");
        bool esNum1 = double.TryParse(Console.ReadLine(), out double num1);

        Console.Write("Ingrese el segundo número: ");
        bool esNum2 = double.TryParse(Console.ReadLine(), out double num2);

        if (!esNum1 || !esNum2) {
            Console.WriteLine("Uno o ambos valores ingresados no son números válidos.");
        } else {
            if (opcion == 1) Console.WriteLine($"Resultado: {num1 + num2}");
            else if (opcion == 2) Console.WriteLine($"Resultado: {num1 - num2}");
            else if (opcion == 3) Console.WriteLine($"Resultado: {num1 * num2}");
            else if (opcion == 4) {
                if (num2 == 0) Console.WriteLine("No se puede dividir por cero.");
                else Console.WriteLine($"Resultado: {num1 / num2}");
            }
            else if (opcion == 11) Console.WriteLine($"Máximo: {Math.Max(num1, num2)}");
            else if (opcion == 12) Console.WriteLine($"Mínimo: {Math.Min(num1, num2)}");
        }
    }
    // operaciones que piden un solo número
    else {
        Console.Write("Ingrese un número: ");
        bool esNum = double.TryParse(Console.ReadLine(), out double num);

        if (!esNum) {
            Console.WriteLine("No es un número válido.");
        } else {
            if (opcion == 5) Console.WriteLine($"Valor absoluto: {Math.Abs(num)}");
            else if (opcion == 6) Console.WriteLine($"Cuadrado: {Math.Pow(num, 2)}");
            else if (opcion == 7) Console.WriteLine($"Raíz cuadrada: {Math.Sqrt(num)}");
            else if (opcion == 8) Console.WriteLine($"Seno: {Math.Sin(num)}");
            else if (opcion == 9) Console.WriteLine($"Coseno: {Math.Cos(num)}");
            else if (opcion == 10) Console.WriteLine($"Parte entera: {Math.Truncate(num)}");
        }
    }

    Console.Write("\n¿Desea realizar otro cálculo? (s/n): ");
    continuar = Console.ReadLine().ToLower() == "s";
}