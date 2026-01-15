using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson1;
using 贪吃蛇.Lesson3;
using 贪吃蛇.Lesson6;

namespace 贪吃蛇.Lesson4
{
    class Food : GameObject
    {
        public Food(Snake snake)
        {
            RandomPos(snake);
        }
        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("◇");
        }

        //随机位置的行为 需要考虑蛇和墙位置
        public void RandomPos(Snake snake)
        {
            //随机位置
            Random r = new Random();
            int x = r.Next(2,Game.w / 2 - 1) * 2;
            int y = r.Next(1, Game.h - 4);
            pos = new Position(x,y);
            //得到蛇
            //如果重合 就会进入if语句
            if(snake.CheckSamePos(pos))
            {
                RandomPos(snake);
            }
        }
    }
}
