﻿
namespace Maui.GoogleMaps
{
    public sealed class Geocoder
    {
        internal static Func<string, Task<IEnumerable<Position>>> GetPositionsForAddressAsyncFunc;

        internal static Func<Position, Task<IEnumerable<string>>> GetAddressesForPositionFuncAsync;

        public Task<IEnumerable<string>> GetAddressesForPositionAsync(Position position)
        {
            if (GetAddressesForPositionFuncAsync == null)
                throw new InvalidOperationException("You MUST call Xamarin.FormsGoogleMaps.Init (); prior to using it.");
            return GetAddressesForPositionFuncAsync(position);
        }

        public Task<IEnumerable<Position>> GetPositionsForAddressAsync(string address)
        {
            if (GetPositionsForAddressAsyncFunc == null)
                throw new InvalidOperationException("You MUST call Xamarin.FormsGoogleMaps.Init (); prior to using it.");
            return GetPositionsForAddressAsyncFunc(address);
        }
    }
}