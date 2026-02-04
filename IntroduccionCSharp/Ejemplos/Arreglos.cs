using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace IntroduccionCSharp.Ejemplos
{

    public class Arreglos
    {
        public int[] Numbers { get; set; }
        public int CurrentPosition { get; set; }
        public Arreglos(int tamaño)
        {
            Numbers = new int[tamaño];
            CurrentPosition = 0;
        }

        public void AddValue(int number)
        {   
            //Solo Agregar valores positivos
            Numbers[CurrentPosition] = number;
            CurrentPosition++;
        }    
        public void Print()
        {
            for (int i = 0; i < Numbers.Length; i++)
            {
                Console.WriteLine(i + " - " + Numbers[i]);
            }
        }
    }
}