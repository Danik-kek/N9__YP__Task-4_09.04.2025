namespace N9__YP__Task_4_09._04._2025
{
    internal class Program
    {
        static void Main()
        {
            string FilePath = "Karl.txt";

            if (!File.Exists(FilePath)) 
            {
                Console.WriteLine("file not found!");
                return;
            }

            string text = File.ReadAllText(FilePath);
            int count = 0;
            Console.WriteLine(text);


            foreach (char c in text)
            {
                if (c == 'а') count ++;
            }
            Console.WriteLine(count);
        }
    }
}
