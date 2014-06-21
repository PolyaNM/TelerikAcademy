namespace _01.StringBuilderExtension
{
    using System;
    using System.Text;
    public static class Extension
    {
        public static StringBuilder SubString(this StringBuilder input, int index, int length)
        {
            //StringBuilder result = new StringBuilder();
            //for (int i = index; i < length + index; i++)
            //{
            //    result.Append(input[i]);
            //}
            //return result;

            if (input.Length - length >= 0)
            {
                input.Remove(0, index);
                input.Remove(length, input.Length - length);
                return input;
            }
            else
            {
                throw new ArgumentOutOfRangeException("The length of the substring must be less or equal to the lenght of the StringBuilder");
            }
        }
    }


    // TEST
    public static class TestExtension
    {
        static void Main()
        {
            var test = new StringBuilder();
            test.Append("Uncontrollable"); 
            Console.WriteLine(test.SubString(3, 3)); //ont
            

        }
    }
}
