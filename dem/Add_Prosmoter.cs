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
    public partial class Add_Prosmoter : Form
    {
        public Add_Prosmoter()
        {
            InitializeComponent();
            //Add_Prosmoter add_Prosmoter = new Add_Prosmoter();
            //add_Prosmoter.Show();
        }
        public void Nev()
        {
            clientBindingSource.MoveNext();
            pictureBox1.Image = Image.FromFile(photoPathTextBox.Text.Replace(@" ", @""));


        }
        private void clientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.___DemSkaredinDataSet);

            

        }

        private void Add_Prosmoter_Load(object sender, EventArgs e)
        {
           
          
                // TODO: данная строка кода позволяет загрузить данные в таблицу "___DemSkaredinDataSet.Client". При необходимости она может быть перемещена или удалена.
                this.clientTableAdapter.Fill(this.___DemSkaredinDataSet.Client);
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "C:/Users/Skaredin/source/repos/dem/dem/bin/Debug/Клиенты/|*.jpeg;*.jpg;*.png| All files(*.*) | *.* ";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = new Bitmap(openFile.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nev();
        }
    }
}
