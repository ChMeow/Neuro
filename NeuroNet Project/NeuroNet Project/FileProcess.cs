using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using NaturalSort;

namespace FileProcessing
{
    public class fileProcess
    {
        public static float[] getData(string path, int j)
        {
            List<string> FileName = new List<string>();
            double temp;
           
            FileName.AddRange(Directory.GetFiles(path));
            FileName.Sort(new NaturalStringComparer(false));
         
            float[] data = new float[FileName.Count];
            

            for (int X = 0; X < FileName.Count; X++)
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
                List<string> FileName = new List<string>();

                string tempW;
                FileName.AddRange(Directory.GetFiles(path));
                FileName.Sort(new NaturalStringComparer(false));
                tempW = Path.GetFileNameWithoutExtension(FileName[FileName.Count-1]);
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

        public static int[] checkWeightInfo(string path)
        {
            int L;
            int I;
            int N;
            int E;
            int[] check;
            try
            {
                List<string> FileName = new List<string>();

                string tempW;
                FileName.AddRange(Directory.GetFiles(path));
                FileName.Sort(new NaturalStringComparer(false));
                tempW = Path.GetFileNameWithoutExtension(FileName[FileName.Count - 1]);
                var NCL = tempW.Split(new char[] { 'N', 'C', 'L' });
                L = int.Parse(NCL[3]) + 2;

                int k = 0;
                string[] split;
                char[] tab = new char[3];
                tab[0] = Convert.ToChar("\t");
                tab[1] = Convert.ToChar("\r");
                tab[2] = Convert.ToChar("\n");

                string readText = File.ReadAllText(FileName[0]);
                split = readText.Split(tab);
                string[] split2 = new string[split.Length];
                for (int jj = 0; jj < split.Length; jj++)
                {
                    if (split[jj] != "")
                    {
                        split2[k] = split[jj];
                        k++;
                    }
                    else break;
                } I = k;

                k = 0;
                readText = File.ReadAllText(FileName[FileName.Count-1]);
                split = readText.Split(tab);
                string[] split3 = new string[split.Length];
                for (int jj = 0; jj < split.Length; jj++)
                {
                    if (split[jj] != "")
                    {
                        split2[k] = split[jj];
                        k++;
                    }
                    else break;
                }
                N = k;

                k = 0;
                readText = File.ReadAllText(FileName[FileName.Count - 1]);
                split = readText.Split(tab);
                string[] split4 = new string[split.Length];
                for (int jj = 0; jj < split.Length; jj++)
                {
                    if (split[jj] == "")
                    {
                        k++;
                    }
                }

                E = (k - 1) / 2;

                check = new int[L];
                check[0] = I;
                for (int j = 1; j < L - 1; j++) check[j] = N;
                check[L - 1] = E;
            }
            catch (Exception exx)
            {
                check = new int[1];
                check[0] = -1;
            }
            return check;
        }

        public static float error(float[] result, float[] expected)
        {
            float costx = 0;
            for (int i = 0; i < result.Length; i++) costx = ((result[i] - expected[i]) * (result[i] - expected[i])) + costx;
            costx = costx / (2 * result.Length);
            return costx;
        }

        public static float[] diff(float[] result, float[] expected)
        {
            float[] costx = new float[result.Length];
            for (int i = 0; i < result.Length; i++)
            costx[i] = -(result[i] - expected[i]);
            return costx;
        }

        public static void removeNull(string Path)
        {
                List<string> FileName = new List<string>();

                FileName.AddRange(Directory.GetFiles(Path));
                FileName.Sort(new NaturalStringComparer(false));

            
        }
    }
}