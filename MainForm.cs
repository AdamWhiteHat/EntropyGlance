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

        private FileInfo currentFile;
        private DataEntropyUTF8 currentEntropy;
        private string initialDirectory = "";

        public MainForm()
        {
            InitializeComponent();
            btnByteDetails.Enabled = false;
            btnFileDetails.Enabled = false;
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
            currentFile = file;
            tbFilePath.Text = file.FullName;
            btnByteDetails.Enabled = true;
            btnFileDetails.Enabled = true;

            progressBarCompression.Value = 0;
            progressBarEntropy.Value = 0;

            currentEntropy = new DataEntropyUTF8(file);

            tbShannonSpecific.Text = currentEntropy.ShannonSpecificEntropy.ToString("###0.###");
            tbShannonNormalized.Text = currentEntropy.NormalizedShannonSpecificEntropy.ToString("###0.###");
            tbCompression.Text = currentEntropy.CompressionEntropy.ToString("##0.#");

            progressBarCompression.Value = (int)currentEntropy.CompressionEntropy;
            progressBarEntropy.Value = (int)(currentEntropy.ShannonSpecificEntropy * 10);
        }

        private void btnByteDetails_Click(object sender, EventArgs e)
        {
            Int64 chunks = currentFile.Length / FileDetails.DefaultChunkLength;
            if (chunks < 20)
            {
                MessageBox.Show("Can't open graph--file size must be greater than 20 chunks.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            ByteDetails byteDetailsForm = new ByteDetails(currentEntropy);
            byteDetailsForm.ShowDialog();
        }

        private void btnFileDetails_Click(object sender, EventArgs e)
        {
            FileDetails fileDetailsForm = new FileDetails(currentFile);
            fileDetailsForm.ShowDialog();
        }
    }
}
