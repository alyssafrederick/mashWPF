using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MASH
{
    public partial class MainWindow : Window
    {
        int pleaseenter = 0;
        int magicNumber = 6;
        List<string>[] lists = new List<string>[8];


        public MainWindow()
        {
            InitializeComponent();
            for (int i = 0; i < 8; i++)
            {
                lists[i] = new List<string>();
            }

            lists[7].Add("Mansion");
            lists[7].Add("Apartment");
            lists[7].Add("Shack");
            lists[7].Add("House");

        }

        private void enterbutton_Click(object sender, RoutedEventArgs e)
        {
            pleaseenter++;

            if (pleaseenter == 1)
            {

                lists[0].Add(textBox1.Text);
                lists[0].Add(textBox2.Text);
                lists[0].Add(textBox3.Text);
                lists[0].Add(textBox4.Text);

                questionbox.Content = "please enter four names";


            }

            if (pleaseenter == 2)
            {
                lists[1].Add(textBox1.Text);
                lists[1].Add(textBox2.Text);
                lists[1].Add(textBox3.Text);
                lists[1].Add(textBox4.Text);

                questionbox.Content = "please enter four animals";

            }

            if (pleaseenter == 3)
            {
                lists[2].Add(textBox1.Text);
                lists[2].Add(textBox2.Text);
                lists[2].Add(textBox3.Text);
                lists[2].Add(textBox4.Text);

                questionbox.Content = "please enter four jobs";

            }

            if (pleaseenter == 4)
            {
                lists[3].Add(textBox1.Text);
                lists[3].Add(textBox2.Text);
                lists[3].Add(textBox3.Text);
                lists[3].Add(textBox4.Text);

                questionbox.Content = "please enter four places";

            }

            if (pleaseenter == 5)
            {
                lists[4].Add(textBox1.Text);
                lists[4].Add(textBox2.Text);
                lists[4].Add(textBox3.Text);
                lists[4].Add(textBox4.Text);

                questionbox.Content = "please enter four colors";

            }

            if (pleaseenter == 6)
            {
                lists[5].Add(textBox1.Text);
                lists[5].Add(textBox2.Text);
                lists[5].Add(textBox3.Text);
                lists[5].Add(textBox4.Text);

                questionbox.Content = "please enter four cars";


            }

            if (pleaseenter == 7)
            {
                lists[6].Add(textBox1.Text);
                lists[6].Add(textBox2.Text);
                lists[6].Add(textBox3.Text);
                lists[6].Add(textBox4.Text);

                questionbox.Content = "please enter a magic number";

                textBox2.Visibility = Visibility.Hidden;
                textBox3.Visibility = Visibility.Hidden;
                textBox4.Visibility = Visibility.Hidden;

            }
            if (pleaseenter == 8)
            {
                magicNumber = int.Parse(textBox1.Text);


                int count = 0;
                while (!isOneOfEach())
                {
                    for (int i = 0; i < lists.Length; i++)
                    {
                        for (int j = 0; j < lists[i].Count; j++)
                        {
                            if (count % magicNumber == 0 && lists[i].Count > 1)
                            {
                                lists[i].RemoveAt(j);
                            }

                            count++;
                        }

                    }
                }

                questionbox.Content = string.Format("Once upon a time you will fall in love \n and marry {0}. Together you will \n move to {1}, have {2} \n children, and live in a {3}. \n You will also have a {4} \n as a pet. You will drive a \n {5} {6} and work \n as a {7}.", lists[1][0], lists[4][0], lists[0][0], lists[7][0], lists[2][0], lists[5][0], lists[6][0], lists[3][0]);

                textBox1.Visibility = Visibility.Hidden;
                enterbutton.Visibility = Visibility.Hidden;
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        bool isOneOfEach()
        {
            int counter = 0;
            for (int i = 0; i < lists.Length; i++)
            {
                if (lists[i].Count == 1)
                {
                    counter++;
                }
            }

            if (counter == lists.Length)
            {
                return true;
            }

            return false;
        }
    }
}
