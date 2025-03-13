namespace MemoryAddressHelpers.Tests
{
    public partial class MemoryAddressTests
    {

        private long GetAddressOfParameter2<T>(T obj)
        {
            return MemoryAddress.Get(obj);
        }

        private long GetAddressOfRefParameter2<T>(ref T obj)
        {
            return MemoryAddress.Get(obj);
        }

        private long GetAddressOfParameter3<T>(ref T obj)
            where T : struct
        {
            return MemoryAddress.Get(ref obj);
        }

        private long GetAddressOfRefParameter3<T>(ref T obj)
            where T : struct
        {
            return MemoryAddress.Get(ref obj);
        }

    }
}
