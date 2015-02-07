using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IConAndLunchImage
{
    class ImageData
    {
        public string fileName;   //需要打开转化的图片的名字
        public List<int> imageDataLenght;//每条线程处理的量
    }

    class CreateImageThreadManager
    {
        delegate void MyDelegateData(string value);
        // this is manage create data
        private bool bAppCon = false; //是否是转化appicon
        private string strImageGuiGe;//图片规格字符串
        private string strResImageFile;//图片文件
        private ContainerControl m_pForm;

        /// <summary></summary>
        /// <param name="isAppCo"></param>
        /// <param name="data"></param>
        ///  /// <param name="ImagetFile"></param>
       public CreateImageThreadManager(ContainerControl pForm,bool isAppCo,string ImagetFile, string guige)
        {
            this.bAppCon = isAppCo;
            this.strImageGuiGe = guige;
            this.strResImageFile = ImagetFile;
            m_pForm = pForm;
        }
        public void startWorking()
        {
            if (this.bAppCon)
            {
              string []arrStr=this.strImageGuiGe.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                double tempIntArray = Math.Ceiling((double)arrStr.Length / 3);
                int indexArray = Convert.ToInt32(tempIntArray);
                int beginIndex = 0;
                
                while (beginIndex < arrStr.Length)
                {
                    ImageData pv = new ImageData();
                    pv.fileName = this.strResImageFile;
                    pv.imageDataLenght = new List<int>();
                    int index = 0;
                    while (index < indexArray)
                    {
                        if (beginIndex + index < arrStr.Length)
                        {
                            pv.imageDataLenght.Add(int.Parse(arrStr[beginIndex + index]));
                            index++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    beginIndex += indexArray;
                    if (pv.imageDataLenght.Count!=0)
                    { 
                        Thread netThread = new Thread(threadWorkAppIcon);
                        netThread.Start(pv);
                    }
                }
            }
            else
            {

            }
        }
        public string ReduceImage(string imageFile, int toWidth, int toHeight)
        {

            if (toWidth <= 0 || toHeight <= 0)
            {
                return imageFile;
            }
            Image originalImage = Image.FromFile(imageFile);
            Image toBitmap = new Bitmap(toWidth, toHeight);
            using (Graphics g = Graphics.FromImage(toBitmap))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.Clear(Color.Transparent);
                g.DrawImage(originalImage,
                            new Rectangle(0, 0, toWidth, toHeight),
                            new Rectangle(0, 0, originalImage.Width, originalImage.Height),
                            GraphicsUnit.Pixel);
                originalImage.Dispose();
                string newFileName;
                newFileName = Path.GetDirectoryName(imageFile) + "Icon-" + toWidth.ToString() + ".png";
                toBitmap.Save(newFileName, ImageFormat.Png);
                toBitmap.Dispose();
                return newFileName;
            }
        }
        public void UpdateAddListView(string str)
        {
            ((Form1)m_pForm).addListView(str);
        }

        //线程处理函数
        private void threadWorkAppIcon(object o)
        { 

            ImageData pv = (ImageData)o;
            int index = 0;
            while (index < pv.imageDataLenght.Count)
            {
                int widht = pv.imageDataLenght[index];
                string BackFunctionFile= ReduceImage(pv.fileName, widht, widht);
                m_pForm.BeginInvoke(new MyDelegateData(UpdateAddListView), BackFunctionFile);
                index++;
            }
        }


    }
}
