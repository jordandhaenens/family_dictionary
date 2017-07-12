using System;
using System.Collections.Generic;

namespace family_dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> myFamily = new Dictionary<string, Dictionary<string, string>>();
            myFamily.Add("sister", new Dictionary<string, string>(){
                {"Name", "Krista"},
                {"Age", "29"}
            });
            myFamily.Add("brother", new Dictionary<string, string>(){
                {"Name", "Jet"},
                {"Age", "25"}
            });

            // Console.WriteLine(myFamily["sister"]["Name"]);
            foreach (KeyValuePair<string, Dictionary<string, string>> person in myFamily) {
                // myFamily[person.Key]["Name"] = Krista
                // person.Key = sibling type
                // myFamily[person.Key]["Age"] = sibling age
                // Krista is my sister and is 42 years old
                Console.WriteLine($"{myFamily[person.Key]["Name"]} is my {person.Key} and is {myFamily[person.Key]["Age"]}");
            }

        }
    }
}
