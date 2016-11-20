using System;
using System.Drawing;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class HeaderPlacement : UserControl
    {

        private int _row;
        private readonly int[] _column = {1, 6, 11};
        private int _counter;

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


            HeaderTable.Controls.Add(new Label {Text = itemType.Title,Anchor = AnchorStyles.Left, TextAlign = ContentAlignment.MiddleLeft, AutoSize = true}, _column[_counter], _row);

            switch (itemType.InputType)
            {
                case "Text":

                    TextBox text = new TextBox
                    {
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                        AutoSize = true,
                        Text = itemType.ValueItem[0],
                        Name = "header"+itemType.Id
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

                    HeaderTable.Controls.Add(list, _column[_counter] + 1, _row);
                    HeaderTable.SetColumnSpan(list,3);

                    break;
                        /*
                case "Query":

                    ComboBox listQuery = new ComboBox
                    {
                        DropDownStyle = ComboBoxStyle.DropDownList,
                        Anchor = AnchorStyles.Left | AnchorStyles.Right,
                        AutoSize = true,
                        Name = "header" + itemType.Id
                    };


                    foreach (string s in itemType.ValueItem)
                    {
                        listQuery.Items.Add(s);
                    }

                    HeaderTable.Controls.Add(listQuery, _column[_counter] + 1, _row);
                    HeaderTable.SetColumnSpan(listQuery, 3);

                    break;
                    */
                case "Date":

                    DateTime time = DateTime.Now;

                    switch (itemType.ValueItem[0])
                    {
                        case "Review":
                            break;
                        case "Today":
                            time = DateTime.Now;
                            break;
                    }
                        
                        
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
                    HeaderTable.SetColumnSpan(date,3);

                    break;

                case "Label":
                case "Query":
                    Label label = new Label {Text = itemType.ValueItem[0], TextAlign = ContentAlignment.BottomLeft, Anchor = AnchorStyles.Left, AutoSize = true, Name = "header" + itemType.Id };
                    HeaderTable.Controls.Add(label, _column[_counter] + 1, _row);
                    HeaderTable.SetColumnSpan(label,3);

                    break;

            }
            
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


        }// end add item

        public void ResetTable()
        {
            HeaderTable.Controls.Clear();
            _counter = 0;
            _row = 0;
        }
    }
}
