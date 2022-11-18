using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Appointments
{
    class Program
    {
        static void Main(string[] args)
        {
      
           
            // Appointsments instance
            Appoint appoint = new Appoint();
            char choice = '0';
            // main loop
            while (choice != '6')
            { 
                appoint.PrintHomeScreen();
                Console.WriteLine();
                Console.WriteLine("What would you like to do?:");
                Console.WriteLine("1 - Add an entry");
                Console.WriteLine("2 - Search for entries");
                Console.WriteLine("3 - Delete entries");
                Console.WriteLine("4 - Write To Journal");
                Console.WriteLine("5 - Read journal");
                Console.WriteLine("6 - End");
                choice = Console.ReadKey().KeyChar;
                Console.WriteLine(); 
                    {
                        string path = @"MyJournal.txt";
                        if (!File.Exists(path))
                        {
                            // Create a file to write to.
                            using (StreamWriter sw = File.CreateText(path))
                            {
                                sw.WriteLine("My Journal"); 
                            }	
                        }
                    }
                     // reaction to the choice
                switch (choice)
                {
                    case '1':
                        appoint.AddEntry();
                        break;
                    case '2':
                        appoint.SearchEntries();
                        break;
                    case '3':
                        appoint.DeleteEntries();
                        break;
                    case '4':    
                        
                        
                        break;
                    case '5':
                        using (StreamReader sr = new StreamReader(@"MyJournal.txt"))
                        {  
                            string s;
                            do
                            {
                                s = sr.ReadLine();
                                Console.WriteLine(s);
                            }while (s != null);
                        }
                          
                         break;
                    case '6':                         
                    Console.WriteLine(" To leave the program.");
                    break;

                    default:
                    Console.WriteLine("Error. Have you had your coffee yet? Press any key to choose another action.");
                    break;
                }
            
                    Console.WriteLine("Press any key to continue.");  
                    Console.ReadKey();
            }
        }
    }
}
          