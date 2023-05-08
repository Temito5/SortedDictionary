using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> kontakti = new SortedDictionary<string, string>();
            string[] input = Console.ReadLine().Split().ToArray();

                while (input[0] != "END")
                {
                    switch (input[0])
                    {
                        case "A":
                            kontakti.Add(input[1], input[2]); break;

                        case "S":
                            if (kontakti.ContainsKey(input[1]))
                            {
                                string phone = kontakti[input[1]];
                                Console.WriteLine($"{input[1]} -> {phone}");
                            }
                            else
                            {
                                Console.WriteLine($"Contact {input[1]} does not exist.");
                            }
                            break;
                        case "ListAll":
                        Console.WriteLine($"В указателя има {kontakti.Count} записани.");
                                Console.WriteLine($"Списък по азбучен ред: ");
                            foreach (var item in kontakti)
                            {
                                Console.WriteLine($"{item.Key} -> {item.Value}");
                            }
                            break;

                        default:
                            break;
                    }
                    input = Console.ReadLine().Split().ToArray();
                }
                
            
        }
    }
}