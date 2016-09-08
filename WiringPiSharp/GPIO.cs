//Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class GPIO
    {
        /// <summary>
        /// Setup the mode of a pin to either Input, Output, Pwm output or Gpio clock
        /// Note that only wiringPi pin 1 (BCM_GPIO 18) supports PWM output and only wiringPi pin 7 (BCM_GPIO 4) supports CLOCK output modes
        /// </summary>
        /// <param name="pin">The pin to setup</param>
        /// <param name="mode">The mode to assign the pin</param>
        public static void PinMode(WiringPi.WPiPinout pin, WiringPi.PinMode mode) { PinMode((int)pin, (int)mode); }
        [DllImport("libwiringPi.so", EntryPoint = "pinMode")]
        static extern void PinMode(int pin, int mode);

        /// <summary>
        /// Setup the pull-up or pull-down internal resistor mode on the given pin, which should be set as an input
        /// </summary>
        /// <param name="pin">The pin to setup</param>
        /// <param name="mode">The mode to assign the input pin</param>
        public static void PullUpDnControl(WiringPi.WPiPinout pin, WiringPi.PullMode mode) { PullUpDnControl((int)pin, (int)mode); }
        [DllImport("libwiringPi.so", EntryPoint = "pullUpDnControl")]
        static extern void PullUpDnControl(int pin, int mode);

        /// <summary>
        /// Returns the value of the pin. Returns true for high
        /// </summary>
        /// <param name="pin">The pin to read the value of</param>
        /// <returns>Returns true for high</returns>
        public static bool DigitalRead(WiringPi.WPiPinout pin) { return Convert.ToBoolean(DigitalReadRaw((int)pin)); }
        [DllImport("libwiringPi.so", EntryPoint = "digitalRead")]
        static extern int DigitalReadRaw(int pin);

        /// <summary>
        /// Writes the value high or low to the given pin. True value for high
        /// </summary>
        /// <param name="pin"></param>
        /// <param name="value"></param>
        public static void DigitalWrite(WiringPi.WPiPinout pin, bool value) { DigitalWrite((int)pin, Convert.ToInt32(value)); }
        [DllImport("libwiringPi.so", EntryPoint = "digitalWrite")]
        static extern void DigitalWrite(int pin, int value);

        /// <summary>
        /// Writes the value to the PWM register for the given pin. The Raspberry Pi has one on-board PWM pin, pin 1 (BMC_GPIO 18, Phys 12)
        /// </summary>
        /// <param name="pin">The pin to use for PWM</param>
        /// <param name="value">Range is 0-1024</param>
        public static void PwmWrite(WiringPi.WPiPinout pin, int value) {PwmWrite((int)pin,value); }
        [DllImport("libwiringPi.so", EntryPoint = "pwmWrite")]
        static extern void PwmWrite(int pin, int value);

        /// <summary>
        /// Returns the analog value of the pin
        /// </summary>
        /// <param name="pin">The pin to read the value of</param>
        /// <returns></returns>
        public static int AnalogRead(WiringPi.WPiPinout pin) { return AnalogRead((int)pin); }
        [DllImport("libwiringPi.so", EntryPoint = "analogRead")]
        static extern int AnalogRead(int pin);

        /// <summary>
        /// Writes the analog value to the given pin
        /// </summary>
        /// <param name="pin"></param>
        /// <param name="value"></param>
        public static void AnalogWrite(WiringPi.WPiPinout pin, int value) { AnalogWrite((int)pin, value); }
        [DllImport("libwiringPi.so", EntryPoint = "analogWrite")]
        static extern void AnalogWrite(int pin, int value);
    }
}
