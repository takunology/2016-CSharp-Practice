using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace 受付入力システム
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private ObservableCollection<Student> observableStudent = new ObservableCollection<Student>();

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string S = "";
            if(ManBtn.IsChecked == true)
            {
                S = "男";
            }
            else if(WomBtn.IsChecked == true)
            {
                S = "女";
            }

            //データベース接続文字列
            string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\WPFたち\受付入力システム\受付入力システム\Database.mdf;Integrated Security=True";
            //データベース接続
            DataClassesDataContext context = new DataClassesDataContext(connection);

            //School変数に学校名を設定
            School school = new School();
            school.Name = SchoolName.Text;
            //データベースにSchoolを登録
            context.School.InsertOnSubmit(school);
            context.SubmitChanges();

            //Student変数に名前を設定
            Student student = new Student();
            student.Name = LastName.Text + " " + FirstName.Text; // 漢字名
            student.KanaName = Lastname.Text + " " + Firstname.Text; //　かな名
            student.Grade = grade.Text; //学年
            student.Sei = S; //性別
            student.SchoolId = school.Id;
            
            //データベースにStudentを登録
            context.Student.InsertOnSubmit(student);
            context.SubmitChanges();

            this.observableStudent.Add(student);
            this.dataGrid.ItemsSource = observableStudent;

            
        }
    }
}
