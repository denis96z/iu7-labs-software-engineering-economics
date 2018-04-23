using System.Windows.Forms;

namespace Lab06.Forms
{
    internal class FloatTrackBar: TrackBar
    {
        public double MinFloatValue { get; set; }
        public double MaxFloatValue { get; set; }

        public double FloatValue
        {
            get => MinFloatValue + (MaxFloatValue - MinFloatValue) * (Value / 100.0);
            set => Value = (int) (value / (MaxFloatValue - MinFloatValue) * 100);
        }
    }
}
