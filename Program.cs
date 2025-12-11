using System.Diagnostics.Metrics;

namespace Passwortgenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             * Programmieren Sie einen eigenen Passwortgenerator.
Dieser soll am Anfang nach der Länge des Passworts fragen
und dann eine zufällige Kombination von Zeichen in dieser
Länge erstellen und dem Anwender ausgeben.

Hinweis:
--------
Hinweis zu einer möglichen Lösung:
Erstellen Sie einen Array mit allen Zeichen, welche Sie
benutzen wollen. Den Rest überlasse ich Ihrer Fantasie :)
            */

            bool checklaenge = true;
            bool check=false;
            int laenge = 0;
            


                static void ClearLastLines(int count)
            {
                int currentLine = Console.CursorTop;
                for (int i = 0; i < count; i++)
                {
                    Console.SetCursorPosition(0, currentLine - 1 - i);
                    Console.Write(new string(' ', Console.WindowWidth));
                }
                Console.SetCursorPosition(0, currentLine - count);
            }


            do
            {
                Console.Clear();
                Console.WriteLine("Geben sie die Länge des Passworts ein:");
               
                checklaenge = int.TryParse(Console.ReadLine(), out laenge);
                Console.WriteLine();

                if (checklaenge == false)
                {
                    Console.WriteLine("Geben Sie die Ziffern (0-9) ein!");
                    ClearLastLines(2);

                }
                else if (laenge <=0)
                {
                    checklaenge = false;
                    Console.WriteLine("Geben Sie die Ziffern (0-9) ein!");
                    ClearLastLines(2);

                }
                else
                {
                    string[] pass = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0","a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m",
"n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"};

                    Random rnd = new Random();
                    
                    Console.WriteLine($"Ihr zufällig generiertes Passwort ist {laenge} Zeichen lang:");
                    for (int i = 0; i < laenge; i++)
                        Console.Write(pass[rnd.Next(0, pass.Length)]);

                    
                    Console.WriteLine();
                    Console.ReadKey();
                    check= true;
                }
            }
            while (checklaenge == false||check==true);

           
            
        }
        
    }
}

