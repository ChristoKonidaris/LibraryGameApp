using _19013888_PROG7312_Task1.Node;
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

namespace _19013888_PROG7312_Task1
{
    public partial class FindingCallNumbers : Form
    {
        //declare global variables
        List<Tree<string>> rootlist = new List<Tree<string>>();

        Tree<string> tree3;
        TreeNode<string> parent;
        TreeNode<string> children;
        int gameNumber = 0;
        public FindingCallNumbers()
        {
            InitializeComponent();
            //create lists
            List<string> roots = new List<string>();
            List<string> parents = new List<string>();
            List<string> children = new List<string>();

            List<Tree<string>> trees = new List<Tree<string>>();// use basic tree
            Tree<string> tree = new Tree<string>();

            tree.Root = new TreeNode<string>() { CallNumber = "100", Description = "" };

            string[] file = File.ReadAllLines(@"TreeData.txt");//read data into tree

            foreach(string line in file)//check the level of the item
            {
                if (line[0] == '-')
                {
                    roots.Add(line);
                }
                if(line[0] == '#')
                {
                    parents.Add(line);
                }
                if(line[0] == '*')
                {
                    children.Add(line);
                }
            }

            foreach (string root in roots)//get the root item
            {
                Tree<string> tree2 = new Tree<string>();

                tree2.Root = new TreeNode<string>() { CallNumber = root.Substring(1, 3), Description = root.Substring(4) };//selects only the call number and description

                rootlist.Add(tree2);
            }

            rootlist[0].Root.Children = new List<TreeNode<string>>();

            for (int i = 0; i < parents.Count; i++)
            {
                if (rootlist[i].Root.Children == null)
                {
                    rootlist[i].Root.Children = new List<TreeNode<string>>()
                    {
                       

                    };
                }
                    rootlist[i].Root.Children.Add(new TreeNode<string>() { CallNumber = parents[i].Substring(1, 3), Description = parents[i].Substring(4) });//selects only the call number and description

            }

            foreach(string child in children) 
            { 
                Console.WriteLine(); 
            
            }

            int count = -1;
            for (int i = 0; i < children.Count; i++)
            {
                //gets the child values
                if (i % 9 == 0) count++;
                if (rootlist[count].Root.Children[0].Children == null)
                {
                    rootlist[count].Root.Children[0].Children = new List<TreeNode<string>>()
                    {
                        new TreeNode<string> { CallNumber = children[i].Substring(1, 3), Description = children[i].Substring(4) }

                    };
                }
                else
                {

                    rootlist[count].Root.Children[0].Children.Add(new TreeNode<string> { CallNumber = children[i].Substring(1, 3), Description = children[i].Substring(4) });
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FindingCallNumbersBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home h = new Home(); // Instantiate a h object.
            h.ShowDialog(); // Show replacing books 
            this.Close(); // closes this instance.
        }

        private void GenerateQuiz_Click(object sender, EventArgs e)
        {
            //displays call number and description for quiz
            System.Random rnd = new System.Random();

            int rootAnswer = rnd.Next(10), parentAnswer = 0, childAnswer = rnd.Next(9);

            tree3 = rootlist[rootAnswer];

            parent = tree3.Root.Children[parentAnswer];

            children = parent.Children[childAnswer];

            Question.Text = children.Description;//displays question

            var result = rootlist.OrderBy(x => rnd.Next()).Where(x => x.Root.CallNumber != tree3.Root.CallNumber).Take(3).ToList();

            result.Add(tree3);

            result = result.OrderBy(x => x.Root.CallNumber).ToList();

            QuizBox.Items.Clear();
            QuizBox.Items.Add(result[0].Root.CallNumber + " " + result[0].Root.Description);
            QuizBox.Items.Add(result[1].Root.CallNumber + " " + result[1].Root.Description);
            QuizBox.Items.Add(result[2].Root.CallNumber + " " + result[2].Root.Description);
            QuizBox.Items.Add(result[3].Root.CallNumber + " " + result[3].Root.Description);
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            System.Random rnd = new System.Random();
            if (gameNumber == 0)
            {
                //submit button to check if user is correct

                if (QuizBox.SelectedItem.Equals(tree3.Root.CallNumber + " " + tree3.Root.Description))
                {
                    MessageBox.Show("Your answer is correct, well done!");
                    gameNumber = gameNumber + 1;

                    var result = rootlist.OrderBy(x => rnd.Next()).Where(x => x.Root.CallNumber != tree3.Root.CallNumber).Take(3).ToList();

                    result.Add(tree3);

                    result = result.OrderBy(x => x.Root.CallNumber).ToList();

                    QuizBox.Items.Clear();
                    QuizBox.Items.Add(result[0].Root.Children[0].CallNumber + " " + result[0].Root.Children[0].Description);
                    QuizBox.Items.Add(result[1].Root.Children[0].CallNumber + " " + result[1].Root.Children[0].Description);
                    QuizBox.Items.Add(result[2].Root.Children[0].CallNumber + " " + result[2].Root.Children[0].Description);
                    QuizBox.Items.Add(result[3].Root.Children[0].CallNumber + " " + result[3].Root.Children[0].Description);
                    Question.Text = children.Description;

                }
                else
                {//if user incorrect complete quiz again
                    MessageBox.Show("Your answer is incorrect, please try again!");
                    GenerateQuiz_Click(null, null);
                }
            }
            else if(gameNumber == 1)
            {
                if (QuizBox.SelectedItem.Equals(parent.CallNumber + " " + parent.Description))
                {//if user is correct move to next level
                    MessageBox.Show("Your answer is correct, well done!");
                    string message = "Congratulations on completing your first quiz!" + "\n" + "Please complete more quiz's!";//gamification feature, trophy and achievement earned
                    string title = "Badge earned: Quiz Expert!";
                    MessageBox.Show(message, title);
                    QuizBox.Items.Clear();
                    Question.Text = "";
                }
                else
                {
                    MessageBox.Show("Your answer is incorrect, please try again!");
                    GenerateQuiz_Click(null, null);//restart if incorrect
                }
            }
            else
            {
                gameNumber = 0;
            }

        }
    }
}
