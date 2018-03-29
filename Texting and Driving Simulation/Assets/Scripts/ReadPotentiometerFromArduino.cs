
using UnityEngine;
using System;
using System.Collections;
using System.IO.Ports;

// https://www.alanzucconi.com/2015/10/07/how-to-integrate-arduino-with-unity/

public class ReadPotentiometerFromArduino : MonoBehaviour
{
    /* The serial port where the Arduino is connected. */
    [Tooltip("The serial port where the Arduino is connected")]
    public string port = "COM4";
    /* The baudrate of the serial port. */
    [Tooltip("The baudrate of the serial port")]
    public int baudrate = 9600;
    public bool noWheel;

    private SerialPort stream;

    public void Open()
    {

        // Opens the serial port
        stream = new SerialPort(port, baudrate);
        stream.ReadTimeout = 50;
        stream.Open();
        //this.stream.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

    }

    long lastReadingImpl = 1023 / 2;

    public int GetWheelCurrentValue()
    {
        return (int) System.Threading.Interlocked.Read(ref lastReadingImpl);
        
    }

    public void ReadWheelValueFromSerial(int timeout = 0)
    {
        stream.ReadTimeout = timeout;
        try
        {
            // Bit banging. If we start adding more pheripherals,
            // we will want to move over to just sending strings for easier parsing.
            //return stream.ReadLine();
            int a = stream.ReadByte();
            int b = stream.ReadByte();

            long combined  = (b << 8) | a;
            System.Threading.Interlocked.Exchange(ref lastReadingImpl,combined);
        }
        catch (TimeoutException)
        {
           // on timeout do nothing.
        }
    }

    System.Threading.Thread myThread;
    public void Start()
    {
        if (!noWheel)
        {
            Open();
            myThread =
                new System.Threading.Thread(new System.Threading.ThreadStart(updateReading));
            myThread.Start();
        }
    }

    public void updateReading()
    {
        while (true)
        {
            ReadWheelValueFromSerial(20);
            System.Threading.Thread.Sleep(10);
        }
    }

    public void Update()
    {

    }




    public void Close()
    {
        stream.Close();
    }
}