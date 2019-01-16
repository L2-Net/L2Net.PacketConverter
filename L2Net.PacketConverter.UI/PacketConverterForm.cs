using System;
using System.Windows.Forms;
using Convert = L2Net.PacketConverter.Core.Convert;

namespace L2Net.PacketConverter.UI
{
    public partial class PacketConverterForm : Form
    {
        private ConvertMode Mode = ConvertMode.String;
        private RichTextBox LastSender = null;
        public PacketConverterForm()
        {
            InitializeComponent();
            rbtnString.Checked = true;
        }

        private void rtbxHex_KeyUp(object sender, KeyEventArgs e)
        {
            string value = "Cannot convert";
            try
            {
                switch (Mode)
                {
                    case ConvertMode.Byte:
                        value = Convert.FromHexToByte(rtbxHex.Text).ToString();
                        break;
                    case ConvertMode.Int16:
                        value = Convert.FromHexToInt16(rtbxHex.Text).ToString();
                        break;
                    case ConvertMode.Int32:
                        value = Convert.FromHexToInt32(rtbxHex.Text).ToString();
                        break;
                    case ConvertMode.Int64:
                        value = Convert.FromHexToInt64(rtbxHex.Text).ToString();
                        break;
                    case ConvertMode.String:
                        value = Convert.FromHexToString(rtbxHex.Text);
                        break;
                }
            }
            catch (Exception) { }
            finally
            {
                rtbxPlain.Text = value;
            }
            LastSender = sender as RichTextBox;
        }

        private void rtbxPlain_KeyUp(object sender, KeyEventArgs e)
        {
            string value = "Cannot convert";
            try
            {
                switch (Mode)
                {
                    case ConvertMode.Byte:
                        var bytee = GetIntSafe(rtbxPlain.Text, System.Convert.ToByte, byte.MaxValue);
                        value = Convert.FromByteToHex(bytee);
                        break;
                    case ConvertMode.Int16:
                        var int16 = GetIntSafe(rtbxPlain.Text, System.Convert.ToInt16, Int16.MaxValue);
                        value = Convert.FromInt16ToHex(int16);
                        break;
                    case ConvertMode.Int32:
                        var int32 = GetIntSafe(rtbxPlain.Text, System.Convert.ToInt32, int.MaxValue);
                        value = Convert.FromInt32ToHex(int32);
                        break;
                    case ConvertMode.Int64:
                        var int64 = GetIntSafe(rtbxPlain.Text, System.Convert.ToInt64, Int64.MaxValue);
                        value = Convert.FromInt64ToHex(int64);
                        break;
                    case ConvertMode.String:
                        value = Convert.FromStringToHex(rtbxPlain.Text);
                        break;
                }
            }
            catch (Exception) { }
            finally
            {
                rtbxHex.Text = value;
            }
            LastSender = sender as RichTextBox;
        }

        private T GetIntSafe<T>(string text, Func<string, T> fun, T fallback)
        {
            T int16;
            try
            {
                int16 = fun.Invoke(text);
            }
            catch (OverflowException)
            {
                int16 = fallback;
            }
            return int16;
        }

        private void rbtn_CheckedChanged(object sender, EventArgs e)
        {
            switch ((sender as RadioButton).Name)
            {
                case "rbtnByte":
                    Mode = ConvertMode.Byte;
                    break;
                case "rbtnInt16":
                    Mode = ConvertMode.Int16;
                    break;
                case "rbtnInt32":
                    Mode = ConvertMode.Int32;
                    break;
                case "rbtnInt64":
                    Mode = ConvertMode.Int64;
                    break;
                case "rbtnString":
                    Mode = ConvertMode.String;
                    break;

                default:
                    break;
            }

            if (LastSender != null)
            {
                switch (LastSender.Name)
                {
                    case "rtbxHex":
                        rtbxHex_KeyUp(LastSender, null);
                        break;
                    case "rtbxPlain":
                        rtbxPlain_KeyUp(LastSender, null);
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
