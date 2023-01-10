using System;
using System.Globalization;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {

            Random slumpkort = new Random();

            

           
            string menyVal = "0";
            string senastevinnare = " ";
            while (menyVal != "4")
            {
                Console.WriteLine("Välkommen till blackjack");
                Console.WriteLine("Skriv in ett nummer från 1-4 nedan");
                Console.WriteLine("1. Spela blackjack spelet");
                Console.WriteLine("2. Visa senaste vinnaren");
                Console.WriteLine("3. Visa spelets regler");
                Console.WriteLine("4. Avsluta programmet");
                Console.Write("Skriv här: ");


                menyVal = Console.ReadLine();
                switch (menyVal)
                {
                    case "1":
                        Console.Clear();

                        int datornsPoäng = 0;
                        int spelarensPoäng = 0;
                        string spelareKort = "";
                        Console.WriteLine("Välkommen till BlackJack, du och datorn kommer att få 2 slumpmässiga kort.");
                        datornsPoäng += slumpkort.Next(1, 11);
                        datornsPoäng += slumpkort.Next(1, 11);
                        spelarensPoäng += slumpkort.Next(1, 11);
                        spelarensPoäng += slumpkort.Next(1, 11);

                        while (spelareKort != "n" && spelarensPoäng <= 21)
                        {

                            Console.WriteLine("Datorns poäng är:" + " " + datornsPoäng);
                            Console.WriteLine("Dina poäng är:" + " " + spelarensPoäng);
                            Console.WriteLine("Vill du ta ett till kort? svara med y eller n.");
                            
                            spelareKort = Console.ReadLine();

                            switch (spelareKort)
                            {



                                case "y":
                                    int nyttkort = slumpkort.Next(1, 11);
                                    spelarensPoäng += nyttkort;
                                    Console.WriteLine("Du fick en:" + " " + nyttkort + ":a");
                                    Console.WriteLine("Du har nu: " + spelarensPoäng + " poäng");


                                    //Förlust över 21
                                    if (spelarensPoäng >= 22)
                                    {

                                        Console.WriteLine("Du har tyvärr förlorat\n");
                                        break;

                                    }

                                    
                                    break;

                                case "n":

                                    while (datornsPoäng < spelarensPoäng && datornsPoäng <18)
                                    {

                                        int datornyttkort = slumpkort.Next(1, 11);
                                        datornsPoäng += datornyttkort;
                                        Console.WriteLine("Datorn drog en" + " " + datornyttkort + ":a");
                                    }

                                    Console.WriteLine("Dina poäng är:" + " " + spelarensPoäng);
                                    Console.WriteLine("Datorns poäng är: " + " " + datornsPoäng);

                                    
                                    

                                    //Vinst och senaste vinnaren
                                    if (spelarensPoäng > datornsPoäng && spelarensPoäng <= 21)
                                    {
                                        Console.WriteLine("Grattis, du vann mot datorn");
                                        Console.WriteLine("Skriv in ditt namn nedan så syns du som den senaste vinnaren:");
                                        senastevinnare = Console.ReadLine();
                                    }

                                    //Lika
                                    if (spelarensPoäng == datornsPoäng)
                                    {
                                        Console.WriteLine("Ni fick samma poäng, tyvärr vann ingen");
                                    }

                                    if (datornsPoäng > 21)
                                    {
                                        Console.WriteLine("Grattis, du vann mot datorn");
                                        Console.WriteLine("Skriv in ditt namn nedan så syns du som den senaste vinnaren:\n");
                                        senastevinnare = Console.ReadLine();



                                    }

                                    //Förlust när datorn har mer dig men under 21
                                    if (datornsPoäng > spelarensPoäng && datornsPoäng < 22)
                                        Console.WriteLine("Du har tyvärr förlorat mot datorn \n");
                                    break;
    
                            }


                        }
                        break;



                    case "2":
                        Console.WriteLine("Den senaste vinnaren är:" + " " + senastevinnare);
                        break;


                    case "3":
                        Console.WriteLine("Spelets regler:");
                        Console.WriteLine("\nDu ska få max 21 poäng men inte över.");
                        Console.WriteLine("För att vinna måste du ha mer poäng än datorn men inte mer än 21.");
                        Console.WriteLine("När du startar spelet får du och datorn 2 kort var och du får sedan ta mer kort om du behöver.");
                        Console.WriteLine("Datorn kommer att dra tills den har mer kort än dig men om den har över 17 får den inte dra ett nytt kort.");
                        Console.WriteLine("När du har dragit alla dina kort komemr datorn att börja dra sina kort.\n");

                        break;


                    case "4":
                        Console.WriteLine("Tack för att du har spelat blackjack.");
                        break;

                        

                        
                }
            }

        }
    }
}
