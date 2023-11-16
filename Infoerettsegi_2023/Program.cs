using System;

namespace Infoerettsegi_2023 // Note: actual namespace depends on the project name.
{
    public class Pixels
    {
        public int R { get; set; }
        public int G { get; set; }
        public int B { get; set; }


        public Pixels() { }
        public Pixels(int r, int g, int b)
        {
            this.R = r;
            this.G = g;
            this.B = b;
        }

       
    }
    internal class Program
    {
        private static Pixels[,] pixelArray = new Pixels[360, 640];
        private static int rowCount = 360;
        private static int columnCount = 640;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Task1();
            Task2();
            Task3();
            Task4();
            Task6();
            Console.ReadKey();
        }

        public static void Task6()
        {
            Console.WriteLine("6. feladat");

            int firstRow = 0;
            int lastRow = 0;

            int rowValue = 0;

            while (firstRow == 0)
            {
                if (hatar(rowValue, 10))
                {
                    firstRow = rowValue + 1;
                }

                rowValue++;
            }

            rowValue = rowCount - 1;

            while (lastRow == 0)
            {
                if (hatar(rowValue, 10))
                {
                    lastRow = rowValue + 1;
                }
                rowValue--;
            }
            Console.WriteLine("A felhő legfelső sora {0}", firstRow);
            Console.WriteLine("A felhő legalsó sora {0}", lastRow);
        }

        public static bool hatar(int rowValue, int differenceValue)
        {
            for (int i = 1; i < columnCount - 1; i++)
            {
                int pixelDifferencePlus = pixelArray[rowValue, i].B - pixelArray[rowValue, i + 1].B;
                int pixelDifferenceMinus = pixelArray[rowValue, i].B - pixelArray[rowValue, i - 1].B;

                if (Math.Abs(pixelDifferencePlus) > differenceValue)
                {
                    return true;
                }

                if (Math.Abs(pixelDifferenceMinus) > differenceValue)
                {
                    return true;
                }
            }
            return false;
        }

        public static void Task4()
        {
            Console.WriteLine("4. feladat: ");

            int currentDarkest = 255 * 3;

            for (int rowValue = 0; rowValue < rowCount; rowValue++)
            {
                for (int columnValue = 0; columnValue < columnCount; columnValue++)
                {
                    Pixels currentPixel = pixelArray[rowValue, columnValue];
                    int currentSum = currentPixel.R + currentPixel.G + currentPixel.B;


                    if (currentSum <= currentDarkest)
                    {
                        currentDarkest = currentSum;
                    }
                }
            }
            Console.WriteLine("A legsötétebb pontRGB összege: {0}", currentDarkest);

            List<Pixels> darkPixels = new List<Pixels>();
            for (int rowValue = 0; rowValue < rowCount; rowValue++)
            {
                for (int columnValue = 0; columnValue < columnCount; columnValue++)
                {
   
                    
                    Pixels currentPixel = pixelArray[rowValue, columnValue];
                    int currentSum = currentPixel.R + currentPixel.G + currentPixel.B;

                    if (currentSum == currentDarkest)
                    {
                        darkPixels.Add(currentPixel);

                        Console.WriteLine("RGB({0}, {1}, {2})", currentPixel.R, currentPixel.G, currentPixel.B);
                    }
                }
            }



        }

        public static void Task3()
        {
            Console.WriteLine("3. feladat: ");
            int lightPixelCount = 0;
            for (int rowValue = 0; rowValue < rowCount; rowValue++)
            {
                for (int columnValue = 0; columnValue < columnCount; columnValue++)
                {
                    Pixels currentPixel = pixelArray[rowValue, columnValue];

                    if (currentPixel.R + currentPixel.G + currentPixel.B > 600)
                    {
                        lightPixelCount++;
                    }
                }
            }
            Console.WriteLine("A világos képpontok száma: {0}", lightPixelCount);
        }

        public static void Task2()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine("Kérem egy képpont adatait!");
            Console.Write("Sor: ");
            int rowValue = int.Parse(Console.ReadLine());
            Console.Write("Oszlop: ");
            int columnValue = int.Parse(Console.ReadLine());

            Pixels pixelValue = pixelArray[rowValue, columnValue];

            Console.WriteLine("A képpont színe RGB({0}, {1}, {2})", pixelValue.R, pixelValue.G, pixelValue.B);
        }

        public static void Task1()
        {
            using (StreamReader openedFile = new StreamReader("kep.txt"))
            {
                int currentRow = 0;
                while (!openedFile.EndOfStream)
                {
                    string[] splitArray = openedFile.ReadLine().Split(" ");
                    int currentColumn = 0;

                    for (int i = 0; i < splitArray.Length; i++)
                    {
                        if (i % 3 == 2)
                        {
                            pixelArray[currentRow, currentColumn] = new Pixels(Convert.ToInt32(splitArray[i - 2]), Convert.ToInt32(splitArray[i - 1]), Convert.ToInt32(splitArray[i]));

                            currentColumn++;
                        }
                    }

                    currentRow++;
                    
                }
 
                
                

                

                
            
                
            }
            
        }
    }


}