// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class Interrupts
    {
        [DllImport("libwiringPi.so", EntryPoint = "waitForInterrupt")]
        public static extern int waitForInterrupt(int pin, int timeout);

        public static int WiringPiISR(int pin, WiringPi.EdgeMode mode, Action method) { return WiringPiPiISR(pin, (int)mode, method); }
        [DllImport("libwiringPi.so", EntryPoint = "wiringPiISR")]
        static extern int WiringPiPiISR(int pin, int mode, Action method);
    }
}