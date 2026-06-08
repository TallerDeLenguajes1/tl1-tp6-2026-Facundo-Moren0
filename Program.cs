
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

// --- PARTE 1: operaciones con strings ---

Console.Write("Ingrese una cadena de texto: ");
string cadena = Console.ReadLine();

Console.WriteLine($"\nLongitud: {cadena.Length}");

Console.Write("Ingrese una segunda cadena para concatenar: ");
string cadena2 = Console.ReadLine();
Console.WriteLine($"Concatenación: {cadena + cadena2}");

Console.WriteLine($"Subcadena (desde índice 0, longitud 4): {cadena.Substring(0, Math.Min(4, cadena.Length))}");

Console.WriteLine("\nCaracteres uno por uno:");
foreach (char c in cadena) {
    Console.Write(c + " ");
}

Console.Write("\n\nIngrese una palabra a buscar: ");
string palabra = Console.ReadLine();
int indiceOcurrencia = cadena.IndexOf(palabra);
if (indiceOcurrencia >= 0) {
    Console.WriteLine($"'{palabra}' encontrada en el índice {indiceOcurrencia}.");
} else {
    Console.WriteLine($"'{palabra}' no encontrada en la cadena.");
}

Console.WriteLine($"Mayúsculas: {cadena.ToUpper()}");
Console.WriteLine($"Minúsculas: {cadena.ToLower()}");

Console.Write("\nIngrese una cadena separada por comas (ej: uno,dos,tres): ");
string cadenaSplit = Console.ReadLine();
string[] partes = cadenaSplit.Split(',');
Console.WriteLine("Resultados del split:");
foreach (string parte in partes) {
    Console.WriteLine($"  - {parte}");
}

// --- PARTE 2: calculadora con texto ---

Console.WriteLine("\n--- CALCULADORA CON TEXTO ---");
Console.Write("Ingrese el primer número: ");
bool esNum1 = double.TryParse(Console.ReadLine(), out double n1);
Console.Write("Ingrese el segundo número: ");
bool esNum2 = double.TryParse(Console.ReadLine(), out double n2);

if (!esNum1 || !esNum2) {
    Console.WriteLine("Uno o ambos valores no son números válidos.");
} else {
    double suma = n1 + n2;
    double resta = n1 - n2;
    double multi = n1 * n2;

    Console.WriteLine("la suma de " + n1.ToString() + " y de " + n2.ToString() + " es igual a: " + suma.ToString());
    Console.WriteLine("la resta de " + n1.ToString() + " y de " + n2.ToString() + " es igual a: " + resta.ToString());
    Console.WriteLine("la multiplicación de " + n1.ToString() + " y de " + n2.ToString() + " es igual a: " + multi.ToString());

    if (n2 == 0) {
        Console.WriteLine("No se puede dividir por cero.");
    } else {
        double division = n1 / n2;
        Console.WriteLine("la división de " + n1.ToString() + " y de " + n2.ToString() + " es igual a: " + division.ToString());
    }
}

// --- PARTE 3: parsear ecuación ---

Console.Write("\nIngrese una ecuación (ej: 582+2): ");
string ecuacion = Console.ReadLine();

char[] operadores = { '+', '-', '*', '/' };
char opEncontrado = ' ';
int idxOp = -1;

foreach (char op in operadores) {
    int idx = ecuacion.IndexOf(op);
    if (idx > 0) {
        opEncontrado = op;
        idxOp = idx;
        break;
    }
}

if (idxOp == -1) {
    Console.WriteLine("No se encontró un operador válido en la ecuación.");
} else {
    bool esParte1 = double.TryParse(ecuacion.Substring(0, idxOp), out double e1);
    bool esParte2 = double.TryParse(ecuacion.Substring(idxOp + 1), out double e2);

    if (!esParte1 || !esParte2) {
        Console.WriteLine("La ecuación no tiene un formato válido.");
    } else {
        double resEcuacion = 0;
        bool divPorCero = false;

        if (opEncontrado == '+') resEcuacion = e1 + e2;
        else if (opEncontrado == '-') resEcuacion = e1 - e2;
        else if (opEncontrado == '*') resEcuacion = e1 * e2;
        else if (opEncontrado == '/') {
            if (e2 == 0) divPorCero = true;
            else resEcuacion = e1 / e2;
        }

        if (divPorCero) Console.WriteLine("No se puede dividir por cero.");
        else Console.WriteLine($"Resultado de '{ecuacion}': {resEcuacion}");
    }
}