//Stack_classe
//Zugehörig zum Stack-Projekt
//Manuel Weißböck
//4AHWII

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Stack_class
    {
        //Merkmale
        /// <summary>
        /// Ist der Stack (First in, last out)
        /// </summary>
        private int[] stack;

        /// <summary>
        /// Errorspeicher des Stacks
        /// </summary>
        private bool error = false;

        //Konstruktor

        /// <summary>
        /// Erstellt den Stack mit dem bestimmten Speicherplatz n.
        /// </summary>
        /// <param name="n"></param>
        public Stack_class(int n)
        {
            stack = new int[n];
        }

        //Eigenschaften

        /// <summary>
        /// Gibt den aktuellen Fehlerstatus zurück
        /// </summary>
        public bool Error
        {
            get
            {
                return error;
            }
        }

        /// <summary>
        /// Gibt die Anzahl der maximal möglichen Elemente aus
        /// </summary>
        public int MaxElements
        {
            get
            {
                return stack.Length;

            }
        }

        /// <summary>
        /// Gibt an, wie viele Stackelemente zurzeit im Stack abgelegt sind
        /// </summary>
        public int Size
        {
            get
            {
                int i = 0;
                while(stack[i] != 0)
                {
                    i++;
                }
                return i;
            }
        }

        /// <summary>
        /// Gibt an, ob der Stack leer ist
        /// </summary>
        public bool IsEmpty
        {
            get
            {
                if (stack[0] == 0) return true;
                return false;
            }
        }

        /// <summary>
        /// Gibt an, ob der Stack bereits voll ist
        /// </summary>
        public bool IsFull
        {
            get
            {
                if (stack[stack.Length-1] != 0) return true;
                return false;

            }
        }

        //Methoden

        /// <summary>
        /// Fügt element "oben" in den Stack ein. Setzt Fehlerflag, wenn der Stack bereits voll ist
        /// </summary>
        /// <param name="element"></param>
        public void Push(int element)
        {
            if(IsEmpty)
            {
                stack[0] = element;
                return;
            }
            if (IsFull)
            {
                error = true;
            }
            else{
                stack[Size] = element;
            }
        }

        /// <summary>
        /// Holt oberstes Element vom Stack und gibt dessen Inhalt zurück. Setzt Fehlerflag, wenn der Stack bereits leer ist
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            int stack_wert = 0;
            if (IsEmpty)
            {
                error = true;
            }
            else
            {
                stack_wert = stack[Size - 1];
                stack[2] = 0;
            }
            return stack_wert;
        }

        /// <summary>
        /// Gibt Inhalt des obersten Stackelements zurück. Belässt das Stackelement aber im Stack.Setzt das Fehlerflag, wenn der Stack bereits leer ist
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            int stack_wert = 0;
            if (IsEmpty)
            {
                error = true;
            }
            else
            {
                stack_wert = stack[Size-1];
            }
            return stack_wert;
        }

        /// <summary>
        /// Leert den Stack und löscht das Fehlerflag
        /// </summary>
        public void Clear()
        {
            Array.Clear(stack, 0, MaxElements);
            error = false;
        }

        //Orverrides

        /// <summary>
        /// Diese Funktion dient zum Testen der Stack-Klasse. Sie gibt den Inhalt des Stacks als Text zurück
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < stack.Length; i++)
            {
                if(stack[i] != 0)
                {
                    if (i != 0)
                    {
                        sb.Append(",");
                    }
                    sb.Append(stack[i]);
                }
            }
            sb.Append("]");

            return sb.ToString();
        }

        //Operatoren

        /// <summary>
        /// Führ die Push-Methode aus
        /// </summary>
        /// <param name="s"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static Stack_class operator +(Stack_class s, int n)
        {
            s.Push(n);

            return s;
        }



    }



}
