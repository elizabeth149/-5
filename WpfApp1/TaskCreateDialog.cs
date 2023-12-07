using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApp1
{
    public partial class TaskCreateDialog : DialogBase
    {
        public Task CreatedTask { get; private set; }

        public TaskCreateDialog()
        {
            InitializeComponent();
            CreatedTask = new Task(); // Создаем новую задачу при инициализации диалога
        }

        private void CreateTaskButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true; // Устанавливаем DialogResult в true при нажатии кнопки "Create Task"
            Close(); // Закрываем диалог
        }
    }
}

