using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6_4_714240039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SetErrorMessages(TextBox txt, string warn, string wrong, string correct)
        {
            epWarning.SetError(txt, warn);
            epWrong.SetError(txt, wrong);
            epCorrect.SetError(txt, correct);
        }

        private void IbINumeric_TextChanged(object sender, EventArgs e)
        {
            if (IbINumeric.Text.All(Char.IsDigit))
                SetErrorMessages(IbINumeric, "", "", "OK");
            else
                SetErrorMessages(IbINumeric, "", "Harus angka!", "");
        }

        private void IbIChar_Leave(object sender, EventArgs e)
        {
            if (IbIChar.Text == "")
                SetErrorMessages(IbIChar, "Harus diisi!", "", "");
            else if (!IbIChar.Text.All(Char.IsLetter))
                SetErrorMessages(IbIChar, "", "Hanya boleh huruf!", "");
            else
                SetErrorMessages(IbIChar, "", "", "OK");
        }

        private void IbIRequired_Leave(object sender, EventArgs e)
        {
            if (IbIRequired.Text == "")
                SetErrorMessages(IbIRequired, "Harus diisi!", "", "");
            else
                SetErrorMessages(IbIRequired, "", "", "OK");
        }

        private void IbIRegex_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$";

            if (Regex.IsMatch(IbIRegex.Text, pattern))
                SetErrorMessages(IbIRegex, "", "", "Email valid");
            else
                SetErrorMessages(IbIRegex, "", "Format email salah!", "");
        }

        private void IbIA1_Leave(object sender, EventArgs e)
        {
            if (!IbIA1.Text.All(Char.IsDigit))
            {
                SetErrorMessages(IbIA1, "", "Harus angka!", "");
                return;
            }

            SetErrorMessages(IbIA1, "", "", "OK");
        }

        private void IbIA2_Leave(object sender, EventArgs e)
        {
            if (!IbIA2.Text.All(Char.IsDigit))
            {
                SetErrorMessages(IbIA2, "", "Harus angka!", "");
                return;
            }

            if (IbIA1.Text == "")
            {
                SetErrorMessages(IbIA2, "", "Sugar Level 1 harus diisi!", "");
                return;
            }

            int a1 = int.Parse(IbIA1.Text);
            int a2 = int.Parse(IbIA2.Text);

            if (a1 > a2)
                SetErrorMessages(IbIA2, "", "", "Benar (Level1 > Level2)");
            else
                SetErrorMessages(IbIA2, "", "Sugar Level 1 harus lebih besar!", "");
        }

        private void IbILength_TextChanged(object sender, EventArgs e)
        {
            if (IbILength.Text.Length < 5)
                SetErrorMessages(IbILength, "", "Min 5 karakter!", "");
            else if (IbILength.Text.Length > 10)
                SetErrorMessages(IbILength, "", "Max 10 karakter!", "");
            else
                SetErrorMessages(IbILength, "", "", "OK");
        }

        private void IbIUpper_TextChanged(object sender, EventArgs e)
        {
            int pos = IbIUpper.SelectionStart;
            IbIUpper.Text = IbIUpper.Text.ToUpper();
            IbIUpper.SelectionStart = pos;

            SetErrorMessages(IbIUpper, "", "", "OK");
        }

        private void IbILower_TextChanged(object sender, EventArgs e)
        {
            int pos = IbILower.SelectionStart;
            IbILower.Text = IbILower.Text.ToLower();
            IbILower.SelectionStart = pos;

            SetErrorMessages(IbILower, "", "", "OK");
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string msg =
        "Sweet Number : " + IbINumeric.Text + "\n" +
        "Lovely Letters : " + IbIChar.Text + "\n" +
        "Must Fill : " + IbIRequired.Text + "\n" +
        "Email : " + IbIRegex.Text + "\n" +
        "Sugar Level 1 : " + IbIA1.Text + "\n" +
        "Sugar Level 2 : " + IbIA2.Text + "\n" +
        "Dessert Code : " + IbILength.Text + "\n" +
        "UPPER Cream : " + IbIUpper.Text + "\n" +
        "lower cocoa : " + IbILower.Text;

            MessageBox.Show(msg, "Sweet Dessert Form");
        }
    }
    
}
