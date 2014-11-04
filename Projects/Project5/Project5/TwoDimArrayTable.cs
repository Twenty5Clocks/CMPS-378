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
    class TwoDimArrayTable
    {
        //prints the rows and sums of the rows of an array
        public void printArrayRows(int[,] array, uint r, uint c)
        {
            int rowTotal;
            for (int i = 0; i < r; i++)
            {
                rowTotal = 0;
                Console.Write("Row {0}     ", i);
                for (int j = 0; j < c; j++)
                {
                    rowTotal += array[i, j];
                    Console.Write("{0}\t", array[i, j]);
                }
                Console.Write("{0}", rowTotal);
                Console.WriteLine();
            }
        }//end printArrayRows

        //prints the totals for the columns of an array
        public void printColumnTotal(int[,] array, uint r, uint c)
        {
            int columnTotal;
            for (int j = 0; j < c; j++)
            {
                columnTotal = 0;
                for (int i = 0; i < r; i++)
                {
                    columnTotal += array[i, j];

                }
                Console.Write("{0}\t", columnTotal);
            }
        }//end printColumnTotal

        //returns the sum of all elements of an array
        public int arrayTotal(int[,] array)
        {
            int arrayTotal = 0;
            foreach (int digit in array)
            {
                arrayTotal += digit;
            }
            return arrayTotal;
        }//end arrayTotal
    }// class endTwoDimArrayTable
}// end namespace Project 5
