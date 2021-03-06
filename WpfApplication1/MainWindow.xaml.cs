﻿using System;
using System.Collections.Generic;
using System.IO;
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
        //global
        TextBox textbox1 = new TextBox();
        TextBox textbox2 = new TextBox();
        TextBox textbox3 = new TextBox();
        ListBox listbox = new ListBox();

       
       

        private Employee[] phonebook = new Employee[1];



        private void Write(Employee obj)
        {


            StreamWriter sw = new StreamWriter("NewContacts.txt");
            sw.WriteLine(phonebook.Length + 1);
            sw.WriteLine(obj.FirstName);
            sw.WriteLine(obj.LastName);
            sw.WriteLine(obj.Phone);
            for (int i = 0; i < phonebook.Length; i++)
            {
                sw.WriteLine(phonebook[i].FirstName);
                sw.WriteLine(phonebook[i].LastName);
                sw.WriteLine(phonebook[i].Phone);
            }

            sw.Close(); 
        }

        private void Read()
        {


            StreamReader sr = new StreamReader("NewContacts.txt");
            phonebook = new Employee[Convert.ToInt32(sr.ReadLine())];
            for (int x = 0; x < phonebook.Length; x++)
            {
                phonebook[x] = new Employee();
                phonebook[x].FirstName = sr.ReadLine();
                phonebook[x].LastName = sr.ReadLine();
                phonebook[x].Phone = sr.ReadLine();
            }

            sr.Close();

        }

        private void Dispaly()
        {
            listbox.Items.Clear();
            foreach (var item in phonebook)

            {
                listbox.Items.Add(item.ToString());
            }
        }

        private void ClearFields()
        {
            textbox1.Text = String.Empty;
            textbox2.Text = String.Empty;
            textbox3.Text = String.Empty;
        }
       

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

            Read();
           Dispaly();
        }


        private void btn_Add(object sender, RoutedEventArgs e)
        {
            Employee employ = new Employee();

            employ.FirstName = textbox1.Text;
            employ.LastName = textbox2.Text;
            employ.Phone = textbox3.Text;
            Write(employ);
            Read();
            Dispaly();
            ClearFields();
       

        }

    }
}

