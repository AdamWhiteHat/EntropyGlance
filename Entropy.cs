using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntropyGlance
{
    public class DataEntropyUTF8
    {
        // Stores the number of times each symbol appears
        public SortedDictionary<byte, int> DistributionDict { get; private set; }
        // Stores the entropy for each character
        public SortedDictionary<byte, double> ProbabilityDict { get; private set; }

        public int DataSampleSize { get; private set; }
        public int UniqueSymbols { get { return DistributionDict.Count; } }

        public double AbsoluteEntropy { get; private set; }
        public double ShannonSpecificEntropy { get; private set; }
        public double NormalizedAbsoluteEntropy { get; private set; }
        public double NormalizedShannonSpecificEntropy { get; private set; }
        public double CompressionEntropy { get; private set; }

        public DataEntropyUTF8()
        {
            this.Clear();
        }

        public DataEntropyUTF8(FileInfo file)
            : this()
        {
            if (file.Exists)
            {
                CalculateCompressionEntropy(file);
                ExamineBytes(file);
                CalculateEntropy();
            }
        }

        public void Clear()
        {
            DataSampleSize = 0;
            AbsoluteEntropy = 0;
            CompressionEntropy = 0;
            ShannonSpecificEntropy = 0;
            NormalizedAbsoluteEntropy = 0;
            NormalizedShannonSpecificEntropy = 0;
            DistributionDict = new SortedDictionary<byte, int>();
            ProbabilityDict = new SortedDictionary<byte, double>();
        }

        private void ExamineBytes(FileInfo file)
        {
            byte[] bytes = File.ReadAllBytes(file.FullName);

            DataSampleSize = bytes.Length;

            foreach (byte bite in bytes)
            {
                if (!DistributionDict.ContainsKey(bite))
                {
                    DistributionDict.Add(bite, 1);
                    continue;
                }
                DistributionDict[bite]++;
            }

            foreach (KeyValuePair<byte, int> entry in DistributionDict)
            {
                // Probability = Freq of symbol / # symbols examined thus far
                ProbabilityDict.Add(
                    entry.Key,
                    (entry.Value / (double)DataSampleSize)
                );
            }
        }

        public static double ExamineChunk(byte[] chunk)
        {
            if (chunk.Length < 1 || chunk == null)
            {
                throw new ArgumentException();
            }

            int chunkSize = chunk.Length;
            Dictionary<byte, int> distribution = new Dictionary<byte, int>();

            foreach (byte bite in chunk)
            {
                if (!distribution.ContainsKey(bite))
                {
                    distribution.Add(bite, 1);
                    continue;
                }
                distribution[bite]++;
            }

            double value = 0;
            double result = 0;
            foreach (KeyValuePair<byte, int> entry in distribution)
            {
                value = (entry.Value / (double)chunkSize);
                result += (value * Math.Log(value, 2)) * -1;
            }

            distribution.Clear();
            distribution = null;

            return (result / Math.Log(byte.MaxValue + 1, 2));
        }

        private void CalculateEntropy()
        {
            foreach (KeyValuePair<byte, double> entry in ProbabilityDict)
            {
                // Entropy = probability * Log2(1/probability) : OveralEntropy += entry.Value * Math.Log((1 / entry.Value), 2);
                // Shannon (specific) entropy = -1*sum(probability * ln(probability))
                ShannonSpecificEntropy += ((entry.Value * Math.Log(entry.Value, 2)) * -1);
            }

            if (ShannonSpecificEntropy > 8)
            {
                ShannonSpecificEntropy = 8;
            }

            NormalizedShannonSpecificEntropy = ShannonSpecificEntropy / Math.Log(byte.MaxValue + 1, 2);
            AbsoluteEntropy = ShannonSpecificEntropy * DataSampleSize;
            NormalizedAbsoluteEntropy = AbsoluteEntropy / Math.Log(byte.MaxValue + 1, 2);
        }

        private void CalculateCompressionEntropy(FileInfo file)
        {
            string compressedFilename = Path.GetTempFileName();

            using (FileStream stream = new FileStream(compressedFilename, FileMode.Open))
            {
                using (GZipStream gzip = new GZipStream(stream, CompressionMode.Compress))
                {
                    gzip.Write(File.ReadAllBytes(file.FullName), 0, (int)file.Length);
                }
            }

            FileInfo compressedFI = new FileInfo(compressedFilename);

            double result = (double)compressedFI.Length / (double)file.Length;
            result = result * 100;

            if (result > 100)
            {
                result = 100;
            }

            compressedFI.Delete();
            compressedFI = null;

            CompressionEntropy = result;
        }

        public double GetSymbolDistribution(byte symbol)
        {
            return DistributionDict[symbol];
        }

        public double GetSymbolEntropy(byte symbol)
        {
            return ProbabilityDict[symbol];
        }
    }
}
