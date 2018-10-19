/*



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] {1,2,3};
            var b = new int[] {1,2};

            var itemsANoB = a.Where(c => !b.Contains(c)).ToList();
            var itemsANoB2 = a.Except(b).ToList();

            Console.WriteLine("Prueba con el metodo Contains()");

            foreach(var item in itemsANoB)
            {
                Console.WriteLine(item);
            }           

            Console.WriteLine("Prueba con el metodo Except()");
            
            foreach(var item in itemsANoB2)
            {
                Console.WriteLine(item);
            }
            
            Console.ReadLine();

            
        }
    }


/*namespace Ejercicio3
{
    class Program
    {
        public static IEnumerable<int> Pares(int from, int to)
        {
            if(to < from || from < 0)
            {
                throw new ArgumentException("Los argumentos no son correctos");
                
            }
            else
            {
                for (var i = from; i <= to; i++)
                {
                    if (i % 2 == 0) { yield return i; }
                }
            }
        }

        public static IEnumerable<int> MayoresDe10(int from, int to)
        {
            if (to < from || to <= 10 || from < 0)
            {
                throw new ArgumentException("Los argumentos no son correctos");
            }            
            else
            {
                if(from <= 10)
                {
                    for (var i = 11; i <= to; i++)
                    {
                        yield return i;
                    }
                }
                else
                {
                    for (var i = from; i <= to; i++)
                    {
                        yield return i;
                    }
                }
                
            }            
        }

        public static IEnumerable<int> MenoresDe10(int from, int to)
        {
            if (to < from || from >=10 || from < 0)
            {
                throw new ArgumentException("Los argumentos no son correctos");
            }
            else
            {
                if(to <= 10)
                {
                    for (var i = from; i <= to; i++)
                    {
                        yield return i;
                    }
                }
                else
                {
                    for (var i = from; i <= 10; i++)
                    {
                        yield return i;
                    }
                }
            }            
        }
        
        static void Main(string[] args)
        {
            try
            {
                var items = Pares(20,30);
                foreach (var item in items)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine("___________________");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


            try
            {
                var from = 5;
                var to = 15;
                var maxPares = Pares(from,to).Max();
                Console.WriteLine("El maximo de los numeros pares comprendidos entre {0} y {1} es {2}", 
                                    from, to, maxPares);
                var maxMax10 = MayoresDe10(5, 15).Max();
                Console.WriteLine("El maximo de los numeros mayores de 10 comprendidos entre {0} y {1} es {2}", 
                                    from, to, maxMax10);
                var maxMin10 = MenoresDe10(5, 15).Max();
                Console.WriteLine("El maximo de los numeros menores de 10 comprendidos entre {0} y {1} es {2}", 
                                    from, to, maxMin10);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            Console.ReadLine();
        }
    }
}*/
/*   
ejercicio4

 ﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio4
{
    class ejercicio_4
    {
        public int DevolverMax(List<int> list)
        {
            var num =
                    (from i in list select i).Max();

            return num;
        }

    }
}
}*/

/*﻿
 * EJercicio6
 * using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio6
{
    public delegate int DelgateOperacion(int x, int y);
    public delegate int DelegateLambda(int x, int y);
    class Exámen_2__ejercicio_6

    {
        public static int Operation(int num1, int num2, DelegateLambda Operation)
        {
            return Operation(num1, num2);
        }
    }
    class Metodos
    {
        #region Métodos
        public static int Suma(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Multiplicacion(int num1, int num2)
        {
            return num1 * num2;
        }
        #endregion
    }

     test
     * int num1 = 30;
    int num2 = 10;
    DelgateOperacion Operacion = new DelgateOperacion(Multiplicacion);
    var result_mult = Operacion(num1, num2);
    Console.WriteLine("El resultado de la multiplicacion es:{0}", result_mult);
            Operacion += Suma;
            var result_suma = Operacion(num1, num2);
    Console.WriteLine("El resultado de la suma es:{0}", result_suma);
            var result_lambda_suma = Ejercicio.Operation(num1, num2, (x, y) => { return x + y; });
    var result_lambda_mult = Ejercicio.Operation(num1, num2, (x, y) => { return x * y; });
    Console.WriteLine("El resultado de la suma es:{0}", result_lambda_suma);
            Console.WriteLine("El resultado de la multiplicacione es:{0}", result_lambda_mult);
            Console.ReadKey();*/

/*
