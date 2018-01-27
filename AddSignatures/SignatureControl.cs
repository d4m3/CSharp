using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace AddSignatures
{    
    class SignatureControl : Control
    {
        private string background = null;
        public string Background
        {
            get { return background; }
            set { background = value; }
        }

        Bitmap bmp;
        Graphics graphics;
        Pen pen = new Pen(Color.Black);

        // List of Line Segments
        ArrayList pVector = new ArrayList();
        Point lastPoint = new Point(0,0);

        // If drawing signature or not
        bool drawSign = false;

        // notify parent that line segment was updated
        public event EventHandler SignatureUpdate;

        public SignatureControl(){}

        protected override void OnPaint(PaintEventArgs e)
        {
            // draw on the memory bitmap on mousemove so 
            // there is nothing else to draw ar this time
            CreateGdiObjects();
            e.Graphics.DrawImage(bmp, 0, 0);            
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // don't pass to base since we paint everything, avoid flashing
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            // process if currently drawing signature
            if (!drawSign)
            {
                // start collecting points
                drawSign = true;

                // use current mouse click as the first point
                lastPoint.X = e.X;
                lastPoint.Y = e.Y;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            // process if drawing sign
            if (drawSign)
            {
                // stop collecting points
                drawSign = false;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            // process if drawing sing
            if (drawSign)
            {
                // draw the new segment on the memory bitmap
                graphics.DrawLine(pen, lastPoint.X, lastPoint.Y,e.X, e.Y);
                pVector.Add(lastPoint.X + " " + lastPoint.Y + " " + e.X + " " + e.Y);

                // Update the current position
                lastPoint.X = e.X;
                lastPoint.Y = e.Y;

                // display the updated bitmap
                Invalidate();
            }
        }

        // Clear Signature
        public void Clear()
        {
            pVector.Clear();
            InitMemoryBitmap();
            Invalidate();
        }

        //Create and GDI objects required to draw signature
        private void CreateGdiObjects()
        {
            // only creat if don't have one or the size changed
            if (bmp == null || bmp.Width != this.Width || bmp.Height != this.Height)
            {
                // memory bitmap to draw on
                InitMemoryBitmap();
            }
        }

        // Create a memory bitmap that is used to draw the signature
        private void InitMemoryBitmap()
        {
            // load the background image
            if (this.Background == null)
            {
                bmp = new Bitmap(this.Width, this.Height);
                graphics = Graphics.FromImage(bmp);
                graphics.Clear(Color.White);
            }
            else
            {
                bmp = new Bitmap(this.Background);
                // get graphics object now to make drawing during mousemove faster
                graphics = Graphics.FromImage(bmp);
            }
        }

        // Notify container that a line segment has been added
        private void RaiseSignatureUpdateEvent()
        {
            if (this.SignatureUpdate != null)
            {
                SignatureUpdate(this, EventArgs.Empty);
            }
        }

        private void CreateFile(String fileName, String fileContent)
        {
            if (File.Exists(fileName))
            {
                Console.WriteLine("{0} already exists.", fileName);
                //return;
            }
            StreamWriter sr = File.CreateText(fileName);
            sr.WriteLine(fileContent);
            //MessageBox.Show("File creation complete");
            sr.Close();
        }

        public void StoreSigData(String fileName)
        {
            string sigData = "";
            for (int i = 0; i < pVector.Count; i++)
            {
                // This commented operation is used to convert decimal to hex and store
                //sigData = sigData + PadHex(int.Parse(xVector[i].ToString()))+" " + PadHex(int.Parse(yVector[i].ToString()))+ "\n";
                sigData = sigData + pVector[i].ToString() + "\n";
            }
            CreateFile(fileName, sigData);

        }
        // this method PadHex can be used to convert int to hex format //  
        // not in use
        private string PadHex(int inNum)
        {
            uint uiDecimal = checked((uint)System.Convert.ToUInt32(inNum));
            string s = String.Format("{0:x2}", uiDecimal);
            return (s);
        }
    }//SignatureControl   
}
