﻿// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class SPI
    {
        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSPIGetFd")]
        public static extern int WiringPiPiSPIGetFd(int channel);

        /// <summary>
        /// This performs a simultaneous write/read transaction over the selected SPI bus. Data that was in your buffer is overwritten by data returned from the SPI bus.
        /// </summary>
        /// <param name="channel">The channel to use</param>
        /// <param name="data">Data to send</param>
        /// <param name="lenght">Lenght of data</param>
        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSPIDataRW")]
        public static extern int ReadWrite(int channel, byte[] data, int lenght);

        /// <summary>
        /// Setup a spi channel (0 or 1). Returns a file descriptor
        /// </summary>
        /// <param name="channel">The channel to use</param>
        /// <param name="clockSpeed">Interger in the range 500,000 through 32,000,000. Represent clock speed in Hertz</param>
        [DllImport("libwiringPi.so", EntryPoint = "wiringPiSPISetup")]
        public static extern int Setup(int channel, int clockSpeed);
    }
}
