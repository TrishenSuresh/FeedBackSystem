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

        public void AddItem(UserControl itemType)
        {
            var userControlType = itemType;
             
            HeaderTable.Controls.Add(userControlType, _column[_counter], _row);
            HeaderTable.SetColumnSpan(userControlType, 4);
            
            if (_counter >= 2)
            {
                _counter = 0;
                _row++;
            }
            else
            {
                _counter++;
            }

            
        }
    }
}
