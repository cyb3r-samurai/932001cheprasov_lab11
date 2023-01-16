using lab11.Models;

namespace lab11.Services

{
    public class MyService : IMyService
    {
        private Random rand = new();



        public MyModel setModel()
        {
            int x = rand.Next()%11;
            int y = rand.Next()%11;
            return new MyModel(x, y);
        }
    }
}
