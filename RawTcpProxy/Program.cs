using System;
using System.Windows.Forms;

namespace RawTcpProxy
{

  public class Program
  {

    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new frmServerListener());
    }

  }

}
