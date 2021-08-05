using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TestApp
{
    public class ModbusRTUProtocol
    {
        private byte _slaveAddress;
        private byte _function;
        private ushort _startAddress = 0xA441;
        private uint _numberOfPoints = 1;

        private SerialPort _port = new SerialPort();
        private List<Register> _Registers = new List<Register>();

        public ModbusRTUProtocol()
        {
            for (ushort i = 0; i < NumberOfPoints; i++)
            {
                Registers.Add(new Register() {Address = (ushort) (_startAddress + i)});
            }
        }

        /// <summary>
        /// Возвращает и задает адрес устройства
        /// </summary>
        public byte SlaveAddress
        {
            get
            {
                return _slaveAddress;
            }

            set
            {
                _slaveAddress = value;
            }
        }

        /// <summary>
        /// Возвращает и задает функцию операции
        /// </summary>
        public byte Function
        {
            get
            {
                return _function;
            }

            set
            {
                _function = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес регистра
        /// </summary>
        public ushort StartAddress
        {
            get
            {
                return _startAddress;
            }

            set
            {
                _startAddress = value;
            }
        }

        public SerialPort Port
        {
            get
            {
                return _port;
            }

            set
            {
                _port = value;
            }
        }


        /// <summary>
        /// Запуск чтения данных с регистра
        /// </summary>
        public void Start()
        {
            try
            {
                if (Port.IsOpen) 
                {
                    byte[] frame = ReadHoldingRegistersMsg(SlaveAddress, StartAddress, Function, NumberOfPoints);
                    Port.Write(frame, 0, frame.Length);
                    Thread.Sleep(100); // Delay 100ms
                    if (Port.BytesToRead >= 5)
                    {
                        byte[] bufferReceiver = new byte[this.Port.BytesToRead];
                        Port.Read(bufferReceiver, 0, Port.BytesToRead);
                        Port.DiscardInBuffer();

                        // Process data.
                        byte[] data = new byte[bufferReceiver.Length - 5];
                        Array.Copy(bufferReceiver, 3, data, 0, data.Length);
                        UInt16[] result = Word.ByteToUInt16(data);
                        for (int i = 0; i < result.Length; i++)
                        {
                            Registers[i].Value = result[i];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Функция 03 (03hex) Read Holding Registers
        /// Чтение данных со Slave устройства 
        /// </summary>
        /// <param name="slaveAddress">Slave Address</param>
        /// <param name="startAddress">Starting Address</param>
        /// <param name="function">Function</param>
        /// <param name="numberOfPoints">Quantity of inputs</param>
        /// <returns>Byte Array</returns>
        private byte[] ReadHoldingRegistersMsg(byte slaveAddress, ushort startAddress, byte function, uint numberOfPoints)
        {
            byte[] frame = new byte[8];
            frame[0] = slaveAddress;			    // Slave Address
            frame[1] = function;				    // Function             
            frame[2] = (byte)(startAddress >> 8);	// Starting Address High
            frame[3] = (byte)startAddress;		    // Starting Address Low            
            frame[4] = (byte)(numberOfPoints >> 8);	// Quantity of Registers High
            frame[5] = (byte)numberOfPoints;		// Quantity of Registers Low
            byte[] crc = this.CalculateCRC(frame);  // Calculate CRC.
            frame[frame.Length - 2] = crc[0];       // Error Check Low
            frame[frame.Length - 1] = crc[1];       // Error Check High
            return frame;
        }


        /// <summary>
        /// CRC Калькулятор
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private byte[] CalculateCRC(byte[] data)
        {
            ushort CRCFull = 0xFFFF; // Set the 16-bit register (CRC register) = FFFFH.
            char CRCLSB;
            byte[] CRC = new byte[2];
            for (int i = 0; i < (data.Length) - 2; i++)
            {
                CRCFull = (ushort)(CRCFull ^ data[i]); // 

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            CRC[1] = (byte)((CRCFull >> 8) & 0xFF);
            CRC[0] = (byte)(CRCFull & 0xFF);
            return CRC;
        }

        public List<Register> Registers
        {
            get
            {
                return _Registers;
            }

            set
            {
                _Registers = value;
            }
        }

        public uint NumberOfPoints
        {
            get
            {
                return _numberOfPoints;
            }

            set
            {
                _numberOfPoints = value;
            }
        }
    }
}
