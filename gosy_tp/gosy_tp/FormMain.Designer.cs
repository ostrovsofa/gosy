namespace gosy_tp
{
    partial class FormMain
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            buttonSave = new Button();
            buttonLoad = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(555, 426);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(573, 12);
            button1.Name = "button1";
            button1.Size = new Size(132, 23);
            button1.TabIndex = 1;
            button1.Text = "Добавить фильм";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(711, 40);
            button2.Name = "button2";
            button2.Size = new Size(173, 23);
            button2.TabIndex = 2;
            button2.Text = "Отобрать по режиссеру";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(711, 69);
            button3.Name = "button3";
            button3.Size = new Size(173, 23);
            button3.TabIndex = 3;
            button3.Text = "Отобрать по году";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(573, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(132, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(573, 69);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(132, 23);
            textBox2.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(573, 386);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(145, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Сохранить в файл";
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(573, 415);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(145, 23);
            buttonLoad.TabIndex = 0;
            buttonLoad.Text = "Загрузить из файла";
            buttonLoad.Click += buttonLoad_Click;
            // 
            // button4
            // 
            button4.Location = new Point(711, 12);
            button4.Name = "button4";
            button4.Size = new Size(173, 23);
            button4.TabIndex = 6;
            button4.Text = "Очистить таблицу";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 450);
            Controls.Add(button4);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "FormMain";
            Text = "Главная форма";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button buttonSave;
        private Button buttonLoad;
        private Button button4;
    }
}
