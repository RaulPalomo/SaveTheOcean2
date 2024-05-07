namespace SaveTheOcean2
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            cbOfici = new ComboBox();
            textBoxName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnRescat = new Button();
            errorName = new ErrorProvider(components);
            errorOfici = new ErrorProvider(components);
            labelOptions = new Label();
            cbOptions = new ComboBox();
            LabelResult = new Label();
            btnAccept = new Button();
            errorAction = new ErrorProvider(components);
            label3 = new Label();
            btnPlay = new Button();
            btnExit = new Button();
            btnConsultes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorOfici).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorAction).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(78, 176);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(576, 48);
            dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(78, 230);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(576, 45);
            dataGridView2.TabIndex = 1;
            // 
            // cbOfici
            // 
            cbOfici.FormattingEnabled = true;
            cbOfici.Location = new Point(204, 137);
            cbOfici.Name = "cbOfici";
            cbOfici.Size = new Size(121, 23);
            cbOfici.TabIndex = 2;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(78, 137);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 119);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 4;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(204, 119);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 5;
            label2.Text = "Occupation:";
            // 
            // btnRescat
            // 
            btnRescat.Location = new Point(359, 137);
            btnRescat.Name = "btnRescat";
            btnRescat.Size = new Size(100, 23);
            btnRescat.TabIndex = 6;
            btnRescat.Text = "Generate rescue";
            btnRescat.UseVisualStyleBackColor = true;
            btnRescat.Click += btnRescat_Click;
            // 
            // errorName
            // 
            errorName.ContainerControl = this;
            // 
            // errorOfici
            // 
            errorOfici.ContainerControl = this;
            // 
            // labelOptions
            // 
            labelOptions.AutoSize = true;
            labelOptions.Location = new Point(78, 307);
            labelOptions.Name = "labelOptions";
            labelOptions.Size = new Size(147, 15);
            labelOptions.TabIndex = 7;
            labelOptions.Text = "What are you going to do?";
            // 
            // cbOptions
            // 
            cbOptions.FormattingEnabled = true;
            cbOptions.Location = new Point(228, 304);
            cbOptions.Name = "cbOptions";
            cbOptions.Size = new Size(121, 23);
            cbOptions.TabIndex = 8;
            // 
            // LabelResult
            // 
            LabelResult.AutoSize = true;
            LabelResult.Location = new Point(82, 349);
            LabelResult.Name = "LabelResult";
            LabelResult.Size = new Size(39, 15);
            LabelResult.TabIndex = 9;
            LabelResult.Text = "Result";
            // 
            // btnAccept
            // 
            btnAccept.Location = new Point(372, 304);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(75, 23);
            btnAccept.TabIndex = 10;
            btnAccept.Text = "Accept";
            btnAccept.UseVisualStyleBackColor = true;
            btnAccept.Click += btnAccept_Click;
            // 
            // errorAction
            // 
            errorAction.ContainerControl = this;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(242, 23);
            label3.Name = "label3";
            label3.Size = new Size(226, 37);
            label3.TabIndex = 11;
            label3.Text = "Save The Ocean 2";
            // 
            // btnPlay
            // 
            btnPlay.Location = new Point(271, 73);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(75, 23);
            btnPlay.TabIndex = 12;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += btnPlay_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(359, 73);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnConsultes
            // 
            btnConsultes.Location = new Point(579, 37);
            btnConsultes.Name = "btnConsultes";
            btnConsultes.Size = new Size(75, 23);
            btnConsultes.TabIndex = 14;
            btnConsultes.Text = "Search";
            btnConsultes.UseVisualStyleBackColor = true;
            btnConsultes.Click += btnConsultes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 394);
            Controls.Add(btnConsultes);
            Controls.Add(btnExit);
            Controls.Add(btnPlay);
            Controls.Add(label3);
            Controls.Add(btnAccept);
            Controls.Add(LabelResult);
            Controls.Add(cbOptions);
            Controls.Add(labelOptions);
            Controls.Add(btnRescat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(cbOfici);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorOfici).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorAction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private ComboBox cbOfici;
        private TextBox textBoxName;
        private Label label1;
        private Label label2;
        private Button btnRescat;
        private ErrorProvider errorName;
        private ErrorProvider errorOfici;
        private Label LabelResult;
        private ComboBox cbOptions;
        private Label labelOptions;
        private Button btnAccept;
        private ErrorProvider errorAction;
        private Label label3;
        private Button btnExit;
        private Button btnPlay;
        private Button btnConsultes;
    }
}
