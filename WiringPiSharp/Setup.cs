// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class Setup
    {
        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSetup")]
        public static extern int WiringPiPiSetup();

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSetupSys")]
        public static extern int WiringPiPiSetupSys();

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSetupGpio")]
        public static extern int WiringPiPiSetupGpio();

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSetupPhys")]
        public static extern int WiringPiPiSetupPhys();

        [DllImport("libwiringPi.so", EntryPoint = "piFaceSetup")]
        public static extern int PiFaceSetup(int pinbase);
    }
}