using System.Diagnostics;

namespace QueueModel
{
    public class Shop
    {
        //static ModelTimer modelTimer = new ModelTimer();
        System.Timers.Timer modelTimer = new System.Timers.Timer(1000);
        int _modelTime = 0;
        public Shop()
        {
            //modelTimer.OnTimeInterval += (s, e) => Debug.WriteLine
            //    ((e as ModelTimeEventArgs).ModelTime.ToString());
            modelTimer.Elapsed += ModelTimer_Elapsed;
            modelTimer.Start();
        }

        private void ModelTimer_Elapsed(object? sender, System.Timers.ElapsedEventArgs e)
        {
            Debug.WriteLine((++_modelTime).ToString());
        }
    }

    public class ModelTimer : System.Timers.Timer
    {
        public event EventHandler OnTimeInterval;
        int _modelTime = 0;
        public ModelTimer() : base(1000)
        {
            Elapsed += (s, e) => OnTimeInterval
                (this, new ModelTimeEventArgs { ModelTime = ++_modelTime });
        }
        public override 
    }

    public class ModelTimeEventArgs : EventArgs
    {
        public int ModelTime { get; set; }
    }
}
