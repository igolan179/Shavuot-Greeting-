using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Shavuot_Blessing.PersonFolder;

namespace Shavuot_Blessing
{

    public partial class ShavuotForm : Form
    {
        bool encrypted = false;
        Queue<string> personsQueue = new Queue<string>();
        public ShavuotForm()
        {
            InitializeComponent();

        }
        Dictionary<string, Person> persons = new Dictionary<string, Person>();

        // ======  timer to change color and text size ======
        private void myTimer_Tick(object sender, EventArgs e)
        {
            if (mainLabel.ForeColor == Color.SaddleBrown)
            {
                mainLabel.Font = new Font("Arial Rounded MT", 30, FontStyle.Bold);
                mainLabel.ForeColor = Color.OrangeRed;
            }
            else
            {
                mainLabel.Font = new Font("Arial Rounded MT", 31, FontStyle.Bold);
                mainLabel.ForeColor = Color.SaddleBrown;
            }
            if (personLabel.ForeColor == Color.SaddleBrown)
            {
                personLabel.Font = new Font("Arial Rounded MT", 30, FontStyle.Bold);
                personLabel.ForeColor = Color.OrangeRed;
            }
            else
            {
                personLabel.Font = new Font("Arial Rounded MT", 31, FontStyle.Bold);
                personLabel.ForeColor = Color.SaddleBrown;
            }
        }
        // ======  timer to change names ======
        private void queueTimer_Tick(object sender, EventArgs e)
        {
            string temp = personsQueue.Dequeue();
            personsQueue.Enqueue(temp);
            personLabel.Text = temp;
        }

        // ======  timer to change names ======
        private void addPerson_Click(object sender, EventArgs e) // add person to the dictionary
        {
            string personName = comboBox.Text; // combobox will show the previous names for debugging purpose
            int personAge = int.Parse(ageBox.Value.ToString());
            Person person = new Person(personName, personAge);
            persons.Add(person.Name, person);
            comboBox.Items.Add(person.Name);
            MessageBox.Show(personName + " added successfully!");
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            if (persons.Count == 0) MessageBox.Show("There are no names to greet."); // no input 
            else
            {
                personsQueue.Clear();
                if (EncryptBox.Checked == true && encrypted == false)
                {
                    EncryptNames(persons);
                    encrypted = true;
                }
                if (EncryptBox.Checked == false && encrypted == true)
                {
                    DecryptNames(persons);
                    encrypted = false;
                }
                var sortedPersons = from entry in persons orderby entry.Value.Age descending select entry;
                foreach (var el in sortedPersons)
                {
                    personsQueue.Enqueue(el.Value.Name);
                }
                colorTimer.Enabled = true;
                queueTimer.Enabled = true;
                mainLabel.Text = "Happy Shavuot to";
            }
        }

        // ======  Encryption Method with ascii + 3 ======
        private Dictionary<string, Person> EncryptNames(Dictionary<string, Person> dicionary)
        {
            foreach (var el in dicionary)
            {
                string tempWord = "";
                foreach (char c in el.Value.Name)
                {
                    tempWord += System.Convert.ToChar(Convert.ToInt32(c) + 3);
                }
                el.Value.Name = tempWord;
            }
            return dicionary;
        }

        // ======  Decryption Method with ascii - 3 ======
        private Dictionary<string, Person> DecryptNames(Dictionary<string, Person> dicionary)
        {
            foreach (var el in dicionary)
            {
                string tempWord = "";
                foreach (char c in el.Value.Name)
                {
                    tempWord += System.Convert.ToChar(Convert.ToInt32(c) - 3);
                }
                el.Value.Name = tempWord;
            }
            return dicionary;
        }
    }
}
