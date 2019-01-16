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
                        value = Convert.FromByteToHex(rtbxPlain.Text);
                        break;
                    case ConvertMode.Int16:
                        value = Convert.FromInt16ToHex(System.Convert.ToInt16(rtbxPlain.Text));
                        break;
                    case ConvertMode.Int32:
                        value = Convert.FromInt32ToHex(System.Convert.ToInt32(rtbxPlain.Text));
                        break;
                    case ConvertMode.Int64:
                        value = Convert.FromInt64ToHex(System.Convert.ToInt64(rtbxPlain.Text));
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
