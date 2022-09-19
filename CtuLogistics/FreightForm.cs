using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CtuLogistics
{
    public partial class FreightForm : Form
    {
        public FreightForm()
        {
            InitializeComponent();
        }

        //Add the data from textboxes into the table Freight in SQL//
        private void Freight_Create_Button_Click(object sender, EventArgs e)
        {
            string sqlText = "SELECT * FROM Freight";

            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");

            SqlCommand command = new SqlCommand(sqlText, connection);


            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("INSERT INTO Freight VALUES(@CustomerID, @Height, @Weight, @Length, @DestinationAddressID, @OriginAddressID, @Status, @Date)", connection);
            da.InsertCommand.Parameters.Add("@CustomerID", SqlDbType.Int).Value = int.Parse(Freight_CustomerNumber_TextBox.Text);
            da.InsertCommand.Parameters.Add("@Height", SqlDbType.Float).Value = float.Parse(Freight_Height_TextBox.Text);
            da.InsertCommand.Parameters.Add("@Weight", SqlDbType.Float).Value = float.Parse(Freight_Weight_TextBox.Text);
            da.InsertCommand.Parameters.Add("@Length", SqlDbType.Float).Value = float.Parse(Freight_Length_TextBox.Text);
            da.InsertCommand.Parameters.Add("@DestinationAddressID", SqlDbType.Int).Value = int.Parse(Freight_Destination_TextBox.Text);
            da.InsertCommand.Parameters.Add("@OriginAddressID", SqlDbType.Int).Value = int.Parse(Freight_OriginAddress_TextBox.Text);
            da.InsertCommand.Parameters.Add("@Status", SqlDbType.NVarChar).Value = Freight_Status_ComboBox.Text;
            da.InsertCommand.Parameters.Add("@Date", SqlDbType.Date).Value = FreigthDate_DateTimePicker.Text;

            connection.Open();
            da.InsertCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Successfuly Added");
            this.Hide();
            new FreightForm().Show();
        }

        //Display the table//
        private void Freight_Read_Button_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Freight;", cnn);

            DataTable data = new DataTable();
            sda.Fill(data);

            Freight_DataGridView.DataSource = data;

        }

        /*Update the row if the CustomerID that is enter in the Freight_CustomerNumber_TextBox
        Match with a CustomerID in the table then it will update the row with the new data*/
        private void Freight_Update_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");
            SqlCommand cmd;


            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Freight", con);

            cmd = new SqlCommand("Update Freight set Height='" + Freight_Height_TextBox.Text + "',Weight ='" + Freight_Weight_TextBox.Text + "',Length ='" + Freight_Length_TextBox.Text
                + "',DestinationAddressID ='" + Freight_Destination_TextBox.Text + "',OriginAddressID ='" + Freight_OriginAddress_TextBox.Text + "',Status ='" + Freight_Status_ComboBox.Text +
                 "' Where CustomerID = '" + Freight_CustomerNumber_TextBox.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated");

            DataTable data = new DataTable();
            sda.Fill(data);

            Freight_DataGridView.DataSource = data;

            con.Close();
        }

        /*Deletes the row if the CustomerID that is enter in the Freight_CustomerNumber_TextBox
        Match with a CustomerID in the table then it will Delete the row*/
        private void Freight_Delete_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");
            SqlCommand cmd;


            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Freight", con);

            cmd = new SqlCommand("Delete Freight Where CustomerID = '" + Freight_CustomerNumber_TextBox.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Delete");

            DataTable data = new DataTable();
            sda.Fill(data);

            Freight_DataGridView.DataSource = data;

            con.Close();
        }

        //Exits and return to the home form//
        private void Freight_Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }
    }
}
