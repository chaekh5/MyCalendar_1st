namespace MyCalendar
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btn_Previous = new Button();
            btn_Next = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            daycontainer = new FlowLayoutPanel();
            title_month = new Label();
            title_year = new Label();
            btn_today = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_Previous
            // 
            btn_Previous.Location = new Point(962, 759);
            btn_Previous.Name = "btn_Previous";
            btn_Previous.Size = new Size(75, 23);
            btn_Previous.TabIndex = 1;
            btn_Previous.Text = "Previous";
            btn_Previous.UseVisualStyleBackColor = true;
            btn_Previous.Click += btn_Previous_Click;
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(1043, 759);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(75, 23);
            btn_Next.TabIndex = 1;
            btn_Next.Text = "Next";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(79, 61);
            label1.Name = "label1";
            label1.Size = new Size(79, 25);
            label1.TabIndex = 2;
            label1.Text = "Sunday";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(214, 61);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 2;
            label2.Text = "Monday";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(356, 61);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 2;
            label3.Text = "Tuesday";
            label3.Click += label1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label4.Location = new Point(498, 61);
            label4.Name = "label4";
            label4.Size = new Size(116, 25);
            label4.TabIndex = 2;
            label4.Text = "Wednesday";
            label4.Click += label1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label5.Location = new Point(670, 61);
            label5.Name = "label5";
            label5.Size = new Size(95, 25);
            label5.TabIndex = 2;
            label5.Text = "Thursday";
            label5.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label6.Location = new Point(821, 61);
            label6.Name = "label6";
            label6.Size = new Size(66, 25);
            label6.TabIndex = 2;
            label6.Text = "Friday";
            label6.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label7.Location = new Point(943, 61);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 2;
            label7.Text = "Saturday";
            label7.Click += label1_Click;
            // 
            // daycontainer
            // 
            daycontainer.BackColor = Color.Transparent;
            daycontainer.Location = new Point(50, 99);
            daycontainer.Name = "daycontainer";
            daycontainer.Size = new Size(1047, 640);
            daycontainer.TabIndex = 0;
            // 
            // title_month
            // 
            title_month.AutoSize = true;
            title_month.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_month.Location = new Point(548, 13);
            title_month.Name = "title_month";
            title_month.Size = new Size(185, 37);
            title_month.TabIndex = 3;
            title_month.Text = "title_month";
            // 
            // title_year
            // 
            title_year.AutoSize = true;
            title_year.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title_year.Location = new Point(402, 13);
            title_year.Name = "title_year";
            title_year.Size = new Size(155, 37);
            title_year.TabIndex = 3;
            title_year.Text = "title_year";
            // 
            // btn_today
            // 
            btn_today.Location = new Point(881, 759);
            btn_today.Name = "btn_today";
            btn_today.Size = new Size(75, 23);
            btn_today.TabIndex = 4;
            btn_today.Text = "Today";
            btn_today.UseVisualStyleBackColor = true;
            btn_today.Click += btn_today_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.None;
            pictureBox1.Cursor = Cursors.No;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(250, 652);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 147);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(207, 255, 229);
            ClientSize = new Size(1134, 811);
            Controls.Add(pictureBox1);
            Controls.Add(btn_today);
            Controls.Add(title_year);
            Controls.Add(title_month);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Next);
            Controls.Add(btn_Previous);
            Controls.Add(daycontainer);
            Name = "Form1";
            Text = "My Little Little Jian's Calendar";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn_Next;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private FlowLayoutPanel daycontainer;
        private Label title_month;
        private Button btn_Previous;
        private Label title_year;
        private Button btn_today;
        private PictureBox pictureBox1;
    }
}
