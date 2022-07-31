using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MohammadMehdiGhalandarian_GodelNumber.Forms
{
    public partial class Write_program_By_Number : Form
    {
        public Write_program_By_Number()
        {
            InitializeComponent();
        }

        private Calculate calculate = new Calculate();

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Line", typeof(int));
            table.Columns.Add("Label", typeof(string));
            table.Columns.Add("Instruction", typeof(string));
            try
            {
                calculate.Clear();
                var Godels = calculate.Decomposition(Int32.Parse(NumberOfProgram.Text) + 1);

                var a_b_c_of_line = calculate.get_A_B_C(Godels);


                string Instruction;
                for (int i = 0; i < a_b_c_of_line.Count; i++)
                {
                    if (a_b_c_of_line[i][2] == "0")
                    {
                        Instruction = $"{a_b_c_of_line[i][1]} <--- {a_b_c_of_line[i][1]}";
                        table.Rows.Add(i + 1, a_b_c_of_line[i][0], Instruction);
                    }
                    else if (a_b_c_of_line[i][2] == "1")
                    {
                        Instruction = $"{a_b_c_of_line[i][1]} <--- {a_b_c_of_line[i][1]}+1";
                        table.Rows.Add(i + 1, a_b_c_of_line[i][0], Instruction);
                    }
                    else if (a_b_c_of_line[i][2] == "2")
                    {
                        Instruction = $"{a_b_c_of_line[i][1]} <--- {a_b_c_of_line[i][1]}-1";
                        table.Rows.Add(i + 1, a_b_c_of_line[i][0], Instruction);

                    }
                    else
                    {
                        string Label_OF_IF = calculate.Find_label(int.Parse(a_b_c_of_line[i][0]) - 2);
                        Instruction = $"IF {a_b_c_of_line[i][1]}!=0 Go To {Label_OF_IF}";
                        table.Rows.Add(i + 1, a_b_c_of_line[i][0], Instruction);
                    }

                }
                Dgv_Show_Program.DataSource = table;
                NumberOfProgram.Clear();


            }
            catch (Exception)
            {
                MessageBox.Show("Please Insure That your Input is Correct!!!");
            }


        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dgv_Show_Program.DataSource = null;
            this.Dgv_Show_Program.Rows.Clear();
            NumberOfProgram.Clear();
        }
    }
}
