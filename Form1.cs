namespace ThreadForm
{
    public partial class ThreadForm : Form
    {
        /// <summary>
        /// カウント
        /// </summary>
        
        public int _count = 0;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ThreadForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Countボタンクリックイベント
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private void btnCount_Click(object sender, EventArgs e)
        {
            this.btnCount.Text = _count++.ToString();
        }

        /// <summary>
        /// Nomalボタンクリックイベント
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private void btnNomal_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetDataAsync();
        }

        /// <summary>
        /// Threadボタン
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private void btnThread_Click(object sender, EventArgs e)
        {
            var t = new Thread(GetDataAsync);
            t.Start();
        }

        //private void GetDataAsync()
        //{
        //    var dtos = new List<DTO>();
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Thread.Sleep(1000);
        //        dtos.Add(new DTO(i.ToString(), DateTime.Now.ToString("HH:mm:ss")));
        //    }

        //    this.Invoke((Action)delegate ()
        //    {
        //        dataGridView1.DataSource = dtos;
        //    });
        //}

        /// <summary>
        /// ThreadPoolボタンクリック
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private void btnThreadPool_Click(object sender, EventArgs e)
        {
            ThreadPool.QueueUserWorkItem(GetDataAsync);
        }

        private void GetDataAsync(object o)
        {
            var dtos = new List<DTO>();
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                dtos.Add(new DTO(i.ToString(), DateTime.Now.ToString("HH:mm:ss")));
            }
            this.Invoke((Action)delegate ()
            {
                dataGridView1.DataSource = dtos;
            });
        }

        /// <summary>
        /// Taskボタンクリック
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引き数</param>
        private void btnTask_Click(object sender, EventArgs e)
        {
            var context = TaskScheduler.FromCurrentSynchronizationContext();

            Task.Run(() => GetDataAsync()).ContinueWith(dtos =>{ dataGridView1.DataSource = dtos.Result;}, context);
        }

        /// <summary>
        /// AsyncAwaitボタンクリック
        /// </summary>
        /// <param name="sender">コントロール</param>
        /// <param name="e">イベント引数</param>
        private async void btnAsyncAwait_Click(object sender, EventArgs e)
        {
            var dtos = await Task.Run(() => GetDataAsync());
            dataGridView1.DataSource=dtos;
        }



        private List<DTO> GetDataAsync()
        {
            var result = new List<DTO>();
            for(int i= 0; i<5; i++)
            {
                System.Threading.Thread.Sleep(1000);
                result.Add(new DTO(i.ToString(),DateTime.Now.ToString("HH:mm:ss")));
            }
            return result;
        }

        public class DTO
        {
            public string ID { get; set; }
            public string DateTime { get; set; }

            public DTO(string iD, string dateTime)
            {
                ID = iD;
                DateTime = dateTime;
            }
        }


    }
}