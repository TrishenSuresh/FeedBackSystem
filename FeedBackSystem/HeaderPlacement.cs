﻿using System;
using System.Windows.Forms;

namespace FeedBackSystem
{
    public partial class HeaderPlacement : UserControl
    {

        private int _row;
        private readonly int[] _column = { 1, 6, 11 };
        private int _counter;

        public HeaderPlacement()
        {
            _counter = 0;
            _row = 0;
            InitializeComponent();
        }

        public void AddItem(HeaderItem itemType)
        {

            RowStyle style = new RowStyle { SizeType = SizeType.AutoSize };

            HeaderTable.Controls.Add(new Label {Text = itemType.Title,Anchor = AnchorStyles.Left}, _column[_counter], _row);

            switch (itemType.InputType)
            {
                case "Text":
                    
                    TextBox text = new TextBox { Anchor = AnchorStyles.Left | AnchorStyles.Right};
                    HeaderTable.Controls.Add(text, _column[_counter]+1,_row);
                    HeaderTable.SetColumnSpan(text, 3);
                    break;

                case "List":

                    ComboBox list = new ComboBox
                    {
                        DropDownStyle = ComboBoxStyle.DropDownList,
                        Anchor = AnchorStyles.Left | AnchorStyles.Right
                    };

                    foreach (string s in itemType.ValueItem)
                    {
                        list.Items.Add(s);
                    }

                    HeaderTable.Controls.Add(list, _column[_counter] + 1, _row);
                    HeaderTable.SetColumnSpan(list,3);

                    break;

                case "Query":

                    ComboBox listQuery = new ComboBox
                    {
                        DropDownStyle = ComboBoxStyle.DropDownList,
                        Anchor = AnchorStyles.Left | AnchorStyles.Right
                    };


                    foreach (string s in itemType.ValueItem)
                    {
                        listQuery.Items.Add(s);
                    }

                    HeaderTable.Controls.Add(listQuery, _column[_counter] + 1, _row);
                    HeaderTable.SetColumnSpan(listQuery, 3);

                    break;

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
                        Anchor = AnchorStyles.Left | AnchorStyles.Right
                    };

                    HeaderTable.Controls.Add(date, _column[_counter] + 1, _row);
                    HeaderTable.SetColumnSpan(date,3);

                    break;

                case "Label":

                    Label label = new Label {Anchor = AnchorStyles.Left};
                    HeaderTable.Controls.Add(label, _column[_counter] + 1, _row);
                    HeaderTable.SetColumnSpan(label,3);

                    break;
            }
            
            if (_counter >= 2)
            {
                _counter = 0;
                HeaderTable.RowStyles.Add(style);
                
                _row++;
            }
            else
            {
                _counter++;
            }

            
        }
    }
}
