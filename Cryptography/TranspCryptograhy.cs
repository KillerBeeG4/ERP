using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Cryptography
{
    internal class TranspCryptograhy : ICryptography
    {
        private int matriceLength = 4;

        public string crypt(string input)
        {
            int height = (input.Length / matriceLength) + 1;
            char[,] matrix = new char[matriceLength, height];

            for(int cIndex = 0; cIndex < input.Length; cIndex++)
            {
                matrix[cIndex % matriceLength, cIndex / matriceLength] = input[cIndex];
            }

            var finalStr = "";
            for(int i = 0; i < matriceLength; i++)
            {
                for(int j = 0; j < height; j++)
                {
                    try
                    {
                        finalStr += matrix[i, j];
                    }
                    catch(Exception e)
                    {
                        continue;
                    }
                }
            }

            return finalStr;
        }

        public string decrpyt(string input)
        {
            int matriceLength = input.Length / 3;
            int height = (input.Length / matriceLength) + 1;
            char[,] matrix = new char[matriceLength, height];

            int heighestCols = input.Length % matriceLength;
            var cIndex = 0;
            for(int i = 0; i < heighestCols; i++)
            {
                for(int j = 0; j < height; i++)
                {
                    matrix[i, j] = input[cIndex];
                    cIndex++;
                }
            }

            for(int i = heighestCols; i < matriceLength; i++)
            {
                for(int j = 0; j < height-1; j++)
                {
                    matrix[i, j] = input[cIndex];
                    cIndex++;
                }
            }

            var finalStr = "";
            for(int j = 0; j < height; j++)
            {
                for(int i = 0; i < matriceLength; i++)
                {
                    try
                    {
                        finalStr += matrix[i, j];
                    }
                    catch(Exception e)
                    {

                    }
                }
            }

            return finalStr;
        }
    }
}
