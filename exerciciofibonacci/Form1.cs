namespace exerciciofibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int n1 = 0, n2 = 1, n3; 
            lstfibonacci.Items.Clear();
            lstfibonacci.Items.Add(n1); 
            lstfibonacci.Items.Add(n2);

            for (int i = 3; i <= 30 ; i++) {
                n3 = n1 + n2;
                lstfibonacci.Items.Add(n3);
                    n1 = n2;
                    n2 = n3;
            }
        }
       
    } 
}
