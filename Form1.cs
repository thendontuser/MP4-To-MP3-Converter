namespace MP4_To_MP3_Converter
{
    public partial class Form1 : Form
    {
        private string Input;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Input = string.Empty;
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "(*.MP4)|*.MP4";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Input = openFileDialog.FileName;
                FileNameTextBox.Text = Input;
            }
        }

        private void ConvertSaveBtn_Click(object sender, EventArgs e)
        {
            if (string.Equals(Input, string.Empty))
            {
                MessageBox.Show("The input file is not selected");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            if (MP3RadioBtn.Checked)
            {
                saveFileDialog.Filter = "(*.MP3)|*.MP3";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Converter.MP4ToMP3(Input, saveFileDialog.FileName);
                }
            }
            else if (WavRadioBtn.Checked)
            {
                saveFileDialog.Filter = "(*.WAV)|*.WAV";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Converter.MP4ToWav(Input, saveFileDialog.FileName);
                }
            }
            else
            {
                MessageBox.Show("The output file is not selected");
                return;
            }
        }
    }
}