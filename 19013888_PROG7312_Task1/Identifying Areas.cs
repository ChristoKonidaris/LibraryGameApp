using System;
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
    public partial class Identifying_Areas : Form
    {
        public Identifying_Areas()
        {
            InitializeComponent();
        }

         void Start2()
        {
            //initialize randomizer 
            Random random = new Random();

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary for storing and displaying categories
            dictionary.Add(000, "Genral Knowlege");
            dictionary.Add(100, "Philosophy & Psycology");
            dictionary.Add(200, "Religion");
            dictionary.Add(300, "Social Sciences");
            dictionary.Add(400, "Languages");
            dictionary.Add(500, "Science");
            dictionary.Add(600, "Technology");
            dictionary.Add(700, "Arts & Recriation");
            dictionary.Add(800, "Litrature");
            dictionary.Add(900, "History and Geography");

            Dictionary<String, string> dictionary2 = new Dictionary<string, string>();
            //dictionary2 for storing and  displaying call numbers
            dictionary2.Add("Genral Knowlege", "000");
            dictionary2.Add("Philosophy & Psycology", "100");
            dictionary2.Add("Religion", "200");
            dictionary2.Add("Social Sciences", "300");
            dictionary2.Add("Languages", "400");
            dictionary2.Add("Science", "500");
            dictionary2.Add("Technology", "600");
            dictionary2.Add("Arts & Recriation", "700");
            dictionary2.Add("Litrature", "800");
            dictionary2.Add("History and Geography", "900");

            //Generating Column B Categories

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnB1.Text = (dictionary[pair.Key]);

            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnB2.Text = (dictionary[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB2.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary.Count);
                        KeyValuePair<int, string> pair1 = dictionary.ElementAt(index1);
                        ColumnB2.Text = (dictionary[pair1.Key]);
                    }
                }

            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnB3.Text = (dictionary[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB3.Text.Equals(ColumnB2.Text) || ColumnB3.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary.Count);
                        KeyValuePair<int, string> pair1 = dictionary.ElementAt(index1);
                        ColumnB3.Text = (dictionary[pair1.Key]);
                    }
                }
            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnB4.Text = (dictionary[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB4.Text.Equals(ColumnB3.Text) || ColumnB4.Text.Equals(ColumnB2.Text) || ColumnB4.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary.Count);
                        KeyValuePair<int, string> pair1 = dictionary.ElementAt(index1);
                        ColumnB4.Text = (dictionary[pair1.Key]);
                    }
                }
            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnB5.Text = (dictionary[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB5.Text.Equals(ColumnB4.Text) || ColumnB5.Text.Equals(ColumnB3.Text) || ColumnB5.Text.Equals(ColumnB2.Text) || ColumnB5.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary.Count);
                        KeyValuePair<int, string> pair1 = dictionary.ElementAt(index1);
                        ColumnB5.Text = (dictionary[pair1.Key]);
                    }
                }

            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnB6.Text = (dictionary[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB6.Text.Equals(ColumnB5.Text) || ColumnB6.Text.Equals(ColumnB4.Text) || ColumnB6.Text.Equals(ColumnB3.Text) || ColumnB6.Text.Equals(ColumnB2.Text) || ColumnB6.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary.Count);
                        KeyValuePair<int, string> pair1 = dictionary.ElementAt(index1);
                        ColumnB6.Text = (dictionary[pair1.Key]);
                    }
                }

            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnB7.Text = (dictionary[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB7.Text.Equals(ColumnB6.Text) || ColumnB7.Text.Equals(ColumnB5.Text) || ColumnB7.Text.Equals(ColumnB4.Text) || ColumnB7.Text.Equals(ColumnB3.Text) || ColumnB7.Text.Equals(ColumnB2.Text) || ColumnB7.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary.Count);
                        KeyValuePair<int, string> pair1 = dictionary.ElementAt(index1);
                        ColumnB7.Text = (dictionary[pair1.Key]);
                    }

                }

            }

            //Generating Column A call numbers

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<string, string> pair = dictionary2.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnA1.Text = (dictionary2[pair.Key]);

            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<string, string> pair = dictionary2.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnA2.Text = (dictionary2[pair.Key]);

                //Ensures Column A values dont match eachother, making each value unique
                while (ColumnA2.Text.Equals(ColumnA1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary2.Count);
                        KeyValuePair<string, string> pair1 = dictionary2.ElementAt(index1);
                        ColumnA2.Text = (dictionary2[pair1.Key]);
                    }
                }

            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<string, string> pair = dictionary2.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnA3.Text = (dictionary2[pair.Key]);

                //Ensures Column A values dont match eachother, making each value unique
                while (ColumnA3.Text.Equals(ColumnA2.Text) || ColumnA3.Text.Equals(ColumnA1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary2.Count);
                        KeyValuePair<string, string> pair1 = dictionary2.ElementAt(index1);
                        Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                        ColumnA3.Text = (dictionary2[pair1.Key]);
                    }
                }
            }
            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<string, string> pair = dictionary2.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnA4.Text = (dictionary2[pair.Key]);

                //Ensures Column A values dont match eachother, making each value unique
                while (ColumnA4.Text.Equals(ColumnA3.Text) || ColumnA4.Text.Equals(ColumnA2.Text) || ColumnA4.Text.Equals(ColumnA1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary2.Count);
                        KeyValuePair<string, string> pair1 = dictionary2.ElementAt(index1);
                        Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                        ColumnA4.Text = (dictionary2[pair1.Key]);
                    }
                }

            }

            

        }

        void Start1()
        {
            Random random = new Random();

            Dictionary<String, string> dictionary2 = new Dictionary<string, string>();
            //dictionary2 for storing and  displaying call numbers
            dictionary2.Add("Genral Knowlege", "000");
            dictionary2.Add("Philosophy & Psycology", "100");
            dictionary2.Add("Religion", "200");
            dictionary2.Add("Social Sciences", "300");
            dictionary2.Add("Languages", "400");
            dictionary2.Add("Science", "500");
            dictionary2.Add("Technology", "600");
            dictionary2.Add("Arts & Recriation", "700");
            dictionary2.Add("Litrature", "800");
            dictionary2.Add("History and Geography", "900");

            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary for storing and displaying categories
            dictionary.Add(000, "Genral Knowlege");
            dictionary.Add(100, "Philosophy & Psycology");
            dictionary.Add(200, "Religion");
            dictionary.Add(300, "Social Sciences");
            dictionary.Add(400, "Languages");
            dictionary.Add(500, "Science");
            dictionary.Add(600, "Technology");
            dictionary.Add(700, "Arts & Recriation");
            dictionary.Add(800, "Litrature");
            dictionary.Add(900, "History and Geography");

            //Generating Unique Column B Call number values 
            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<String, string> pair = dictionary2.ElementAt(index);
                ColumnB1.Text = (dictionary2[pair.Key]);

            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<String, string> pair = dictionary2.ElementAt(index);
                ColumnB2.Text = (dictionary2[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB2.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary2.Count);
                        KeyValuePair<String, string> pair1 = dictionary2.ElementAt(index1);
                        ColumnB2.Text = (dictionary2[pair1.Key]);
                    }
                }
            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<String, string> pair = dictionary2.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnB3.Text = (dictionary2[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB3.Text.Equals(ColumnB2.Text) || ColumnB3.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary2.Count);
                        KeyValuePair<String, string> pair1 = dictionary2.ElementAt(index1);
                        ColumnB3.Text = (dictionary2[pair1.Key]);
                    }
                }

            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<String, string> pair = dictionary2.ElementAt(index);
                ColumnB4.Text = (dictionary2[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB4.Text.Equals(ColumnB3.Text) || ColumnB4.Text.Equals(ColumnB2.Text) || ColumnB4.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary2.Count);
                        KeyValuePair<String, string> pair1 = dictionary2.ElementAt(index1);
                        ColumnB4.Text = (dictionary2[pair1.Key]);
                    }
                }

            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<String, string> pair = dictionary2.ElementAt(index);
                ColumnB5.Text = (dictionary2[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB5.Text.Equals(ColumnB4.Text) || ColumnB5.Text.Equals(ColumnB3.Text) || ColumnB5.Text.Equals(ColumnB2.Text) || ColumnB5.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary2.Count);
                        KeyValuePair<String, string> pair1 = dictionary2.ElementAt(index1);
                        ColumnB5.Text = (dictionary2[pair1.Key]);
                    }
                }
            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<String, string> pair = dictionary2.ElementAt(index);
                ColumnB6.Text = (dictionary2[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB6.Text.Equals(ColumnB5.Text) || ColumnB6.Text.Equals(ColumnB4.Text) || ColumnB6.Text.Equals(ColumnB3.Text) || ColumnB6.Text.Equals(ColumnB2.Text) || ColumnB6.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary2.Count);
                        KeyValuePair<String, string> pair1 = dictionary2.ElementAt(index1);
                        ColumnB6.Text = (dictionary2[pair1.Key]);
                    }
                }
            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary2.Count);
                KeyValuePair<String, string> pair = dictionary2.ElementAt(index);
                Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                ColumnB7.Text = (dictionary2[pair.Key]);

                //Ensures Column B values dont match eachother, making each value unique
                while (ColumnB7.Text.Equals(ColumnB6.Text) || ColumnB7.Text.Equals(ColumnB5.Text) || ColumnB7.Text.Equals(ColumnB4.Text) || ColumnB7.Text.Equals(ColumnB3.Text) || ColumnB7.Text.Equals(ColumnB2.Text) || ColumnB7.Text.Equals(ColumnB1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary2.Count);
                        KeyValuePair<String, string> pair1 = dictionary2.ElementAt(index1);
                        ColumnB7.Text = (dictionary2[pair1.Key]);
                    }
                    
                }

            }

            //Generating Unique Column A  Category Values 

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                ColumnA1.Text = (dictionary[pair.Key]);

            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                ColumnA2.Text = (dictionary[pair.Key]);

                //Ensures Column A values dont match eachother, making each value unique
                while (ColumnA2.Text.Equals(ColumnA1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary.Count);
                        KeyValuePair<int, string> pair1 = dictionary.ElementAt(index1);
                        ColumnA2.Text = (dictionary[pair1.Key]);
                    }
                }
            }
            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                ColumnA3.Text = (dictionary[pair.Key]);

                //Ensures Column A values dont match eachother, making each value unique
                while (ColumnA3.Text.Equals(ColumnA2.Text) || ColumnA3.Text.Equals(ColumnA1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary.Count);
                        KeyValuePair<int, string> pair1 = dictionary.ElementAt(index1);
                        Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                        ColumnA3.Text = (dictionary[pair1.Key]);
                    }
                }
            }

            for (int i = 0; i < 9; ++i)
            {
                int index = random.Next(dictionary.Count);
                KeyValuePair<int, string> pair = dictionary.ElementAt(index);
                ColumnA4.Text = (dictionary[pair.Key]);

                //Ensures Column A values dont match eachother, making each value unique
                while (ColumnA4.Text.Equals(ColumnA3.Text) || ColumnA4.Text.Equals(ColumnA2.Text) || ColumnA4.Text.Equals(ColumnA1.Text))
                {
                    for (int j = 0; j < 9; ++j)
                    {
                        int index1 = random.Next(dictionary.Count);
                        KeyValuePair<int, string> pair1 = dictionary.ElementAt(index1);
                        Console.WriteLine("key: " + pair.Key + ", value: " + pair.Value);
                        ColumnA4.Text = (dictionary[pair1.Key]);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home(); // Instantiate a h object.
            h.ShowDialog(); // Show replacing books 
            this.Close(); // closes this instance.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //start question button for one question
            DeweyDecimalSystem.Visible = false;
            DeweyDeciamDescription.Visible = false;

            Answer1.Text = "";
            Answer2.Text = "";
            Answer3.Text = "";
            Answer4.Text = "";
            Start1();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //start question button for other question
            DeweyDecimalSystem.Visible = false;
            DeweyDeciamDescription.Visible = false;

            Answer1.Text = "";
            Answer2.Text = "";
            Answer3.Text = "";
            Answer4.Text = "";
            Start2();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //clear button clears all fields
            DeweyDecimalSystem.Visible = false;
            DeweyDeciamDescription.Visible = false;//makes answers invisible to users 

            Answer1.Text = "";
            Answer2.Text = "";
            Answer3.Text = "";
            Answer4.Text = "";

            ColumnA1.Text = "            ";
            ColumnA2.Text = "            ";
            ColumnA3.Text = "            ";
            ColumnA4.Text = "            ";
            ColumnB1.Text = "                            ";
            ColumnB2.Text = "                            ";
            ColumnB3.Text = "                            ";
            ColumnB4.Text = "                            ";
            ColumnB5.Text = "                            ";
            ColumnB6.Text = "                            ";
            ColumnB7.Text = "                            ";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Done button with error message if the user has not provided their answers
            if (ColumnA1.Text.Equals("            "))
            {
                string message1 = "Please select the question of your choice before proceeding!";//Error message
                string title1 = "Error!";
                MessageBox.Show(message1, title1);
            }
            else
            {

                //error message
                if (Answer1.Text.Equals("") || Answer2.Text.Equals("") || Answer3.Text.Equals("") || Answer4.Text.Equals(""))
                {
                string message1 = "Please select all your answers from the drop down lists provided!";//Error message
                string title1 = "Error!";
                MessageBox.Show(message1, title1);
                }
                else
                {
                    //Success message congratulating the user for completeing 
                    string message = "Congratulations on completing your matching columns challange!" + "\n" + "Please check alongside with the Dewey Decimal System if your matching is correct!";//gamification feature, trophy and achievement earned
                    string title = "Badge earned: Matching!";
                    MessageBox.Show(message, title);
                    DeweyDecimalSystem.Visible = true;//makes answers visible to user
                    DeweyDeciamDescription.Visible = true;
                }
            }
        }
    }
}
