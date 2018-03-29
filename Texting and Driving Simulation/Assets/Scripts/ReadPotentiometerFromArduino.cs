
using UnityEngine;
using System;
using System.Collections;
using System.IO.Ports;

// https://www.alanzucconi.com/2015/10/07/how-to-integrate-arduino-with-unity/

public class ReadPotentiometerFromArduino : MonoBehaviour {
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
        if (!noWheel)
        {
            // Opens the serial port
            stream = new SerialPort(port, baudrate);
            stream.ReadTimeout = 50;
            stream.Open();
            //this.stream.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }
    }

    int lastReading = 0;
	public int ReadFromArduino(int timeout = 0)
    {
        if (noWheel)
        {
            return 1023 / 2;
        }
        stream.ReadTimeout = timeout;
        try
        {
			// Bit banging. If we start adding more pheripherals,
			// we will want to move over to just sending strings for easier parsing.
            //return stream.ReadLine();
			int a =  stream.ReadByte();
			int b = stream.ReadByte();

			lastReading = (b << 8) | a;
            return lastReading;
        }
        catch (TimeoutException)
        {
            return lastReading;
        }
    }

    public void Start()
    {
        Open();
    }

    public void Update()
    {

    }


	public IEnumerator AsynchronousReadFromArduino(Action<int> callback, Action fail = null, float timeout = float.PositiveInfinity)
    {
        DateTime initialTime = DateTime.Now;
        DateTime nowTime;
        TimeSpan diff = default(TimeSpan);

        int value = 0;

        do
        {
            // A single read attempt
            try
            {
				int a =  stream.ReadByte();
				int b = stream.ReadByte();

				value =  (b << 8) | a;
            }
            catch (TimeoutException)
            {
				value = -1;
            }

            if (value != -1)
            {
				callback(value);
                yield return null;
            }
            else
                yield return new WaitForSeconds(0.05f);

            nowTime = DateTime.Now;
            diff = nowTime - initialTime;

        } while (diff.Milliseconds < timeout);

        if (fail != null)
            fail();
        yield return null;
    }

    public void Close()
    {
        stream.Close();
    }
}