using System;
using System.IO;
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
    public partial class MainForm : Form
    {
        public string Filename { get; set; }

        private string initialDirectory = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(Filename) && File.Exists(Filename))
            {
                FileInfo file = new FileInfo(Filename);
                initialDirectory = file.Directory.FullName;
                LoadFile(file);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.InitialDirectory = initialDirectory;
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    FileInfo file = new FileInfo(openDialog.FileName);
                    initialDirectory = file.Directory.FullName;
                    LoadFile(file);
                }
            }
        }

        public void LoadFile(FileInfo file)
        {
            progressBarCompression.Value = 0;
            progressBarEntropy.Value = 0;

            DataEntropyUTF8 entropy = new DataEntropyUTF8(file);

            tbShannonSpecific.Text = entropy.ShannonSpecificEntropy.ToString("###0.###");
            tbShannonNormalized.Text = entropy.NormalizedShannonSpecificEntropy.ToString("###0.###");
            tbAbsolute.Text = entropy.AbsoluteEntropy.ToString("###,###,###,##0.###");
            tbAbsoluteNormalized.Text = entropy.NormalizedAbsoluteEntropy.ToString("###,###,###,##0.###");
            tbCompression.Text = entropy.CompressionEntropy.ToString("##0.#");

            progressBarCompression.Value = (int)entropy.CompressionEntropy;
            progressBarEntropy.Value = (int)(entropy.ShannonSpecificEntropy * 100);
        }

    }
}
