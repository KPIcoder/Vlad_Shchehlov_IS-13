namespace Lab0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double y, a, x, z;

        private void arg_a_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (arg_a.Text != "")
                    a = double.Parse(arg_a.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show($"Invalid value -> {arg_a.Text}");
                arg_a.Text = "";
            }
        }

        private void arg_x_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (arg_x.Text != "")
                    x = double.Parse(arg_x.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show($"Invalid value -> {arg_x.Text}");
                arg_x.Text = "";
            }

        }

        private void arg_z_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (arg_z.Text != "")
                    z = double.Parse(arg_z.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show($"Invalid value -> {arg_z.Text}");
                arg_z.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkGray;
            Random rand = new Random();
            int c = rand.Next(1, 12);
            switch (c)
            {
                case 1: button2.BackColor = Color.Red; break;
                case 2: button2.BackColor = Color.Green; break;
                case 3: button2.BackColor = Color.Yellow; break;
                case 4: button2.BackColor = Color.Green; break;
                case 5: button2.BackColor = Color.Gray; break;
                case 6: button2.BackColor = Color.Blue; break;
                case 7: button2.BackColor = Color.Cyan; break;
                case 8: button2.BackColor = Color.DarkBlue; break;
                case 9: button2.BackColor = Color.DarkCyan; break;
                case 10: button2.BackColor = Color.DarkGray; break;
                case 11: button2.BackColor = Color.DarkRed; break;
                case 12: button2.BackColor = Color.DarkGreen; break;
            }
            if (button2.BackColor == Color.Green)
            {
                if (arg_a.Text.Length == 0 || arg_x.Text.Length == 0)
                {
                    MessageBox.Show("Please, enter all necessary arguments");
                    return;
                }
                else if (x == 1 || a == -2)
                {
                    MessageBox.Show("Can`t divide by 0");
                    return;
                }
                y = (x * x * x + 2 * a * x + 3) / ((x - 1) * (x - 1)) + Math.Cos(x * x) / (a + 2);
                MessageBox.Show($"According to your arguments the result is -> {y}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.DarkBlue;
            Random rand = new Random();
            int c = rand.Next(1, 12);
            switch (c)
            {
                case 1: button1.BackColor = Color.Red; break;
                case 2: button1.BackColor = Color.Green; break;
                case 3: button1.BackColor = Color.Yellow; break;
                case 4: button1.BackColor = Color.Red; break;
                case 5: button1.BackColor = Color.Gray; break;
                case 6: button1.BackColor = Color.Blue; break;
                case 7: button1.BackColor = Color.Cyan; break;
                case 8: button1.BackColor = Color.DarkBlue; break;
                case 9: button1.BackColor = Color.DarkCyan; break;
                case 10: button1.BackColor = Color.DarkGray; break;
                case 11: button1.BackColor = Color.DarkRed; break;
                case 12: button1.BackColor = Color.DarkGreen; break;
            }
            if (button1.BackColor == Color.Red)
            {
                if (arg_z.Text.Length == 0 || arg_x.Text.Length == 0)
                {
                    MessageBox.Show("Please, enter all necessary arguments");
                    return;
                }
                else if (x == 1 || z == 2)
                {
                    MessageBox.Show("Can`t divide by 0");
                    return;
                }
                y = (x + 2 * x + 3) / (z - 2) + Math.Atan(z);
                MessageBox.Show($"According to your arguments the result is -> {y}");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}