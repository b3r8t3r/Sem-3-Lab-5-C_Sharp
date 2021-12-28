using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Sem_3_Lab_5_C_Sharp
{
    class Program
    {
        static void Main(string [] args)
        {
            //StreamWriter file_in = new StreamWriter("Data_in.txt",true);
            //file_in.Close();
            StreamWriter file_out = new StreamWriter("Data_out.txt",true);
            file_out.Close();


            List<Currency> Currencies = new List<Currency>();
            StreamReader reader = new StreamReader("Data_in.txt");
            char Symbol;
            double Value = 0, Sum = 0;
            int number_of_lines = 0;

            number_of_lines = Convert.ToInt32(reader.ReadLine());

            for (int i = 0; i < number_of_lines; i++)
            {
                Symbol = Convert.ToChar(reader.Read());
                reader.Read();
                Value = Convert.ToDouble(reader.ReadLine());
                switch (Symbol)
                {
                    case 'D':
                        Currencies.Add(new Dollar(Value));
                        break;
                    case 'E':
                        Currencies.Add(new Euro(Value));
                        break;
                }
            }
            reader.Close();

            foreach(Currency currency in Currencies)
            {
                currency.Convert();
                Sum += currency.GetBack();
            }

            StreamWriter writer = new StreamWriter("Data_out.txt");
            writer.WriteLine(Convert.ToString(Sum));
            writer.Close();
        }
    }
}