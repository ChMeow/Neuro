﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;
using NaturalSort;

namespace NeuroNet_Project
{
    public class Normalized
    {
        public static int norData(string inPath, string outPath, double lowerLimit, double upperLimit, double InMin, double InMax, double OutMin, double OutMax, bool cusNor)
        {
            int norStatus = 0;
            DialogResult dialogResult = MessageBox.Show("The original files will be moved to ..\\Original and min max will be saved in ..\\MinMax, proceed with INPUT data? ", "Normalize Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                calculateNor(inPath, lowerLimit, upperLimit, InMin, InMax, OutMin, OutMax, cusNor, norStatus);
            }

            norStatus = 1;
            DialogResult dialogResult2 = MessageBox.Show("The original files will be moved to ..\\Original and min max will be saved in ..\\MinMax, proceed with OUTPUT data? ", "Normalize Data", MessageBoxButtons.YesNo);
            if (dialogResult2 == DialogResult.Yes)
            {
                calculateNor(outPath, lowerLimit, upperLimit, InMin, InMax, OutMin, OutMax, cusNor, norStatus);
            }
            return norStatus;
        }

        public static int calculateNor(string inPath, double lowerLimit, double upperLimit, double InMin, double InMax, double OutMin, double OutMax, bool cusNor, int norStatus)
        {
            Directory.CreateDirectory(inPath + "\\MinMax");
            Directory.CreateDirectory(inPath + "\\Original");

            List<string> FileName = new List<string>();
            double maxValue;
            double minValue;
            string saveTo;
            FileName.AddRange(Directory.GetFiles(inPath));
            FileName.Sort(new NaturalStringComparer(false));

            float[] data = new float[FileName.Count];

            for (int X = 0; X < FileName.Count; X++)
            {
                StreamReader file =
                        new StreamReader(FileName[X]);
                var input = file.ReadToEnd();  // big string
                file.Close();
                double[] resultArray = Array.ConvertAll(input.Split('\n'), Double.Parse);

                // var lines_input = input.Split(new char[] { '\n' });           // big array

                saveTo = Path.GetFileName(FileName[X]);
                StreamWriter saveMinMax = new StreamWriter(inPath + "\\MinMax\\" + saveTo);

                maxValue = resultArray.Max();
                minValue = resultArray.Min();

                if (cusNor)
                {
                    if(norStatus == 0)
                    {
                        maxValue = InMax;
                        minValue = InMin;
                    }
                    else
                    {
                        maxValue = OutMax;
                        minValue = OutMin;
                    }
                }

                saveMinMax.WriteLine(lowerLimit);
                saveMinMax.WriteLine(upperLimit);
                saveMinMax.WriteLine(minValue);
                saveMinMax.WriteLine(maxValue);
                saveMinMax.Close();

                Directory.CreateDirectory(inPath + "\\MinMax");
                File.Move(FileName[X], inPath + "\\Original\\" + saveTo);
                int j = 0;
                StreamWriter saveResult = new StreamWriter(FileName[X]);
                for (j=0; j < resultArray.Length -1 ; j++)
                {
                    resultArray[j] = (upperLimit - lowerLimit) * (resultArray[j] - minValue) / (maxValue - minValue) + lowerLimit;  // x' = [(b-a)(x - min)/(max - min)] + a    for range [a,b]          
                    saveResult.WriteLine(resultArray[j]);
                }
                resultArray[j] = (upperLimit - lowerLimit) * (resultArray[j] - minValue) / (maxValue - minValue) + lowerLimit;
                saveResult.Write(resultArray[j]);
                saveResult.Close();
            }
            return 1;
        }

        //This part recalculates the normalized data into non-normalized data (original).
        public static float reverseNor(float normalizedData, float lowerLimit, float upperLimit, float minValue, float maxValue)
        {
            float reversedNor = 0;
            reversedNor = (((normalizedData - lowerLimit) * (maxValue - minValue )) / (upperLimit - lowerLimit)) + minValue;
            return reversedNor;
        }
    }
}
