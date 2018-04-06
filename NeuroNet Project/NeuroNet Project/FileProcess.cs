using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace FileProcessing
{
    public class fileProcess
    {
        public static float[] getData(string path, int j)
        {
            string[] FileName;
            double temp;
            FileName = Directory.GetFiles(path);
            float[] data = new float[FileName.Length];
            

            for (int X = 0; X < FileName.Length; X++)
            {
                StreamReader file =
                       new StreamReader(FileName[X]);
                var input = file.ReadToEnd();  // big string
                var lines_input = input.Split(new char[] { '\n' });           // big array
                temp = Convert.ToDouble(lines_input[j]);
                data[X] = (float)temp;
                file.Close();
            }
            return data;
        }

        public static int checkData(string path)
        {
            int check = 0;
            string[] FileName;
            
            FileName = Directory.GetFiles(path);
            float[] data = new float[FileName.Length];

            StreamReader file =
                   new StreamReader(FileName[0]);
            var input = file.ReadToEnd();  // big string
            var lines_input = input.Split(new char[] { '\n' });           // big array
            check = lines_input.Length;
            file.Close();

            for (int X = 0; X < FileName.Length; X++)
            {
                StreamReader file2 =
                       new StreamReader(FileName[X]);
                var input2 = file2.ReadToEnd();  // big string
                var lines_input2 = input2.Split(new char[] { '\n' });           // big array
                file2.Close();
                if(check != lines_input2.Length)
                {
                    check = -1;
                    break;
                }
            }

            return check;
        }

        public static int[] checkWeight(string path)
        {
            int[] check = new int[3];
            try
            { 
                string[] FileName;
                string tempW;
                FileName = Directory.GetFiles(path);
                tempW = Path.GetFileNameWithoutExtension(FileName[FileName.Length - 1]);
                var NCL = tempW.Split(new char[] { 'N', 'C', 'L' });
                check[0] = int.Parse(NCL[1]);
                check[1] = int.Parse(NCL[2]);
                check[2] = int.Parse(NCL[3]);
            }
            catch (Exception exx)
            {
                check[0] = -1;
                check[1] = -1;
                check[2] = -1;
            }
            return check;
        }
    }
}