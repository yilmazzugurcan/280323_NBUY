using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _280323_NBUY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] sinemalar = new string[] { "Gerçek Cinler 2", "Demon Slayer 2", "Özel Bir Hediye", "Motelde Katliam", "John Wick 4", "Creed 3" };
            comboBox1.Items.AddRange(sinemalar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox2.Text;
            string selectedItems = "";
            int hesap = 0;

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    selectedItems += checkedListBox1.Items[i].ToString() + "\n";
                }
                if (selectedItems == "")
                {
                    selectedItems = "Müşteri Ürün Almadı.";
                }

            }
            if (comboBox1.SelectedIndex != -1)
            {
                hesap += 50;
            }

            if (checkedListBox1.GetItemChecked(0))
            {
                hesap += 30;
            }
            if (checkedListBox1.GetItemChecked(1))
            {
                hesap += 20;
            }

            if (checkedListBox1.GetItemChecked(2))
            {
                hesap += 25;
            }

            if (checkedListBox1.GetItemChecked(3))
            {
                hesap += 25;
            }

            MessageBox.Show(ad+" "+soyad+"\n"+"Sinema Seçimi:"+comboBox1.SelectedItem+"\n"+"Ürün Tercihi:"+selectedItems+"\n"+"Tutar:"+hesap+"TL");
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.SelectedIndex = -1;
            checkedListBox1.SelectedItems.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                string firstChar = textBox1.Text.Substring(0, 1);
                string restChars = textBox1.Text.Substring(1).ToLower();
                textBox1.Text = firstChar.ToUpper() + restChars;
                textBox1.Select(textBox1.Text.Length, 0);
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text)) 
            { 
            string firstChar1 = textBox2.Text.Substring(0, 1);
            string restChars = textBox2.Text.Substring(1).ToLower();
            textBox2.Text = firstChar1.ToUpper() + restChars;
            textBox2.Select(textBox1.Text.Length, 0);
            }
        }
    }
}
