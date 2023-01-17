using Emgu.CV;
using Emgu.CV.Structure;



namespace EdgeDetectionComparison
{
    public partial class Home : Form
    {
        Image<Bgr, byte> _imageInput;
        public Home()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _imageInput = new Image<Bgr, byte>(ofd.FileName);
                imageBox1.Image = _imageInput;
            }
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


        private void sobelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplySobel();
        }

        public void ApplySobel(int xOrder = 1, int yOrder = 1, int apertureSize = 3)
        {
            if (_imageInput == null)
            {
                return;
            }

            Image<Gray, byte> imageGrey = _imageInput.Convert<Gray, byte>();
            Image<Gray, float> imageSobel = new(_imageInput.Width, _imageInput.Height, new Gray(0));

            imageSobel = imageGrey.Sobel(xOrder, yOrder, apertureSize);
            imageBox1.Image = imageSobel.Convert<Gray, byte>();
        }

        private void laplacianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApplyLaplacian();
        }

        public void ApplyLaplacian(int appertureSize = 3)
        {
            if (_imageInput == null)
            {
                return;
            }

            Image<Gray, byte> imageGrey = _imageInput.Convert<Gray, byte>();
            Image<Gray, float> imageLaplacian = new(_imageInput.Width, _imageInput.Height, new Gray(0));

            imageLaplacian = imageGrey.Laplace(appertureSize);
            imageBox1.Image = imageLaplacian.Convert<Gray, byte>();
        }

        private void cannyParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CannyParameters cannyParameters = new CannyParameters(this);
            cannyParameters.StartPosition = FormStartPosition.CenterParent;
            cannyParameters.Show();
        }

        private void sobelParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SobelParameters sobelParameters = new SobelParameters(this);
            sobelParameters.StartPosition = FormStartPosition.CenterParent;
            sobelParameters.Show();
        }

        private void laplacianParametersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaplacianParameters laplacianParameters = new LaplacianParameters(this);
            laplacianParameters.StartPosition = FormStartPosition.CenterParent;
            laplacianParameters.Show();
        }
    }
}
