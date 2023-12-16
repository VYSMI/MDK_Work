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

namespace Work16._12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int count = 4;
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            lBoxTV.Items.Insert(count,txtBox.Text);
            count++;
        }

        private void ButtonAdd1_Click(object sender, RoutedEventArgs e)
        {
            
            MessageBox.Show($"Результат суммы:{Convert.ToInt32(txtNum1.Text) + Convert.ToInt32(txtNum2.Text)}","Сообщение");
        }
    }
}
