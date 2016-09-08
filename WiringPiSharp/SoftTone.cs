// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class SoftTone
    {
        /// <summary>
        /// Setup the mode of a pin to software created square wave signal
        /// </summary>
        /// <param name="pin">The pin to setup</param>
        public static void Create(WiringPi.WPiPinout pin) { SoftToneCreateRaw((int)pin); }
        [DllImport("libwiringPi.so", EntryPoint = "softToneCreate")]
        static extern int SoftToneCreateRaw(int pi);

        /// <summary>
        /// Update the tone frequency value on the given pin. The tone will be played until you set the frequency to 0.
        /// </summary>
        /// <param name="pin">The pin to setup</param>
        /// <param name="frequency">The tone frequency</param>
        public static void Write(WiringPi.WPiPinout pin, int frequency) { SoftToneWriteRaw((int)pin, frequency); }
        [DllImport("libwiringPi.so", EntryPoint = "softToneWrite")]
        static extern void SoftToneWriteRaw(int pin, int frewq);
    }
}