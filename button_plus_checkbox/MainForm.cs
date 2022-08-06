using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace button_plus_checkbox
{
    public partial class MainForm : Form , INotifyPropertyChanged
    {
        public MainForm()
        {
            InitializeComponent();
            level1.Appearance = Appearance.Button;
            numericUpDown.DataBindings.Add(
                nameof(NumericUpDown.Value), 
                this, 
                nameof(Moneycount),
                false,
                DataSourceUpdateMode.OnPropertyChanged);
        }
        private void mButton_Click(object sender, EventArgs e)
        {
            Moneycount += level1.Checked ? 2 : 1;
        }
        private void level1_CheckedChanged(object sender, EventArgs e)
        {
            // Clicking up/down arrows increments 1 or 2
            numericUpDown.Increment = level1.Checked ? 2 : 1;
        }
        public int Moneycount
        {
            get => _moneyCount;
            set
            {
                if(!Equals(_moneyCount, value))
                {
                    _moneyCount = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Moneycount)));
                }
            }
        }
        int _moneyCount = 0;
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
