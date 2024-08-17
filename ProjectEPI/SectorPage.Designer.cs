namespace ProjectEPI
{
    partial class SectorPage
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
            dataGridViewSectors = new DataGridView();
            labelGridTitle = new Label();
            panel2 = new Panel();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            buttonAdd = new Button();
            labelSectorName = new Label();
            textBoxName = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSectors).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(dataGridViewSectors);
            panel1.Controls.Add(labelGridTitle);
            panel1.Location = new Point(21, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(753, 192);
            panel1.TabIndex = 0;
            // 
            // dataGridViewSectors
            // 
            dataGridViewSectors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSectors.Location = new Point(26, 60);
            dataGridViewSectors.Name = "dataGridViewSectors";
            dataGridViewSectors.Size = new Size(703, 110);
            dataGridViewSectors.TabIndex = 1;
            // 
            // labelGridTitle
            // 
            labelGridTitle.AutoSize = true;
            labelGridTitle.Font = new Font("Tahoma", 14F);
            labelGridTitle.Location = new Point(21, 16);
            labelGridTitle.Name = "labelGridTitle";
            labelGridTitle.Size = new Size(72, 23);
            labelGridTitle.TabIndex = 0;
            labelGridTitle.Text = "Setores";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(buttonDelete);
            panel2.Controls.Add(buttonUpdate);
            panel2.Controls.Add(buttonAdd);
            panel2.Controls.Add(labelSectorName);
            panel2.Controls.Add(textBoxName);
            panel2.Location = new Point(21, 233);
            panel2.Name = "panel2";
            panel2.Size = new Size(753, 205);
            panel2.TabIndex = 1;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(365, 161);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(75, 23);
            buttonDelete.TabIndex = 6;
            buttonDelete.Text = "Deletar";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(229, 161);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(75, 23);
            buttonUpdate.TabIndex = 5;
            buttonUpdate.Text = "Atualizar";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(96, 161);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 23);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "Adicionar";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelSectorName
            // 
            labelSectorName.AutoSize = true;
            labelSectorName.Location = new Point(26, 24);
            labelSectorName.Name = "labelSectorName";
            labelSectorName.Size = new Size(40, 15);
            labelSectorName.TabIndex = 3;
            labelSectorName.Text = "Nome";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(72, 21);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(127, 23);
            textBoxName.TabIndex = 2;
            // 
            // SectorPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SectorPage";
            Text = "SectorPage";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSectors).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label labelGridTitle;
        private Panel panel2;
        private DataGridView dataGridViewSectors;
        private TextBox textBoxName;
        private Label labelSectorName;
        private Button buttonAdd;
        private Button buttonDelete;
        private Button buttonUpdate;
    }
}