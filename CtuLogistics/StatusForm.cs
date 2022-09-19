using System;
using System.IO;
using System.Windows.Forms;

namespace CtuLogistics
{
    public partial class StatusForm : Form
    {
        public StatusForm()
        {
            InitializeComponent();
        }

        //This will create and fill in the data from the textboxes into the txt file//
        private void Status_Create_Button_Click(object sender, EventArgs e)
        {

            string filePath = @"C:\Users\nellt\Documents\Work\2nd year\PRG521\Summitive\status.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine("-----------------------------------------------------------------------------");
                writer.WriteLine("StatusID : " + Status_ID_Textbox.Text.ToString());
                writer.WriteLine("DriverID: " + Status_DriverID_Textbox.Text.ToString());
                writer.WriteLine("Picked Up: " + Status_PickedUp_DateTimePicker.Text.ToString());
                writer.WriteLine("Deliverd: " + Status_Delivered_DateTimePicker.Text.ToString());
            }

        }

        //when the button is click it will diplay the text file in richtextboxs
        private void Status_Read_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string s = File.ReadAllText(ofd.FileName);
                Status_RichTextBox.Text = s;
            }

        }

        // when the  update buton is press it will update and save the changes made it the text document 
        private void Status_Update_Button_Click(object sender, EventArgs e)
        {

            TextWriter txt = new StreamWriter(@"C:\Users\nellt\Documents\Work\2nd year\PRG521\Summitive\status.txt");
            txt.Write(Status_RichTextBox.Text);
            txt.Close();

        }


        //when the button is press it will delete everything and ask you to save the txt file 
        private void Status_Delete_Button_Click(object sender, EventArgs e)
        {
            Status_RichTextBox.Clear();

            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

                    myStream.Close();
                }

            }
        }

        //Exit and reeturns to the home form//
        private void Status_Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }
    }
}
