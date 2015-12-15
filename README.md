WiringPiSharp
=============

A nice little C# wrapper library for .Net of Gordon's [WiringPi](http://wiringpi.com "WiringPi homepage") library.
It take advantage of strongly-typed enum for pin and value input, to prevent error. It is in its initial stages but it works! 🙂

Getting Started
---------------

####1. Get Gordon's C library
   Get it from http://wiringpi.com/download-and-install/.
   All neccesary installation and build steps are described over there, but for short:

   To get the source:
```bash
git clone git://git.drogon.net/wiringPi
```
   To build the C library:
```bash
cd wiringPi
./build
```
   
   That will produce a library file called **libwiringPi.so.x.x**, where **x.x** are the version number for the library.
   All refrences in *WiringPiSharp* are to __*libwiringPi.so*__, so to make the wrapper work you have to remove the version number in the filename.

####2. Download or clone this wrapper
   When you have the code, compile it using your favor of C# complier. After that it is only left for you to reference it in your project.
   
####3. Test it out!
   Here are a small example of the WiringPi and the WiringPiSharp in action
   
```C#
using System.Threading;
using WiringPiSharp;
using static WiringPiSharp.WiringPi;

class Program
{
    public static void Main()
    {
        Setup.WiringPiPiSetupGpio();
        GPIO.PinMode(WPiPinout.P14, PinMode.Output);
        while (true)
        {
            GPIO.DigitalWrite(WPiPinout.P14, true);
            Thread.Sleep(1000);
            GPIO.DigitalWrite(WPiPinout.P14, false);
            Thread.Sleep(1000);
        }
    }
}
   ```


> Just make sure that __*WiringPiSharp.dll*__ and __*libwiringPi.so*__ are in the same folder as your program when you run it on the Raspberry Pi
   
#####*Good luck creating some awesome creations!* 😄

All praise should really go to Gordon@drogon for his great library which exposes all the required interfaces making my life and others that much easier. Cheers Gordon!!
