using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EntropyGlance
{
    public partial class FileDetails : Form
    {
        public static int DefaultChunkLength = 1024;

        private int chunkLength;
        private FileInfo fileInfo;

        public FileDetails(FileInfo file)
        {
            InitializeComponent();
            fileInfo = file;

            chart1.Series[0].XValueType = ChartValueType.Int32; //## HERE, ##
            chart1.Series[0].YValueType = ChartValueType.Int32;
        }

        private void FileDetails_Shown(object sender, EventArgs e)
        {
            List<int> dataPoints = GenerateDataPoints(fileInfo);

            PlotDataPoints(dataPoints);
        }

        public void PlotDataPoints(List<int> points)
        {
            int counter = 0;
            foreach(int point in points)
            {
                chart1.Series[0].Points.AddXY(counter++, point);
            }
        }
                
        public List<int> GenerateDataPoints(FileInfo file)
        {
            chunkLength = DefaultChunkLength;
            Int64 chunks = file.Length / chunkLength;

            if (chunks < 20)
            {
                return new List<int>();
            }

            while (chunks > 10000)
            {
                chunkLength *= 2;
                chunks = file.Length / chunkLength;
            }

            while ((chunks * chunkLength) > file.Length)
            {
                chunkLength--;
            }
            
            List<byte> bytes = File.ReadAllBytes(file.FullName).ToList();

            int offset = 0;
            int counter = 0;
            List<int> result = new List<int>();
            while (counter < chunks)
            {
                byte[] chunk = bytes.GetRange(offset, chunkLength).ToArray();

                result.Add((int)(DataEntropyUTF8.ExamineChunk(chunk) * 12.5));

                chunk = null;

                offset += chunkLength;
                counter++;
            }

            bytes.Clear();
            bytes = null;

            return result;
        }

        #region Chart Tooltips

        private int moveBuffer = 100;
        private Point? clickPosition = null;
        private List<ToolTip> tooltips = new List<ToolTip>();
        private static string formatString = "#,###,###,###,##0";        

        private void chart1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (ToolTip tip in tooltips)
                {
                    tip.RemoveAll();
                }

                tooltips.Clear();
            }
            else
            {
                Point pos = e.Location;
                clickPosition = pos;
                HitTestResult[] hits = chart1.HitTest(pos.X, pos.Y, false, ChartElementType.DataPoint);

                if (hits == null || hits.Length < 1) { return; }
                if (hits[0].ChartElementType == ChartElementType.DataPoint)
                {
                    DataPoint dpObj = hits[0].Object as DataPoint;
                    if (dpObj != null)
                    {
                        var xVal = (int)dpObj.XValue;

                        var offset = xVal * chunkLength;

                        ToolTip tip = new ToolTip();

                        tip.Show(
                            $"Offset: {offset.ToString(formatString)} bytes",
                            this.chart1, e.Location.X, e.Location.Y - 15);

                        tooltips.Add(tip);
                    }
                }
            }
        }

        private void chart1_MouseMove(object sender, MouseEventArgs e)
        {
            if (clickPosition.HasValue)
            {
                if (e.Location.X > (clickPosition.Value.X + moveBuffer)
                    || e.Location.X < (clickPosition.Value.X - moveBuffer)
                    || e.Location.Y > (clickPosition.Value.Y + moveBuffer)
                    || e.Location.Y < (clickPosition.Value.Y - moveBuffer)
                    )
                {
                    foreach (ToolTip tip in tooltips)
                    {
                        tip.RemoveAll();
                    }

                    tooltips.Clear();
                    clickPosition = null;
                }
            }
        }


        #endregion
    }
}
