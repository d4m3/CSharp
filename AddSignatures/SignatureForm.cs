using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace AddSignatures
{
    public partial class Form : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel areaSignature;
        private System.Windows.Forms.Button butNew;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Load;

        SignatureControl signature = new SignatureControl();

        public Form()
        {
            InitializeComponent();

            // add signature control to form
            signature.Location = areaSignature.Location;
            signature.Size = areaSignature.Size;            
            //signature.Background = "C:\\Users\\<path>\\Downloads\\SignatureCapture\\SignCaptureV2\\Images\\sign here.png";
            this.Controls.Add(signature);
        }

        //protected override void Dispose(bool disposing)
        //{
        //    base.Dispose(disposing);
        //}
        // Add areaSignature to Designer

        private void btnNew_Click(object sender, EventArgs e)
        {
            signature.Clear();
            this.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            signature.StoreSigData("SignFile.txt");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            int baseX = 10;
            int baseY = 40; // 100
            string signatureFile = "SignFile.txt";
            load_signature(baseX, baseY, signatureFile);
        }

        private void load_signature(int baseX, int baseY, string signatureFile)
        {
            StreamReader streamReader = new StreamReader("SignFile.txt");
            string pointString = null;

            while ((pointString = streamReader.ReadLine()) != null)
            {
                if (pointString.Trim().Length > 0)
                {
                    String[] points = new String[4];
                    points = pointString.Split(new Char[] { ' ' });
                    Pen pen = new Pen(Color.Black);
                    this.CreateGraphics().DrawLine(pen, (baseX + int.Parse(points[0].ToString())), (baseY + int.Parse(points[1].ToString())), (baseX + int.Parse(points[2].ToString())), (baseY + int.Parse(points[3].ToString())));
                }
            }
            streamReader.Close();
        }
    }
}
