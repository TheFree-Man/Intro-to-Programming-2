/*
 * Description: Programme that lets a user view player reports, 
 *              location analysis reports, and search for a player.
 *              
 * Author     : Mark Gilmartin
 * 
 * Date       : 23/03/2020
*/
using System;
using System.IO;

namespace Q1
{
    class Program
    {
        static string[] fields = new string[4];

        static void Main(string[] args)
        {
            int userChoice = Menu();

            while (userChoice != 4)
            {
                if (userChoice == 1)
                {
                    string[] scoreBand = { "0-9999", "10,000-19,999", "20,000-29,999", "30,000-39,999", "40,000 +" };
                    int[] numOfPlayerBand = new int[scoreBand.Length];
                    double average = PlayerScore(numOfPlayerBand);
                    PlayerScoreOutput(scoreBand, numOfPlayerBand, average);
                    Array.Clear(numOfPlayerBand, 0, numOfPlayerBand.Length);
                    userChoice = Menu();
                }
                else if (userChoice == 2)
                {
                    string[] Locations = { "Europe", "Asia", "North America", "South America", "Austrailia" };
                    int[] locationPlayerBand = new int[Locations.Length];
                    LocationReport(locationPlayerBand);
                    LocationReportOutput(Locations, locationPlayerBand);
                    userChoice = Menu();
                }
                else if (userChoice == 3)
                {
                    string[] locationBand = { "Europe", "Asia", "North America", "South America", "Australia" };
                    PlayerSearch(locationBand);
                    userChoice = Menu();
                }
            }
        }

        static int Menu()
        {
            bool validInput;
            int userChoice = 0;
            bool validValue = false;

            do
            {
                Console.WriteLine("\nMenu:\n");
                Console.WriteLine("1. Player Report");
                Console.WriteLine("2. Location Analysis Report");
                Console.WriteLine("3. Search for a player");
                Console.WriteLine("4. Exit");

                validInput = true;
            } while (!validInput);

            while (!validValue)
            {
                do
                {
                    Console.Write("\nEnter Choice: ");
                }
                while (!int.TryParse(Console.ReadLine(), out userChoice));

                if (userChoice < 1 || userChoice > 4)
                {
                    Console.WriteLine("\nInvalid value, Please try again");
                }
                else
                {
                    validValue = true;
                }
            }

            return userChoice;
        }

        static double PlayerScore(int[] numOfPlayerBand)
        {
            double average = 0;
            // Crash handling if the gamescores.txt file is not present
            try
            {
                FileStream fs = new FileStream(@"../../GameScores.txt", FileMode.Open, FileAccess.Read);
                StreamReader inputStream = new StreamReader(fs);
                string lineIn;
                lineIn = inputStream.ReadLine();
                int score;

                while (lineIn != null)
                {
                    fields = lineIn.Split(',');
                    score = int.Parse(fields[2]);
                    

                    /*switch (score)
                    {
                        case (score > 39999) :
                            numOfPlayerBand[4]++;
                            break;
                        case 2:
                            numOfPlayerBand[3]++;
                            break;
                        case 3:
                            numOfPlayerBand[2]++;
                            break;
                        case 4:
                            numOfPlayerBand[1]++;
                            break;
                        case 5:
                            numOfPlayerBand[0]++;
                            break;
                        default:
                            break;
                    }*/

                    if (score > 39999)
                    {
                        numOfPlayerBand[4]++;
                    }
                    else if (score > 29999)
                    {
                        numOfPlayerBand[3]++;
                    }
                    else if (score > 19999)
                    {
                        numOfPlayerBand[2]++;
                    }
                    else if (score > 9999)
                    {
                        numOfPlayerBand[1]++;
                    }
                    else if (score > 0)
                    {
                        numOfPlayerBand[0]++;
                    }
                    lineIn = inputStream.ReadLine();
                }

                inputStream.Close();
            }
            catch (Exception myError)
            {
                Console.WriteLine(myError);
            }

            // Crash handling if the gamescores.txt file is not present
            try
            {
                FileStream fs = new FileStream(@"../../GameScores.txt", FileMode.Open, FileAccess.Read);
                StreamReader inputStream = new StreamReader(fs);
                string lineIn;
                lineIn = inputStream.ReadLine();
                int score = 0, totalScore = 0, numOfScores = 0;

                // Calculates average player score
                while (lineIn != null)
                {
                    fields = lineIn.Split(',');
                    score = int.Parse(fields[2]);
                    totalScore += score;
                    numOfScores++;
                    lineIn = inputStream.ReadLine();
                }

                average = totalScore / numOfScores;
                inputStream.Close();
            }
            catch (Exception Error)
            {
                Console.WriteLine(Error);
            }

            return average;

        }

        static void PlayerScoreOutput(string[] scoreBand, int[] numOfPlayerBand, double average)
        {
            Console.WriteLine("\n{0,-15}{1,-20}{2,-10}", "Scores", "Number of Players", "Graph");
            string[] graph = new string[numOfPlayerBand.Length];

            for (int i = 0; i < graph.Length; i++)
            {
                for (int j = 0; j < numOfPlayerBand[i]; j++)   // Adds a hashtag for every player in that current index
                {
                    graph[i] += "#";
                }
            }

            for (int i = 0; i < scoreBand.Length; i++)
            {
                Console.WriteLine("{0,-15}{1,-20}{2,-10}", scoreBand[i], numOfPlayerBand[i], graph[i]);
            }

            int total = 0;
            for (int i = 0; i < numOfPlayerBand.Length; i++)
            {
                total += numOfPlayerBand[i];
            }

            Console.WriteLine("\nTotal Players: {0}", total);
            Console.WriteLine("\nAverage Score: {0:n0}", average);
        }

        static void LocationReport(int[] locationPlayerBand)
        {
            try
            {
                FileStream fs = new FileStream(@"../../GameScores.txt", FileMode.Open, FileAccess.Read);
                StreamReader inputStream = new StreamReader(fs);
                string lineIn;
                lineIn = inputStream.ReadLine();
                int locationBand;

                while (lineIn != null)
                {
                    fields = lineIn.Split(',');
                    locationBand = int.Parse(fields[3]);
                    switch (locationBand)
                    {
                        case 1:
                            locationPlayerBand[0]++;
                            break;
                        case 2:
                            locationPlayerBand[1]++;
                            break;
                        case 3:
                            locationPlayerBand[2]++;
                            break;
                        case 4:
                            locationPlayerBand[3]++;
                            break;
                        case 5:
                            locationPlayerBand[4]++;
                            break;
                        default:
                            break;
                    }
                    lineIn = inputStream.ReadLine();
                }

                inputStream.Close();
            }
            catch (Exception myError)
            {
                Console.WriteLine(myError);
            }
        }

        static void LocationReportOutput(string[] locations, int[] locationPlayerBand)
        {
            Console.WriteLine("{0,-20}{1,-15}", "Location", "Player Count");

            for (int i = 0; i < locationPlayerBand.Length; i++)
            {
                Console.WriteLine("{0,-20}{1,-15}", locations[i], locationPlayerBand[i]);
            }

            int total = 0;
            int max = locationPlayerBand[0];
            int maxIndex = 0;

            for (int i = 0; i < locationPlayerBand.Length; i++)
            {
                total += locationPlayerBand[i];
                if (locationPlayerBand[i] > max)
                {
                    maxIndex = i;
                }
            }

            Console.WriteLine("\nTotals: {0:n0}", total);
            Console.WriteLine("\nLocation with the most players: {0}", locations[maxIndex]);
        }

        static void PlayerSearch(string[] locations)
        {
            try
            {
                FileStream fs = new FileStream(@"../../GameScores.txt", FileMode.Open, FileAccess.Read);
                StreamReader inputStream = new StreamReader(fs);
                string lineIn;
                lineIn = inputStream.ReadLine();
                int index = 0;
                string playerName, player;

                Console.Write("\nEnter Player Name: ");
                playerName = Console.ReadLine().ToLower();

                while (lineIn != null)
                {
                    fields = lineIn.Split(',');
                    player = fields[1].ToLower();
                    if (playerName == player)
                    {
                        Console.WriteLine("\nLocation  : {0}", locations[index]);
                        break;
                    }
                    else
                    {
                        index++;
                        lineIn = inputStream.ReadLine();
                        if (lineIn == null)
                        {
                            Console.WriteLine("\nNo match found");
                            break;
                        }
                    }
                }

                inputStream.Close();
            }
            catch (Exception myError)
            {
                Console.WriteLine(myError);
            }
        }
    }
}
