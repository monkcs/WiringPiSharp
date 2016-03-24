// Copyright (c) TRONSoft, Inc. All rights reserved. See License.txt in the project root for license information.

using System.Runtime.InteropServices;

namespace WiringPiSharp
{
    public static class Lcd
    {
        [DllImport("libwiringPi.so", EntryPoint = "lcdHome")]
        public static extern void LcdHome(int fd);

        [DllImport("libwiringPi.so", EntryPoint = "lcdClear")]
        public static extern void LcdClear(int fd);

        [DllImport("libwiringPi.so", EntryPoint = "lcdSendCommand")]
        public static extern void LcdSendCommand(int fd, byte command);

        [DllImport("libwiringPi.so", EntryPoint = "lcdPosition")]
        public static extern void LcdPosition(int fd, int x, int y);

        [DllImport("libwiringPi.so", EntryPoint = "lcdPutchar")]
        public static extern void LcdPutchar(int fd, byte data);

        [DllImport("libwiringPi.so", EntryPoint = "lcdPuts")]
        public static extern void LcdPuts(int fd, string message);

        [DllImport("libwiringPi.so", EntryPoint = "lcdPrintf")]
        public static extern void LcdPrintf(int fd, string message, params object[] args);

        [DllImport("libwiringPi.so", EntryPoint = "lcdInit")]
        public static extern int LcdInit(int rows, int cols, int bits, int rs, int strb, int d0, int d1, int d2, int d3, int d4, int d5, int d6, int d7);
    }
}