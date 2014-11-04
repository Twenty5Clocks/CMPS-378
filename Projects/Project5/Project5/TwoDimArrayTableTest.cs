/**********************place in your source code as first few lines**************************
* Name: Jeremy Driesler
* Class: CPMS 378,
* Assignment #: 5, Two Dimension Array 
* Date Due: 11-04-14
* Problem Description 
 * Working with 2 dimensional arrays for the first time
*  User inputs how many rows and columns to use for the array
*  The users than inputs the desired values for the array they just created
*  The program then prints out a table of the array with the total sum and sum of each row and column
*  Type	Variable	Description	
*Input:
        int rows,       // number of rows in array
            columns,    // number of columns in array
            array[,],   // value inputted by user to be placed in array			
*Output:
int 	    rowTotal,   // total value of the integers in the row
            columnTotal,// total value of the integers in the column
            arrayTotal, // total calue of all integers in array
******************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5
{
    class TwoDimArrayTableTest
    {
        static void Main(string[] args)
        {
            //declare variables
            TwoDimArrayTable twoTable = new TwoDimArrayTable();
            uint rows = 0;
            uint columns = 0;
            

            //ask for user input
            Console.WriteLine("How many rows would you like the array to have?");
            try
            {
                rows = Convert.ToUInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            
            Console.WriteLine("How many columns would you like the array to have?");
            
            try
            {
                columns = Convert.ToUInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }

            //create the array
            int[,] array = new int[rows, columns];


            Console.WriteLine("An array with dimensions ({0}, {1}) has been created.\n\n", rows, columns);

            Console.WriteLine("Please enter all values to be placed in the array:\n\n");
            // prompt user to input values for the array
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("enter a number for array position [{0}, {1}]", i, j);
                    try
                    {
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("{0} Exception caught.", e);
                    }
                }
            }
            Console.Write("\t ");
            //print the table header
            for (int i = 0; i < columns; i++)
            {
                Console.Write("C{0}\t", i);
            }
            Console.Write("Sum\n");

            //print the array and add the rows.
            twoTable.printArrayRows(array, rows, columns);


            //write the line under the array output
            Console.Write("\t  ");
            for (int j = 0; j <= columns; j++)
            {
                Console.Write("-------");
            }
            Console.Write("\n");

            //write the total of the array columns and total of all elements
            Console.Write("Sum\t  ");
            twoTable.printColumnTotal(array, rows, columns);
            
            
            //print total of all elements of the array
            Console.Write("{0}\n\n", twoTable.arrayTotal(array));

        }// end main method
    }//end class TwoDimArrayTableTest
}//end namespace Project5
