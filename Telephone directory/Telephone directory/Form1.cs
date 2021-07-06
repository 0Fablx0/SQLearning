using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_directory
{
    public partial class Form1 : Form
    {
        void TableForm()
        {
            string[] head = new string[]
            {
                "Id",
                "Name",
                "Number",
                "Mail"
            };

            for (int i =0; i < head.Length; i++)
            {
                dataGridView.Rows[0].Cells[i].Value = head[i];
            }

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Refresh_table_button_Click(object sender, EventArgs e)
        {
            
        }
    }
}
