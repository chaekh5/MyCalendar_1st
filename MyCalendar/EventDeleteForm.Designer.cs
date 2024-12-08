namespace MyCalendar
{
    partial class EventDeleteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventDeleteForm));
            listBox1 = new ListBox();
            date_selected = new TextBox();
            delete_selected = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            resources.ApplyResources(listBox1, "listBox1");
            listBox1.Name = "listBox1";
            // 
            // date_selected
            // 
            resources.ApplyResources(date_selected, "date_selected");
            date_selected.Name = "date_selected";
            date_selected.ReadOnly = true;
            // 
            // delete_selected
            // 
            resources.ApplyResources(delete_selected, "delete_selected");
            delete_selected.Name = "delete_selected";
            delete_selected.UseVisualStyleBackColor = true;
            // 
            // EventDeleteForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(delete_selected);
            Controls.Add(date_selected);
            Controls.Add(listBox1);
            Name = "EventDeleteForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private TextBox date_selected;
        private Button delete_selected;
    }
}