using System.Text;

namespace Lab5.Model
{
    public class MultiplicationTable
    {
        public string GenerateTable(int number)
        {
            StringBuilder table = new StringBuilder();
            table.AppendLine($"Таблиця множення для числа {number}:");
            table.AppendLine("------------------------");

            for (int i = 1; i <= 10; i++)
            {
                table.AppendLine($"{number} × {i} = {number * i}");
            }

            return table.ToString();
        }
    }
}