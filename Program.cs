using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab3_var11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Все функции и проверки при работе с текстом работают только для данного текста, для реального текста потребовалось бы предусматривать куда больше различных ситуаций.
            List<string> my_col = new List<string>();
            //наш текст
            string[] my_text = "Із заданого тексту видалити всі слова визначеної довжини, що починаються з приголосної літери. З кожного речення заданого тексту видалити підрядок найбільшої довжини, що починається та закінчується заданими літерами.".Replace(". ", ".+").Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
            //зубчастый массив, который нужен нам что б слова выделить из каждого предложения
            string[] myTest;
            while (true)
            {
                Console.WriteLine("Введите текст:");
                myTest = Console.ReadLine().Replace(". ", ".+").Split(new char[] { '+' }, StringSplitOptions.RemoveEmptyEntries);
                break;
            }
            string[][] my_text_jagged = new string[my_text.Length][];
            int given_length1 = 6;
            int given_length2 = 7;
            string list_of_consonants = "йцкнгшщзхфвпрлджчсмтьб";
            //заполняем коллекцию словами текста
            for (int i = 0; i < my_text.Length; i++)
            {
                my_text_jagged[i] = my_text[i].Split(new char[] { ' ' });
                my_col.AddRange(my_text_jagged[i]);
            }
            //проверяем слово
            for (int i = 0; i < my_col.Count; i++)
            {
                if (list_of_consonants.Contains(my_col[i][0].ToString().ToLower()) & (my_col[i].Length == given_length1 | my_col[i].Length == given_length2))
                    my_col.Remove(my_col[i]);
            }

            for (int i = 0; i < my_col.Count; i++)
            {
                Console.Write(my_col[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
