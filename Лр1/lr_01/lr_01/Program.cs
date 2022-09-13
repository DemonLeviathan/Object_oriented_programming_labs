﻿using System;
using System.Text;

namespace lr_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            bool BooleanVariable = true;
            Console.WriteLine($"Boolean Variable: {BooleanVariable}");

            byte ByteVariable = 13;
            Console.WriteLine($"ByteVariable: {ByteVariable}");

            sbyte SbyteVariable = -47;
            Console.WriteLine($"SbyteVariable: {SbyteVariable}");

            Console.Write("Enter Char variable: ");
            char CharVariable = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"Char variable: {CharVariable}");

            Console.Write("Enter Decimal variable: ");
            decimal DecimalVariable = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Decimal variable: {DecimalVariable}");

            double DoubleVariable = 74.256;
            Console.WriteLine($"Double variable: {DoubleVariable}");

            float FloatVariable = (float)DoubleVariable;
            Console.WriteLine($"Float variable: {FloatVariable}");

            short ShortVariable = 52;
            Console.WriteLine($"Short variable: {ShortVariable}");

            int IntVariable = ShortVariable;
            Console.WriteLine($"Int variable: {IntVariable}");

            long LongVariable = IntVariable;
            Console.WriteLine($"Long variable: {LongVariable}");

            Console.Write("Enter Uint variable: ");
            uint UintVariable = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine($"Uint variable: {UintVariable}");

            ulong UlongVariable = UintVariable;
            Console.WriteLine($"Ulong variable: {UlongVariable}");

            ushort UshortVariable = (ushort)UintVariable;
            Console.WriteLine($"Ushort variable: {UshortVariable}");

            int IntVariable2 = ByteVariable;
            Console.WriteLine($"Int variable 2: {IntVariable2}");

            int DoubleVariable2 = SbyteVariable;
            Console.WriteLine($"Double variable 2: {DoubleVariable2}");

            object BoxIntVariable = IntVariable;
            int UnboxIntVariable = (int)BoxIntVariable;

            object BoxBooleanVariable = BooleanVariable;
            bool UnboxBooleanVariable = (bool)BoxBooleanVariable;

            object BoxCharVariable = CharVariable;
            char UnboxCharVariable = (char)BoxCharVariable;

            object BoxFloatVariable = FloatVariable;
            float UnboxFloatVariable = (float)BoxFloatVariable;

            object BoxDoubleVariable = DoubleVariable;
            double UnboxDoubleVariable = (double)BoxDoubleVariable;

            var UnknowTypeVariable1 = 172;
            var UnknowTypeVariable2 = 'g';
            var UnknowTypeVariable3 = 15.7;
            Type type1 = UnknowTypeVariable1.GetType();
            Type type2 = UnknowTypeVariable2.GetType();
            Type type3 = UnknowTypeVariable3.GetType();
            Console.WriteLine("First variable type: {0}", type1);
            Console.WriteLine("Second variable type: {0}", type2);
            Console.WriteLine("Third variable type: {0}", type3);

            int? NullVariable = null;
            Console.WriteLine("Null variable: {0}", NullVariable);

            string StringVariable1 = "string";
            string StringVariable2 = "worlds";
            Console.WriteLine(String.Compare(StringVariable1, StringVariable2));

            string str1 = "the first word";
            string str2 = "the second word";
            string str3 = "the third word";

            string StringConcatenate1 = string.Concat(str1, str2);
            string StringConcatenate2 = StringConcatenate1 + " " + str3;
            Console.WriteLine("Concatenation: {0}", StringConcatenate2);

            string StringCopy = string.Copy(str2);
            Console.WriteLine("Copied string: {0}", StringCopy);
            string StringSubstring = StringConcatenate2.Substring(2, 9);
            Console.WriteLine($"Substring from consatenated string: {StringSubstring}");

            string[] words = StringConcatenate2.Split(' ');

            foreach (var word in words)
            {
                System.Console.WriteLine($"<{word}>");
            }

            str1 = str1.Insert(4, str2);
            Console.WriteLine("Insert string: {0}", str1);
            str3 = str3.Remove(4, 5);
            Console.WriteLine("Remove substring: {0}", str3);
            Console.WriteLine($"Inter: {str2} {str3}");

            string EmptyString = "";
            string NullString = null;

            String TestNullorEmpty(string EmptyString)
            {
                if (String.IsNullOrEmpty(EmptyString))
                    return "null or empty";
                else
                    return "not null or empty";
            }
            Console.WriteLine("Empty string is {0}", TestNullorEmpty(EmptyString));

            String Test2NullorEmpty(string NullString)
            {
                if (String.IsNullOrEmpty(NullString))
                    return "null or empty";
                else
                    return "not null or empty";
            }
            Console.WriteLine("Null string is {0}", Test2NullorEmpty(NullString));

            StringBuilder str4 = new StringBuilder("suotnago aiouirgh iughaio fgh srthsj");
            str4 = str4.Remove(8, 8);
            Console.WriteLine("After remove element: {0}", str4);
            str4 = str4.Append("Last");
            Console.WriteLine("Append: {0}", str4);

            int[,] array = { { 4, 0, 8 }, { 1, 7, 5 } };
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;

            Console.WriteLine("Matrix: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{array[i, j]} \t");
                }
                Console.WriteLine();
            }

            int[] OneArray = new int[5] { 3, 7, 9, 5, 0 };
            Console.WriteLine("Array: ");
            foreach (int i in OneArray)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine();
            Console.WriteLine($"Array length: { OneArray.Length}");

            Console.WriteLine("Enter number: ");
            int ChangeVariable = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter position of number: ");
            int Position = Convert.ToInt32(Console.ReadLine());
            OneArray[Position - 1] = ChangeVariable;
            Console.WriteLine("Array: ");
            foreach (int i in OneArray)
            {
                Console.Write(" {0} ", i);
            }
            Console.WriteLine();

            int[][] ArrayA = new int[3][];
            ArrayA[0] = new int[2];
            ArrayA[1] = new int[3];
            ArrayA[2] = new int[4];
            int counterX = -1, counterY = -1;
            foreach (int[] row in ArrayA) 
            {
                counterX++;
                foreach (int element in row)
                {
                    counterY++;
                    Console.Write($"Число {counterX} {counterY}: "); ArrayA[counterX][counterY] = int.Parse(Console.ReadLine());
                }

                counterY = -1;
                Console.WriteLine();
            }

            foreach (int[] row in ArrayA)
            {
                counterX++;
                foreach (int element in row)
                {
                    counterY++;
                    Console.Write($" {element} ");
                }

                counterY = -1;
                Console.WriteLine();
            }

                
        }
    }
}