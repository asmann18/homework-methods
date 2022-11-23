namespace Homework4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentences=Console.ReadLine();
            sentences =sentences.ToLower();
            string firstLetter;
            int i = 0;
            string[] words = sentences.Split();
            foreach (string item in words)
            {
              
                    firstLetter=Convert.ToString(item[0]);

                    firstLetter=firstLetter.ToUpper();             
                    string item1=item.Replace(item[0],Convert.ToChar(firstLetter));
                if (i != words.Length)
                {
                    words[i] = item1;

                }
                i++;
            }
                 Console.WriteLine(string.Join(" ",words));
        }
    }
}