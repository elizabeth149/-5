using System;
using System.Threading;
using System.Windows;
using Xunit;
using WpfApp1;

namespace TestProject1
{
    public class MainWindowTests
    {
        [Fact]
        public void TestCreateTaskButton()
        {
            var mainWindow = new MainWindow();
            var initialTasksCount = mainWindow.ViewModel.Tasks.Count;

            // Имитация действий пользователя: клик по кнопке "Create Task"
            mainWindow.CreateTask_Click(null, null);

            // Ожидание, чтобы дать приложению время обработать событие
            Thread.Sleep(1000);

            Assert.Equal(initialTasksCount + 1, mainWindow.viewModel.Tasks.Count);
        }

        [Fact]
        public void TestEditTaskButton()
        {
            var mainWindow = new MainWindow();
            var selectedTask = new WpfApp1.Task { Title = "Test Task", Priority = 1, Deadline = DateTime.Now.AddDays(1), IsCompleted = false };
            mainWindow.viewModel.Tasks.Add(selectedTask);

            // Выбор задачи в списке
            mainWindow.taskListView.SelectedItem = selectedTask;

            // Имитация действий пользователя: клик по кнопке "Edit Task"
            mainWindow.EditTask_Click(null, null);

            // Ожидание, чтобы дать приложению время обработать событие
            Thread.Sleep(1000);

            // Проверка, что открывается диалог редактирования
            Assert.NotNull(mainWindow.OwnedWindows);
        }
    }
}