using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MohammadMehdiGhalandarian_GodelNumber
{
    public class Find_a_b_c
    {
        public int Find_a(string lable)
        {
            if (lable == "")
                return 0;
            int NumberOfCurrentLabel = 0;
            if (lable.Length > 1)
            {
                NumberOfCurrentLabel = Convert.ToInt32(lable[1].ToString());
            }

            string lbl = lable[0].ToString().ToUpper();
            switch (lbl)
            {
                case "A":
                    if (NumberOfCurrentLabel == 0)
                    {
                        return 1;
                    }
                    else
                    {
                        return ((NumberOfCurrentLabel - 1) * 5) + 1;
                    }

                case "B":
                    if (NumberOfCurrentLabel == 0)
                    {
                        return 2;
                    }
                    else
                    {
                        return ((NumberOfCurrentLabel - 1) * 5) + 2;
                    }
                case "C":
                    if (NumberOfCurrentLabel == 0)
                    {
                        return 3;
                    }
                    else
                    {
                        return ((NumberOfCurrentLabel - 1) * 5) + 3;
                    }
                case "D":
                    if (NumberOfCurrentLabel == 0)
                    {
                        return 4;
                    }
                    else
                    {
                        return ((NumberOfCurrentLabel - 1) * 5) + 4;
                    }
                case "E":
                    if (NumberOfCurrentLabel == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        return ((NumberOfCurrentLabel - 1) * 5) + 5;
                    }

            }

            return 0;
        }

        public int Find_b(string inst)
        {
            if (inst.Length == 1)
            {
                return 0;
            }

            if (inst.Contains("+"))
            {
                return 1;
            }
            else if ((inst.Contains("-")))
            {
                return 2;
            }
            else
            {
                return (Find_a(inst) + 2);
            }
        }

        public int Find_C(string variable)
        {
            string var = variable[0].ToString().ToLower();
            int amount = 0;
            if (variable.Length > 1&& variable[1].ToString()!="!"&& variable[1].ToString() != "=")
            {
                amount=Convert.ToInt32(variable[1].ToString());
            }

            switch (var)
            {
                case "y":
                    return 1-1;
                case "x":
                    if (amount == 0 || amount == 1)
                    {
                        return 2-1;
                    }
                    else
                    {
                        return (2 * amount)-1;
                    }
                case "z":
                    if (amount == 0 || amount == 1)
                    {
                        return 3-1;
                    }
                    else
                    {
                        return ((2 * amount) + 1)-1;
                    }
                default:
                   throw new Exception();  //means variable is not accept

            }

        }

    }
}
