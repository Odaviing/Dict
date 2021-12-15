using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList Name = new ArrayList();
            //Name.Add(2.3);
            //Name.Add(55);
            //Name.Add("lol");
            //foreach (object a in Name)
            //{
            //    Console.WriteLine(a);
            //}

            //Queue<char> symbols = new Queue<char>();
            //symbols.Enqueue('a');
            //symbols.Enqueue('b');
            //symbols.Enqueue('c');
            ////Console.WriteLine(symbols.Dequeue());
            ////Console.WriteLine(symbols.Dequeue());
            ////Console.WriteLine(symbols.Dequeue());

            //Stack<char> symb_stack = new Stack<char>();

            //symb_stack.Push(symbols.Dequeue());
            //symb_stack.Push(symbols.Dequeue());
            //symb_stack.Push(symbols.Dequeue());
            //Console.WriteLine(symb_stack.Pop());
            //Console.WriteLine(symb_stack.Pop());
            //Console.WriteLine(symb_stack.Pop());

            ////foreach(char ch in symbols)
            ////{
            ////    Console.WriteLine(ch);
            ////}
            //Dictionary<string, ArrayList> some_strange_shit = new Dictionary<string, ArrayList>();
            //Queue<int> first = new Queue<int>();
            //first.Enqueue(1);
            //first.Enqueue(2);
            //Queue<int> second = new Queue<int>();
            //second.Enqueue(3);
            //second.Enqueue(4);
            //Queue<int> third = new Queue<int>();
            //third.Enqueue(5);
            //third.Enqueue(6);
            //Queue<int> fourth = new Queue<int>();
            //fourth.Enqueue(7);
            //fourth.Enqueue(8);
            //Queue<int> fifth = new Queue<int>();
            //fifth.Enqueue(9);
            //fifth.Enqueue(10);
            //ArrayList all = new ArrayList();
            //all.Add(first);
            //all.Add(second);
            //all.Add(third);
            //all.Add(fourth);
            //all.Add(fifth);
            //some_strange_shit.Add("kek", all);
            //foreach (ArrayList arr in some_strange_shit.Values)
            //{
            //    Console.WriteLine(arr);
            //}

            //char a = 'a';
            //Console.WriteLine(a - 1);
            //Console.WriteLine(a + 1);

            //Console.WriteLine("Your message");
            //string message = Console.ReadLine();
            //Dictionary<int, char> dict = new Dictionary<int, char>();
            //foreach(char ch in message)
            //{
            //    dict.Add(ch, ch);
            //}
            //Console.WriteLine("Your unicode message is:");
            //foreach(int i in dict.Keys)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Your message in unicode");
            //string uni_message = Console.ReadLine();
            //string[] mess = uni_message.Split(' ');
            //Console.WriteLine("Your message in unicode");
            //foreach (string s in mess)
            //{
            //    Console.Write((char)Convert.ToInt32(s));
            //}



            //Dictionary<char, string> binary = new Dictionary<char, string>();
            //binary.Add('a', "01000001");
            //binary.Add('b', "01000010");
            //binary.Add('c', "01000011");
            //binary.Add('d', "01000100");
            //binary.Add('e', "01000101");
            //binary.Add('f', "01000110");
            //binary.Add('g', "01000111");
            //binary.Add('h', "01001000");
            //binary.Add('i', "01001001");
            //binary.Add('j', "01001010");
            //binary.Add('k', "01001011");
            //binary.Add('l', "01001100");
            //binary.Add('m', "01001101");
            //binary.Add('n', "01001110");
            //binary.Add('o', "01001111");
            //binary.Add('p', "01010000");
            //binary.Add('q', "01010001");
            //binary.Add('r', "01010010");
            //binary.Add('s', "01010011");
            //binary.Add('t', "01010100");
            //binary.Add('u', "01010101");
            //binary.Add('v', "01010110");
            //binary.Add('w', "01010111");
            //binary.Add('x', "01011000");
            //binary.Add('y', "01011001");
            //binary.Add('z', "01011010");

            //Console.WriteLine("Enter");
            //string mes = Console.ReadLine();
            //foreach(char a in mes)
            //{
            //    Console.Write(binary[a] + " ");
            //}




            //Console.WriteLine("Enter array size");
            //int size = Int32.Parse(Console.ReadLine());
            //int[] array = new int[size];
            //for(int i = 0; i < size; i++)
            //{
            //    Console.WriteLine("Enter the element");
            //    array[i] = Int32.Parse(Console.ReadLine());
            //}
            //int temp;
            //for (int i = 0; i < size; i++)
            //{
            //    for (int j = 0; j < size - i - 1; j++)
            //    {
            //        if(array[j] == 0)
            //        {
            //            temp = array[j];
            //            array[j] = array[j + 1];
            //            array[j + 1] = temp;
            //        }
            //    }
            //}

            //for (int i = 0; i < size; i++)
            //{
            //    Console.Write(array[i] + " ");

            //}





            //Console.WriteLine("Enter your word");
            //string word = Console.ReadLine();
            //Console.WriteLine("Enter list of words");
            //string words = Console.ReadLine();
            //string[] arr = words.Split(' ');
            //List<string> list_of_words = new List<string>();
            //foreach (string str in arr)
            //{
            //    list_of_words.Add(str);
            //}

            //Console.WriteLine("List of anograms");
            //foreach (string str in Anograms(word, list_of_words))
            //{
            //    Console.WriteLine(str);
            //}
            Dictionary<string, string> morze = new Dictionary<string, string>();
            morze.Add("a", ". -   ");
            morze.Add("b", "- . . .   ");
            morze.Add("c", "- . - .   ");
            morze.Add("d", "- . .   ");
            morze.Add("e", ".   ");
            morze.Add("f", ". . - .   ");
            morze.Add("g", "- - .   ");
            morze.Add("h", ". . . .   ");
            morze.Add("i", ". .   ");
            morze.Add("j", ". - - -   ");
            morze.Add("k", "- . -   ");
            morze.Add("l", ". - . .   ");
            morze.Add("m", "- -   ");
            morze.Add("n", "- .   ");
            morze.Add("o", "- - -   ");
            morze.Add("p", ". - - .   ");
            morze.Add("q", "- - . -   ");
            morze.Add("r", "- . -   ");
            morze.Add("s", ". . .   ");
            morze.Add("t", "-   ");
            morze.Add("u", ". . -   ");
            morze.Add("v", ". . . -   ");
            morze.Add("w", ". - -   ");
            morze.Add("x", "- . . -   ");
            morze.Add("y", "- . - -   ");
            morze.Add("z", "- - . .   ");
            morze.Add(" ", "    ");


            Dictionary<char, string> time_units = new Dictionary<char, string>();
            time_units.Add('.', "11");
            time_units.Add('-', "111111");
            time_units.Add(' ', "00");



            Console.WriteLine("Enter your message");
            string message = Console.ReadLine().ToLower();




            string final_mess = "";
            foreach (char sub in message)
            {
             final_mess += morze[sub.ToString()];
            }
            final_mess = final_mess.Trim();
            Console.WriteLine(final_mess);


            string time_unit = "";
            foreach(char ch in final_mess)
            {
                time_unit += time_units[ch];
                
            }
        
            Console.WriteLine("Time-unit code");
            Console.WriteLine(time_unit);



        }


        //public static void morze_code(string your_message, Dictionary<string, string> dict)
        //{
        //    string pattern = @"([ ])";
        //    string[] sub_mess = Regex.Split(your_message, pattern);
        //    for (int i = 1; i < sub_mess.Length - 1; i++)
        //    {
        //        if (sub_mess[i] == " ")
        //        {
        //            if (sub_mess[i - 1] == "")
        //            {
        //                if (sub_mess[i + 1] == "")
        //                {
        //                    sub_mess[i] = "   ";
        //                }
        //            }

        //        }
        //    }


        //    for (int i = 0; i < sub_mess.Length; i++)
        //    {
        //        int count = 0;
        //        int check_space = String.Compare(sub_mess[i], " ");
        //        int check_empty = String.Compare(sub_mess[i], "");


        //        foreach (KeyValuePair<string, string> keyValue in dict)

        //        {


        //            if (sub_mess[i] == keyValue.Key || check_space == 0)
        //            {


        //                count++;



        //            }



        //        }

        //        if (check_empty != 0)
        //        {
        //            if (count == 0)
        //            {
        //                Console.WriteLine("Re-enter your symbol №" + (i + 1));
        //                sub_mess[i] = mess();
        //                i--;
        //            }
        //        }
        //    }


        //    foreach (string sub in sub_mess)
        //    {
        //        foreach (KeyValuePair<string, string> keyValue in dict)
        //        {
        //            if (sub == keyValue.Key)
        //            {
        //                Console.Write(keyValue.Value);


        //            }
        //        }

        //    }
        //    Console.WriteLine("");
        //}


        public static string mess()
        {
            string message = Console.ReadLine();
            bool emptyness = false;
            while (!emptyness)
            {
                if (message == "")
                {
                    Console.WriteLine("Enter your message");
                    message = Console.ReadLine();

                }
                else
                {
                    emptyness = true;
                }
            }
            return message;
        }
        static public List<string> Anograms(string word, List<string> words)
        {
            int counter, word_counter;
            List<string> anograms = new List<string>();
            foreach(string str in words)
            {
                
                word_counter = 0;
                foreach(char ch in str)
                {
                    if(!word.Contains(ch))
                    {
                        word_counter++;
                    }
                   
                }
                if(word_counter == 0)
                {
                    anograms.Add(str);
                }
            }
            return anograms;
        }
    }
}
