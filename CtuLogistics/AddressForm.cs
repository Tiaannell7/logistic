using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace CtuLogistics
{
    public partial class AddressForm : Form
    {
        public AddressForm()
        {
            InitializeComponent();
        }

        private void AddressManagement_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        //Exit Form andreturn to home form//
        private void Address_Exit_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm().Show();
        }

        //create the row in the Address Table//
        private void Address_Create_Button_Click(object sender, EventArgs e)
        {
            string sqlText = "SELECT * FROM Address";

            SqlConnection connection = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");

            SqlCommand command = new SqlCommand(sqlText, connection);


            SqlDataAdapter da = new SqlDataAdapter();
            da.InsertCommand = new SqlCommand("INSERT INTO Address VALUES(@ComplexNumber, @ComplexName, @Street, @Surburb, @City, @Province, @Country, @PostalCode)", connection);
            da.InsertCommand.Parameters.Add("@ComplexNumber", SqlDbType.Int).Value = int.Parse(Address_ComplexNumber_TextBox.Text);
            da.InsertCommand.Parameters.Add("@ComplexName", SqlDbType.NVarChar).Value = Address_ComplexName_TextBox.Text;
            da.InsertCommand.Parameters.Add("@Street", SqlDbType.NVarChar).Value = Address_Street_TextBox1.Text;
            da.InsertCommand.Parameters.Add("@Surburb", SqlDbType.NVarChar).Value = Address_Surburb_TextBox.Text;
            da.InsertCommand.Parameters.Add("@City", SqlDbType.NVarChar).Value = Address_City_TextBox.Text;
            da.InsertCommand.Parameters.Add("@Province", SqlDbType.NVarChar).Value = Address_Province_TextBox.Text;
            da.InsertCommand.Parameters.Add("@Country", SqlDbType.NVarChar).Value = Address_Country_TextBox.Text;
            da.InsertCommand.Parameters.Add("@PostalCode", SqlDbType.Int).Value = int.Parse(Address_PostalCode_TextBox.Text);

            connection.Open();
            da.InsertCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Data Successfuly Added");
            this.Hide();
            new AddressForm().Show();


        }

        //Displays the Table in the DataGridView//
        private void Address_Read_Button_Click(object sender, EventArgs e)
        {
            String connectionString = @"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True";

            SqlConnection cnn = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Address;", cnn);

            DataTable data = new DataTable();
            sda.Fill(data);

            address_DataGridView.DataSource = data;

        }

        //Find where the ComplexNumber and ComplexName Match and the updates the Row // 
        private void Address_Update_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");
            SqlCommand cmd;


            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Address", con);

            cmd = new SqlCommand("Update Address set Street='" + Address_Street_TextBox1.Text + "',Surburb ='" + Address_Surburb_TextBox.Text + "',City ='" + Address_City_TextBox.Text
                + "',Province ='" + Address_Province_TextBox.Text + "',Country ='" + Address_Country_TextBox.Text + "',PostalCode ='" + Address_PostalCode_TextBox.Text +
                 "' Where ComplexNumber = '" + Address_ComplexNumber_TextBox.Text + "' AND ComplexName ='" + Address_ComplexName_TextBox.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Updated");

            DataTable data = new DataTable();
            sda.Fill(data);

            address_DataGridView.DataSource = data;

            con.Close();

        }

        //Deletes the row that match what is fill in the two textboxes( ComplexNumber and ComplexName)//
        private void Address_Delete_Button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-02687\SQLEXPRESS;Initial Catalog=DBCCtuLogistics;Integrated Security=True");
            SqlCommand cmd;


            con.Open();

            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM Address", con);

            cmd = new SqlCommand("Delete Address Where ComplexNumber = '" + Address_ComplexNumber_TextBox.Text + "' AND ComplexName ='" + Address_ComplexName_TextBox.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Delete");

            DataTable data = new DataTable();
            sda.Fill(data);

            address_DataGridView.DataSource = data;

            con.Close();

        }

        private void address_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
