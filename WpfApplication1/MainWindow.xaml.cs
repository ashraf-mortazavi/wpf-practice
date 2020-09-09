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



namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }


        TextBox textbox1 = new TextBox();
        TextBox textbox2 = new TextBox();
        TextBox textbox3 = new TextBox();
        ListBox listbox = new ListBox();


        public class User
        {
            public int Id { get; set; }
            public string name { get; set;}
            public string location { get; set; }
        }


        private void txtblock_Loaded(object sender, RoutedEventArgs e)
        {
             Employee e1 = new Employee();
            //textBlock.Text = Convert.ToString(e1.name.Length);

            grild1.Children.Add(listbox);
            listbox.VerticalAlignment = VerticalAlignment.Top;
            listbox.HorizontalAlignment = HorizontalAlignment.Right;
            listbox.Width = 180;
            listbox.Height = 220;

            listbox.Margin = new Thickness(300, 13, 10, 0);

            for (int i = 0; i < 2; i++)
            {
                Button addbtni = new Button();
                addbtni.Width = 90;
                addbtni.Height = 30;
                addbtni.HorizontalAlignment = HorizontalAlignment.Left;
                addbtni.VerticalAlignment = VerticalAlignment.Top;

                grild1.Children.Add(addbtni);

                if (i == 0)
                {
                    addbtni.Content = "Add Contact";
                    addbtni.Margin = new Thickness(i + 60, i + 190, i + 100, i + 50);
                     addbtni.Click += btn_Add;
                }
                else
                {
                    addbtni.Content = "Add Sort";
                    addbtni.Margin = new Thickness(i + 180, i + 189, i + 99, i + 49);
                }
            }


            for (int i = 0; i < 3; i++)
            {
                Label labeli = new Label();
                if (i == 0)
                {
                    labeli.Content = "FirstName";
                    labeli.Margin = new Thickness(i + 10, i + 10, i + 10, i + 30);
                }
                else if (i == 1)
                {
                    labeli.Content = "LastName";
                    labeli.Margin = new Thickness(i + 9, i + 64, i + 49, i + 99);
                }
                else
                {
                    labeli.Content = "Phone";
                    labeli.Margin = new Thickness(i + 8, i + 118, i + 98, i + 158);
                }

                labeli.Width = 80;
                labeli.Height = 30;
                labeli.VerticalAlignment = VerticalAlignment.Top;
                labeli.HorizontalAlignment = HorizontalAlignment.Left;
                grild1.Children.Add(labeli);


            }




            for (int i = 1; i < 4; i++)
            {

                if (i == 1)
                { 
                    textbox1.Width = 150;
                textbox1.Height = 25;
                textbox1.VerticalAlignment = VerticalAlignment.Top;
                textbox1.HorizontalAlignment = HorizontalAlignment.Left;

                textbox1.Margin = new Thickness(100, i + 12, 100, 120);
                }
                else if (i == 2)
                {
                    textbox2.Width = 150;
                    textbox2.Height = 25;
                    textbox2.VerticalAlignment = VerticalAlignment.Top;
                    textbox2.HorizontalAlignment = HorizontalAlignment.Left;

                    textbox2.Margin = new Thickness(100, i + 65, 100, 120);
                }
                else
                textbox3.Width = 150;
                textbox3.Height = 25;
                textbox3.VerticalAlignment = VerticalAlignment.Top;
                textbox3.HorizontalAlignment = HorizontalAlignment.Left;
                textbox3.Margin = new Thickness(100, i + 120, 100, 120);
            }


            grild1.Children.Add(textbox1);
            grild1.Children.Add(textbox2);
            grild1.Children.Add(textbox3);

            //Array array = Array.CreateInstance(typeof(string), 2,4);
            //array.SetValue("ahmad", 0,0);
            //array.SetValue("amir", 0,1);
            //array.SetValue("mohammad", 0, 2);
            //array.SetValue("mihan",0, 3);
            //array.SetValue("samin", 1, 0);
            //array.SetValue("sara", 1, 1);
            //array.SetValue("yashar", 1, 2);
            //array.SetValue("sina", 1, 3);

            //int x = array.GetLength(0);
            //int y = array.GetLength(1);

            //for (int i = 0; i < x; i++)
            //{
            //    for (int j = 0; j < y; j++)
            //    {
            //   MessageBox.Show($"{i.ToString()}, {j.ToString()}:{array.GetValue(i, j)}");
            //    }
            //}



            Array arra1 = Array.CreateInstance(typeof(int), 4);
            arra1.SetValue(0, 0);
            arra1.SetValue(1, 1);
            arra1.SetValue(2, 2);
            arra1.SetValue(3, 3);

            //Array arra2 = Array.CreateInstance(typeof(object), 5);
            //Array.Copy(arra1, arra1.GetLowerBound(0), arra2, arra2.GetLowerBound(0), 4);
            //int x = arra2.GetUpperBound(0);
            //for(int i=0; i<x; i++)
            //{
            //    MessageBox.Show(arra2.GetValue(i).ToString());
            //}


            Array oddArray = Array.CreateInstance(typeof(Int32), 5);
            oddArray.SetValue(1, 0);
            oddArray.SetValue(3, 1);
            oddArray.SetValue(5, 2);
            oddArray.SetValue(7, 3);
            oddArray.SetValue(9, 4);
            // Creates and initializes a new Array of type Object.  
            Array objArray = Array.CreateInstance(typeof(object), 5);
            Array.Copy(oddArray, oddArray.GetLowerBound(0) + 1, objArray, objArray.GetLowerBound(0) +1,4);
            int items1 = objArray.GetUpperBound(0);
           // for (int i = 1; i <= items1; i++) MessageBox.Show(objArray.GetValue(i).ToString());
            //Int32[] cloneArray = (Int32[])oddArray.Clone();
            // foreach(var x in cloneArray)
            //{
            //    MessageBox.Show(x.ToString());
            //}


            //object[] arrayy ;
            //arrayy = new object[] { 1, "ahmad", 'a', 3.526 , null};
            //foreach (var item in arrayy)
            //{
            //    MessageBox.Show(item.ToString());
            //}

            List<int> lst = new List<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            List<int> lst2 = new List<int>();
            lst2.AddRange(lst);
            //foreach (var item in lst2)
            //{
            //    MessageBox.Show(item.ToString());
            //}

            List<User> lst3 = new List<User>()
            {
                new User {Id=1, name="hgh", location="gfttru" },
                new User {Id=2, name="ttyry", location="ewerwre" }
            };

            lst3.Add(new User { Id = 3, name = "wwrwr", location = "wewqe" });
            //MessageBox.Show(lst[1]);

            //MessageBox.Show((lst3.Capacity).ToString());
            lst.Insert(1, 5);


            List<int> lst4 = new List<int>() { 20, 30 };
            lst.InsertRange(2, lst4);

            //MessageBox.Show((lst.Contains(5)).ToString());
            //foreach (var item in lst)
            //{
            //    MessageBox.Show(item.ToString());
            //}


            //for (int i = 0; i < lst3.Count; i++)
            //{
            //    MessageBox.Show($"Id:{lst3[i].Id}, name:{lst3[i].name}, location:{lst3[i].location}");
            //}
            //foreach (var item in lst3)
            //{
            //    MessageBox.Show($"Id:{item.Id}, name:{item.name}, location:{item.location}");
            //}


            // MessageBox.Show((lst.Count).ToString());
            // MessageBox.Show((lst.Capacity).ToString());
            //foreach (var item in lst)
            //{
            //    MessageBox.Show(item.ToString());
            //}





        }


        private void btn_Add(object sender, RoutedEventArgs e)
        {
            Employee employ = new Employee();

            employ.FirstName = textbox1.Text;
            employ.LastName = textbox2.Text;
            employ.Phone = textbox3.Text;
            listbox.Items.Add(employ.ToString());

        }

    }
    }

