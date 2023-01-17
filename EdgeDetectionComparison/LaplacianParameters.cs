namespace EdgeDetectionComparison;

public partial class LaplacianParameters : Form
{
    private Home _home;

    public LaplacianParameters()
    {
        InitializeComponent();
    }

    public LaplacianParameters(Home home)
    {
        InitializeComponent();
        this._home = home;
    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (_home == null) return;

        _home.ApplyLaplacian((int) numericAperture.Value);
    }
}