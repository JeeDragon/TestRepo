using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Adds items to the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddToDo(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox1.Text != String.Empty)
            {
                checkedListBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
                checkedListBox1.Refresh();
            }

        }

        /// <summary>
        /// When the user presses the enter button it sends the item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EnterKeyPressedEvent(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (int)Keys.Enter)
            {
                e.Handled = true;
                AddToDo(sender, e);
            }
        }

        /// <summary>
        /// Deletes an item from the check box list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int index = checkedListBox1.SelectedIndex;

            if(index != -1)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
                checkedListBox1.Refresh();
            }
            else
            {

            }

        }

        private void ItemCheckEvent(object sender, ItemCheckEventArgs e)
        {
            // CALCULATE THE PROGRESS BAR STEP
            progressBar.Step = progressBar.Maximum / checkedListBox1.Items.Count;

            CheckState i = e.CurrentValue;

            if(e.CurrentValue == CheckState.Unchecked)
            {
                e.NewValue = CheckState.Checked;

                progressBar.PerformStep();
            }
            else
            {
                progressBar.Increment(-progressBar.Step);
            }
        }

        private void ClockClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
