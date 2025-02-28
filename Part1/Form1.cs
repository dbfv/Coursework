﻿namespace Part1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            this.Text = "I like yo cut G"; //change window's name (title)

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            label5.Text = $"Character count: {textBox1.Text.Length}";  //display character count
            Validator.ValidateString(textBox1.Text, label5);

            if (Validator.errorList[0] == "String length is within 1-40 characters.") {
                label10.ForeColor = Color.Green;
                label10.Text = "✅ " + Validator.errorList[0];
            }
            else {
                label10.ForeColor = Color.Red;
                label10.Text = "❌ " + Validator.errorList[0];
            }

            if (Validator.errorList[1] == "All characters are uppercase letters!") {
                label12.ForeColor = Color.Green;
                label12.Text = "✅ " + Validator.errorList[1];
            }
            else {
                label12.ForeColor = Color.Red;
                label12.Text = "❌ " + Validator.errorList[1];
            }
        }//textbox1_TextChanged

        private void button1_Click(object sender, EventArgs e) {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e) {

        }

        private void label11_Click(object sender, EventArgs e) {

        }

        private void Form1_Paint(object sender, PaintEventArgs e) {

        }

        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void pictureBox2_Click(object sender, EventArgs e) {

        }

        private void label13_Click(object sender, EventArgs e) {

        }

        private void label10_Click(object sender, EventArgs e) {
            //console 1st line
        }

        private void label12_Click(object sender, EventArgs e) {
            //console 2nd line
        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }



        private void numericUpDown1_ValueChanged(object sender, EventArgs e) {

        }
    }
}





