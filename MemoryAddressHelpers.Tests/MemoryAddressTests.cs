using FluentAssertions;

namespace MemoryAddressHelpers.Tests
{
    public partial class MemoryAddressTests
    {

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenReferenceTypeIsUsed1()
        {
            var someClass = new SomeClass();
            var longAddress1 = MemoryAddress.Get(someClass);
            var longAddress2 = GetAddressOfParameter2(someClass);

            longAddress1.Should().Be(longAddress2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenReferenceTypeIsUsed2()
        {
            var someClass = new SomeClass();
            var longAddress1 = MemoryAddress.Get(someClass);
            var longAddress2 = GetAddressOfRefParameter2(ref someClass);

            longAddress1.Should().Be(longAddress2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenReferenceTypeIsUsed3()
        {
            var someClass = new SomeClass();
            var longAddress1 = someClass.GetMemoryAddress();
            var longAddress2 = GetAddressOfRefParameter2(ref someClass);

            longAddress1.Should().Be(longAddress2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenReferenceTypeIsUsed4()
        {
            var someClass = new SomeClass();
            long address1 = MemoryAddress.Get(someClass);
            long address2 = someClass.GetAddress();

            address1.Should().Be(address2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenReferenceTypeIsUsed5()
        {
            var someClass = new SomeClass();
            long address1 = someClass.GetMemoryAddress();
            long address2 = someClass.GetAddress();

            address1.Should().Be(address2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenReferenceTypeIsUsed6()
        {
            var someRecord = new SomeRecord();
            var longAddress1 = MemoryAddress.Get(someRecord);
            var longAddress2 = GetAddressOfParameter2(someRecord);

            longAddress1.Should().Be(longAddress2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenReferenceTypeIsUsed7()
        {
            var someRecord = new SomeRecord();
            var longAddress1 = someRecord.GetMemoryAddress();
            var longAddress2 = someRecord.GetAddress();

            longAddress1.Should().Be(longAddress2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenValueTypeIsUsed1()
        {
            var someStruct = new SomeStruct();
            var longAddress1 = MemoryAddress.Get(ref someStruct);
            var longAddress2 = GetAddressOfParameter3(ref someStruct);

            longAddress1.Should().Be(longAddress2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenValueTypeIsUsed2()
        {
            var someStruct = new SomeStruct();
            var longAddress1 = MemoryAddress.Get(ref someStruct);
            var longAddress2 = GetAddressOfRefParameter3(ref someStruct);

            longAddress1.Should().Be(longAddress2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenValueTypeIsUsed3()
        {
            var someValue = 42;
            var longAddress1 = MemoryAddress.Get(ref someValue);
            var longAddress2 = GetAddressOfParameter3(ref someValue);

            longAddress1.Should().Be(longAddress2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenValueTypeIsUsed4()
        {
            var someValue = 42;
            var longAddress1 = MemoryAddress.Get(ref someValue);
            var longAddress3 = GetAddressOfRefParameter3(ref someValue);

            longAddress1.Should().Be(longAddress3);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenValueTypeIsUsed5()
        {
            SomeStruct someStruct = new SomeStruct();
            long address1 = MemoryAddress.Get(ref someStruct);
            long address2 = someStruct.GetAddress();

            address1.Should().Be(address2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenValueTypeIsUsed6()
        {
            SomeStruct someStruct = new SomeStruct();
            long address1 = someStruct.GetMemoryAddress();
            long address2 = someStruct.GetAddress();

            address1.Should().Be(address2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenValueTypeIsUsed7()
        {
            SomeRecordStruct someRecordStruct = new SomeRecordStruct();
            long address1 = MemoryAddress.Get(ref someRecordStruct);
            long address2 = someRecordStruct.GetAddress();

            address1.Should().Be(address2);
        }

        [Fact]
        public void GetAddress_ShouldReturnSameAddress_WhenValueTypeIsUsed8()
        {
            SomeRecordStruct someRecordStruct = new SomeRecordStruct();
            long address1 = someRecordStruct.GetMemoryAddress();
            long address2 = someRecordStruct.GetAddress();

            address1.Should().Be(address2);
        }

    }
}