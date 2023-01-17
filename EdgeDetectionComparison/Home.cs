using Emgu.CV;
using Emgu.CV.Structure;

namespace EdgeDetectionComparison;

public partial class Home : Form
{
    private Image<Bgr, byte> _imageInput;

    public Home()
    {
        InitializeComponent();
    }

    private void open_Click(object sender, EventArgs e)
    {
        var openFileDialog = new OpenFileDialog();

        if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            
        _imageInput = new Image<Bgr, byte>(openFileDialog.FileName);
        imageBox1.Image = _imageInput;
    }

    private void exit_Click(object sender, EventArgs e)
    {
        if(MessageBox.Show("Are you sure you want to close?", "System.Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            this.Close();
        }
    }

    private void cannyToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ApplyCanny();
    }

    private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ApplySobel();
    }

    private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ApplyLaplacian();
    }

    private void cannyParametersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var cannyParameters = new CannyParameters(this);
        cannyParameters.StartPosition = FormStartPosition.CenterParent;
        cannyParameters.Show();
    }

    private void sobelParametersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var sobelParameters = new SobelParameters(this);
        sobelParameters.StartPosition = FormStartPosition.CenterParent;
        sobelParameters.Show();
    }

    private void laplacianParametersToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var laplacianParameters = new LaplacianParameters(this);
        laplacianParameters.StartPosition = FormStartPosition.CenterParent;
        laplacianParameters.Show();
    }

    //
    // Summary:
    //     Find the edges on this image and marked them in the returned image.
    //
    // Parameters:
    //   threshhold:
    //     The threshhold to find initial segments of strong edges
    //
    //   threshLink:
    //     The threshold used for edge Linking
    //
    public void ApplyCanny(double threshold = 50.0, double threshLink = 20.0)
    {
        if (_imageInput == null)
        {
            return;
        }

        Image<Gray, byte> imageCanny = new(_imageInput.Width, _imageInput.Height, new Gray(0));
        imageCanny = _imageInput.Canny(threshold, threshLink);
        imageBox1.Image = imageCanny;
    }

    //
    // Summary:
    //     Calculates the image derivative by convolving the image with the appropriate
    //     kernel The Sobel operators combine Gaussian smoothing and differentiation so
    //     the result is more or less robust to the noise. Most often, the function is called
    //     with (xorder=1, yorder=0, aperture_size=3) or (xorder=0, yorder=1, aperture_size=3)
    //     to calculate first x- or y- image derivative.
    //
    // Parameters:
    //   xorder:
    //     Order of the derivative x
    //
    //   yorder:
    //     Order of the derivative y
    //
    //   apertureSize:
    //     Size of the extended Sobel kernel, must be 1, 3, 5 or 7. In all cases except
    //     1, aperture_size xaperture_size separable kernel will be used to calculate the
    //     derivative.
    //
    public void ApplySobel(int xOrder = 1, int yOrder = 1, int apertureSize = 3)
    {
        if (_imageInput == null)
        {
            return;
        }

        var imageGrey = _imageInput.Convert<Gray, byte>();
        Image<Gray, float> imageSobel = new(_imageInput.Width, _imageInput.Height, new Gray(0));

        imageSobel = imageGrey.Sobel(xOrder, yOrder, apertureSize);
        imageBox1.Image = imageSobel.Convert<Gray, byte>();
    }

    //
    // Summary:
    //     Calculates Laplacian of the source image by summing second x- and y- derivatives
    //     calculated using Sobel operator. Specifying aperture_size=1 gives the fastest
    //     variant that is equal to convolving the image with the following kernel: |0 1
    //     0| |1 -4 1| |0 1 0|
    //
    // Parameters:
    //   apertureSize:
    //     Aperture size
    //
    public void ApplyLaplacian(int apertureSize = 3)
    {
        if (_imageInput == null)
        {
            return;
        }

        var imageGrey = _imageInput.Convert<Gray, byte>();
        Image<Gray, float> imageLaplacian = new(_imageInput.Width, _imageInput.Height, new Gray(0));

        imageLaplacian = imageGrey.Laplace(apertureSize);
        imageBox1.Image = imageLaplacian.Convert<Gray, byte>();
    }
}