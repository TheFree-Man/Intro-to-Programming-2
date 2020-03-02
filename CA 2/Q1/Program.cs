/*
 * Description : Takes as input a series of property values terminated with a value of -999. The program also
 *               keeps a count of property values input for each valuation band, determines the total amount 
 *               of tax payable for each valuation band, determines the average tax payable for each valuation
 *               band, shows the total count of all property values entered, and shows the total of all taxes payable.
 *               
 * Author      : Mark Gilmartin
 * 
 * Date        : 02/03/2020
*/

using System;

namespace Q1
{
    class Program
    {
        static double[] totalTaxBand = new double[7];
        static double[] TaxBands = new double[] {0.0018, 0.002, 0.0021, 0.0023, 0.003, 0.0033, 0.005};
        static string[] OutputTaxBands = new string[] { "0.18%", "0.20%", "0.21%", "0.23%", "0.30%", "0.33%", "0.50%" };
        static double[] TaxTotal = new double[7];
        static double[] averageTax = new double[7];

        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            double counter = 0;
            double band = 0.0018;
            string input;
            double propertyValue = 0;
            double taxPayable;
            do
            {
                try
                {
                    Console.Write("Please input property value: ");
                    input = Console.ReadLine();
                    if (input == "-999")        // sentinel value -999 breaks out of the loop
                    {
                        break;
                    }
                    taxPayable = CalculatedTax(propertyValue, band);
                    propertyValue = isDataValid(input);   // Validates the data entered
                    band = getTaxBand(propertyValue);   // Method that gets all the necessary values needed like what Band they got
                    counter++;
                    Console.WriteLine("\nThe tax due on {0} with a rate of {1}\n", propertyValue, band); // Prints out what tax they got for their mark
                }
                catch (Exception myError)
                {
                    Console.WriteLine(myError.Message);
                }
            } while (propertyValue != -999);

            doAverage(); // Calls Average Method

            Console.WriteLine("\n{0, -10}{1,-20}{2, -15}{3, -20}\n", "Valuation Band", "Number of Properties", "Total Tax Payable");        // Formatting Output to be a table
            for (int i = 0; i < totalTaxBand.Length; i++)
            {
                Console.WriteLine("{0, -10} {1, -20} {2,-15:c} {3, -20}", TaxBands[i], totalTaxBand[i], averageTax[i], TaxTotal[i]);  // Prints out value in the table
            }
        }

        static double isDataValid(string input)     // Method to validate the inputted data
        {
            if (input == "" || input == null)
            {
                throw new Exception("Data must not be Empty");
            }
            double propertyValue;
            propertyValue = double.Parse(input);   // Makes sure the input data is turned to a double
            if (propertyValue == -999)
            {
                return propertyValue;
            }
            else if ((propertyValue < 0))
            {
                throw new Exception("Data must be a positive number");
            }
            else
            {
                return propertyValue;
            }
        }

        static double CalculatedTax(double propertyValue, double band)
        {
            double calculatedTax;
            calculatedTax = propertyValue * band;
            return calculatedTax;
        }

        static void doAverage() // Method to calculate the average for each tax
        {
            for (int i = 0; i < totalTaxBand.Length; i++)
            {
                averageTax[i] = TaxTotal[i] / totalTaxBand[i];
            }
        }

        static double getTaxBand(double propertyValue)    // Method to get all necessary data needed
        {
            double taxBand = 0;
            if (propertyValue > 300000 && propertyValue <= 500000)
            {
                taxBand = TaxBands[6];
                totalTaxBand[6]++;
                TaxTotal[6] += propertyValue;
                return taxBand;
            }
            else if (propertyValue > 250000 && propertyValue <= 300000)
            {
                taxBand = TaxBands[5];
                totalTaxBand[5]++;
                TaxTotal[5] += propertyValue;
                return taxBand;
            }
            else if (propertyValue > 250000 && propertyValue <= 300000)
            {
                taxBand = TaxBands[4];
                totalTaxBand[4]++;
                TaxTotal[4] += propertyValue;
                return taxBand;
            }
            else if (propertyValue > 150000 && propertyValue <= 200000)
            {
                taxBand = TaxBands[3];
                totalTaxBand[3]++;
                TaxTotal[3] += propertyValue;
                return taxBand;
            }
            else if (propertyValue > 150000 && propertyValue <= 200000)
            {
                taxBand = TaxBands[2];
                totalTaxBand[2]++;
                TaxTotal[2] += propertyValue;
                return taxBand;
            }
            else if (propertyValue > 0 && propertyValue <= 100000)
            {
                taxBand = TaxBands[1];
                totalTaxBand[1]++;
                TaxTotal[1] += propertyValue;
                return taxBand;
            }
            else
            {
                taxBand = TaxBands[0];
                totalTaxBand[0]++;
                TaxTotal[0] += propertyValue;
                return taxBand;
            }
        }

    }
}
