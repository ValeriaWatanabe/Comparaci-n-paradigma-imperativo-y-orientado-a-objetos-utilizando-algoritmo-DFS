using System;
using System.Collections.Generic;

namespace DFS_Imperativo
{
    class Program
    {
        public class Grafo
        {
            int numV;//Cantidad de nodos que contiene el grafo
            List<int>[] adj;//Inicializacion de lista enlazada
            bool[] visitado;//Inicializacion de arreglo para saber si se ha visitado un nodo
            public Grafo(int V)//Constructor del Grafo
            {
                int numV = V;//Indica que el Grafo g tiene V nodos
                adj = new List<int>[V];//La lista enlazada contendra listas enlazadas
                visitado = new bool[V];//Arreglo de visita tendrá el largo de la cantidad de nodos 
                for (int i=0; i<V; i++)
                {
                    adj[i] = new List<int>();//Cada nodo tiene su propia lista enlazada (nodos relacionados a el)
                }
            }

            public void InsertarVertice(int v, int u)
            {
                adj[v].Add(u);//Se añade el nodo u a la lista enlazada de v
                //Al final cada lista guardara aquellos nodos enlazados 
            }

            public void DFS(int V)//Algoritmo de busqueda profunda 
            {
                visitado[V] = true;//Se marca que se ha visitado el nodo, de modo que no se vuelva a pasar por el
                List<int> aux = adj[V];//Se toma la lista del nodo V
                Console.Write(V + "->");//Imprime el numero del nodo 
                foreach (var n in aux)//se revisa cada nodo que aparece en la lista
                {
                    if(!visitado[n])//Si no esta marcado como visitado, se llama a la misma funcion para marcarlo
                    {
                        DFS(n);
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
            //Utiliza listas enlazadas para crear el grafo
            Grafo g = new Grafo(15);//Cantidad de nodos del grafo
            //Nodo origen, nodo destino
            g.InsertarVertice(0, 1);
            g.InsertarVertice(0, 2);
            g.InsertarVertice(0, 3);

            g.InsertarVertice(1, 0);
            g.InsertarVertice(1, 4);
            g.InsertarVertice(1, 5);
            g.InsertarVertice(1, 6);

            g.InsertarVertice(2, 0);
            g.InsertarVertice(2, 10);
            g.InsertarVertice(2, 11);

            g.InsertarVertice(3, 0);
            g.InsertarVertice(3, 7);

            g.InsertarVertice(4, 1);

            g.InsertarVertice(5, 1);
            g.InsertarVertice(5, 8);
            g.InsertarVertice(5, 9);

            g.InsertarVertice(6, 1);
            g.InsertarVertice(6, 9);

            g.InsertarVertice(7, 3);
            g.InsertarVertice(7, 12);

            g.InsertarVertice(8, 5);
            g.InsertarVertice(8, 13);

            g.InsertarVertice(9, 5);
            g.InsertarVertice(9, 13);

            g.InsertarVertice(10, 2);

            g.InsertarVertice(11, 14);
            g.InsertarVertice(11, 12);

            g.InsertarVertice(12, 7);
            g.InsertarVertice(12, 11);

            g.InsertarVertice(13, 8);
            g.InsertarVertice(13, 9);

            g.InsertarVertice(14, 11);

            //Llamada al metodo de busqueda profunda
            g.DFS(0);//El arbol iniciara desde el nodo indicado
        }
    }
}
