using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19013888_PROG7312_Task1
{
    public partial class Replacing_Books : Form
    {

        SortClass sc = new SortClass();//calls sort class
        Random rnd = new Random();
        char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToArray();//random letter array
        string output;

        void generate()
        {
            //randomly generated call numebrs and sets values to listbox 1
            string result = "";
            output = null;
            int num1 = rnd.Next(0, 999);
            int num2 = rnd.Next(0, 99);

            for (int i = 0; i < 3; i++)
            {
                output += letters[rnd.Next(0, letters.Length)];
            }

            result = result = num1.ToString() + "." + num2.ToString() + " " + output;
            RandomOrder.Items.Add(result);           
           
        }

        public Replacing_Books()
        {
            InitializeComponent();
        }
     

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home(); // Instantiate a h object.
            h.ShowDialog(); // Show replacing books 
            this.Close(); // closes this instance.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Allows user to move a selected call number up
            int index = RandomOrder.SelectedIndex;
            string ListBoxItemText = RandomOrder.SelectedItem.ToString();
            if (index > 0)
            {
                RandomOrder.Items.RemoveAt(index);
                RandomOrder.Items.Insert(index - 1, ListBoxItemText);
                RandomOrder.SetSelected(index - 1, true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Allows user to move a selected call number up
            int index = RandomOrder.SelectedIndex;
            string ListBoxItemText = RandomOrder.SelectedItem.ToString();
            if (index < RandomOrder.Items.Count-1)
            {
                RandomOrder.Items.RemoveAt(index);
                RandomOrder.Items.Insert(index + 1, ListBoxItemText);
                RandomOrder.SetSelected(index + 1, true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //clears list boxes and displays randomly generated call numbers
            RandomOrder.Items.Clear();
            CorrectOrder.Items.Clear();
            CorrectOrder.Visible = false;
            CorrectOrderDescription.Visible = false;
            for (int i = 0; i < 10; i++)
            {
                generate();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

            //sc.bubblesort(sort);

            //for (int i = 0; i < 10; i++)
            //{
            //    listBox2.Items.Add(sort[i]);
            //}

            //for (int i = 0; i < 5; i++)
            //    sort.SetValue(i, i);
            //var li = new List<string>((string[])sort);
            //List<string> list = listBox2.Items.OfType<string>().ToList();
            //li = li.OrderBy(n => n).ToList();

          
            
            ArrayList list = new ArrayList();
            ArrayList list2 = new ArrayList();
            foreach (var item in RandomOrder.Items) // collects users sorted call numbers from listbox1
            {
                list.Add(item);
            }
            list.Sort();


            CorrectOrder.Items.Clear();
            foreach (var item in list)//displays sorted items in listbox2 to compare
            {
                CorrectOrder.Items.Add(item);
            }

            CorrectOrderDescription.Visible = true;
            CorrectOrder.Visible = true;

            string message = "Congratulations on completing your first sort challange!" + "\n" + "Please check alongside if your sort is correct!";//gamification feature, trophy and achievement earned
            string title = "Badge earned: First steps!";
            MessageBox.Show(message, title);

            //foreach (var item in list2)
            //{
            //    if (list == list2)
            //    {
            //        string message = "You have correctly ordered the call Numbers in Ascending Order!";
            //        string title = "WELL DONE! Trophy Achieved!";
            //        MessageBox.Show(message, title);
            //    }
            //    string error = "You have failed to ccorrectly order the call Numbers in Ascending Order! Please try again!";
            //    string header = "SORRY!";
            //    MessageBox.Show(error, header);
            //}
        }
    }
}
