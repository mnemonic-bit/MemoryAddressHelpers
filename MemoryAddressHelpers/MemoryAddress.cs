using System.Runtime.InteropServices;

namespace MemoryAddressHelpers
{
    public static class MemoryAddress
    {

        /// <summary>
        /// This represents the address for null.
        /// </summary>
        public const long NullAddress = 0;


        /// <summary>
        /// Returns the address of the given instance as a long integer.
        /// </summary>
        /// <param name="obj">The instance we want an address for.</param>
        /// <returns>Returns a long integer value representing the memory address of the instance.</returns>
        public static unsafe long Get(object? obj)
        {
            if (obj == null)
            {
                return NullAddress;
            }

            GCHandle handle = GCHandle.Alloc(obj, GCHandleType.Pinned);

            try
            {
                IntPtr address = handle.AddrOfPinnedObject();
                return address.ToInt64();
            }
            catch (Exception)
            {
                return NullAddress;
            }
            finally
            {
                handle.Free();
            }
        }

        /// <summary>
        /// Returns the address of the given instance as a long integer.
        /// </summary>
        /// <param name="obj">The instance we want an address for.</param>
        /// <returns>Returns a long integer value representing the memory address of the instance.</returns>
        public static long GetMemoryAddress(this object? obj)
        {
            return Get(obj);
        }

        /// <summary>
        /// Returns the memory address of the given value type.
        /// </summary>
        /// <typeparam name="T">The type of the value type.</typeparam>
        /// <param name="value">The value, passed by-ref.</param>
        /// <returns>Returns a long integer value representing the memory address of the value.</returns>
        public static unsafe long Get<T>(ref T value)
            where T : struct
        {
#pragma warning disable CS8500
            fixed (T* ptr = &value)
#pragma warning restore CS8500
            {
                return (long)ptr;
            }
        }

        /// <summary>
        /// Returns the memory address of the given value type.
        /// </summary>
        /// <typeparam name="T">The type of the value type.</typeparam>
        /// <param name="value">The value, passed by-ref.</param>
        /// <returns>Returns a long integer value representing the memory address of the value.</returns>
        public static long GetMemoryAddress<T>(this ref T value)
            where T : struct
        {
            return Get(ref value);
        }


        static MemoryAddress()
        {
#if !DEBUG
    throw new InvalidOperationException("This package is intended for debug use only. Please do not use any of the results returned by any of this methods in your code, and refain from deploying it to production.");
#endif
        }

    }
}
