using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text == "")
            {
                MessageBox.Show("Kérem irja be a nevét a betöltéshez!");
            }
            else
            {
                string fileName = nameTxtBox.Text + ".txt";
                if (File.Exists(fileName))
                {
                    string load = "";
                    string[] lines = File.ReadAllLines(fileName);

                    foreach (var item in lines)
                    {
                        load += item + Environment.NewLine;
                    }

                    MessageBox.Show(load, nameTxtBox.Text, MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("Nincs ilyen fájl!");
                }
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (newhobbiTxtBox.Text != "")
            {
                hobbieListBox.Items.Add(newhobbiTxtBox.Text);
            }
            else
            {
                MessageBox.Show("Kérem irja be a hobbit!");
            }
            newhobbiTxtBox.Clear();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            List<User> user = new List<User>();

            if (nameTxtBox.Text == "" || birthDatePicker.Value.ToString("yyyy-MMMM-dd") == "" || hobbieListBox.Items.Count == 0 || (boyRadioBtn.Checked == false && girlRadioBtn.Checked == false))
            {
                MessageBox.Show("Tölts ki mindent!");
            }
            else
            {
                if (boyRadioBtn.Checked)
                {
                    User x = new User(nameTxtBox.Text, birthDatePicker.Value.ToString("yyyy-MMMM-dd"), true, hobbieListBox);
                    user.Add(x);
                }
                else
                {
                    User x = new User(nameTxtBox.Text, birthDatePicker.Value.ToString("yyyy-MMMM-dd"), false, hobbieListBox);
                    user.Add(x);
                }

                string line = "";
                foreach (var item in hobbieListBox.Items)
                {
                    line += item + ", ";
                }



                if (MessageBox.Show("Biztos szeretné menteni?", "Mentés", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    string fileName = nameTxtBox.Text + ".txt";
                    if (string.IsNullOrWhiteSpace(fileName) || fileName == ".txt")
                    {
                        throw new IOException("Fájl létrehozásakor érvénytelen fájlnév!\n");
                    }
                    else
                    {
                        if (!File.Exists(fileName))
                        {
                            if (boyRadioBtn.Checked)
                            {
                                File.WriteAllText(fileName, "Név : " + nameTxtBox.Text + Environment.NewLine + "Születési év : " + birthDatePicker.Value.ToString("yyyy-MMMM-dd") + Environment.NewLine + "Nem : Férfi " + Environment.NewLine + "Hobbik : " + line);
                            }
                            else
                            {
                                File.WriteAllText(fileName, "Név : " + nameTxtBox.Text + Environment.NewLine + "Születési év : " + birthDatePicker.Value.ToString("yyyy-MMMM-dd") + Environment.NewLine + "Nem : Nő " + Environment.NewLine + "Hobbik : " + line);
                            }
                        }
                        else
                        {
                            File.AppendAllText(fileName, "" + line);
                        }
                    }
                    nameTxtBox.Clear();
                    birthDatePicker.ResetText();
                    boyRadioBtn.Checked = false;
                    girlRadioBtn.Checked = false;
                    hobbieListBox.Items.Clear();
                    newhobbiTxtBox.Clear();
                    MessageBox.Show("Sikeres Mentés!");
                }
            }
        }

        private void newhobbiTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                addBtn.PerformClick();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            hobbieListBox.Items.Remove(hobbieListBox.SelectedItem);
        }

        private void hobbieListBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteBtn.PerformClick();
            }
        }
    }
}
