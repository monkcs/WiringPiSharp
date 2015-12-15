// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class I2C
    {
        [DllImport("libwiringPi.so", EntryPoint = "wiringPiI2CSetupInterface")]
        public static extern int WiringPiPiI2CSetupInterface(string device, int devId);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiI2CSetup")]
        public static extern int WiringPiPiI2CSetup(int devId);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiI2CRead")]
        public static extern int WiringPiPiI2CRead(int fd);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiI2CReadReg8")]
        public static extern int WiringPiPiI2CReadReg8(int fd, int reg);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiI2CReadReg16")]
        public static extern int WiringPiPiI2CReadReg16(int fd, int reg);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiI2CWrite")]
        public static extern int WiringPiPiI2CWrite(int fd, int data);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiI2CWriteReg8")]
        public static extern int WiringPiPiI2CWriteReg8(int fd, int reg, int data);

        [DllImport("libwiringPi.so", EntryPoint = "wiringPiI2CWriteReg16")]
        public static extern int WiringPiPiI2CWriteReg16(int fd, int reg, int data);
    }
}