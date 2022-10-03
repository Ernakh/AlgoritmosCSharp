int[] vetor = new int[10] { 10, 7, 3, 4, 3, 6, 7, 2, 9, 1 };
            int aux = 0;

            //o vetor é percorrido com o uso de um laço auxiliar para a ordenação
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    //verifica se a valor atual é menor que o próximo valor
                    if (vetor[j + 1] < vetor[j])
                        {
                        //inverte-se o valor caso a condição acima seja verdadeira
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }

            //mostra o vetor ordenado
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("vetor[" + i + "] = " + vetor[i]);
            }
