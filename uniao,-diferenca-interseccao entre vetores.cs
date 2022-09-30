// Escreva um algoritmo que leia 2 vetores X[10] e Y[10]
            // e os escreva.Crie, a seguir, um vetor para cada uma das operações:
            //•	A união de X com Y
            //•	A diferença entre X e Y
            //•	A interseção entre X e Y
            //Escreva o vetor resultado de cada uma das operações.
            int[] x = new int[5] { 1,5,2,8,7};
            int[] y = new int[5] { 1,2,9,3,7};

            int[] uniao = new int[10];//Uniao entre X e Y:
                                     //todos os elementos de X, e todos os elementos de Y
                                     //que nao estao em X.
            int[] diferenca = new int[5];//Diferenca entre X e Y:
                                         //todos os elementos de X que não exista em Y;
            int[] interseccao = new int[5];//Interseccao entre X e Y:
                                           //apenas os elementos que apareçam nos dois vetores;

            //inicio união
            x.CopyTo(uniao,0);
            int aux = 5;

            for (int i = 0; i < y.Length; i++)
            {
                for (int j = 0; j < x.Length; j++)
                {
                    if (y[i] == x[j])
                    {
                        break;
                    }

                    if(j == (x.Length - 1))
                    {
                        uniao[aux] = y[i];
                        aux++;
                    }
                }
            }

            Console.WriteLine("União");

            for (int i = 0; i < aux; i++)
            {
                Console.WriteLine(uniao[i]);
            }

            //fim união

            Console.WriteLine("");
            Console.WriteLine("Diferença");
            //inicio diferença //todos os elementos de X que não exista em Y
            int aux2 = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        break;
                    }

                    if(j == (y.Length - 1))
                    {
                        diferenca[aux2] = x[i];
                        aux2++;
                    }
                }
            }

            for (int i = 0; i < aux2; i++)
            {
                Console.WriteLine(diferenca[i]);
            }

            //fim diferença

            //inicio intersecção //apenas os elementos que apareçam nos dois vetores

            Console.WriteLine("");
            Console.WriteLine("intersecção");
            
            int aux3 = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j])
                    {
                        interseccao[aux3] = x[i];
                        aux3++;
                        break;
                    }
                }
            }

            for (int i = 0; i < aux3; i++)
            {
                Console.WriteLine(interseccao[i]);
            }

            //fim intersecção
