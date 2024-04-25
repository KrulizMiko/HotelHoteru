using HotelHoteru;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;
using Telegram.Bot;

[Obsolete]

class Program
{
    public delegate void ThreadStart();

    [Obsolete]
    [STAThread] //ассинхрация 

    static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Authorization()); //тут название своей формы которая должна запустится при запуске проги        
    }    
}
