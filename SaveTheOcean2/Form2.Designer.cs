namespace SaveTheOcean2
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            dataGridSelectAll = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            textBoxId = new TextBox();
            dataGridSelectId = new DataGridView();
            buttonSearchId = new Button();
            errorId = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dataGridSelectAll).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSelectId).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorId).BeginInit();
            SuspendLayout();
            // 
            // dataGridSelectAll
            // 
            dataGridSelectAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSelectAll.Location = new Point(154, 108);
            dataGridSelectAll.Name = "dataGridSelectAll";
            dataGridSelectAll.Size = new Size(475, 150);
            dataGridSelectAll.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 76);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "All rescues:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 286);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 2;
            label2.Text = "Select by id:";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(230, 283);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(100, 23);
            textBoxId.TabIndex = 3;
            // 
            // dataGridSelectId
            // 
            dataGridSelectId.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSelectId.Location = new Point(154, 312);
            dataGridSelectId.Name = "dataGridSelectId";
            dataGridSelectId.Size = new Size(475, 63);
            dataGridSelectId.TabIndex = 4;
            // 
            // buttonSearchId
            // 
            buttonSearchId.Location = new Point(363, 282);
            buttonSearchId.Name = "buttonSearchId";
            buttonSearchId.Size = new Size(75, 23);
            buttonSearchId.TabIndex = 5;
            buttonSearchId.Text = "Search";
            buttonSearchId.UseVisualStyleBackColor = true;
            buttonSearchId.Click += buttonSearchId_Click;
            // 
            // errorId
            // 
            errorId.ContainerControl = this;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSearchId);
            Controls.Add(dataGridSelectId);
            Controls.Add(textBoxId);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridSelectAll);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridSelectAll).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridSelectId).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorId).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridSelectAll;
        private Label label1;
        private Label label2;
        private TextBox textBoxId;
        private DataGridView dataGridSelectId;
        private Button buttonSearchId;
        private ErrorProvider errorId;
    }
}