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
        private void MoveTask(ListBox fromList, string fromStatus, string toStatus)
        {
            if (fromList.SelectedItem == null) return;

            string selectedTaskTitle = fromList.SelectedItem.ToString();
            TaskItem task = tasks.Find(t => t.Title == selectedTaskTitle && t.Status == fromStatus);
            if (task != null)
            {
                task.Status = toStatus;
                SaveTasks();
                UpdateLists();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            MoveTask(lstToDo, "To Do", "In Progress");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoveTask(lstInProgress, "In Progress", "Done");
        }
    }
}
