namespace _08.SoftUniParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            List<string> vipGuests = new List<string>();
            List<string> normalGuests = new List<string>();
            while ((input = Console.ReadLine()) != "PARTY")
            {
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    normalGuests.Add(input);
                }
            }

            while ((input = Console.ReadLine()) != "END")
            {
                if (char.IsDigit(input[0]))
                {
                    if (vipGuests.Contains(input))
                    {
                        vipGuests.Remove(input);
                    }
                }
                else
                {
                    if (normalGuests.Contains(input))
                    {
                        normalGuests.Remove(input);
                    }
                }
            }

            Console.WriteLine(vipGuests.Count + normalGuests.Count);
            foreach (string guest in vipGuests)
            {
                Console.WriteLine(guest);
            }

            foreach (string guest in normalGuests)
            {
                Console.WriteLine(guest);
            }

        }
    }
}