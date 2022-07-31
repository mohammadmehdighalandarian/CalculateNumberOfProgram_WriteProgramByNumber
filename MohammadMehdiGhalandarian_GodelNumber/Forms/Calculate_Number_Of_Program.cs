using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MohammadMehdiGhalandarian_GodelNumber.NewFolder
{
    public partial class Calculate_Number_Of_Program : Form
    {
        private Find_a_b_c find = new Find_a_b_c();
        public Calculate_Number_Of_Program()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txt_Unc_lbl.Clear();
            txt_con_lbl.Clear();
            txt_con_var.Clear();
            txt_unc_inst.Clear();
            txt_unc_var.Clear();
            txt_condotional_lbl.Clear();
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Conditional.Enabled = true;
            pnl_unconditional.Enabled = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pnl_Conditional.Enabled = false;
            pnl_unconditional.Enabled = true;
        }

        private void calculate_btn(object sender, EventArgs e)
        {
            try
            {
                int lenghth = calculate.Get_lenghth_Of();
                calculate.calculatePrimeNumber(lenghth);
                string NumeberOfProgram = calculate.CalculateNumberOfProgram();
                MessageBox.Show($"Result: {NumeberOfProgram}");
            }
            catch (Exception)
            {
                MessageBox.Show("Please Insure That your Input is Correct!!");
            }

        }

        private void Calculate_Number_Of_Program_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Line", typeof(int));
            table.Columns.Add("Number", typeof(int));

            pnl_Conditional.Enabled = false;
        }

        private Calculate calculate = new Calculate();
        public static int numberofLine = 1;
        DataTable table = new DataTable();
        int a = 0, b = 0, c = 0;
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                
                a = find.Find_a(txt_Unc_lbl.Text);
                b = find.Find_b(txt_unc_inst.Text);
                c = find.Find_C(txt_unc_var.Text);

                int number = calculate.CalculateNumberOfLine(a, b, c);
                table.Rows.Add(numberofLine, number);
                dgv_show.DataSource = table;
                numberofLine++;

                txt_Unc_lbl.Clear();
                txt_con_lbl.Clear();
                txt_con_var.Clear();
                txt_unc_inst.Clear();
                txt_unc_var.Clear();
            }
            catch (Exception )
            {
                MessageBox.Show("Please Insure That your Input is Correct!!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                a = find.Find_a(txt_condotional_lbl.Text);
                b = find.Find_b(txt_con_lbl.Text);
                c = find.Find_C(txt_con_var.Text);

                int number = calculate.CalculateNumberOfLine(a, b, c);

                table.Rows.Add(numberofLine, number);
                dgv_show.DataSource = table;
                numberofLine++;

                txt_Unc_lbl.Clear();
                txt_con_lbl.Clear();
                txt_con_var.Clear();
                txt_unc_inst.Clear();
                txt_unc_var.Clear();
                txt_condotional_lbl.Clear();
            }
            catch (Exception )
            {
                MessageBox.Show("Please Insure That your Input is Correct!!");
            }
        }
    }
}
