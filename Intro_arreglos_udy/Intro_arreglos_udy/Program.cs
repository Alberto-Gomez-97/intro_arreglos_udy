// Introduccion a los Arreglos

//char
char[] vocales = new char[5]; //new= crear instancias de ciertos tipos de datos
//vocales = null; //son tipo de referencia
vocales[0] = 'a';
vocales[1] = 'e';
vocales[2] = 'i';
vocales[3] = 'o';
vocales[4] = 'u';

var segundavocale = vocales[1]; //pedir una variable del arreglo
Console.WriteLine(segundavocale); //e

// foreach

foreach (var vocal in vocales) //igualas la variable vocal al arreglo vocales
{
    Console.WriteLine(vocal);
}

//arreglo de enteros

var primerosSeisNumeros = new int[] { 1, 2, 3, 4, 5, 6 }; //arreglo listo

foreach( var numero in primerosSeisNumeros)
{
    Console.Write($"{numero}");
}

/*Ejercicio numero mayor mostrar numero mayor de un arreglo y si no hay elementos mostrar null
 namespace Variables.Soluciones
{
    public class NumeroMayor
    {
        public int? DeterminarElNumeroMayor(int[] numeros)
        {
            int? resultado = 0;

            // Tu código debajo de esta línea
            if (numeros.Length == 0)
            {
                return null;
            }

            resultado = numeros[0];
            foreach (var numero in numeros)
            {
                if (numero > resultado)
                {
                    resultado = numero;
                }
            }

            return resultado;
        }
    }
}
 * */