namespace WPF
{
    public class Program
    {
        [System.STAThreadAttribute()]
        public static void Main()
        {
            using (new UI.App())
            {
                var app = new WPF.App();
                app.InitializeComponent();
                app.Run();
            }
        }
    }
}