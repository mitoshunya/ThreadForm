namespace ThreadForm
{
    partial class ThreadForm
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
            this.btnNomal = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThread = new System.Windows.Forms.Button();
            this.btnThreadPool = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnAsyncAwait = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNomal
            // 
            this.btnNomal.Location = new System.Drawing.Point(24, 27);
            this.btnNomal.Margin = new System.Windows.Forms.Padding(2);
            this.btnNomal.Name = "btnNomal";
            this.btnNomal.Size = new System.Drawing.Size(85, 32);
            this.btnNomal.TabIndex = 0;
            this.btnNomal.Text = "Nomal";
            this.btnNomal.UseVisualStyleBackColor = true;
            this.btnNomal.Click += new System.EventHandler(this.btnNomal_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(150, 27);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(86, 32);
            this.btnCount.TabIndex = 1;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-3, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(300, 198);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnThread
            // 
            this.btnThread.Location = new System.Drawing.Point(24, 64);
            this.btnThread.Name = "btnThread";
            this.btnThread.Size = new System.Drawing.Size(85, 28);
            this.btnThread.TabIndex = 3;
            this.btnThread.Text = "Thread";
            this.btnThread.UseVisualStyleBackColor = true;
            this.btnThread.Click += new System.EventHandler(this.btnThread_Click);
            // 
            // btnThreadPool
            // 
            this.btnThreadPool.Location = new System.Drawing.Point(24, 98);
            this.btnThreadPool.Name = "btnThreadPool";
            this.btnThreadPool.Size = new System.Drawing.Size(85, 28);
            this.btnThreadPool.TabIndex = 4;
            this.btnThreadPool.Text = "ThreadPool";
            this.btnThreadPool.UseVisualStyleBackColor = true;
            this.btnThreadPool.Click += new System.EventHandler(this.btnThreadPool_Click);
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(24, 132);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(85, 28);
            this.btnTask.TabIndex = 5;
            this.btnTask.Text = "Task";
            this.btnTask.UseVisualStyleBackColor = true;
            this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
            // 
            // btnAsyncAwait
            // 
            this.btnAsyncAwait.Location = new System.Drawing.Point(24, 166);
            this.btnAsyncAwait.Name = "btnAsyncAwait";
            this.btnAsyncAwait.Size = new System.Drawing.Size(85, 27);
            this.btnAsyncAwait.TabIndex = 6;
            this.btnAsyncAwait.Text = "AsyncAwait";
            this.btnAsyncAwait.UseVisualStyleBackColor = true;
            this.btnAsyncAwait.Click += new System.EventHandler(this.btnAsyncAwait_Click);
            // 
            // ThreadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 422);
            this.Controls.Add(this.btnAsyncAwait);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnThreadPool);
            this.Controls.Add(this.btnThread);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnNomal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ThreadForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNomal;
        private Button btnCount;
        private DataGridView dataGridView1;
        private Button btnThread;
        private Button btnThreadPool;
        private Button btnTask;
        private Button btnAsyncAwait;
    }
}