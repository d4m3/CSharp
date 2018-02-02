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

        // Clear Button
        private void btnNew_Click(object sender, EventArgs e)
        {
            signature.Clear();
            this.Refresh();
        }

        // Save Button
        // https://stackoverflow.com/questions/31352515/saving-image-from-picturebox-after-drawing-to-it
        private void btnSave_Click(object sender, EventArgs e)
        {
            //signature.StoreSigData("SignFile.txt");
            //Bitmap bmp = new Bitmap(Convert.ToInt32(1024), Convert.ToInt32(1024), System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            //Graphics g = Graphics.FromImage(bmp);
            //g.Clear(Color.Green);

            // Take image to be used for placing into pdf document
            Bitmap bmp = new Bitmap(signature.ClientSize.Width, signature.ClientSize.Height);
            signature.DrawToBitmap(bmp, signature.ClientRectangle);
            //bmp.Save(@"C:\Users\<User>\Desktop\signature.png"+" "+ISO_Date());
            

            // This will be handled by the Dialog Result
            //bmp.Save("C:\\Users\\dof344\\Desktop\\Signatures"+ISO_Date()+".png");

            //TODO Close the window once signed
            DialogResult dr = MessageBox.Show("Would you like to retry your signature?","Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                bmp.Save("C:\\Users\\dof344\\Desktop\\Signatures" + ISO_Date() + ".png");
                this.Close();
            }
            if (dr == DialogResult.Yes)
            {
                signature.Clear();
                this.Refresh();
            }
                        
        }

        // Load Button
        // TODO Recall the previous signed name, or use a drop down to get signature, need to match txtName and signature pic
        private void btnLoad_Click(object sender, EventArgs e)
        {
            int baseX = 10;
            int baseY = 40; // 100
            string signatureFile = "SignFile.txt";
            load_signature(baseX, baseY, signatureFile); // Need to set path for sign txt file
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
        
        // Identifier for different images
        static String ISO_Date(){  return DateTime.Now.ToString("_MMddyyyyHHmmss"); }

        // TODO Get name from pdf file to place in txtName
    }
}
