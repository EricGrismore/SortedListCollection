namespace SortedListCollection
{
    class Program
    {
        static void Main(string[] args)
        {

            SortedList<string, string> classItems = new SortedList<string, string>();


 
            classItems.Add("Class188", "Calculators");
            classItems.Add("Class190", "Paint");
            classItems.Add("Class147", "Markers");
            classItems.Add("Class155", "Paper");
            classItems.Add("Class126", "Basketballs");



            Console.WriteLine("The Items on call including locations are of the following:");


            foreach (KeyValuePair<string, string> bl in classItems)
            {
                Console.WriteLine($"Class = {bl.Key}  Item={bl.Value}");
            }
            Console.WriteLine("What item are you trying to get?");
            string item = Console.ReadLine();
            Console.WriteLine("What class is it in?");
            string classroom = Console.ReadLine();



            if (classItems.ContainsValue(item))
                Console.WriteLine($"{item} is one of the item on call.");
            else
            {

                if (classItems.ContainsKey(classroom))
                {
                    Console.WriteLine($"You can only visit 1 class from {classroom} ");
                    classItems.Remove(classroom);
                    classItems.Remove(item);
                    Console.WriteLine($"The item on call in {classroom} has been removed and {item} has been removed as well");
                }
                else
                {
                    classItems.Add(classroom, item);
                    Console.WriteLine("{item} {classroom} was added to your list");
                }
            }



            Console.WriteLine("The new items on call are of the following:");
            foreach (KeyValuePair<string, string> bl in classItems)
            {
                Console.WriteLine($"Class = {bl.Key}  Item={bl.Value}");
            }
        }
    }
}
