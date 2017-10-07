using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace EntropyGlance
{
	public static class FileHelper
	{
		public static IEnumerable<byte> GetBytes(FileInfo file)
		{
			using (FileStream fileStream = file.OpenRead())
			{
				using (StreamReader reader = new StreamReader(fileStream))
				{
					while (!reader.EndOfStream)
					{
						yield return (byte)reader.Read();
					}
				}
			}
			yield break;
		}

		public static IEnumerable<byte[]> GetByteChunks(FileInfo file, int chunkSize)
		{
			using (FileStream fileStream = file.OpenRead())
			{
				using (BinaryReader reader = new BinaryReader(fileStream))
				{
					byte[] chunk;

					chunk = reader.ReadBytes(chunkSize);
					while (chunk.Length > 0)
					{
						yield return chunk;						
						chunk = reader.ReadBytes(chunkSize);
					}
				}
			}
			yield break;
		}
	}
}
