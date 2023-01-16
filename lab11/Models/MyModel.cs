namespace lab11.Models
{
    public class MyModel
    {
        public int X { get; }
        public int Y { get; }

        public string add { get; }
        public string sub { get; }
        public string mul { get; }
        public string div { get; }
 
        public MyModel(int x,int y) {
            X = x;
            Y= y;
            add = $"{x} + {y} = {x + y}";
            sub = $"{x} - {y} = {x - y}";
            mul = $"{x} * {y} = {x * y}";
            if (y == 0) div = $"{x} / {y} = Error division by 0";
            else div = $"{x} / {y} = {x / y}";
        }
    }
}
