using Restaurant_Mangement_System.DL;
using System.Drawing;
using System.Windows.Forms;

namespace Restaurant_Mangement_System
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]

        public static string path3 = "Customers.txt";
        public static string path = "Cashiers.txt";
        public static string path1 = "Stock.txt";
        public static string path4 = "Users.txt";
        static void Main()
        {
            CredentialsDL.loadUser(path4);
            ProductsDL.loadStock(path1);
            CashierDL.loadCashier(path);
            CustomerDL.LoadCustomers(path3);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_signup());
        }
        public static void integerValidation(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static void stringValidation(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        public static void resizeGrid(DataGridView grid_Cashiers)
        {

            grid_Cashiers.EnableHeadersVisualStyles = false;
            grid_Cashiers.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            grid_Cashiers.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 23, 40);
            grid_Cashiers.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(127, 67, 47);
            grid_Cashiers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid_Cashiers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_Cashiers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grid_Cashiers.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            grid_Cashiers.DefaultCellStyle.BackColor = Color.FromArgb(26, 23, 40);
            grid_Cashiers.GridColor = Color.FromArgb(18, 18, 32);
            grid_Cashiers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid_Cashiers.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 23, 40);
            grid_Cashiers.RowHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(26, 23, 40);
            grid_Cashiers.RowHeadersDefaultCellStyle.Font = new Font("Segoe UI", 14, FontStyle.Bold);
            grid_Cashiers.DefaultCellStyle.SelectionBackColor = Color.FromArgb(127, 67, 47);
            grid_Cashiers.ColumnHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 10); // Set left padding
            grid_Cashiers.RowHeadersDefaultCellStyle.Padding = new Padding(0, 0, 0, 20); // Set left padding
            grid_Cashiers.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid_Cashiers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            // Stretch the row header cells
            grid_Cashiers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            grid_Cashiers.RowHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.True;

            // Stretch the column header cells
            grid_Cashiers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
    }
}
