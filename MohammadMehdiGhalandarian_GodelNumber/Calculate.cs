using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohammadMehdiGhalandarian_GodelNumber
{
    public class Calculate
    {
        public List<int> NumberOflines = new List<int>();
        public List<int> primeNumber = new List<int>();
        public int CalculateNumberOfLine(int a, int b, int c)
        {
            int FirstCouple = 0;
            int SecondCouple = 0;

            FirstCouple = (((int)Math.Pow(2, b)) * ((2 * c) + 1)) - 1;
            SecondCouple = (((int)Math.Pow(2, a)) * ((2 * FirstCouple) + 1)) - 1;

            NumberOflines.Add(SecondCouple);
            return SecondCouple;
        }
        public int Get_lenghth_Of()
        {
            return NumberOflines.Count();
        }
        public void calculatePrimeNumber(int End)
        {
            bool Is_Prime;
            primeNumber.Add(2);

            for (int num = 3; num <= 10000000; num += 2)
            {
                if (primeNumber.Count == End)
                {
                    break;
                }
                Is_Prime = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        Is_Prime = false;
                        break;
                    }
                }
                if (Is_Prime)
                    primeNumber.Add(num);
            }
        }
        public string CalculateNumberOfProgram()
        {

            string numberOfProgram = "";
            string x;
            for (int i = 0; i < NumberOflines.Count; i++)
            {
                x = $"({primeNumber[i]}^{NumberOflines[i]})";
                if (i == NumberOflines.Count - 1)
                {
                    numberOfProgram += x;
                }
                else
                {
                    numberOfProgram += x + "*";
                }
            }
            return numberOfProgram;
        }

        public int Get_Power(int x, int y)
        {
            int Power = 0;
            while (x % y == 0)
            {
                x = x / y;
                Power = Power + 1;
            }
            return Power;
        }

        public bool IsPrime(int x)
        {
            if (x % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i < x; i += 2)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
        List<int[]> Prime_Pow = new List<int[]>();

        public int[] Decomposition(int number)
        {

            int max_prime = 0, counter = 0;
            int power = 0;


            power = Get_Power(number, 2);
            Prime_Pow.Add(new int[] { 2, power });

            if (power > 0)
            {
                max_prime = counter;
            }
            counter++;

            for (int i = 3; i <= number; i += 2)
            {
                if (!IsPrime(i))
                {
                    continue;
                }

                power = Get_Power(number, i);
                Prime_Pow.Add(new int[] { i, power });
                if (power > 0)
                {
                    max_prime = counter;
                }
                counter++;
            }

            int[] Godel_number = new int[max_prime + 1];
            for (int i = 0; i <= max_prime; i++)
            {
                Godel_number[i] = Prime_Pow[i][1];
            }

            return Godel_number;

        }
        public string calculate_inverse_Of_pairing_func(int result)
        {
            string X, Y;
            result++;
            if (result % 2 == 0)
            {
                Y = "0";
                X = Get_Power(result, 2).ToString();
            }
            else
            {
                X = "0";
                result--;
                Y = (result / 2).ToString();
            }
            return $"{X},{Y}";
        }
        List<string[]> a_b_c_OfLine = new List<string[]>();  //a_b_c_OfLine[0]-->label
                                                             //a_b_c_OfLine[1]-->Variable
                                                             //a_b_c_OfLine[2]-->Number oF b
        public List<string[]> get_A_B_C(int[] godel_number)
        {

            for (int i = 0; i < godel_number.Length; i++)
            {
                int a, b, c, result_of_func2;

                a = int.Parse(calculate_inverse_Of_pairing_func(godel_number[i]).Split(',')[0]);
                result_of_func2 = int.Parse(calculate_inverse_Of_pairing_func(godel_number[i]).Split(',')[1]);
                b = int.Parse(calculate_inverse_Of_pairing_func(result_of_func2).Split(',')[0]);
                c = int.Parse(calculate_inverse_Of_pairing_func(result_of_func2).Split(',')[1]);

                a_b_c_OfLine.Add(new String[] { Find_label(a), Find_variable(c + 1), b.ToString() });
            }
            return a_b_c_OfLine;
        }

        public string Find_label(int number)
        {
            if (number == 0)
            {
                return "";
            }
            if (number % 5 == 1)
            {
                return $"A{(number / 5) + 1}";
            }
            else if (number % 5 == 2)
            {
                return $"B{(number / 5) + 1}";
            }
            else if (number % 5 == 3)
            {
                return $"C{(number / 5) + 1}";
            }
            else if (number % 5 == 4)
            {
                return $"D{(number / 5) + 1}";
            }
            else
            {
                return $"E{(number / 5)}";
            }

        }

        public string Find_variable(int number)
        {
            if (number == 1)
            {
                return "Y";
            }
            if (number % 2 == 0)
            {
                return $"X{number / 2}";
            }
            else
            {
                return $"Z{(number - 1) / 2}";
            }
        }

        public void Clear()
        {
            a_b_c_OfLine.Clear();
            Prime_Pow.Clear();
            primeNumber.Clear();
            NumberOflines.Clear();
        }


    }
}
