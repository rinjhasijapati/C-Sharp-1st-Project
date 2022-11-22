namespace Third_Sem_Projet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string data = textBox1.Text;
            if (data == "test")
            {
                MessageBox.Show("Success");
            }
            else
            {
                MessageBox.Show("Failed");
            }
            for (int i = 0; i < 3; i++)
            {
                 MessageBox.Show("Display Time:  " + i);
            }
            // MessageBox.Show("Your name is " + data);

         //   try
         //   {
        //        int age_input = Convert.ToInt32(age.text);
         //       MessageBox.Show("Age: " + age_input);
        //    }
         //   catch (Exception ex)
        //   {
         //       MessageBox.Show("Invalid Number");


         //   }

        }
    }
}