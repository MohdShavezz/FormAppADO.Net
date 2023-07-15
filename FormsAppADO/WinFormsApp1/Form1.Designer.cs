namespace WinFormsApp1
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
            label1 = new Label();
            label2 = new Label();
            name = new TextBox();
            insert = new Button();
            age = new TextBox();
            id = new TextBox();
            label3 = new Label();
            delete = new Button();
            update = new Button();
            search = new Button();
            show = new Button();
            dataGridView1 = new DataGridView();
            first = new Button();
            last = new Button();
            prev = new Button();
            next = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 86);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 119);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 1;
            label2.Text = "Age";
            // 
            // name
            // 
            name.Location = new Point(93, 83);
            name.Name = "name";
            name.Size = new Size(156, 23);
            name.TabIndex = 1;
            // 
            // insert
            // 
            insert.Location = new Point(304, 54);
            insert.Name = "insert";
            insert.Size = new Size(75, 23);
            insert.TabIndex = 3;
            insert.Text = "Insert";
            insert.UseVisualStyleBackColor = true;
            insert.Click += Insert_Click;
            // 
            // age
            // 
            age.Location = new Point(93, 116);
            age.Name = "age";
            age.Size = new Size(156, 23);
            age.TabIndex = 2;
            // 
            // id
            // 
            id.Location = new Point(93, 51);
            id.Name = "id";
            id.Size = new Size(156, 23);
            id.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 54);
            label3.Name = "label3";
            label3.Size = new Size(17, 15);
            label3.TabIndex = 5;
            label3.Text = "Id";
            // 
            // delete
            // 
            delete.Location = new Point(385, 54);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 4;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = true;
            delete.Click += Delete_Click;
            // 
            // update
            // 
            update.Location = new Point(466, 54);
            update.Name = "update";
            update.Size = new Size(75, 23);
            update.TabIndex = 5;
            update.Text = "Update";
            update.UseVisualStyleBackColor = true;
            update.Click += Update_Click;
            // 
            // search
            // 
            search.Location = new Point(387, 88);
            search.Name = "search";
            search.Size = new Size(75, 23);
            search.TabIndex = 7;
            search.Text = "Search";
            search.UseVisualStyleBackColor = true;
            search.Click += Search_Click;
            // 
            // show
            // 
            show.Location = new Point(304, 88);
            show.Name = "show";
            show.Size = new Size(75, 23);
            show.TabIndex = 6;
            show.Text = "Show";
            show.UseVisualStyleBackColor = true;
            show.Click += Show_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(619, 169);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // first
            // 
            first.Location = new Point(306, 117);
            first.Name = "first";
            first.Size = new Size(75, 23);
            first.TabIndex = 8;
            first.Text = "First";
            first.UseVisualStyleBackColor = true;
            first.Click += First_Click;
            // 
            // last
            // 
            last.Location = new Point(549, 117);
            last.Name = "last";
            last.Size = new Size(75, 23);
            last.TabIndex = 11;
            last.Text = "Last";
            last.UseVisualStyleBackColor = true;
            last.Click += Last_Click;
            // 
            // prev
            // 
            prev.Location = new Point(387, 117);
            prev.Name = "prev";
            prev.Size = new Size(75, 23);
            prev.TabIndex = 9;
            prev.Text = "Prev";
            prev.UseVisualStyleBackColor = true;
            prev.Click += Prev_Click;
            // 
            // next
            // 
            next.Location = new Point(468, 117);
            next.Name = "next";
            next.Size = new Size(75, 23);
            next.TabIndex = 10;
            next.Text = "Next";
            next.UseVisualStyleBackColor = true;
            next.Click += Next_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(694, 344);
            Controls.Add(next);
            Controls.Add(prev);
            Controls.Add(last);
            Controls.Add(first);
            Controls.Add(dataGridView1);
            Controls.Add(show);
            Controls.Add(search);
            Controls.Add(update);
            Controls.Add(delete);
            Controls.Add(id);
            Controls.Add(label3);
            Controls.Add(age);
            Controls.Add(insert);
            Controls.Add(name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox name;
        private Button insert;
        private TextBox age;
        private TextBox id;
        private Label label3;
        private Button delete;
        private Button update;
        private Button search;
        private Button show;
        private DataGridView dataGridView1;
        private Button first;
        private Button last;
        private Button prev;
        private Button next;
    }
}