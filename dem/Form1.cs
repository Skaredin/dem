using dem.Model;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var emp = Entities.GetContext().Client.Where(x => x.Login.Contains(textBox1.Text) && x.Passvord.Contains(textBox2.Text)).ToList();
    
            //Program.client=
            try
            {

                if (textBox1.Text != "" && textBox2.Text != "")
                {


                    if (emp.Count > 0 && emp[0].dolgnost == "Администратор")
                    {
                      
                        Properties.Settings.Default.Id = emp[0].ID;
                        Properties.Settings.Default.Log = emp[0].Login;
                        Properties.Settings.Default.Pass = emp[0].Passvord;
                        Properties.Settings.Default.Positionn = emp[0].dolgnost;
                        Properties.Settings.Default.surname = emp[0].FirstName;
                        Properties.Settings.Default.name = emp[0].LastName;
                        Properties.Settings.Default.name = emp[0].Patronymic;
                        Properties.Settings.Default.Save();
                        Properties.Settings.Default.Reload();
                        textBox1.BackColor = Color.White;
                        textBox2.BackColor = Color.White;
                        textBox1.ForeColor = Color.Green;
                        textBox2.ForeColor = Color.Green;
                        MessageBox.Show("Хорошей работы (Администратор) " + Properties.Settings.Default.surname + " " + Properties.Settings.Default.name + " " + Properties.Settings.Default.Positionn);

                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();

                    }
                    else 
                    {
                        Properties.Settings.Default.Id = emp[0].ID;
                        Properties.Settings.Default.Log = emp[0].Login;
                        Properties.Settings.Default.Pass = emp[0].Passvord;
                        Properties.Settings.Default.Positionn = emp[0].dolgnost;
                        Properties.Settings.Default.surname = emp[0].FirstName;
                        Properties.Settings.Default.name = emp[0].LastName;
                        Properties.Settings.Default.name = emp[0].Patronymic;
                        Properties.Settings.Default.Save();
                        Properties.Settings.Default.Reload();
                        textBox1.BackColor = Color.White;
                        textBox2.BackColor = Color.White;
                        textBox1.ForeColor = Color.Green;
                        textBox2.ForeColor = Color.Green;
                        MessageBox.Show("Хорошей работы ("+Properties.Settings.Default.Positionn+") " + Properties.Settings.Default.surname + " " + Properties.Settings.Default.name + " " );

                        Menu menu = new Menu();
                        menu.Show();
                        this.Hide();

                    }
                   

                }
                else
                {
                    textBox1.BackColor = Color.Red;
                    textBox2.BackColor = Color.Red;
                    MessageBox.Show("Не заполнены поля");
                    textBox1.BackColor = Color.White;
                    textBox2.BackColor = Color.White;

                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
