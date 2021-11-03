using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework15T1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();

            // Метод начать последовательность

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("" + arithProgression.getNext());
            }
         
            // Метод начать с числа

            arithProgression.setStart(15);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("" + arithProgression.getNext());
            }
            
            arithProgression.reset();
           
            // Проверяем Сброс поля 
            Console.WriteLine();
            Console.WriteLine("{0}",arithProgression.start);

            Console.WriteLine();

            Console.ReadKey();


            /////////////////////////////////////////////////////////////////////////

            GeomProgression geomProgression = new GeomProgression();

            geomProgression.q = 2;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("" + geomProgression.getNext()*geomProgression.next);
            }

            // Метод начать с числа

            geomProgression.setStart(5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("" + geomProgression.getNext() * geomProgression.next);
            }

            geomProgression.reset();

            // Проверяем Сброс поля 
            Console.WriteLine();
            Console.WriteLine("{0}", geomProgression.start);

            Console.WriteLine();

            Console.ReadKey();

        }
    }


    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }


    public class ArithProgression : ISeries
    {

        public int start;
        public int next;
       



        public int getNext()
        {
            next += 1; 
            return next;
        }

        public void reset()
        {
            start = 0;
        }

        public void setStart(int x)
        {
            start = x;
            next = start;
        }
    }

    class GeomProgression : ISeries
    {
        public int start;
        public int next;
        public int q;


        public int getNext()
        {
            next += 1*q;
            return next;

        }

        public void reset()
        {
            start = 0;
        }

        public void setStart(int x)
        {
            start = x;
            next = start;
        }
    }
}
