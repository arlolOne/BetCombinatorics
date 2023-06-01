using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace BetCombinatorics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void inputBtn_Click(object sender, EventArgs e)
        {
            string inputDirectory = FileTXT.GetDirectory(false);

            try
            {
                FileTXT.CreateReader(inputDirectory);
            }
            catch (Exception)
            {
                MessageBox.Show("Selected directory doesn't exist! Specify the right file.");
                return;
            }

            Field field;
            try
            {
                 field = new Field(FileTXT.Read());
            }
            catch (Exception)
            {
                MessageBox.Show("Input file is invalid!");
                return;
            }

            FileTXT.RemoveReader();
            string outputDirectory = FileTXT.GetDirectory(true);

            try
            {
                FileTXT.CreateWriter(outputDirectory);
            }
            catch (Exception)
            {
                MessageBox.Show("Specify the right file where you want to save the result!");
                return;
            }

            field.GetCombinations();
            FileTXT.RemoveWriter();

            using (StreamReader seqReader = new StreamReader(outputDirectory, Encoding.Default))
            {
                var maxSeq = AuxiliaryClass.GetMaxSequence(seqReader);
                sequenceLength.Text = maxSeq.MaxLength.ToString();
                sequenceContent.Text = maxSeq.FoundChar.ToString();
            }

            using (StreamReader seqCountReader = new StreamReader(outputDirectory, Encoding.Default))
            {
                int seqCount = AuxiliaryClass.GetCountSequences(seqCountReader, Convert.ToInt32(sequenceLength.Text));
                sequenceCount.Text = seqCount.ToString();
            }
        }

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (inputBtn.CanFocus)
            {
                inputBtn.Focus();
            }
        }

        private void sequenceLengthLabel_Click(object sender, EventArgs e)
        {
            sequenceLength.Clear();
        }

        private void sequenceContentLabel_Click(object sender, EventArgs e)
        {
            sequenceContent.Clear();
        }

        private void sequenceCountLabel_Click(object sender, EventArgs e)
        {
            sequenceCount.Clear();
        }
    }
}
