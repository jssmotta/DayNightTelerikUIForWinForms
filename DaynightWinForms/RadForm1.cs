using System.Collections.Generic;
using System.Windows.Forms;
using Telerik.WinControls.UI;
namespace TelerikWinFormsApp1
{
    public partial class RadForm1 : RadForm
    {
      
        public RadForm1()
        {
            InitializeComponent();

            Text = "My Application - Sales";
            
            var grid = new RadGridView();
            grid.Dock = DockStyle.Fill;
            var textColumn = new GridViewTextBoxColumn();
            textColumn.HeaderText = "Name";
            textColumn.FieldName = "Name";
            textColumn.Width = 200;
            grid.Columns.Add(textColumn);

            var sales = new GridViewTextBoxColumn();
            sales.HeaderText = "Sales";
            sales.FieldName = "Sales";
            sales.Width = 200;
            grid.Columns.Add(sales);

            grid.AllowAddNewRow = false;
            grid.DataSource = new List<Countries>() { new("Brazil", "US$ 500,000.00"), new("Bulgary", "US$ 1,000,000.00"), new("United States", "US$ 400,000.00"), new("Canada", "US$ 100,000.00"), new("England", "US$ 700,000.00") };

            grid.AllowAutoSizeColumns = true;

            Controls.Add(grid);

            _ = new DayNight(this);
        }

    }
    public class Countries
    {
        public Countries(string name, string sales)
        {
            Name = name;
            Sales = sales;
        }

        public string Name { get; set; }
        public string Sales { get; set; }
    }
}
