using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroceryCheckout
{
    public partial class Form1 : Form
    {
        DataTable table;
        List<Double> totalPriceList;
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAllInputField();
        }

        private void ClearAllInputField()
        {
            inputId.Clear();
            inputItem.Clear();
            inputPrice.Clear();
            inputType.Clear();
            inputUnit.Clear();
            statusMsg.Text = "";
        }

        private Boolean formValidation() {
            if (inputId.Text == "" || inputItem.Text == "" || inputPrice.Text == "" || inputType.Text == "" || inputUnit.Text == "")
            {
                return false;
            }
            else {
                return true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            totalPriceList = new List<Double>();
            table.Columns.Add("Id", typeof(String));
            table.Columns.Add("Type", typeof(String));
            table.Columns.Add("Item", typeof(String));
            table.Columns.Add("Unit", typeof(String));
            table.Columns.Add("Price", typeof(String));

            display.DataSource = table;
            totalPrice.Text = $"RM {0}";
            statusMsg.Text = "";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (formValidation())
            {
                String item = inputItem.Text;
                String unit = inputUnit.Text;
                String price = inputPrice.Text;
                table.Rows.Add(inputId.Text, inputType.Text, item, unit, price);
                ClearAllInputField();
                statusMsg.Text = $"Item {item} has been successfully added!";
                statusMsg.ForeColor = System.Drawing.Color.Green;
                Double itemPrice = Double.Parse(unit) * Double.Parse(price);
                totalPriceList.Add(itemPrice);
                updateTotalPrice();
            }
            else {
                statusMsg.Text = $"Please insert value in all the fields.";
                statusMsg.ForeColor = System.Drawing.Color.Red;
            }
            
        }

        private void updateTotalPrice()
        {
            Double priceToDisplay = 0;
            foreach (Double current in totalPriceList)
            {
                priceToDisplay += current;
            }
            totalPrice.Text = $"RM {priceToDisplay}";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            table.Clear();
            statusMsg.Text = $"All items has been cleared from the table.";
            statusMsg.ForeColor = System.Drawing.Color.DarkOrange;
            totalPriceList.Clear();
            totalPrice.Text = $"RM {0}";
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            int index = display.CurrentCell.RowIndex;
            statusMsg.Text = $"The item {table.Rows[index][2].ToString()} has been deleted.";
            Double itemPrice = Double.Parse(table.Rows[index][3].ToString()) * Double.Parse(table.Rows[index][4].ToString());
            table.Rows[index].Delete();
            statusMsg.ForeColor = System.Drawing.Color.DarkOrange;
            totalPriceList.Remove(itemPrice);
            updateTotalPrice();
        }
    }
}
