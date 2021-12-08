namespace lab3Krutov
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.ContextMenuStrip = contextMenuStrip1;
            this.KeyUp += new KeyEventHandler(OKP);

        }
        private void OKP(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                toolStripMenuItem1.DropDownItems.Add("Undo");
                toolStripMenuItem1.DropDownItems.Add("Cut");
                toolStripMenuItem1.DropDownItems.Add("Copy");
                toolStripMenuItem1.DropDownItems.Add("Paste");
            }
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Alt)
            {
                MessageBox.Show("deb");
            }
        }
        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (checkToolStripMenuItem.Checked == false)
            {
                messageToolStripMenuItem.Enabled = false;
            }
            else
            {
                messageToolStripMenuItem.Enabled = true;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Додаток: Лабораторна робота №1.3 з людино-машиної взаємодії\n" +
                "Розробник: студент групи ПІ-225Б Крутов Дмитро\n" +
                "Версія додатку: 1.0.1");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkToolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            if (fffToolStripMenuItem.Checked == false)
            {
                fffToolStripMenuItem.Enabled = false;
            }
            else
            {
                fffToolStripMenuItem.Enabled = true;
            }
        }
    }
}