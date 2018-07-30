namespace Iodine.Abstract.Devices
{
    public class Station : ConnectedDevice
    {
        public string Status { get; set; }

        public string StationType { get; set; } // pull, break glass, etc...
    }
}
