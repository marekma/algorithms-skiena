using System;

namespace _001
{
    public class Binary
    {
        private int[] digits;

        public int Lenght => this.digits.Length;

        public int this[int index]
        {
            get
            {
                return this.digits[index];
            }
        }
        public Binary(int[] digits)
        {
            this.digits = digits;
        }

        public static Binary operator +(Binary a, Binary b)
        {
            int lenght = a.Lenght > b.Lenght ? a.Lenght : b.Lenght;
            int[] digits = new int[lenght + 1];
            int carry = 0;

            for (int i = lenght - 1; i >= 0; i--)
            {
                int r = a[i] + b[i] + carry;
                if (r % 2 == 0)
                {
                    r = 0;
                    carry = 1;
                }
                else if (r % 3 == 0)
                {
                    r = 0;
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
                digits[i + 1] = r;
            }
            digits[0] = carry;

            return new Binary(digits);
        }

        public override string ToString()
        {
            return string.Join("", this.digits);
        }

        public static void Test()
        {
            Binary b1 = new Binary(new int[2] { 0, 1 });
            Binary b2 = new Binary(new int[2] { 0, 1 });

            Binary sum = b1 + b2;

            Asserts.Equals("010", string.Join("", sum));
        }
    }
}