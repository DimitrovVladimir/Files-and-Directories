namespace Advertisement_Message
{
    internal class AdvertisementMessage
    {
        static void Main(string[] args)
        {
            var phrases = File.ReadAllLines("inputData/phrases.txt");
            var events = File.ReadAllLines("inputData/events.txt");
            var authors = File.ReadAllLines("inputData/authors.txt");
            var cities = File.ReadAllLines("inputData/cities.txt");

            var random = new Random();

            var count = int.Parse(Console.ReadLine());

            var ads = new List<string>();


            for (int i = 0; i < count; i++)
            {
                var phrase = PickRandomElementFromArray(phrases, random);
                var @event = PickRandomElementFromArray(events, random);
                var author = PickRandomElementFromArray(authors, random);
                var city = PickRandomElementFromArray(cities, random);

                ads.Add($"{phrase}{@event}{author}-{city}");

            }
            File.WriteAllLines("output.txt", ads);
        }
        private static string PickRandomElementFromArray(string[] arr, Random random)
        {
            var randomValidIndex = random.Next(0, arr.Length -1);
            var randomElement = arr[randomValidIndex];
            return randomElement;
        }
    }
}