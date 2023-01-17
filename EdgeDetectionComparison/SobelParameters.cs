namespace EdgeDetectionComparison;

public partial class SobelParameters : Form
{
    private Home _home;

    public SobelParameters()
    {
        InitializeComponent();
    }

    public SobelParameters(Home home)
    {
        InitializeComponent();
        _home = home;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (_home == null) return;

        _home.ApplySobel(
            (int) numericXOrder.Value, 
            (int) numericYOrder.Value, 
            (int) numericAperture.Value);
    }
}