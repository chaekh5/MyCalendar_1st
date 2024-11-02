namespace MyCalendar
{
    partial class EventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btn_event_save = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(42, 37);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(42, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 23);
            textBox2.TabIndex = 0;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(42, 19);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "날짜";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 76);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "이벤트";
            // 
            // btn_event_save
            // 
            btn_event_save.Location = new Point(231, 136);
            btn_event_save.Name = "btn_event_save";
            btn_event_save.Size = new Size(75, 23);
            btn_event_save.TabIndex = 3;
            btn_event_save.Text = "저장";
            btn_event_save.UseVisualStyleBackColor = true;
            btn_event_save.Click += btn_event_save_Click;
            // 
            // EventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 183);
            Controls.Add(btn_event_save);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "EventForm";
            Text = "이벤트 추가";
            Load += EventForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Button btn_event_save;
    }
}