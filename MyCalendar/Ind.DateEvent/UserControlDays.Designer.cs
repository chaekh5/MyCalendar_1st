namespace MyCalendar
{
    partial class UserControlDays
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            lbdays = new Label();
            event_list = new ListBox();
            SuspendLayout();
            // 
            // lbdays
            // 
            lbdays.AutoSize = true;
            lbdays.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbdays.Location = new Point(8, 7);
            lbdays.Name = "lbdays";
            lbdays.Size = new Size(54, 19);
            lbdays.TabIndex = 0;
            lbdays.Text = "label1";
            // 
            // event_list
            // 
            event_list.BorderStyle = BorderStyle.None;
            event_list.Font = new Font("한컴산뜻돋움", 8.999999F, FontStyle.Bold, GraphicsUnit.Point, 129);
            event_list.FormattingEnabled = true;
            event_list.Location = new Point(3, 29);
            event_list.Name = "event_list";
            event_list.Size = new Size(134, 64);
            event_list.TabIndex = 3;
            event_list.MouseDoubleClick += event_list_MouseDoubleClick;
            // 
            // UserControlDays
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(event_list);
            Controls.Add(lbdays);
            ForeColor = SystemColors.MenuText;
            Name = "UserControlDays";
            Size = new Size(140, 100);
            Load += UserControlDays_Load;
            Click += UserControlDays_Click;
            MouseLeave += UserControlDays_mouseLeave;
            MouseHover += UserControlDays_mouseHover;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbdays;
        private ListBox event_list;
    }
}
