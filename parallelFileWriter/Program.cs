using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parallelFileWriter
{
    internal class Program
    {
        public class parallelFileWriter
        {
            public static void WriteDataParallel(string file1path, string file2path, string file3path)
            {
                int[] data = Enumerable.Range(1, 100).ToArray();

                Task task1 = Task.Run(() => WriteToFile(file1path, data.Take(34).ToArray()));
                //split data for first file(up to 33)

                Task task2 = Task.Run(() => WriteToFile(file2path, data.Skip(34).Take(33).ToArray()));
                //split data for second file (34 to 66)
                Task task3 = Task.Run(() => WriteToFile(file3path, data.Skip(67).ToArray()));
                // Remaining data for third file (67 to 100)

                Task.WaitAll(task1, task2, task3);

                Console.WriteLine("Data written to all three files parallelly!");

            }
            private static void WriteToFile(string filepath, int[] data)
            {
                using (StreamWriter writer = new StreamWriter(filepath))
                {
                    foreach (int num in data)
                    {
                        writer.WriteLine(num);
                    }
                }
            }
            static void Main(string[] args)
            {
                string file1path = "file1.txt";
                string file2path = "file2.txt";
                string file3path = "file3.txt";

                WriteDataParallel(file1path, file2path, file3path);
            }
        }
    }
}
