using TorchSharp;

Console.WriteLine("Start");

torch.InitializeDeviceType(DeviceType.CUDA);

var arr = new[] { 1.0, 2.0 };
torch.tensor(arr).cuda().print();
