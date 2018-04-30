using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            Student s1 = new Student();
            Student s2 = new Student("Doe", "John", "M01020304");
            Student s3 = new Student("Dane", "Jane", "M12345678", "Female", "08/23/1996", "Communications");
            Student s4 = new Student("Horton", "William", "M2254879", "Male", "12/23/1997", "Actuarial Studies");
            Student s5 = new Student("Lange", "Alexa", "M55887744", "Female", "03/06/1995", "Finance");

            students.Add(s1);
            students.Add(s2);
            students.Add(s3);
            students.Add(s4);
            students.Add(s5);

            for (int i = 0; i < students.Count; i++)
            {
                MessageBox.Show(students[i].printStudentInfo());
            }
        }
    }
}
