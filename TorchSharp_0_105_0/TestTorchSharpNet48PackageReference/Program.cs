namespace TestTorchSharpNet48PackageReference
{
    using System;
    using TorchSharp;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");

            torch.InitializeDeviceType(DeviceType.CUDA);

            var arr = new[] { 1.0, 2.0 };
            torch.tensor(arr).cuda().print();
        }
    }
}
