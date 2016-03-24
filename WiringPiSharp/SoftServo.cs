// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class SoftServo
    {
        [DllImport("libwiringPi.so", EntryPoint = "softServoWrite")]
        public static extern void SoftServoWrite(int pin, int value);

        [DllImport("libwiringPi.so", EntryPoint = "softServoSetup")]
        public static extern int SoftServoSetup(int p0, int p1, int p2, int p3, int p4, int p5, int p6, int p7);
    }
}