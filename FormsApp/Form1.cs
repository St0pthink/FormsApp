using System.Text.RegularExpressions;

namespace FormsApp
{
    public partial class Anket : Form
    {
        public Anket()
        {
            InitializeComponent();
        }
        private string previous = "";
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /*private void check(object sender, EventArgs e)
        {
            string pattern = @"^[-+]?(?:(?:0|[1-9]\d*)(?:[.,]\d+)?|(?:[.,]\d+))(?:[eE][-+]?(?:0|[1-9]\d*))?$";
            string zero = "";
            if (Regex.IsMatch(textBox1.Text, pattern))
            {

            }
            else
            {
                textBox1.Text = zero;
            }
        }

        private void insert(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsControl(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == ',' || (e.KeyChar == '-' && textBox1.SelectionStart == 0 && !textBox1.Text.Contains("-"))))
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && (textBox1.Text.Contains(".") || textBox1.Text.Contains(",")))
            {
                e.Handled = true;
                return;
            }

            if ((e.KeyChar == '.' || e.KeyChar == ',') && textBox1.Text.Length == 0)
            {
                e.Handled = true;
                return;
            }
            if ((e.KeyChar == '.' || e.KeyChar == ',') && (textBox1.SelectionStart == 0 || !char.IsDigit(textBox1.Text[textBox1.SelectionStart - 1])))
            {
                e.Handled = true;
                return;
            }

            if (textBox1.Text == "0" && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
            if (textBox1.Text == "-0" && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }
        private void ctrv_check(object sender, KeyEventArgs e)
        {
            string pattern = @"^[-+]?(?:(?:0|[1-9]\d*)(?:[.,]\d+)?|(?:[.,]\d+))(?:[eE][-+]?(?:0|[1-9]\d*))?$";
            if ((e.Control && e.KeyCode == Keys.V) || (e.Shift && e.KeyCode == Keys.Insert))
            {
                if (Regex.IsMatch(textBox1.Text + Clipboard.GetText(), pattern))
                {

                }         
                else
                {
                    e.SuppressKeyPress = true;
                }
            }
        } */
        private void save(object sender, EventArgs e)
        {   
            //String
            if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Fail username");
                    return;
                }
            string text = textBox2.Text;    

            //Type
            if (comboBox1.SelectedItem == null || string.IsNullOrWhiteSpace(comboBox1.SelectedItem.ToString()))
            {
                MessageBox.Show("Fail type");
                return;
            }
            string combo = comboBox1.SelectedItem.ToString();

            //Number
            if (textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text.Replace('.', ',');
            }

            if (!double.TryParse(textBox1.Text, out double number))
            {
                MessageBox.Show("Fail number");
                return;
            }


            object[] data = {text, number, combo};
            MessageBox.Show($"Текст: {data[0]}\nЧисло: {data[1]}\nВыбор: {data[2]}");
        }

        private void check_easy(object sender, EventArgs e)
        {
            string pattern = @"^[-+]?(?:(?:0(?:[.,]\d*)?)|(?:[1-9]\d*(?:[.,]\d*)?)|(?:[.,]\d*))?$";
            if (Regex.IsMatch(textBox1.Text, pattern))
            {
                previous = textBox1.Text; 
            }
            else
            {
                textBox1.Text = previous;
                textBox1.SelectionStart = textBox1.Text.Length;
            }
        }
        private void check_hard(object sender, EventArgs e)
        {
            string pattern = @"^(?:\+?(?:(?:0(?:[.,]\d+)?|[1-9]\d*(?:[.,]\d+)?|[.,]\d+))|-(?:(?:0(?:[.,]\d+)|[1-9]\d*(?:[.,]\d+)?|[.,]\d+)))$";
            if (Regex.IsMatch(textBox1.Text, pattern))
            {

            }
            else
            {
                textBox1.Text = "";
            }
        }
    }
}
