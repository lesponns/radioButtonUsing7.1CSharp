namespace radioButtonUsing7._1CSharp
{
    public partial class Form1 : Form
    {

        /* Mustafa Uysal */
        /* 202342501046  */
        public Form1() {InitializeComponent();}
        private void left_CheckedChanged(object sender, EventArgs e){
            metinKutusu.TextAlign = HorizontalAlignment.Left;
        }

        private void center_CheckedChanged(object sender, EventArgs e)
        {
            metinKutusu.TextAlign = HorizontalAlignment.Center;
        }

        private void right_CheckedChanged(object sender, EventArgs e)
        {
            metinKutusu.TextAlign = HorizontalAlignment.Right;
        }
    }
}
