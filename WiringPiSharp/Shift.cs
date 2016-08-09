// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class Shift
    {
		/// <summary>
		/// Shift out one byte to specified pin
		/// </summary>
		/// <param name="DataPin">Pin to shift data to</param>
		/// <param name="ClockPin">The clock pin</param>
		/// <param name="ShiftOrder">Define the order to shift the byte out</param>
		/// <param name="Data">The data to shift</param>
		public static void ShiftOut(WiringPi.WPiPinout DataPin, WiringPi.WPiPinout ClockPin, WiringPi.ByteOrder ShiftOrder, byte Data)
		{
			ShiftOutRaw (DataPin, ClockPin, ShiftOrder, Data);
		}
        [DllImport("libwiringPi.so", EntryPoint = "shiftOut")]
        static extern void ShiftOutRaw(byte dataPin, byte clockPin, byte order, byte value);

		/// <summary>
		/// Shift in one byte from specified pin
		/// </summary>
		/// <returns>One byte</returns>
		/// <param name="DataPin">Pin to shift data from</param>
		/// <param name="ClockPin">The clock pin</param>
		/// <param name="ShiftOrder">Define the order to shift the byte in</param>
		public static byte ShiftIn(WiringPi.WPiPinout DataPin, WiringPi.WPiPinout ClockPin, WiringPi.ByteOrder ShiftOrder)
		{
			ShiftInRaw (DataPin,ClockPin, ShiftOrder);
		}
        [DllImport("libwiringPi.so", EntryPoint = "shiftIn")]
        static extern byte ShiftInRaw(byte dPin, byte cPin, byte order);
    }
}