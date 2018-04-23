using System.ComponentModel;
using System.Windows.Forms;

namespace Lab06.Forms
{
    internal class FloatTrackBar: TrackBar
    {
        /// <summary>
        /// Минимальное значение.
        /// </summary>
        [
            Browsable(true),
            EditorBrowsable(EditorBrowsableState.Always),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)
        ]
        public double MinFloatValue { get; set; }

        /// <summary>
        /// Максимальное значение.
        /// </summary>
        [
            Browsable(true),
            EditorBrowsable(EditorBrowsableState.Always),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)
        ]
        public double MaxFloatValue { get; set; }

        /// <summary>
        /// Текущее значение (вычисляется).
        /// </summary>
        [
            Browsable(true),
            EditorBrowsable(EditorBrowsableState.Always),
            DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)
        ]
        public double FloatValue
        {
            get => MinFloatValue + (MaxFloatValue - MinFloatValue) * (Value / 100.0);
            set => Value = (int) (value / (MaxFloatValue - MinFloatValue) * 100);
        }
    }
}
