namespace 类库测试
{
    class MyCustomAttribute : Attribute
    {

    }
    public class Player
    {
        [MyCustom()]
        public string name;
        public int hp;
        public int atk;
        public int def;

        public Player()
        {

        }
    }
}
