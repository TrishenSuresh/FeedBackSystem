using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class HeaderPlacement : UserControl
    {

        private int _row;
        private readonly int[] _column = {1, 6, 11};
        private int _counter;
        public List<HeaderItem> _headeritems = new List<HeaderItem>();

        public HeaderPlacement()
        {
            _counter = 0;
            _row = 0;
            InitializeComponent();
        }

        public void AddItem(HeaderItem itemType)
        {

            try
            {

                Label title = new Label
                {
                    Text = itemType.Title,
                    Anchor = AnchorStyles.Left,
                    TextAlign = ContentAlignment.MiddleLeft,
                    AutoSize = true,
                };

                HeaderTable.Controls.Add(title, _column[_counter], _row);

            switch (itemType.InputType)
            {
                case "Text":
                    TextBox text = new TextBox
                    {
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                        AutoSize = true,
                        Text = object.ReferenceEquals(itemType.ValueChosen, null) ? itemType.ValueItem[0] : itemType.ValueChosen,
                        Name = itemType.Id
                    };
                    HeaderTable.Controls.Add(text, _column[_counter]+1,_row);
                    HeaderTable.SetColumnSpan(text, 3);
                    break;

                case "List":
                    ComboBox list = new ComboBox
                    {
                        DropDownStyle = ComboBoxStyle.DropDownList,
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                        AutoSize = true,
                        Name = "header" + itemType.Id
                    };

                    foreach (string s in itemType.ValueItem)
                    {
                        list.Items.Add(s);
                    }

                    list.SelectedItem = object.ReferenceEquals(itemType.ValueChosen, null) ? null : itemType.ValueChosen;

                    HeaderTable.Controls.Add(list, _column[_counter] + 1, _row);
                    HeaderTable.SetColumnSpan(list,3);
                    break;

                case "Date":
                    switch (itemType.ValueItem[0])
                    {
                        case "Manual":
                            DateTime time = object.ReferenceEquals(itemType.ValueChosen, null) ? DateTime.Now : DateTime.ParseExact(itemType.ValueChosen, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture) ;
                            //DateTime time = DateTime.Now;

                            DateTimePicker date = new DateTimePicker
                            {
                                Value = time,
                                Format = DateTimePickerFormat.Custom,
                                CustomFormat = @"dd/MM/yyyy",
                                Anchor = AnchorStyles.Left | AnchorStyles.Right,
                                AutoSize = true,
                                Name = "header" + itemType.Id
                            };

                            HeaderTable.Controls.Add(date, _column[_counter] + 1, _row);
                            HeaderTable.SetColumnSpan(date, 3);
                            break;
                        case "Today":
                            Label today = new Label { Text = object.ReferenceEquals(itemType.ValueChosen, null) ? DateTime.Today.ToShortDateString() : itemType.ValueChosen, TextAlign = ContentAlignment.BottomLeft, Anchor = AnchorStyles.Left, AutoSize = true, Name = "header" + itemType.Id };
                            HeaderTable.Controls.Add(today, _column[_counter] + 1, _row);
                            HeaderTable.SetColumnSpan(today, 3);
                            break;
                    }
                    break;

                case "Label":
                case "Query":
                    Label label = new Label {Text = object.ReferenceEquals(itemType.ValueChosen, null) ? itemType.ValueItem[0] : itemType.ValueChosen
                        , TextAlign = ContentAlignment.BottomLeft, Anchor = AnchorStyles.Left, AutoSize = true, Name = "header" + itemType.Id };
                    HeaderTable.Controls.Add(label, _column[_counter] + 1, _row);
                    HeaderTable.SetColumnSpan(label,3);
                    break;
            }

            _headeritems.Add(itemType);

            if (_counter >= 2)
            {
                this.HeaderTable.RowStyles.Add(new RowStyle(SizeType.Absolute,30));
                _counter = 0;
                _row++;
            }
            else
            {
                _counter++;
            }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }
        // end add item
        
        public void ResetTable()
        {
            HeaderTable.Controls.Clear();
            _counter = 0;
            _row = 0;
        }
        

    }
}
