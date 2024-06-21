using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarApp.CustomControls
{
    public class DataGridViewColorEditingControl : UserControl, IDataGridViewEditingControl
    {
        private ColorDialog colorDialog;
        private DataGridView dataGridView;
        private bool valueChanged = false;
        private int rowIndex;

        public DataGridViewColorEditingControl()
        {
            colorDialog = new ColorDialog();
            this.Click += new EventHandler(OpenColorDialog);
        }

        public Color SelectedColor
        {
            get
            {
                return this.BackColor;
            }
            set
            {
                this.BackColor = value;
                colorDialog.Color = value;
            }
        }

        private void OpenColorDialog(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.SelectedColor = colorDialog.Color;
                valueChanged = true;
                this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
            }
        }

        public object EditingControlFormattedValue
        {
            get
            {
                return ColorTranslator.ToHtml(SelectedColor);
            }
            set
            {
                if (value is string)
                {
                    SelectedColor = ColorTranslator.FromHtml(value.ToString());
                }
            }
        }

        public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
        {
            return EditingControlFormattedValue;
        }

        public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
        {
            this.Font = dataGridViewCellStyle.Font;
            this.BackColor = SelectedColor;
        }

        public int EditingControlRowIndex
        {
            get
            {
                return rowIndex;
            }
            set
            {
                rowIndex = value;
            }
        }

        public bool EditingControlWantsInputKey(Keys keyData, bool dataGridViewWantsInputKey)
        {
            return true;
        }

        public void PrepareEditingControlForEdit(bool selectAll)
        {
        }

        public bool RepositionEditingControlOnValueChange
        {
            get
            {
                return false;
            }
        }

        public DataGridView EditingControlDataGridView
        {
            get
            {
                return dataGridView;
            }
            set
            {
                dataGridView = value;
            }
        }

        public bool EditingControlValueChanged
        {
            get
            {
                return valueChanged;
            }
            set
            {
                valueChanged = value;
            }
        }

        public Cursor EditingPanelCursor
        {
            get
            {
                return base.Cursor;
            }
        }

        protected override void OnClick(EventArgs e)
        {
            // base.OnClick(e);
            OpenColorDialog(this, e);
        }
    }

    public class DataGridViewColorColumn : DataGridViewColumn
    {
        public DataGridViewColorColumn()
            : base(new DataGridViewColorCell())
        {
        }

        public override DataGridViewCell CellTemplate
        {
            get
            {
                return base.CellTemplate;
            }
            set
            {
                if (value != null && !value.GetType().IsAssignableFrom(typeof(DataGridViewColorCell)))
                {
                    throw new InvalidCastException("Must be a DataGridViewColorCell");
                }
                base.CellTemplate = value;
            }
        }
    }

    public class DataGridViewColorCell : DataGridViewTextBoxCell
    {
        public DataGridViewColorCell()
            : base()
        {
            this.Style.Format = "Color";
        }

        public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
        {
            base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
            DataGridViewColorEditingControl ctl = DataGridView.EditingControl as DataGridViewColorEditingControl;
            ctl.SelectedColor = (this.Value == null || this.Value == DBNull.Value) ? Color.Empty : (Color)this.Value;
        }

        public override Type EditType
        {
            get
            {
                return typeof(DataGridViewColorEditingControl);
            }
        }

        public override Type ValueType
        {
            get
            {
                return typeof(Color);
            }
        }

        public override object DefaultNewRowValue
        {
            get
            {
                return Color.Empty;
            }
        }

        protected override void Paint(Graphics graphics, Rectangle clipBounds, Rectangle cellBounds, int rowIndex, DataGridViewElementStates elementState, object value, object formattedValue, string errorText, DataGridViewCellStyle cellStyle, DataGridViewAdvancedBorderStyle advancedBorderStyle, DataGridViewPaintParts paintParts)
        {
            if (value == null || value == DBNull.Value)
            {
                value = Color.Empty;
            }

            Color color = (Color)value;

            // Draw the cell background
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, paintParts & ~DataGridViewPaintParts.ContentForeground);

            // Draw the color rectangle
            using (Brush brush = new SolidBrush(color))
            {
                graphics.FillRectangle(brush, cellBounds.X + 2, cellBounds.Y + 2, cellBounds.Width - 4, cellBounds.Height - 4);
            }

            // Draw the cell border
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState, value, formattedValue, errorText, cellStyle, advancedBorderStyle, DataGridViewPaintParts.Border);
        }
    }
}
