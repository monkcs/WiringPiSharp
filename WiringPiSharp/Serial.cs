// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class Serial
    {
        /// <summary>
        /// Open a serial connection, returns the device as a file descriptor
        /// </summary>
        /// <param name="device">The serial device</param>
        /// <param name="baud">The baud rate</param>
        [DllImport("libwiringPi.so", EntryPoint = "serialOpen")]
        public static extern int SerialOpen(string device, int baud);

        /// <summary>
        /// Closing the serial connection
        /// </summary>
        /// <param name="fileDescriptor">The serial device</param>
        [DllImport("libwiringPi.so", EntryPoint = "serialClose")]
        public static extern void SerialClose(int fileDescriptor);

        /// <summary>
        /// Discards all data received, or data waiting to be send down the given device
        /// </summary>
        /// <param name="fileDescriptor">The serial device</param>
        [DllImport("libwiringPi.so", EntryPoint = "serialFlush")]
        public static extern void SerialFlush(int fileDescriptor);

        /// <summary>
        /// Send data to serial device
        /// </summary>
        /// <param name="fileDescriptor">The serial device</param>
        /// <param name="data">The data to send</param>
        [DllImport("libwiringPi.so", EntryPoint = "serialPutchar")]
        public static extern void SerialWrite(int fileDescriptor, byte data);

        /// <summary>
        /// Send data to serial device
        /// </summary>
        /// <param name="fileDescriptor">The serial device</param>
        /// <param name="data">The data to send</param>
        [DllImport("libwiringPi.so", EntryPoint = "serialPuts")]
        public static extern void SerialPuts(int fileDescriptor, string data);


        [DllImport("libwiringPi.so", EntryPoint = "serialPrintf")]
        public static extern void SerialPrintf(int fileDescriptor, string message, params object[] args);

        ///<summary>
        /// Returns the number of characters available for reading, or -1 for any error condition, in which case errno will be set appropriately.
        ///</summary>
        ///<param name="fileDescriptor">The serial device</param>
        [DllImport("libwiringPi.so", EntryPoint = "serialDataAvail")]
        public static extern int SerialDataAvailble(int fileDescriptor);

        ///<summary>
        /// Returns the next character available on the serial device. This call will block for up to 10 seconds if no data is available (when it will return -1)
        ///</summary>
        ///<param name="fileDescriptor">The serial device</param>
        [DllImport("libwiringPi.so", EntryPoint = "serialGetchar")]
        public static extern int SerialGetchar(int fileDescriptor);

        public static int[] SerialRead(int fileDescriptor)
        {
            int counter = SerialDataAvailble(fileDescriptor);
            int[] data = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                data[i] = SerialGetchar(fileDescriptor);
            }
            return data;
        }
    }
}