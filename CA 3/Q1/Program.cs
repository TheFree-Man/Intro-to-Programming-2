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
                // Menu choice system
                if (userChoice == 1)
                {
                    string[] scoreBand = { "0-9999", "10,000-19,999", "20,000-29,999", "30,000-39,999", "40,000 +" };
                    int[] numOfPlayers = new int[scoreBand.Length];
                    double average = PlayerScore(numOfPlayers);
                    PlayerScoreOutput(scoreBand, numOfPlayers, average);
                    Array.Clear(numOfPlayers, 0, numOfPlayers.Length);
                    userChoice = Menu();
                }
                else if (userChoice == 2)
                {
                    string[] locations = { "Europe", "Asia", "North America", "South America", "Austrailia" };
                    int[] playerLocation = new int[locations.Length];
                    LocationReport(playerLocation);
                    LocationReportOutput(locations, playerLocation);
                    userChoice = Menu();
                }
                else if (userChoice == 3)
                {
                    string[] locations = { "Europe", "Asia", "North America", "South America", "Australia" };
                    PlayerSearch(locations);
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
                // To stop programme crashing if number outside of 1-4 is entered
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

        static double PlayerScore(int[] numOfPlayers)
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
                    // Increments Counter for every person in each score band
                    fields = lineIn.Split(',');
                    score = int.Parse(fields[2]);
                    
                    if (score > 39999)
                    {
                        numOfPlayers[4]++;
                    }
                    else if (score > 29999)
                    {
                        numOfPlayers[3]++;
                    }
                    else if (score > 19999)
                    {
                        numOfPlayers[2]++;
                    }
                    else if (score > 9999)
                    {
                        numOfPlayers[1]++;
                    }
                    else if (score > 0)
                    {
                        numOfPlayers[0]++;
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

        static void PlayerScoreOutput(string[] scoreBand, int[] numOfPlayers, double average)
        {
            Console.WriteLine("\n{0,-15}{1,-20}{2,-10}", "Scores", "Number of Players", "Graph");
            string[] graph = new string[numOfPlayers.Length];

            for (int i = 0; i < graph.Length; i++)
            {
                // Increments graph for every person in each band
                for (int j = 0; j < numOfPlayers[i]; j++)
                {
                    graph[i] += "#";
                }
            }

            // Outputs player score and total to a table
            for (int i = 0; i < scoreBand.Length; i++)
            {
                Console.WriteLine("{0,-15}{1,-20}{2,-10}", scoreBand[i], numOfPlayers[i], graph[i]);
            }

            int total = 0;
            for (int i = 0; i < numOfPlayers.Length; i++)
            {
                total += numOfPlayers[i];
            }

            Console.WriteLine("\nTotal Players: {0}", total);
            Console.WriteLine("\nAverage Score: {0:n0}", average);
        }

        static void LocationReport(int[] playerLocation)
        {
            try
            {
                // Crash handling if the gamescores.txt file is not present
                FileStream fs = new FileStream(@"../../GameScores.txt", FileMode.Open, FileAccess.Read);
                StreamReader inputStream = new StreamReader(fs);
                string lineIn;
                lineIn = inputStream.ReadLine();
                int locations;

                while (lineIn != null)
                {
                    fields = lineIn.Split(',');
                    locations = int.Parse(fields[3]);

                    // Increments Counter for every person in each location band
                    switch (locations)
                    {
                        case 1:
                            playerLocation[0]++;
                            break;
                        case 2:
                            playerLocation[1]++;
                            break;
                        case 3:
                            playerLocation[2]++;
                            break;
                        case 4:
                            playerLocation[3]++;
                            break;
                        case 5:
                            playerLocation[4]++;
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

        static void LocationReportOutput(string[] locations, int[] playerLocation)
        {

            //Outputs location report to a table
            Console.WriteLine("\n{0,-20}{1,-15}", "Location", "Player Count");

            for (int i = 0; i < playerLocation.Length; i++)
            {
                Console.WriteLine("{0,-20}{1,-15}", locations[i], playerLocation[i]);
            }

            int total = 0;
            int max = playerLocation[0];
            int maxIndex = 0;

            for (int i = 0; i < playerLocation.Length; i++)
            {
                total += playerLocation[i];
                if (playerLocation[i] > max)
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
                // Crash handling if the gamescores.txt file is not present
                FileStream fs = new FileStream(@"../../GameScores.txt", FileMode.Open, FileAccess.Read);
                StreamReader inputStream = new StreamReader(fs);
                string lineIn;
                lineIn = inputStream.ReadLine();
                int index = 0;
                string playerName, player;

                Console.Write("\nEnter Player Name: ");
                playerName = Console.ReadLine().ToLower();

                // Searches csv file for names matching one entered and outputs location
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
