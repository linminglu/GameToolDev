namespace IConAndLunchImage
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.FileDropBegin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ImageGuiGe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AppIcon = new System.Windows.Forms.RadioButton();
            this.LunchImage = new System.Windows.Forms.RadioButton();
            this.TranFormButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // FileDropBegin
            // 
            this.FileDropBegin.AllowDrop = true;
            this.FileDropBegin.Location = new System.Drawing.Point(12, 49);
            this.FileDropBegin.Name = "FileDropBegin";
            this.FileDropBegin.Size = new System.Drawing.Size(624, 25);
            this.FileDropBegin.TabIndex = 0;
            this.FileDropBegin.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileDropBegin_DragDrop);
            this.FileDropBegin.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileDropBegin_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "拖进来要转化的图片";
            // 
            // ImageGuiGe
            // 
            this.ImageGuiGe.Location = new System.Drawing.Point(12, 149);
            this.ImageGuiGe.Name = "ImageGuiGe";
            this.ImageGuiGe.Size = new System.Drawing.Size(621, 25);
            this.ImageGuiGe.TabIndex = 2;
            this.ImageGuiGe.Click += new System.EventHandler(this.ImageGuiGe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "转化的图片的规格";
            // 
            // AppIcon
            // 
            this.AppIcon.AutoSize = true;
            this.AppIcon.Location = new System.Drawing.Point(25, 93);
            this.AppIcon.Name = "AppIcon";
            this.AppIcon.Size = new System.Drawing.Size(84, 19);
            this.AppIcon.TabIndex = 4;
            this.AppIcon.TabStop = true;
            this.AppIcon.Text = "AppIcon";
            this.AppIcon.UseVisualStyleBackColor = true;
            this.AppIcon.Click += new System.EventHandler(this.AppIcon_Click);
            // 
            // LunchImage
            // 
            this.LunchImage.AutoSize = true;
            this.LunchImage.Location = new System.Drawing.Point(261, 93);
            this.LunchImage.Name = "LunchImage";
            this.LunchImage.Size = new System.Drawing.Size(108, 19);
            this.LunchImage.TabIndex = 5;
            this.LunchImage.TabStop = true;
            this.LunchImage.Text = "LunchImage";
            this.LunchImage.UseVisualStyleBackColor = true;
            this.LunchImage.Click += new System.EventHandler(this.AppIcon_Click);
            // 
            // TranFormButton
            // 
            this.TranFormButton.Location = new System.Drawing.Point(15, 192);
            this.TranFormButton.Name = "TranFormButton";
            this.TranFormButton.Size = new System.Drawing.Size(623, 47);
            this.TranFormButton.TabIndex = 6;
            this.TranFormButton.Text = "转化";
            this.TranFormButton.UseVisualStyleBackColor = true;
            this.TranFormButton.Click += new System.EventHandler(this.TranFormButton_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(15, 245);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(621, 263);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 531);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.TranFormButton);
            this.Controls.Add(this.LunchImage);
            this.Controls.Add(this.AppIcon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ImageGuiGe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FileDropBegin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FileDropBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ImageGuiGe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton AppIcon;
        private System.Windows.Forms.RadioButton LunchImage;
        private System.Windows.Forms.Button TranFormButton;
        private System.Windows.Forms.ListView listView1;
    }
}

