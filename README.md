## Preguntas sobre String en C#

### ¿String es un tipo por valor o un tipo por referencia?

String es un tipo por referencia. A diferencia de int, double o bool que se almacenan
directamente en la pila (stack), un string se almacena en el heap y la variable guarda
una referencia a esa ubicación de memoria. Sin embargo, se comporta de forma similar a
un tipo por valor porque es inmutable: cada vez que se modifica un string en realidad
se crea un nuevo objeto en memoria, no se modifica el original.

### ¿Qué secuencias de escape tiene el tipo string?

| Secuencia | Significado        |
|-----------|--------------------|
| \n        | Salto de línea     |
| \t        | Tabulación         |
| \r        | Retorno de carro   |
| \\        | Barra invertida    |
| \"        | Comilla doble      |
| \0        | Carácter nulo      |

### ¿Qué sucede cuando se utiliza el carácter @ y $ antes de una cadena de texto?

**@** indica un string literal verbatim. Las secuencias de escape dejan de interpretarse,
lo que significa que el string se toma exactamente como está escrito. Es útil para rutas
de archivos o strings multilínea:
```csharp
string ruta = @"C:\Users\Facundo\Desktop"; // sin @ habría que escribir C:\\Users\\Facundo\\Desktop
string multilinea = @"primera línea
segunda línea";
```

**$** indica un string interpolado. Permite insertar expresiones y variables directamente
dentro del string usando llaves {}, sin necesidad de concatenar con +:
```csharp
string nombre = "Facundo";
int edad = 21;
Console.WriteLine($"Me llamo {nombre} y tengo {edad} años");
```

Ambos se pueden combinar como **$@** para tener un string interpolado y verbatim al mismo tiempo.