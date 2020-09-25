using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dem
{
    public partial class TableClient : Form
    {
        public TableClient()
        {
            InitializeComponent();
        }

        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___DemSkaredinDataSet);

        }

        private void TableClient_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___DemSkaredinDataSet.Gender". При необходимости она может быть перемещена или удалена.
            this.genderTableAdapter.Fill(this.___DemSkaredinDataSet.Gender);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "___DemSkaredinDataSet.Client". При необходимости она может быть перемещена или удалена.
            this.clientTableAdapter.Fill(this.___DemSkaredinDataSet.Client);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                Add_Prosmoter add_Prosmoter = new Add_Prosmoter();
                add_Prosmoter.Show();
                this.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tr = "FirstName like'*" + textBox1.Text + "*' or LastName like'*" + textBox1.Text + "*' or Patronymic like'*" + textBox1.Text+"'";
            clientBindingSource.Filter =tr;
        }
    }
}
