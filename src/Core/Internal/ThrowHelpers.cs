using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Thermite.Core;

namespace Thermite.Utilities
{
    internal static class ThrowHelpers
    {
        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentException(string? paramName,
            string? message)
        {
            throw new ArgumentException(message, paramName);
        }

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowArgumentOutOfRangeException(string? paramName)
        {
            throw new ArgumentOutOfRangeException(paramName);
        }

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowExternalException(string? message,
            int errorCode)
        {
            throw new ExternalException(message, errorCode);
        }

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidOperationException(string? message)
        {
            throw new InvalidOperationException(message);
        }

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowInvalidUriException(string? paramName,
            Uri location)
        {
            throw new InvalidUriException(paramName, location);
        }

        [DoesNotReturn]
        [MethodImpl(MethodImplOptions.NoInlining)]
        public static void ThrowObjectDisposedException(string? objectName)
        {
            throw new ObjectDisposedException(objectName);
        }
    }
}
