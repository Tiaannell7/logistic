using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CtuLogistics
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        //create the row in the Customer Table//
        private void Customer_Create_Button_Click(object sender, EventArgs e)
        {
            string sqlText = "SELECT * FROM Customer";


            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");

            SqlCommand command = new SqlCommand(sqlText, connection);


            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("INSERT INTO Customer VALUES(@FullName, @ContactNumber, @Email, @AddressID)", connection);
            da.InsertCommand.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = Customer_FullName_TextBox.Text;
            da.InsertCommand.Parameters.Add("@ContactNumber", SqlDbType.BigInt).Value = int.Parse(Customer_ContactNumber_TextBox.Text);
            da.InsertCommand.Parameters.Add("@Email", SqlDbType.NVarChar).Value = Customer_Email_TextBox.Text;
            da.InsertCommand.Parameters.Add("@AddressID", SqlDbType.NVarChar).Value = 1 ;

            connection.Open();
            da.InsertCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Successfuly Added");
            this.Hide();
            new CustomerForm().Show();
        }

        //Displays the Table in the DataGridView//
        private void Customer_Read_Button_Click(object sender, EventArgs e)
        {

            String connectionString = @"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer;", cnn);

            DataTable data = new DataTable();
            sda.Fill(data);

            Customer_DataGridView.DataSource = data;
        }

        //When the exit Button is press//
        private void Customer_Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }


        /*Update the row if the Number that is enter in the Customer_ContactNumber_TextBox
         Match with a number in the table then it will update the row with the new data*/
        private void Customer_Update_Button_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection( @"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");
            SqlCommand cmd;
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer", con);

            cmd = new SqlCommand("Update Customer set FullName='" + Customer_FullName_TextBox.Text + "',Email ='" + Customer_Email_TextBox.Text +
                "' Where ContactNumber = '" + Customer_ContactNumber_TextBox.Text + "'", con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated");

            DataTable data = new DataTable();
            sda.Fill(data);

            Customer_DataGridView.DataSource = data;

            con.Close();
          
        }

        /*Deletes the row if the Number that is enter in the Customer_ContactNumber_TextBox
         Match with a number in the table then it will Delete the row*/
        private void Customer_Delete_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");
            SqlCommand cmd;
            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Customer", con);

            cmd = new SqlCommand("Delete Customer Where ContactNumber = '" + Customer_ContactNumber_TextBox.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Delete");

            DataTable data = new DataTable();
            sda.Fill(data);

            Customer_DataGridView.DataSource = data;

            con.Close();

        }

        private void Customer_FullName_TextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
