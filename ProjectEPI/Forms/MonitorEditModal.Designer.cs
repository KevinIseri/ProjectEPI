namespace ProjectEPI.Forms
{
    partial class MonitorEditModal
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
            panel1 = new Panel();
            FieldMonitorEditModalId = new TextBox();
            LabelMonitorEditModalId = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HighlightText;
            panel1.Controls.Add(FieldMonitorEditModalId);
            panel1.Controls.Add(LabelMonitorEditModalId);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(348, 278);
            panel1.TabIndex = 0;
            // 
            // FieldMonitorEditModalId
            // 
            FieldMonitorEditModalId.BorderStyle = BorderStyle.None;
            FieldMonitorEditModalId.Location = new Point(41, 9);
            FieldMonitorEditModalId.Name = "FieldMonitorEditModalId";
            FieldMonitorEditModalId.ReadOnly = true;
            FieldMonitorEditModalId.Size = new Size(36, 16);
            FieldMonitorEditModalId.TabIndex = 1;
            // 
            // LabelMonitorEditModalId
            // 
            LabelMonitorEditModalId.AutoSize = true;
            LabelMonitorEditModalId.Location = new Point(12, 9);
            LabelMonitorEditModalId.Name = "LabelMonitorEditModalId";
            LabelMonitorEditModalId.Size = new Size(23, 15);
            LabelMonitorEditModalId.TabIndex = 0;
            LabelMonitorEditModalId.Text = "Id: ";
            // 
            // MonitorEditModal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 278);
            Controls.Add(panel1);
            Name = "MonitorEditModal";
            Text = "MonitorEditModal";
            Load += MonitorEditModal_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label LabelMonitorEditModalId;
        private TextBox FieldMonitorEditModalId;
    }
}