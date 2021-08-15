using System;

namespace DynamicArray
{
    public class DynamicNumberArray
    {

        int[] buffer;
        public DynamicNumberArray()
        {
            buffer = new int[5];
        }
        public DynamicNumberArray(int initialSize) { buffer = new int[initialSize]; }


        public int this[int index]
        {
            set
            {
                if (index >= buffer.Length)
                {
                    Array.Resize(ref buffer, index + 2);
                }
                buffer[index] = value;
            }
            get
            {
                return buffer[index];
            }

        }

        public class Program
        {
            static void Main()
            {
                try
                {
                    DynamicNumberArray _dynamic = new DynamicNumberArray();
                    Console.WriteLine("enter the index");
                    int n = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("enter the value for index");
                    var valueOfIndex = Convert.ToInt32(Console.ReadLine());
                    _dynamic[n] = valueOfIndex;
                    //_dynamic[0] = 10;
                    //_dynamic[1] = 20;
                    //_dynamic[2] = 30;
                    //_dynamic[3] = 40;
                    //_dynamic[4] = 50;
                    //_dynamic[5] = 60;

                    int value = _dynamic[n];
                    Console.WriteLine("The value of index" + " " + n + " " + "is" + " " + value);

                    Console.ReadKey();
                }
                catch(FormatException e)
                {
                    throw new FormatException("Please enter only in numbers" + e); 
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Please enter the correct value" + ex);
                    Console.ReadKey();
                }

            }
        }
    }
}
