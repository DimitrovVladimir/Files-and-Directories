namespace Index_of_Letters
{
    internal class LetterCounter
    {
        static void Main(string[] args)
        {
            var input = File.ReadAllText("input.txt").Where(a => (a >= 'A' && a <= 'Z') || (a >= 'a' && a <= 'z'));

            var letterOccurrence = new SortedDictionary<char, int>();

            foreach (var letter in input)
            {
                if (!letterOccurrence.ContainsKey(letter))
                {
                    letterOccurrence.Add(letter, 0);
                }
                letterOccurrence[letter]++;
            }
            foreach (var letterOcc in letterOccurrence)
            {
                var letter = letterOcc.Key;
                var occurences = letterOcc.Value;

                Console.WriteLine($"{letter} -> {occurences}");
            }
        }
    }
}