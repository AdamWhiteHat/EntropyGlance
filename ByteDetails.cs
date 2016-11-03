using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntropyGlance
{
    public partial class ByteDetails : Form
    {
        private DataEntropyUTF8 currentEntropy;

        public ByteDetails(DataEntropyUTF8 entropy)
        {
            InitializeComponent();           

            currentEntropy = entropy;
        }

        private void ByteDetails_Shown(object sender, EventArgs e)
        {
            int counter = 1;
            
            List<Tuple<int, byte>> entryList = new List<Tuple<int, byte>>();
            foreach (KeyValuePair<byte, int> entry in currentEntropy.DistributionDict)
            {
                entryList.Add(new Tuple<int, byte>(entry.Value, entry.Key));
            }
            entryList.Sort();
            entryList.Reverse();

            foreach (Tuple<int, byte> tup in entryList)
            {
                /*
                 Rank
                 DecimalValue
                 HexValue
                 Symbol
                 Count
                 Probability
                 */

                int decVal = (int)tup.Item2;
                string hexVal = tup.Item2.ToString("X");
                string symb = Encoding.UTF8.GetString(new byte[] { tup.Item2 });
                int count = tup.Item1;
                string prob = currentEntropy.ProbabilityDict[tup.Item2].ToString("##0.######");

                dataGridView1.Rows.Add(counter, decVal, hexVal, symb, count, prob);

                counter++;
            }



        }
    }
}
