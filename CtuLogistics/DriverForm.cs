using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CtuLogistics
{
    public partial class DriverForm : Form
    {
        public DriverForm()
        {
            InitializeComponent();
        }


        //To add yes or no when the radio buttons are pressed//
        public string Owner = string.Empty;

        //Add the data from textboxes into the table Freight in SQL//
        private void Driver_Create_Button_Click(object sender, EventArgs e)
        {
            string sqlText = "SELECT * FROM Driver";


            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");

            SqlCommand command = new SqlCommand(sqlText, connection);


            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("INSERT INTO Driver VALUES(@FullName, @LicenseType, @Owner)", connection);
            da.InsertCommand.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = Driver_FullName_TextBox.Text;
            da.InsertCommand.Parameters.Add("@LicenseType", SqlDbType.NVarChar).Value = Driver_LicenseType_ComboBox.Text;
            da.InsertCommand.Parameters.AddWithValue("@Owner", SqlDbType.NVarChar).Value = Owner;


            connection.Open();
            da.InsertCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Successfuly Added");
            this.Hide();
            new DriverForm().Show();
        }

        //Display the table in the DataGridView//
        private void Driver_Read_Button_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Driver;", cnn);

            DataTable data = new DataTable();
            sda.Fill(data);

            Driver_DataGridView.DataSource = data;
        }

        /*Update the row if the Fullname that is enter in the Driver_FullName_TextBox
       Match with a Fullname in the table then it will update the row with the new data*/
        private void Driver_Update_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");
            SqlCommand cmd;


            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Driver", con);

            cmd = new SqlCommand("Update Driver set LicenseType='" + Driver_LicenseType_ComboBox.Text + "', Owner ='" + Owner +
                "' Where Fullname = '" + Driver_FullName_TextBox.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated");

            DataTable data = new DataTable();
            sda.Fill(data);

            Driver_DataGridView.DataSource = data;

            con.Close();
        }

        /*Deletes the row where the Fullname that is enter in the Driver_FullName_TextBox
        Match with a Fullname in the table then it will Delete the row*/

        private void Driver_Delete_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");
            SqlCommand cmd;


            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Driver", con);

            cmd = new SqlCommand("Delete Driver Where Fullname = '" + Driver_FullName_TextBox.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Delete");

            DataTable data = new DataTable();
            sda.Fill(data);

            Driver_DataGridView.DataSource = data;

            con.Close();
        }

        //Exit and return to the Home Form//
        private void Driver_Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }

        //Displays Yes in the Table when the yes radio button is pressed
        private void Driver_Owner_Yes_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Owner = "Yes";

        }

        //Displays NO in the Table when the No radio button is pressed
        private void Driver_Owner_No_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Owner = "No";
        }

    }
}
