using System.Windows.Forms;

namespace Module
{
    public partial class Form1 : Form
    {
        private List<ListBox> taskLists = new List<ListBox>();
        public Form1()
        {
            InitializeComponent();
            InitializeTaskLists();
        }
        private void InitializeTaskLists()
        {
            for (int i = 0; i < 3; i++)
            {
                var listBox = new ListBox { Width = 200, Height = 300, AllowDrop = true };
                listBox.DragEnter += ListBox_DragEnter;
                listBox.DragDrop += ListBox_DragDrop;
                listBox.MouseDown += ListBox_MouseDown;
                taskLists.Add(listBox);
                flowLayoutPanel1.Controls.Add(listBox);
            }
        }
        private void ListBox_MouseDown(object sender, MouseEventArgs e)
        {
            var listBox = sender as ListBox;
            if (listBox.SelectedItem != null)
                listBox.DoDragDrop(listBox.SelectedItem, DragDropEffects.Move);
        }

        private void ListBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(string)))
                e.Effect = DragDropEffects.Move;
        }

        private void ListBox_DragDrop(object sender, DragEventArgs e)
        {
            var targetListBox = sender as ListBox;
            var taskText = e.Data.GetData(typeof(string)) as string;

            foreach (var listBox in taskLists)
            {
                if (listBox.Items.Contains(taskText))
                {
                    listBox.Items.Remove(taskText);
                    break;
                }
            }
            targetListBox.Items.Add(taskText);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
                taskLists[0].Items.Add(textBox1.Text);
            textBox1.Clear();
        }
    }
}
