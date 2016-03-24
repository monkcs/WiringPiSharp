// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class SPI
    {
        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSPIGetFd")]
        public static extern int WiringPiPiSPIGetFd(int channel);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSPIDataRW")]
		public static extern int WiringPiPiSPIDataRW(int channel, byte data, int lenght);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSPISetup")]
        public static extern int WiringPiPiSPISetup(int channel, int speed);
		public static void test(){
			WiringPiPiSPIDataRW (0, 0, 1);
		}
    }
}