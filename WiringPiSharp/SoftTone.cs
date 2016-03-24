// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class SoftTone
    {
        [DllImport("libwiringPi.so", EntryPoint = "softToneCreate")]
        public static extern int SoftToneCreate(int pi);

        [DllImport("libwiringPi.so", EntryPoint = "softToneWrite")]
        public static extern void SoftToneWrite(int pin, int frewq);
    }
}