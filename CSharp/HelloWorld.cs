using System;

namespace CSharpHelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            // coemtario HOLA
            Console.WriteLine("Hola, C#");
            /*
            Más de un comentario
            por líneas
            */

            string myString = "Esto es una cadena de texto";
            myString = "Modificado we";
            Console.WriteLine(myString);

            string separacion = "-------------";
            Console.WriteLine(separacion);

            int myInt = 9;
            myInt = myInt * 2;
            Console.WriteLine(myInt);
            Console.WriteLine(myInt - 1);
            Console.WriteLine(myInt);
            
            Console.WriteLine(separacion);

            float myFloat = 6.5f;
            Console.WriteLine(myFloat);

            double myFloatDouble = 6.5;
            Console.WriteLine(myFloatDouble);

            Console.WriteLine(separacion);
            Console.WriteLine(myFloatDouble + myFloat + myInt);

            dynamic MyDynamic = 10;
            MyDynamic = "Lenguaje dynamic";
            Console.WriteLine(MyDynamic);

            Console.WriteLine(separacion);
            var Automatic = "Com s'ha escrit això entre cometes, es detectarà una variable del tipus string";
            var Automatic2 = 3;
            var Automatic3 = 3.4f;
            Console.WriteLine(Automatic);
            Console.WriteLine(Automatic2);
            Console.WriteLine(Automatic3);

            Console.WriteLine(separacion);
            bool mybool = true;
            mybool = false;
            Console.WriteLine(mybool);

            Console.WriteLine(separacion);
            Console.WriteLine($"El valor entero es {myInt} y el valor de mi bool es {mybool}.");
        
            Console.WriteLine(separacion);
            const string MyConst = "Mi constante";
            Console.WriteLine(MyConst);

            //  Estructuras

            Console.WriteLine(separacion);
            var MyArray = new string[] {"Bryan", "Alvitres", "Brax"};
            Console.WriteLine(MyArray[0]);

            MyArray[2] = "swager_men"; 
            Console.WriteLine(MyArray[2]);

            var MyDictionary = new Dictionary<string, int>
            {
                {"Diego", 32},
                {"Pau", 19},
                {"LOL", 2}
            };

            Console.WriteLine(MyDictionary["Diego"]);

            Console.WriteLine(separacion);
            var MySet = new HashSet<string> {"Diego", "Marcelo", "dockerbuild", "Marcelo"};

            Console.WriteLine(separacion);
            var MyTupla = ("Diego", "Marcelo", "dockerbuild");
            Console.WriteLine(MyTupla);

            // Bucles

            Console.WriteLine(separacion);
            for (int index = 0; index < 10; index ++)
            {
                Console.WriteLine(index);
            }

            Console.WriteLine(separacion);
            foreach (var myitem in MyArray)
            {
                Console.WriteLine(myitem);
            }

            Console.WriteLine(separacion);
            foreach (var myitem in MyDictionary)
            {
                Console.WriteLine(myitem);
            }

            Console.WriteLine(separacion);
            foreach (var myitem in MySet)
            {
                Console.WriteLine(myitem);
            }

            // Flujos

            Console.WriteLine(separacion);
            myInt = 11;
            mybool = true;

            if (myInt == 11 && mybool == true)
            {
                Console.WriteLine("El valor es 11");
            }
            else if (myInt == 12 ||mybool == false)
            {
                Console.WriteLine("El valor es 12");
            }
            else
            {
                Console.WriteLine("El valor no es ni 11, ni 12");
            }

            // Funciones 

            Console.WriteLine(separacion);
            MyFunction();
            Console.WriteLine(MyFunctionReturn(5));

            // Clases
            Console.WriteLine(separacion);
            var myClass = new MyClass("Bryan");
            myClass.myName = "Diego";
            Console.WriteLine(myClass.myName);
        }

        // Funciones 
        static void MyFunction()
        {
            Console.WriteLine("Esta es mi funcion");
        }

        static int MyFunctionReturn(int param)
        {
            return 10 + param;
        }

        // Clases
        class MyClass
        {
            public string myName { get; set; }
            public MyClass(string myCurrentName)
            {
                this.myName = myCurrentName; 
            }
        }
    }
}