internal class Program
{
    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine(storedData[i]);
                Console.WriteLine(inputDates[i]);
            }
        }
    }
    private static void Main(string[] args)
    {
        SimpleDataBase<int> dataBase = new SimpleDataBase<int>();
        dataBase.AddNewData(1);
        dataBase.AddNewData(2);
        dataBase.AddNewData(3);
        dataBase.PrintAllData();
        
    }
}