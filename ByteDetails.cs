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
    }
}
