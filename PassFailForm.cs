using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassFailToluA
{
    public partial class frmPassFail : Form
    {
        // Get input and output files
        string filepath = "DATA10.txt";
        string outputFile = "DATA10_Output.txt";

        // Declare local variables
        float weightTest, weightAssign, weightProjects, weightQuizzes;
        float markTests, markAssign, markProjects, markQuizzes;
        int numStudents;
        float average;
        int numPassed = 0;
        int counterA, counterB;

        public frmPassFail()
        {
            InitializeComponent();
        }

        private void frmPassFail_Load(object sender, EventArgs e)
        {

        }

        private void btnParseFile_Click(object sender, EventArgs e)
        {
            // Read each line of the file into a string array. Each elememt
            // of the array is one line of the file
            string[] lines = System.IO.File.ReadAllLines(filepath);
            // Display the files contents to the console by using a for each loop
            System.Console.WriteLine("Contents of " + filepath + " =");
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(outputFile))
            {
                // loop through each line of the array
                for (counterA = 0; counterA < lines.Length; counterA++)
                {
                    //initialize the number of students who got >= 50%
                    numPassed = 0;
                    // read the first line for the next set of students
                    string line = lines[counterA];
                    // split each a weight by the space delimiter
                    string[] weights = line.Split(' ');
                    // get the weight for the tests, assignments, projects and quizzes
                    weightTest = float.Parse(weights[0]);
                    weightAssign = float.Parse(weights[1]);
                    weightProjects = float.Parse(weights[2]);
                    weightQuizzes = float.Parse(weights[3]);
                    // for testing purposes only write the weights to output file
                    file.WriteLine("weights " + weightTest + " " + weightAssign + " " + weightProjects + " " + weightQuizzes);
                    // get number of students from the array
                     numStudents = 
                }

            }
        }
    }
}
