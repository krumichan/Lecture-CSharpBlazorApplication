using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture_CSharpBlazorApplication.Data
{
    public class Food
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public interface IFoodService
    {
        IEnumerable<Food> GetFoods();
    }

    public class FoodService : IFoodService
    {
        public IEnumerable<Food> GetFoods()
        {
            List<Food> foods = new List<Food>()
            {
                new Food() { Name="Bibimbap", Price = 7000 },
                new Food() { Name="Kimbap", Price = 3000 },
                new Food() { Name="Bossam", Price = 9000 }
            };

            return foods;
        }
    }

    public class FastFoodService : IFoodService
    {
        public IEnumerable<Food> GetFoods()
        {
            List<Food> foods = new List<Food>()
            {
                new Food() { Name="Hamburger", Price = 2000 },
                new Food() { Name="Fries", Price = 500 }
            };

            return foods;
        }
    }

    public class PaymentService
    {
        IFoodService _service;

        public PaymentService(IFoodService service)
        {
            _service = service;
        }

        // TODO
    }

    // Server가 최초 실행될 때부터 계속 같은 Instance를 유지.
    public class SingletonService : IDisposable
    {
        public Guid ID { get; set; }

        public SingletonService()
        {
            ID = Guid.NewGuid();
        }

        public void Dispose()
        {
            Console.WriteLine("SingletonService Disposed");
        }
    }

    // 같은 Page를 요청을 할 때마다 Instance를 생성.
    public class TransientService : IDisposable
    {
        public Guid ID { get; set; }

        public TransientService()
        {
            ID = Guid.NewGuid();
        }

        public void Dispose()
        {
            Console.WriteLine("TransientService Disposed");
        }
    }

    // 처음 접속을 할 경우 한 번 Instance를 생성.
    // 새로고침을 누르면 Instance가 다시 생성된다.
    public class ScopedService : IDisposable
    {
        public Guid ID { get; set; }

        public ScopedService()
        {
            ID = Guid.NewGuid();
        }

        public void Dispose()
        {
            Console.WriteLine("ScopedService Disposed");
        }
    }
}
