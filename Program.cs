using System;

public class program
{
    public static void Main(string[] args)
    {
        int[] vet = new int[24] { 10, 8, 6, 4, 7, 3, 1, 2, 5, 9, 105, 63, 99, 88,36,43,27,25,106, 184,149,111,159,14 };
        int atual, prox;
        int inicioLista = 0,finalLista = vet.Length;

        while (true)
        {

            for (int i = inicioLista; i < finalLista - 2; i++)
            {

                if (vet[i] > vet[i + 1])
                {
                    atual = vet[i + 1];                    
                    prox = vet[i];
                    Console.WriteLine("->->->->->DIREITA->->->->");
                    Console.WriteLine(
                        "atual   prox\n" +
                        $" {atual}       {prox}\n" +
                        "-------------");
                    vet[i] = atual;
                    vet[i + 1] = prox;


                }

            }
            for (int i = finalLista -1; i > inicioLista; i--)
            {
                if (vet[i] < vet[i - 1])
                {
                    atual = vet[i - 1];                   
                    prox = vet[i ];
                    Console.WriteLine("<-<-<-<-<-ESQUERDA<-<-<-<-");
                    Console.WriteLine(
                        "atual   prox\n" +
                        $" {atual}       {prox}\n" +
                        "-------------");
                    vet[i - 1] = prox;
                    vet[i] = atual;


                }

            }

            inicioLista++;
            finalLista --;
            if(inicioLista == finalLista)
            {
                Console.Write("[ " + vet[0]);
                for(int i = 1; i < vet.Length; i++)
                {
                    Console.Write(", " + vet[i]);
                    
                }
                Console.Write(" ]");
                break;
            }
        }
    }
}