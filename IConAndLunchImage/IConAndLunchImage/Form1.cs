using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IConAndLunchImage
{
    public partial class Form1 : Form
    {
        private bool isSetImageGuiGet = false;
        private  void setImageGuiGet(bool bAppIconIsCheck)
        {
            if (bAppIconIsCheck)
            {
                this.ImageGuiGe.Text = "40,80,56...78,120";
            }
            else
            {
                this.ImageGuiGe.Text = "120*480,580*640";
            }
        }
        public Form1()
        {
            InitializeComponent();
            this.AppIcon.Checked = true;
            setImageGuiGet(this.AppIcon.Checked);
            this.ImageGuiGe.ForeColor = Color.Gray;
            this.InitListView();
        }

        private void FileDropBegin_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
                this.FileDropBegin.Cursor = System.Windows.Forms.Cursors.Arrow;  //指定鼠标形状（更好看）  
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void FileDropBegin_DragDrop(object sender, DragEventArgs e)
        {
            //GetValue(0) 为第1个文件全路径  
            //DataFormats 数据的格式，下有多个静态属性都为string型，除FileDrop格式外还有Bitmap,Text,WaveAudio等格式  
            string path = ((System.Array)e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            this.FileDropBegin.Text = path;
            this.FileDropBegin.Cursor = System.Windows.Forms.Cursors.IBeam; //还原鼠标形状  
        }

        private void AppIcon_Click(object sender, EventArgs e)
        {
            this.setImageGuiGet(this.AppIcon.Checked);
        }

        private void ImageGuiGe_Click(object sender, EventArgs e)
        {
            this.ImageGuiGe.ForeColor = Color.Black;
            if (isSetImageGuiGet)
            {

            }
            else {
                this.ImageGuiGe.Text = "";
                isSetImageGuiGet = true;
            }

            
            
        }
        private bool checkIsRightDataGuige(string str)
        {
            if (this.AppIcon.Checked)
            { 
                
            }
            else
            {

            }
            return true;
            //return false;
        }

        private void TranFormButton_Click(object sender, EventArgs e)
        {
            if (!isSetImageGuiGet||this.ImageGuiGe.Text=="" ||this.FileDropBegin.Text=="")
            {
                MessageBox.Show("错误的输入图片尺寸规格");
            }
            else
            {
                if (this.checkIsRightDataGuige(this.ImageGuiGe.Text))
                {
                    //start thread tocheck data
                    bool isAppicon = this.AppIcon.Checked;
                    string filenamestr = this.FileDropBegin.Text;
                    string guige = this.ImageGuiGe.Text;
                    CreateImageThreadManager pMnagerThread = 
                        new CreateImageThreadManager(this, isAppicon, filenamestr, guige);


                    pMnagerThread.startWorking();
                }
            }
        }
        private void InitListView()
        {
            //添加列头
            ColumnHeader ch1 = new ColumnHeader();
            ch1.Width = 100; //列标头宽
            ch1.Text = "图片名字";　//列标头名称
            this.listView1.Columns.Add(ch1);//在同一行上添别的列（此处一行共两列)
            this.listView1.GridLines = true;//显示网格线
            this.listView1.FullRowSelect = true;//是否全行选择
            this.listView1.HideSelection = false;//失去焦点时显示选择的项
            this.listView1.HoverSelection = true;//当鼠标停留数秒时自动选择项
            this.listView1.MultiSelect = false;//设置只能单选
        }
        public void addListView(string str)
        {
            //添加项
            ListViewItem lv = new ListViewItem(str);//第一列的记录为钢笔
            this.listView1.Items.Add(lv);
        }

    }
}
