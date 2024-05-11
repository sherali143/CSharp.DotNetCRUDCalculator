// NAME: SHER ALI
// ROLL NO: P21-8024
// BCS 4B

using System.Net.NetworkInformation;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Numerics;
using System.Data;
using System.Drawing;
using System.Web;
using System.Windows.Forms;
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        int value1, value2;
        char sign;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        // BUTTON 1
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        // BUTTON 2
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        // BUTTON 3
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        // BUTTON 4
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        // BUTTON 5
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }


        // BUTTON 6
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        // BUTTON 7
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }


        // BUTTON 8
        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        // BUTTON 9
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        // BUTTON 0
        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        // CLEAR BUTTON CODING
        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }


        // ADDITION BUTTON CODING
        private void button4_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '+';
            textBox1.Text = " ";

        }

        // SUBTRACTION BUTTON CODING
        private void button5_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '-';
            textBox1.Text = " ";
        }

        // MULITPLICATION BUTTON CODING
        private void button9_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '*';
            textBox1.Text = " ";
        }

        // DIVISION BUTTON CODING
        private void button13_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '/';
            textBox1.Text = " ";
        }

        // EQUAL BUTTON CODING
        private void button14_Click(object sender, EventArgs e)
        {
            if (sign == '^')
            {
                result = value1 * value1;
                textBox1.Text = result.ToString();
            }

            else if (sign == '√')
            {
                result = Math.Sqrt(value1);
                textBox1.Text = result.ToString();
            }

            else
            {
                value2 = int.Parse(textBox1.Text);
                if (sign == '+')

                {
                    result = value1 + value2;
                    textBox1.Text = result.ToString();

                }

                else if (sign == '-')
                {
                    result = value1 - value2;
                    textBox1.Text = result.ToString();
                }

                else if (sign == '*')
                {
                    result = value1 * value2;
                    textBox1.Text = result.ToString();
                }

                else
                {
                    result = value1 / value2;
                    textBox1.Text = result.ToString();
                }


            }


        }


        // SQUARE BUTTON CODING
        private void button17_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '^';
            textBox1.Text = " ";

        }

        // SQUARE ROOT BUTTON CODING
        private void button18_Click(object sender, EventArgs e)
        {
            value1 = int.Parse(textBox1.Text);
            sign = '√';
            textBox1.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // CREATE BUTTON CODING
        private void button19_Click(object sender, EventArgs e)
        {
            string ConnectionString = "Data Source= DESKTOP-4IP55K1\\SQLEXPRESS;Initial Catalog=CalculatorDB;Integrated Security= True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            int Value1 = value1;
            int Value2 = value2;
            char Sign = sign;
            double Result = result;


            if (sign == '+')
            {
                string query = " INSERT INTO ADDITION (Value1,Sign,Value2,Result)  VALUES ('" + Value1 + "' , '" + Sign + "' , '" + Value2 + "' , '" + Result + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Have Been Created and Added to Database Sucessfully");

            }

            else if (sign == '-')
            {
                string query = " INSERT INTO SUBTRACTION (Value1,Sign,Value2,Result)  VALUES ('" + Value1 + "' , '" + Sign + "' , '" + Value2 + "', '" + Result + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Have Been Created and Added to Database Sucessfully");

            }


            else if (sign == '*')
            {
                string query = " INSERT INTO MULTIPLICATION (Value1,Sign,Value2,Result)  VALUES ('" + Value1 + "' , '" + Sign + "' , '" + Value2 + "', ' " + Result + " ')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Have Been Created and Added to Database Sucessfully");

            }

            else if (sign == '/')
            {
                string query = " INSERT INTO DIVISION (Value1,Sign,Value2,Result)  VALUES ('" + Value1 + "' , '" + Sign + "' , '" + Value2 + "' , ' " + Result + " ')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Have Been Created and Added to Database Sucessfully");

            }

            else if (sign == '^')
            {
                string query = " INSERT INTO SQUARE (Value,Sign,Result)  VALUES ('" + Value1 + "' , '" + Sign + "' , ' " + Result + " ')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Have Been Created and Added to Database Sucessfully");

            }


            else if (sign == '√')
            {
                string query = " INSERT INTO SQUAREROOT (Value,Sign,Result)  VALUES ('" + Value1 + "' , '" + Sign + "', ' " + Result + " ')";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Have Been Created and Added to Database Sucessfully");

            }
            else
            {
                MessageBox.Show("Wait For a While");
            }
            con.Close();
        }
        // DELETE BUTTON CODING
        private void button20_Click(object sender, EventArgs e)
        {

            string message = "Select an operation:\n";
            message += "1. Addition\n";
            message += "2. Subtraction\n";
            message += "3. Division\n";
            message += "4. Multiplication\n";
            message += "5. Square\n";
            message += "6. Square Root\n";

            string operation = Microsoft.VisualBasic.Interaction.InputBox(message + "\nEnter your choice:", "Operation Selection", "");

            String id = Microsoft.VisualBasic.Interaction.InputBox("Enter ID no You want to Delete :", "ID DELETION", "");
            int idnumber = int.Parse(id);

            string ConnectionString = "Data Source= DESKTOP-4IP55K1\\SQLEXPRESS;Initial Catalog=CalculatorDB;Integrated Security= True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            if (int.Parse(operation) == 1)
            {
                string query = "DELETE FROM ADDITION WHERE ID = " + idnumber;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Sucessfully");
            }

            else if (int.Parse(operation) == 2)
            {
                string query = "DELETE FROM SUBTRACTION WHERE ID = " + idnumber;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Sucessfully");

            }

            else if (int.Parse(operation) == 3)
            {
                string query = "DELETE FROM DIVISION WHERE ID = " + idnumber;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Sucessfully");

            }

            else if (int.Parse(operation) == 4)
            {
                string query = "DELETE FROM MULTIPLICATION WHERE ID = " + idnumber;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Sucessfully");

            }

            else if (int.Parse(operation) == 5)
            {
                string query = "DELETE FROM SQUARE WHERE ID = " + idnumber;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Sucessfully");

            }

            else if (int.Parse(operation) == 6)
            {
                string query = "DELETE FROM SQUAREROOT WHERE ID = " + idnumber;
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Deleted Sucessfully");

            }
            else
            {
                MessageBox.Show("Kindly Select the Appropiate Option");
            }
            con.Close();
        }

        // READ BUTTON CODING
        private void button21_Click(object sender, EventArgs e)
        {
            string message = "Enter Option You want To Read the Data \n";

            message += "1. ADDITION\n";
            message += "2. SUBTRACTION\n";
            message += "3. DIVISION\n";
            message += "4. MULTIPLICATION\n";
            message += "5. SQUARE\n";
            message += "6. SQUARE ROOT\n";

            string read = Microsoft.VisualBasic.Interaction.InputBox(message += "Enter Option Which Table Enteries You want to Read", "READ SELECTION \n ");
            int readinput = int.Parse(read);

            string ConnectionString = "Data Source= DESKTOP-4IP55K1\\SQLEXPRESS;Initial Catalog=CalculatorDB;Integrated Security= True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            if (readinput == 1)
            {
                try
                {
                    string query = "SELECT ID, Value1, Sign, Value2, Result FROM ADDITION"; // Select specific columns
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    string output = "ID\tValue1\tSign\tValue2\tResult\n"; // Column headers

                    while (reader.Read())
                    {
                        int id = (int)reader["ID"];
                        int value1 = (int)reader["Value1"];
                        string sign = reader["Sign"].ToString();
                        int value2 = (int)reader["Value2"];
                        double result = (double)reader["Result"];

                        output += $"{id}\t{value1}\t{sign}\t{value2}\t{result}\n"; // Append values
                    }

                    reader.Close();

                    MessageBox.Show(output, "Data from ADDITION table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }
            }
            if (readinput == 2)
            {
                try
                {
                    string query = "SELECT ID, Value1, Sign, Value2, Result FROM SUBTRACTION"; // Select specific columns
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    string output = "ID\tValue1\tSign\tValue2\tResult\n"; // Column headers

                    while (reader.Read())
                    {
                        int id = (int)reader["ID"];
                        int value1 = (int)reader["Value1"];
                        string sign = reader["Sign"].ToString();
                        int value2 = (int)reader["Value2"];
                        double result = (double)reader["Result"];

                        output += $"{id}\t{value1}\t{sign}\t{value2}\t{result}\n"; // Append values
                    }
                    reader.Close();
                    MessageBox.Show(output, "Data from ADDITION table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }
            }

            if (readinput == 3)
            {
                try
                {
                    string query = "SELECT ID, Value1, Sign, Value2, Result FROM DIVISION"; // Select specific columns
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    string output = "ID\tValue1\tSign\tValue2\tResult\n"; // Column headers

                    while (reader.Read())
                    {
                        int id = (int)reader["ID"];
                        int value1 = (int)reader["Value1"];
                        string sign = reader["Sign"].ToString();
                        int value2 = (int)reader["Value2"];
                        double result = (double)reader["Result"];

                        output += $"{id}\t{value1}\t{sign}\t{value2}\t{result}\n"; // Append values
                    }

                    reader.Close();

                    MessageBox.Show(output, "Data from DIVISION table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }
            }

            if (readinput == 4)
            {
                try
                {
                    string query = "SELECT ID, Value1, Sign, Value2, Result FROM MULTIPLICATION"; // Select specific columns
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    string output = "ID\tValue1\tSign\tValue2\tResult\n"; // Column headers

                    while (reader.Read())
                    {
                        int id = (int)reader["ID"];
                        int value1 = (int)reader["Value1"];
                        string sign = reader["Sign"].ToString();
                        int value2 = (int)reader["Value2"];
                        double result = (double)reader["Result"];

                        output += $"{id}\t{value1}\t{sign}\t{value2}\t{result}\n"; // Append values
                    }

                    reader.Close();

                    MessageBox.Show(output, "Data from MULTIPLICATION table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }
            }

            if (readinput == 5)
            {
                try
                {
                    string query = "SELECT ID, Value, Sign, Result FROM SQUARE"; // Select specific columns
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    string output = "ID\tValue\tSign\tResult\n"; // Column headers

                    while (reader.Read())
                    {
                        int id = (int)reader["ID"];
                        int value = (int)reader["Value"];
                        string sign = reader["Sign"].ToString();
                        double result = (double)reader["Result"];

                        output += $"{id}\t{value}\t{sign}\t{result}\n"; // Append values
                    }

                    reader.Close();

                    MessageBox.Show(output, "Data from SQUARE table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }
            }

            if (readinput == 6)
            {
                try
                {
                    string query = "SELECT ID, Value, Sign, Result FROM SQUAREROOT"; // Select specific columns
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    string output = "ID\tValue\tSign\tResult\n"; // Column headers

                    while (reader.Read())
                    {
                        int id = (int)reader["ID"];
                        int value = (int)reader["Value"];
                        string sign = reader["Sign"].ToString();
                        double result = (double)reader["Result"];

                        output += $"{id}\t{value}\t{sign}\t{result}\n"; // Append values
                    }

                    reader.Close();

                    MessageBox.Show(output, "Data from SQUARE ROOT table");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error");
                }
            }
            con.Close();
        }

        // UPDATE BUTTON CODING
        private void button22_Click(object sender, EventArgs e)
        {
            string message = "Enter Option You want To UPDATE the Data \n";

            message += "1. ADDITION\n";
            message += "2. SUBTRACTION\n";
            message += "3. DIVISION\n";
            message += "4. MULTIPLICATION\n";
            message += "5. SQUARE\n";
            message += "6. SQUARE ROOT\n";

            string update = Microsoft.VisualBasic.Interaction.InputBox(message += "Enter Option Which Table Enteries You want tO update", "UPDATE SELECTION \n ");
            int updateoperation = int.Parse(update);

            string ConnectionString = "Data Source= DESKTOP-4IP55K1\\SQLEXPRESS;Initial Catalog=CalculatorDB;Integrated Security= True";
            SqlConnection con = new SqlConnection(ConnectionString);
            con.Open();

            if (updateoperation == 1)
            {

                string updateidnumber = Microsoft.VisualBasic.Interaction.InputBox("Enter ID number You want to Update Entries", "ID NUMBER SELECTION \n");
                string updatevalue1 = Microsoft.VisualBasic.Interaction.InputBox("Enter value 1 for update");
                string updatevalue2 = Microsoft.VisualBasic.Interaction.InputBox("Enter value 2 for update");

                int id = int.Parse(updateidnumber);
                float result = int.Parse(updatevalue1) + int.Parse(updatevalue2);

                string query = "UPDATE ADDITION SET Value1 = @updatevalue1, Value2 = @updatevalue2, Result = @result WHERE ID = @updateidnumber";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@updatevalue1", int.Parse(updatevalue1));
                cmd.Parameters.AddWithValue("@updatevalue2", int.Parse(updatevalue2));
                cmd.Parameters.AddWithValue("@result", result); // Assuming result is a float or double variable
                cmd.Parameters.AddWithValue("@updateidnumber", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("DATA HAVE BEEN UPDATED SUCCESSFULLY !");
            }

            else if (updateoperation == 2)
            {

                string updateidnumber = Microsoft.VisualBasic.Interaction.InputBox("Enter ID number You want to Update Entries");
                string updatevalue1 = Microsoft.VisualBasic.Interaction.InputBox("Enter value 1 for update");
                string updatevalue2 = Microsoft.VisualBasic.Interaction.InputBox("Enter value 2 for update");

                int id = int.Parse(updateidnumber);
                float result = int.Parse(updatevalue1) - int.Parse(updatevalue2);

                string query = "UPDATE SUBTRACTION SET Value1 = @updatevalue1, Value2 = @updatevalue2, Result = @result WHERE ID = @updateidnumber";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@updatevalue1", int.Parse(updatevalue1));
                cmd.Parameters.AddWithValue("@updatevalue2", int.Parse(updatevalue2));
                cmd.Parameters.AddWithValue("@result", result); // Assuming result is a float or double variable
                cmd.Parameters.AddWithValue("@updateidnumber", id);
                cmd.ExecuteNonQuery();
            }

            else if (updateoperation == 3)
            {

                string updateidnumber = Microsoft.VisualBasic.Interaction.InputBox("Enter ID number You want to Update Entries");
                string updatevalue1 = Microsoft.VisualBasic.Interaction.InputBox("Enter value 1 for update");
                string updatevalue2 = Microsoft.VisualBasic.Interaction.InputBox("Enter value 2 for update");

                int id = int.Parse(updateidnumber);
                float result = int.Parse(updatevalue1) / int.Parse(updatevalue2);

                string query = "UPDATE DIVISION SET Value1 = @updatevalue1, Value2 = @updatevalue2, Result = @result WHERE ID = @updateidnumber";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@updatevalue1", int.Parse(updatevalue1));
                cmd.Parameters.AddWithValue("@updatevalue2", int.Parse(updatevalue2));
                cmd.Parameters.AddWithValue("@result", result); // Assuming result is a float or double variable
                cmd.Parameters.AddWithValue("@updateidnumber", id);
                cmd.ExecuteNonQuery();


            }

            else if (updateoperation == 4)
            {

                string updateidnumber = Microsoft.VisualBasic.Interaction.InputBox("Enter ID number You want to Update Entries");
                string updatevalue1 = Microsoft.VisualBasic.Interaction.InputBox("Enter value 1 for update");
                string updatevalue2 = Microsoft.VisualBasic.Interaction.InputBox("Enter value 2 for update");

                int id = int.Parse(updateidnumber);
                float result = int.Parse(updatevalue1) * int.Parse(updatevalue2);

                string query = "UPDATE MULTIPLICATION SET Value1 = @updatevalue1, Value2 = @updatevalue2, Result = @result WHERE ID = @updateidnumber";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@updatevalue1", int.Parse(updatevalue1));
                cmd.Parameters.AddWithValue("@updatevalue2", int.Parse(updatevalue2));
                cmd.Parameters.AddWithValue("@result", result); // Assuming result is a float or double variable
                cmd.Parameters.AddWithValue("@updateidnumber", id);
                cmd.ExecuteNonQuery();

            }
            else if (updateoperation == 5)
            {

                string updateidnumber = Microsoft.VisualBasic.Interaction.InputBox("Enter ID number You want to Update Entries");
                string updatevalue = Microsoft.VisualBasic.Interaction.InputBox("Enter value  for update");


                int id = int.Parse(updateidnumber);
                float result = int.Parse(updatevalue) * int.Parse(updatevalue);

                string query = "UPDATE SQUARE SET Value = @updatevalue, Result = @result WHERE ID = @updateidnumber";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@updatevalue", int.Parse(updatevalue)); ;
                cmd.Parameters.AddWithValue("@result", result); // Assuming result is a float or double variable
                cmd.Parameters.AddWithValue("@updateidnumber", id);
                cmd.ExecuteNonQuery();
            }

            else if (updateoperation == 6)
            {
                string updateidnumber = Microsoft.VisualBasic.Interaction.InputBox("Enter ID number You want to Update Entries");
                string updatevalue = Microsoft.VisualBasic.Interaction.InputBox("Enter value  for update");

                float result = (float)Math.Sqrt(double.Parse(updatevalue));

                string query = "UPDATE SQUAREROOT SET Value = @updatevalue, Result = @result WHERE ID = @updateidnumber";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@updatevalue", int.Parse(updatevalue)); ;
                cmd.Parameters.AddWithValue("@result", result);
                cmd.Parameters.AddWithValue("@updateidnumber", int.Parse(updateidnumber));
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
