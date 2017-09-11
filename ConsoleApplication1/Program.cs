using SolidWorks.Interop.sldworks;

namespace ConsoleApplication1
{
    class Program
    {       
        //delegate void del();
        static void Main(string[] args)
        {
            MyProcess instance = new MyProcess();
            SldWorks sldWoksApp = null;
            sldWoksApp = instance.CheckProcess();
            sldWoksApp.OpenDoc6("D:\\80 K_TOP.SLDPRT", 1, 1, "00", ref MyProcess.errors, ref MyProcess.warnings);
        }
    }
}
