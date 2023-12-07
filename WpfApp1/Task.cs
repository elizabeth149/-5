using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Task : INotifyPropertyChanged
    {
        private string title;
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        private int priority;
        public int Priority
        {
            get { return priority; }
            set
            {
                priority = value;
                OnPropertyChanged(nameof(Priority));
            }
        }

        private DateTime deadline;
        public DateTime Deadline
        {
            get { return deadline; }
            set
            {
                deadline = value;
                OnPropertyChanged(nameof(Deadline));
            }
        }

        private bool isCompleted;
        public bool IsCompleted
        {
            get { return isCompleted; }
            set
            {
                isCompleted = value;
                OnPropertyChanged(nameof(IsCompleted));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
