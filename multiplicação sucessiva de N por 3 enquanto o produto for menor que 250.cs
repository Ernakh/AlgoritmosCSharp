 /*
             Ler um número N qualquer menor ou igual a 50 e apresentar o valor obtido da 
            multiplicação sucessiva de N por 3 enquanto o produto for menor que 250 
            (N*3; N*3*3; N*3*3*3; etc).
             
             */

            int numero = int.Parse(Console.ReadLine());

            int aux = 0;

            while (numero < 250)
            {
                aux = numero;
                numero *= 3;
            }

            Console.WriteLine(aux);
