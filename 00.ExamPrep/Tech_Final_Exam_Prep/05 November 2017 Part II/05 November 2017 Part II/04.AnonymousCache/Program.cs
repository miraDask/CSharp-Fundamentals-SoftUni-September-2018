namespace _04.AnonymousCache
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Numerics;

    public class Data
    {
        public Data(string dataSet)
        {
            this.DataSet = dataSet;
            this.DataKeysAndSize = new Dictionary<string, int>();
            this.SumOfDataSizes = 0;
        }

        public string DataSet { get; set; }

        public Dictionary<string, int> DataKeysAndSize { get; set; }

        public BigInteger SumOfDataSizes { get; set; }

    }

    public class Program
    {
        public static void Main()
        {
            List<Data> data = new List<Data>();
            List<Data> cashe = new List<Data>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "thetinggoesskrra")
                {
                    break;
                }

                if (!input.Contains("->"))
                {
                    string dataSet = input;

                    if (!data.Any(d => d.DataSet == dataSet))
                    {
                        data.Add(new Data(dataSet));
                    }

                    if (cashe.Any(d => d.DataSet == dataSet))
                    {
                        Data locatedData = cashe.Find(d => d.DataSet == dataSet);
                        cashe.Remove(locatedData);
                        locatedData.SumOfDataSizes = GetSum(locatedData);
                        data.Add(locatedData);
                    }
                }
                else
                {
                    string[] dataInfo = input.Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries);

                    string dataKey = dataInfo[0];
                    int dataSize = int.Parse(dataInfo[1]);
                    string dataSet = dataInfo[2];

                    if (!data.Any(d => d.DataSet == dataSet))
                    {
                        if (!cashe.Any(d => d.DataSet == dataSet))
                        {
                            Data currentData = new Data(dataSet);
                            currentData.DataKeysAndSize.Add(dataKey, dataSize);
                            currentData.SumOfDataSizes = GetSum(currentData);
                            cashe.Add(currentData);

                        }
                        else
                        {
                            Data locatedData = cashe.Find(d => d.DataSet == dataSet);
                            cashe.Remove(locatedData);
                            locatedData.DataKeysAndSize.Add(dataKey, dataSize);
                            locatedData.SumOfDataSizes = GetSum(locatedData);
                            data.Add(locatedData);
                        }

                    }
                    else
                    {
                        Data currentData = data.Find(d => d.DataSet == dataSet);
                        currentData.DataKeysAndSize.Add(dataKey, dataSize);
                        currentData.SumOfDataSizes += dataSize;
                    }
                }
            }

            if (data.Count == 0)
            {
                return;
            }
            Data neededData = GetDataWithHighestSumSize(data);

            if (neededData.DataKeysAndSize.Count > 0)
            {
                Console.WriteLine($"Data Set: {neededData.DataSet}, Total Size: {neededData.SumOfDataSizes}");

                foreach (var item in neededData.DataKeysAndSize)
                {
                    Console.WriteLine($"$.{item.Key}");
                }
            }

        }

        private static Data GetDataWithHighestSumSize(List<Data> data)
        {
            Data neededData = data[0];

            foreach (var currentData in data)
            {
                if (currentData.SumOfDataSizes > neededData.SumOfDataSizes)
                {
                    neededData = currentData;
                }
            }

            return neededData;
        }

        private static BigInteger GetSum(Data locatedData)
        {
            BigInteger sum = 0;

            foreach (var kvp in locatedData.DataKeysAndSize)
            {
                sum += kvp.Value;
            }

            return sum;
        }
    }
}
