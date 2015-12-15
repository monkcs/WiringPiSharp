﻿// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class Timing
    {
        [DllImport("libwiringPi.so", EntryPoint = "delay")]
        public static extern void Delay(uint howLong);

        [DllImport("libwiringPi.so", EntryPoint = "delayMicroseconds")]
        public static extern void DelayMicroseconds(uint howLong);

        [DllImport("libwiringPi.so", EntryPoint = "millis")]
        public static extern uint Millis();

        [DllImport("libwiringPi.so", EntryPoint = "micros")]
        public static extern uint Micros();
    }
}