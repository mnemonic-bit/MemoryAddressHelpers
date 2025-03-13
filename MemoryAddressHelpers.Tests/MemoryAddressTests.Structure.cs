namespace MemoryAddressHelpers.Tests
{
    public partial class MemoryAddressTests
    {

        private class SomeClass
        {

            public SomeClass() { }

            public bool SomeMethod() => true;

            public long GetAddress()
            {
                return MemoryAddress.Get(this);
            }

        }

        private struct SomeStruct
        {

            public SomeStruct() { }

            public bool SomeMethod() => true;

            public long GetAddress()
            {
                return MemoryAddress.Get(ref this);
            }

        }

        private record SomeRecord
        {

            public SomeRecord() { }

            public bool SomeMethod() => true;

            public long GetAddress()
            {
                return MemoryAddress.Get(this);
            }

        }

        private record struct SomeRecordStruct
        {

            public SomeRecordStruct() { }

            public bool SomeMethod() => true;

            public long GetAddress()
            {
                return MemoryAddress.Get(ref this);
            }

        }

    }
}
