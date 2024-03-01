
namespace TestingDynamicEditableTable.Data.GridData
{
    public class CarData : ICarData
    {
        public List<Car> GetCarList()
        {
            Random r = new Random();
            List<Car> carList = new List<Car>();

            carList.Add(new Car()
            {
                VinNumber = r.Next(10000, 43433),
                Make = "Nissan",
                Model = "Altima",
                Price = new decimal(r.Next(5000, 10000))
            });

            carList.Add(new Car()
            {
                VinNumber = r.Next(10000, 43433),
                Make = "Honda",
                Model = "Civic",
                Price = new decimal(r.Next(5000, 10000))
            });

            carList.Add(new Car()
            {
                VinNumber = r.Next(10000, 43433),
                Make = "Ford",
                Model = "Focus",
                Price = new decimal(r.Next(5000, 10000))
            });
            return carList;
        }
    }
}
