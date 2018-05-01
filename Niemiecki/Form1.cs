using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Niemiecki
{
    public partial class Form1 : Form
    {
        ItemsToRemove ItemRemove;

        public Form1()
        {
            InitializeComponent();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ItemRemove = new ItemsToRemove(textInsert.Text);
            ItemRemove.RemoveText();

            textInsert.Text = ItemRemove.ToString();
            checkButton.Enabled = true;
            clearButton.Enabled = true;
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            ItemRemove.CheckText(textInsert.Text);
            textInsert.Text = ItemRemove.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ItemRemove = null;
            textInsert.Text = "";
            clearButton.Enabled = false;
            checkButton.Enabled = false;
        }
    }
}
