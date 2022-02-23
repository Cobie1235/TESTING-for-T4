namespace TEAM_BELA_PROBLEM
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Console.WriteLine("Please enter the number of hands with the value of the suit with a space in between, followed by the values of each hand, with one value per line");
            string[] input = Console.ReadLine().ToUpper().Split(" ");
            long hands = Int32.Parse(input[0]);
            char dom = input[1][0];
            int points = 0;
            for (int i = 0; i < (hands * 4); i++)
            {
                char[] card = Console.ReadLine().ToUpper().ToCharArray();
                char value = card[0];
                char suit = card[1];
                switch (value)
                {
                    case 'A':
                        points += 11;
                        break;
                    case 'K':
                        points += 4;
                        break;
                    case 'Q':
                        points += 3;
                        break;
                    case 'J':
                        if (suit == dom)
                        {
                            points += 20;
                        }
                        else
                        {
                            points += 2;
                        }
                        break;
                    case 'T':
                        points += 10;
                        break;
                    case '9':
                        if (suit == dom)
                        {
                            points += 14;
                        }
                        break;
                }
            }
            Console.WriteLine("The number of points in this game is " + points);
        }
    }
}
