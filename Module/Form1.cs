using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Module
{
    public partial class Form1 : Form
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private string filePath = "tasks.json";
        public Form1()
        {
            InitializeComponent();
            LoadTasks();
        }
        
        private void lstTask_DragDrop(object sender, DragEventArgs e)
        {
            string taskTitle = (string)e.Data.GetData(DataFormats.StringFormat);
            string newStatus = (sender as ListBox)?.Tag.ToString();

            TaskItem task = tasks.Find(t => t.Title == taskTitle);
            if (task != null)
            {
                task.Status = newStatus;
                SaveTasks();
                UpdateLists();
            }
        }

        private void lstTask_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void lstTask_MouseDown(object sender, MouseEventArgs e)
        {
            ListBox listBox = sender as ListBox;
            if (listBox?.SelectedItem != null)
            {
                listBox.DoDragDrop(listBox.SelectedItem.ToString(), DragDropEffects.Move);
            }
        }      

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void LoadTasks()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                tasks = JsonSerializer.Deserialize<List<TaskItem>>(json) ?? new List<TaskItem>();
                UpdateLists();
            }
        }

        private void SaveTasks()
        {
            string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        private void UpdateLists()
        {
            lstToDo.Items.Clear();
            lstInProgress.Items.Clear();
            lstDone.Items.Clear();

            foreach (var task in tasks)
            {
                switch (task.Status)
                {
                    case "To Do": lstToDo.Items.Add(task.Title); break;
                    case "In Progress": lstInProgress.Items.Add(task.Title); break;
                    case "Done": lstDone.Items.Add(task.Title); break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                TaskItem newTask = new TaskItem { Id = Guid.NewGuid(), Title = textBox1.Text, Status = "To Do" };
                tasks.Add(newTask);
                SaveTasks();
                UpdateLists();
                textBox1.Clear();
            }

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
