using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace busquedaBinarios
{
    class Vector
    {
        private int[] miVector;
        private static Random miRandom;
        public int comparaciones{ get; private set; }
        
        public Vector(int tam)
        {
            miVector = new int[tam];
        }

     
        public void llenarMiVector(int lim)
        {
            miRandom = new Random();
            for (int i = 0; i <= miVector.Length - 1; i++)
            {
                miVector[i] = miRandom.Next(0, lim - 1);
            }
        }

      
        public string mostrar()
        {
            string contenidoMiVector = "";
            for (int i = 0; i <= miVector.Length - 1; i++)
            {
                contenidoMiVector += miVector[i] + " ";
            }
            return contenidoMiVector;
        }

        public void ordenar()
        {
            Array.Sort(miVector);
        }

        
        public int busquedaBinaria(int num)
        {
            int limInferior = 0, limSuperior = miVector.Length - 1;
            int encontrado = -1, x = 0;

            while (limInferior <= limSuperior && encontrado == -1)
            {
                x = (limInferior + limSuperior) / 2;
                if (miVector[x] == num)
                {
                    encontrado = x;
                }
                if (miVector[x] < num)
                {
                    limInferior = x + 1;
                }
                else
                {
                    limSuperior = x - 1;
                }
            }
            return encontrado;
        }

    }
}
