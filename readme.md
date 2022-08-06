# Conditional Increment

Instead of `Level 1` being an actual `Button`, it might be useful to make it a `Checkbox` instead, and then make it _look_ like a button by setting the `Appearance` property to `Button` in the designer. Here is a simple example where clicking on `mButton` looks at the state of `level1` to determine the correct increment value. At the same time, toggling the state of `level1` sets the `Increment` value of the `NumericUpDown` control so that the Up/Down arrows _also_ use the correct value of 1 or 2.

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




