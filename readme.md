# TRABAJO PRÁCTICO N° 2
## Programación 3 - TUP - UTN Rafaela - 2024

## ALUMNOS
 - Emanuel Pic
 - César Flores

## EJERCICIOS

### 1 Invertir un numero de N cifras
Realizar el código para obtener el nro invertido al seleccionado.
El ingreso por teclado deberá ser guardado en una variable de tipo string para luego convertirse en
Int32.
123456 -> 654321 987->789.

### 2 Realizar un programa para ingresar un numero y verificar si es un nro primo o no
Un Número Primo es un número que debe ser mayor que 1 y sólo se divide por 1 y por sí mismo. En
otras palabras, podemos decir que los números primos no se pueden dividir por otros números que
no sean él mismo y 1. Por ejemplo, 2, 3, 5, 7, 11, 13, 17, 19 y 23...., son los números primos.

### 3 Verificar si un número ingresado es el número de Armstrong
Un número de Armstrong es un número que es igual a la suma de la potencia de cada dígito por el
número total de dígitos. Por ejemplo, números como 0, 1, 153, 370, 371, 407, 1634, 8208, 9474 son
números de Armstrong.
371 es Armstrong si (3*3*3) + (7*7*7)+(1*1*1) = 371
8208 = (8*8*8*8) + (2*2*2*2)+(0*0*0*0)+(8*8*8*8)

### 4 Realice una calculadora con las para las operaciones indicadas.
Variables a utilizar:
 - string entrada;
 - int Nro1, Nro2;
Operaciones a realizar
 - Básicas + - * /
 - Factorial (con Do While)
 - Residuo.
 - Conversión a Binario
 
### 5 Crear un programa que lea una letra tecleada por el usuario y diga si se trata de una vocal, una cifra numérica o una consonante
Variables a utilizar:
 - string entrada;
 - char letra;

### 6 Al ejercicio anterior agregaremos las funciones de la librería MATH para las operaciones indicadas.
Variables a utilizar:
 - string entrada;
 - int Nro;
Operaciones a realizar.
 - Raíz cuadrada (Sqrt)
 - Potencia (Pow)
 - Coseno(Cos)
 - Seno(Sin)
 - Valor Absoluto (Abs)
 - Redondeo(Round)
 - Nro Maximo (Max)4
 - Nro Minimo (Min)

### 7 Ingresar la base y la altura de un triángulo rectángulo para calcular su hipotenusa y su área.
Variables a utilizar
 - double Base, Altura, Resultado;
 - string linea;

Formato de salida String.Format("{0:####.00}"
Salida
Hipotenusa =

### 8 Para una hamburguesería calcule el total del ticket
Calcule el consumo solicitando cantidad de hamburguesas, precio o -1 para el próximo paso, ingresar cantidad papas, precio o -1, ingresar cantidad de bebidas, precio o -1.
Variables a utilizar:
 - byte CantidadH,CantidadP, CantidadB;
 - doble precioH,precioP,precioB;
 - double Resultado;
 - string linea;
Salidas esperadas
 - Parte entera del total
 - String.Format("{0:####.00}", Resultado));
 - String.Format("{0:c}",Resultado)
 - String.Format("{0:g}", Resultado);
 - String.Format(" {0:F}", DateTime.Now);
 - String.Format(" {0:dddd}{0: dd/MM/yyy}", DateTime.Now);

En base a los siguientes links documente en el código lo que se realice en cada una de las salidas
https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
https://learn.microsoft.com/en-us/dotnet/standard/base-types/custom-numeric-format-strings
https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings

### 9 Funciones para números aleatorios y caracteres ASCII para las operaciones indicadas.
Variables a utilizar:
 - byte CantidadNro, c
 - int Nro
 - string entrada
 - Random ran = new Random(); // iniciar generador random
Operaciones
 - Generar los números random indicados. (ran.Next(100)) limita a 100
 - para cada nro random mostrar el caracter ASCII - Convert.ToString((char) valor.

### 10 Funciones de cadenas de Texto para las operaciones indicadas.
Variables a utilizar:
 - string SuNombre;
 - byte K;
Salidas esperadas:
 - LONGITUD->Length);
 - ESTÁ DENTRO ->Contains("texto")
 - REEMPLAZO VOCAL A->Replace("a", "b")
 - EN MINÚSCULAS->ToLower()
 - EN MAYÚSCULAS-> NOM.ToUpper()
 - REMOVER 4 LETRAS->NOM.Remove(3, 4)
 - EXTRAER 4 LETRAS->NOM.Substring(3, 4)
 - IZQUIERDA 4 LETRAS->Left(variable, 4)
 - DERECHA 4 LETRAS->Right(variable, 4)
 - Recorrer caracteres Desde la Izqueirda

Ejemplo para nombre Jose
 - J
 - Jo
 - Jos
 - Jose
 - Recorrer caracteres Desde la Derecha
Ejemplo para nombre Jose
 - e
 - se
 - ose
 - Jose