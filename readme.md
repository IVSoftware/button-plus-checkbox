# Conditional Increment

To make the increment value be 1 or 2, make `Level 1` a `Checkbox` with the _appearance_ of being a `Button` instead. You can do this by setting the `Appearance` property to `Button` in the designer. Here is a simple example where clicking on `mButton` looks at the state of `level1` to determine the correct increment value. At the same time, toggling the state of `level1` sets the `Increment` value of the `NumericUpDown` control so that the Up/Down arrows _also_ use the correct value of 1 or 2.

![checkbox looks like a button](https://github.com/IVSoftware/button-plus-checkbox/blob/master/button_plus_checkbox/ReadMe/screenshot.png)

***
*Example of coding the `MainForm`:*

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


