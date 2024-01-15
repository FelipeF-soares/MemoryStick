using MemoryStick.Views;

namespace MemoryStick
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddTapPages(string name, UserControl userControl)
        {
            TabPage tabPage = new TabPage();
            userControl.Dock = DockStyle.Fill;
            tabPage.Name = name;
            tabPage.Controls.Add(userControl);
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new System.Drawing.Size(1, 1);
            tabControl.TabPages.Add(tabPage);
            tabControl.SelectTab(tabPage);
        }

        private void panelButtonAddWord_MouseClick(object sender, MouseEventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageAddNewWord";
            UserControlAddNewWord userControlAddNewWord = new UserControlAddNewWord();
            AddTapPages(name, userControlAddNewWord);
        }
        private void panelButtonSortWord_MouseClick(object sender, MouseEventArgs e)
        {
            tabControl.TabPages.Clear();
            string name = "tabPageSortWord";
            UserControlSortWord userControl = new UserControlSortWord();
            AddTapPages(name, userControl);
        }

        private void panelButtonAddWord_MouseHover(object sender, EventArgs e)
        {
            panelButtonAddWord.BackColor = Color.BlueViolet;
            Cursor = Cursors.Hand;
        }

        private void panelButtonAddWord_MouseLeave(object sender, EventArgs e)
        {
            panelButtonAddWord.BackColor = Color.Transparent;
            Cursor = Cursors.Default;
        }

        private void panelButtonSortWord_MouseHover(object sender, EventArgs e)
        {
            panelButtonSortWord.BackColor = Color.BlueViolet;
            Cursor = Cursors.Hand;
        }

        private void panelButtonSortWord_MouseLeave(object sender, EventArgs e)
        {
            panelButtonSortWord.BackColor = Color.Transparent;
            Cursor = Cursors.Default;
        }
    }
}