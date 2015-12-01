using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataBinding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            PopulateData();
        }
        public ObservableCollection<Student> stdlist = new ObservableCollection<Student>();
        public void PopulateData()
        {
            stdlist.Add(new Student { id=1, Name = "Ahmed", RollNo = "100-BSCS-15", Class = "FreshMan", ImagePath="Assets\\Image DB.png" });
            stdlist.Add(new Student { id=2, Name = "Anthony", RollNo = "21-BSCS-14", Class = "Sophomore" , ImagePath = "Assets\\Image DB.png" });
            stdlist.Add(new Student { id = 3, Name = "David", RollNo = "72-PHY-13", Class = "Junior", ImagePath = "Assets\\Image DB.png" });
            stdlist.Add(new Student { id = 4, Name = "Umer", RollNo = "125-BSEE-12", Class = "Senior" , ImagePath = "Assets\\Image DB.png" });
            lst_students.ItemsSource = stdlist;
        }
    }
}
