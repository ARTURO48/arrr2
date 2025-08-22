  // Declaración de variables
            int numero_1, numero_2, numero_3;
            int Opera_1, Opera_2, Opera_3;
            bool contraste_1, contraste_2, contraste_3;

            // Entrada de datos
            Console.Write("Ingresa el primer número (numero_1): ");
            numero_1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el segundo número (numero_2): ");
            numero_2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresa el tercer número (numero_3): ");
            numero_3 = Convert.ToInt32(Console.ReadLine());

            // Operaciones matemáticas
            Opera_1 = (numero_1 + numero_2) - numero_3;
            Opera_2 = numero_1 * numero_2 * numero_3;
            Opera_3 = numero_2 % numero_3; // residuo de la división

            // Operaciones lógicas
            contraste_1 = (numero_1 == numero_3);
            contraste_2 = (numero_1 > numero_2) && (numero_1 > numero_3);
            contraste_3 = contraste_1 && contraste_2;

            // Salida de resultados
            Console.WriteLine("\nResultados de las operaciones matemáticas:");
            Console.WriteLine("Opera_1 = " + Opera_1);
            Console.WriteLine("Opera_2 = " + Opera_2);
            Console.WriteLine("Opera_3 = " + Opera_3);

            Console.WriteLine("\nResultados de las operaciones lógicas:");
            Console.WriteLine("contraste_1 = " + contraste_1);
            Console.WriteLine("contraste_2 = " + contraste_2);
            Console.WriteLine("contraste_3 = " + contraste_3);
