namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            bool enterString = true;
            while (enterString)
            {
                Console.Write("Please Enter the Input String : ");
                string str = Console.ReadLine();
                Console.WriteLine();
                if (str != null && str != "")
                {
                    string reverseString = ReverseString(str);
                    Console.WriteLine($"Your Reverse String : {reverseString}\n");
                    enterString = IsStopLoop();
                }
                else
                {
                    enterString = IsStopLoop();
                } 
            }
        }

        //This Function use for Reverse the String 
        public static string ReverseString(string str) 
        {
            try 
            {
                string CompleteWord = "";
                string[] arrayOfstring = str.Split(" ");
                for (int i = 0; i < arrayOfstring.Length; i++)
                {
                    string reverseWord = "";
                    for (int j = 0; j < arrayOfstring[i].Length; j++)
                    {
                        reverseWord = arrayOfstring[i][j] + reverseWord;
                    }
                    CompleteWord += " " + reverseWord;
                }
                return CompleteWord;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //This Function use for End the Loop
        public static bool IsStopLoop() 
        {

            Console.Write("You Want to Stop (y/n) : ");
            string s = Console.ReadLine();
            if (s == "y" || s == "Y")
            {
                 
                Console.WriteLine("Ok Process was Stoped .......\n");
                //This is Option Beep Sound
                Console.Beep();
                return false;
            }
            else if (s == "n" || s == "N")
            {
                Console.WriteLine("Ok Process Is Continoue.........\n");
            }
            else
            {
                Console.WriteLine("Please Select only the (y/n).........\n");
            }
            return true;

        }
    }
}
