// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class WiringPi
    {
        /// <summary>
        /// The mode to assign to pins
        /// </summary>
        public enum PinMode
        {
            /// <summary>
            /// For reciving data
            /// </summary>
            Input = 0,
            /// <summary>
            /// To output data
            /// </summary>
            Output = 1,
            /// <summary>
            /// Pulse width modulation output
            /// </summary>
            PwmOutput = 2,
            GpioClock = 3
        }
        
        /// <summary>
        /// Sets the pull-up or pull-down internal resistor mode on the given pin
        /// </summary>
        public enum PullMode
        {
            /// <summary>
            /// No internal resistor
            /// </summary>
            Off = 0,
            /// <summary>
            /// Sets pull-down resistor
            /// </summary>
            Down = 1,
            /// <summary>
            /// Sets pull-up resistor
            /// </summary>
            Up = 2
        }
        public enum EdgeMode
        {
            IntEdgeSetup = 0,
            IntEdgeFalling = 1,
            IntEdgeRising = 2,
            IntEdgeBoth = 3
        }

        /// <summary>
        /// The Wiring Pi pinout
        /// </summary>
        public enum WPiPinout
        {
            P0 = 0,
            P1 = 1,
            P2 = 2,
            P3 = 3,
            P4 = 4,
            P5 = 5,
            P6 = 6,
            P7 = 7,
            P8 = 8,
            P9 = 9,
            P10 = 10,
            P11 = 11,
            P12 = 12,
            P13 = 13,
            P14 = 14,
            P15 = 15,
            P16 = 16,
            P17 = 17,
            P18 = 18,
            P19 = 19,
            P20 = 20,
            P21 = 21,
            P22 = 22,
            P23 = 23,
            P24 = 24,
            P25 = 25,
            P26 = 26,
            P27 = 27,
            P28 = 28,
            P29 = 29,
        }

        public const int Low = 0;
        public const int High = 1;
        public const int PwmModeMs = 0;
        public const int PwmModeBal = 1;

		/// <summary>
		/// Declare the byte order
		/// </summary>
		public enum ByteOrder
		{
			/// <summary>
			/// Least significant byte first
			/// </summary>
			LsbFirst = 0,
			/// <summary>
			/// Most significant byte first
			/// </summary>
			MsbFirst = 1
		}

        [DllImport("libwiringPi.so", EntryPoint = "piBoardRev")]
        public static extern int PiBoardRev();

        [DllImport("libwiringPi.so", EntryPoint = "wpiPinToGpio")]
        public static extern int WPIPinToGPIO(int wpiPin);

        [DllImport("libwiringPi.so", EntryPoint = "setPadDrive")]
        public static extern void SetPadDrive(int group, int value);

        [DllImport("libwiringPi.so", EntryPoint = "getAlt")]
        public static extern int GetAlt(int pin);

        [DllImport("libwiringPi.so", EntryPoint = "digitalWriteByte")]
        public static extern void DigitalWriteByte(int value);

        [DllImport("libwiringPi.so", EntryPoint = "pwmSetMode")]
        public static extern void PwmSetMode(int mode);

        [DllImport("libwiringPi.so", EntryPoint = "pwmSetRange")]
        public static extern void PwmSetRange(uint range);

        [DllImport("libwiringPi.so", EntryPoint = "pwmSetClock")]
        public static extern void PwmSetClock(int divisor);

        [DllImport("libwiringPi.so", EntryPoint = "gpioClockSet")]
        public static extern void GpioClockSet(int pin, int freq);

        [DllImport("libwiringPi.so", EntryPoint = "piHiPri")]
        public static extern int PiHiPri(int pri);
    }
}