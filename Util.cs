using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yolo_Demo
{
    public partial class Form1 : Form
    {
        public string ByteArrayToString(byte[] ba)
        {
            try
            {
                StringBuilder hex = new StringBuilder(ba.Length * 2);
                foreach (byte b in ba)
                    hex.AppendFormat("{0:x2}", b);
                return hex.ToString();
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
                return null;
            }
        }


        /*
         * C-의 __FUNC__를 구현하기 위한 API
         */
        public string CallerName([CallerMemberName] string callerName = "")
        {
            return callerName;
        }

        /*
         * delay 를 주기 위한 API
         */
        public DateTime Delay(int ms)
        {
            try
            {
                DateTime CurrentTime = DateTime.Now;
                TimeSpan span = new TimeSpan(0, 0, 0, 0, ms);
                DateTime EndTime = CurrentTime.Add(span);
                while (EndTime >= CurrentTime)
                {
                    System.Windows.Forms.Application.DoEvents();
                    CurrentTime = DateTime.Now;
                }
                return DateTime.Now;
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
                return DateTime.Now;
            }
        }

        /*
         * UInt32 형식의 값을 hex string 값으로 변환한다
         * 변환시 앞에 0x가 붙어서 리턴된다
         */
        public string Uint32ToHexString(UInt32 intVal)
        {
            /*
             * X1 : 한 자리수
             * X2 : 두 자리수
             * X3 : 세 자리수
             */
            try
            {
                return ("0x" + intVal.ToString("X2"));
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
                return null;
            }
        }

        /*
         * Get 4byte UInt32 from byte array from given index number to index + 3 LSB
         */
        public UInt32 Get4LSB(byte[] data, byte startIdx)
        {
            UInt32 ret = 0;

            try
            {
                ret = (UInt32)(data[startIdx] | data[startIdx + 1] << 8 | data[startIdx + 2] << 16 | data[startIdx + 3] << 24);
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
            return ret;
        }

        public UInt32 Get4LSB(byte[] data, int startIdx)
        {
            UInt32 ret = 0;

            try
            {
                ret = (UInt32)(data[startIdx] | data[startIdx + 1] << 8 | data[startIdx + 2] << 16 | data[startIdx + 3] << 24);
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
            return ret;
        }

        public UInt32 Get4LSB(List<byte> data, byte startIdx)
        {
            UInt32 ret = 0;

            try
            {
                ret = (UInt32)(data[startIdx] | data[startIdx + 1] << 8 | data[startIdx + 2] << 16 | data[startIdx + 3] << 24);
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
            return ret;
        }

        /*
         * Get 4byte UInt32 from byte array from given index number to index + 3 MSB
         */
        public UInt32 Get4MSB(byte[] data, byte startIdx)
        {
            UInt32 ret = 0;

            try
            {
                ret = (UInt32)(data[startIdx] << 24 | data[startIdx + 1] << 16 | data[startIdx + 2] << 8 | data[startIdx + 3]);
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
            return ret;
        }

        public UInt32 Get4MSB(List<byte> data, byte startIdx)
        {
            UInt32 ret = 0;

            try
            {
                ret = (UInt32)(data[startIdx] << 24 | data[startIdx + 1] << 16 | data[startIdx + 2] << 8 | data[startIdx + 3]);
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
            return ret;
        }

        /*
         * 하나의 Hex string 을 byte 로 변환.
         * Hex string 을 입력 받아 hex 값으로 처리하고자 할때 사용
         */
        public byte HexStr2Byte(string str)
        {
            byte val = 0;
            try
            {
                val = Convert.ToByte(str, 16);
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
            return val;
        }

        /*
         * IEEE 754 format
         */
        public string IEE754_FloatToHexString(float f)
        {
            var bytes = BitConverter.GetBytes(f);
            var i = BitConverter.ToInt32(bytes, 0);
            return "0x" + i.ToString("X4");
        }

        public float IEE754_HexStringToFloat(string s)
        {
            var i = Convert.ToInt32(s, 16);
            var bytes = BitConverter.GetBytes(i);
            return BitConverter.ToSingle(bytes, 0);
        }

        /*
         * Moving Average
         */
        public double[] Get_MovingAverage(int frameSize, double[] data)
        {
            double[] avgPoints = null;

            try
            {
                double sum = 0;
                avgPoints = new double[data.Length];

                for (int counter = 0; counter <= data.Length - frameSize; counter++)
                {
                    int innerLoopCounter = 0;
                    int index = counter;
                    while (innerLoopCounter < frameSize)
                    {
                        sum = sum + data[index];
                        innerLoopCounter += 1;
                        index += 1;
                    }

                    avgPoints[counter] = sum / frameSize;

                    sum = 0;
                }
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
            return avgPoints;
        }

        public double[] SMA(double[] samples, int blockSize)
        {
            double[] means = new double[samples.Length];
            int i = 0, j = 0, start = 0;
            try
            {
                for (i = 1; i <= samples.Length; i++)
                {
                    start = (i < blockSize) ? 0 : i - blockSize;
                    double[] m = new double[i - start];
                    for (j = 0; j < m.Length; j++)
                    {
                        m[j] = samples[start + j];
                    }
                    means[i - 1] = m.Average();
                }
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
            return means;
        }

        public double[] ExpAvg(double[] samples, double w)
        {
            double[] means = new double[samples.Length];

            try
            {
                means[0] = samples[0];
                for (int i = 1; i < samples.Length; i++)
                {
                    means[i] = w * samples[i] + (1 - w) * means[i - 1];
                }
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }

            return means;
        }

        public UInt16 getU16(byte[] bBuf, int offset)
        {
            UInt16 ret = 0;
            try
            {
                ret = (UInt16)(bBuf[offset + 1] << 8 | bBuf[offset]);
            }
            catch(Exception ex)
            {
                ERR(ex.Message);
            }
            return ret;
        }

        public UInt32 getU32(byte[] bBuf, int offset)
        {
            UInt32 ret = 0;
            try
            {
                ret = (UInt32)(bBuf[offset + 3] << 24 | bBuf[offset + 2] << 16 | bBuf[offset + 1] << 8 | bBuf[offset]);
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
            return ret;
        }

        public float getFloat(byte[] bBuf, int offset)
        {
            float ret = 0;
            try
            {
                ret = BitConverter.ToSingle(bBuf, offset);
            }
            catch (Exception ex)
            {
                ERR(ex.Message);
            }
            return ret;
        }
    }
}
