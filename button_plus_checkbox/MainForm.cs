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
                nameof(Value),
                false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void mButton_Click(object sender, EventArgs e)
        {
            Value += level1.Checked ? 2 : 1;
        }

        private void level1_CheckedChanged(object sender, EventArgs e)
        {
            // Clicking up/down arrows increments 1 or 2
            numericUpDown.Increment = level1.Checked ? 2 : 1;
        }

        int _Value = 0;
        public int Value
        {
            get => _Value;
            set
            {
                if(!Equals(_Value, value))
                {
                    _Value = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
