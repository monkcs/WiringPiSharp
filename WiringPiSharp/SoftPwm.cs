// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class SoftPwm
    {
		/// <summary>
		/// Setup a pin for software pwm
		/// </summary>
		/// <param name="pin">The pin to setup</param>
		/// <param name="value"></param>
		/// <param name="range"></param>
		public static void SoftPwmCreate(WiringPi.WPiPinout pin, int value, int range) { SoftPwmCreate ((int)pin, value, range);}
        [DllImport("libwiringPi.so", EntryPoint = "softPwmCreate")]
        static extern int SoftPwmCreate(int pin, int value, int range);

		/// <summary>
		/// Change the value of the pwm pin
		/// </summary>
		/// <param name="pin">The pin to change</param>
		/// <param name="value"></param>
		public static void SoftPwmWrite(WiringPi.WPiPinout pin, int value) { SoftPwmWrite((int)pin, value);}
        [DllImport("libwiringPi.so", EntryPoint = "softPwmWrite")]
        static extern void SoftPwmWrite(int pin, int value);
    }
}