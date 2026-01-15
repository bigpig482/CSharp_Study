using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson1;
using 贪吃蛇.Lesson4;
using 贪吃蛇.Lesson5;
using 贪吃蛇.Lesson6;

namespace 贪吃蛇.Lesson2
{
    class GameScene : ISceneUpdate
    {
        Map map;
        Snake snake;
        Food food;

        int updateIndex = 0;
        public GameScene()
        {
            map = new Map();
            snake = new Snake(40,10);
            food = new Food(snake);
        }

        public void Update()
        {
            if(updateIndex % 20000 == 0)
            {
                map.Draw();
                food.Draw();

                snake.Move();
                snake.Draw();

                //检测是否撞墙
                if(snake.CheckEnd(map))
                {
                    //结束逻辑
                    Game.ChangeScene(E_SceneType.End);
                }

                snake.CheckEatFood(food);
                
                updateIndex = 0;
            }
            updateIndex++;

            //判断有没有键盘输入
            if(Console.KeyAvailable)
            {
                //检测输入输出要每帧都检测才准确
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDir(E_MoveDir.Up);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDir(E_MoveDir.Down);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDir(E_MoveDir.Left);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDir(E_MoveDir.Right);
                        break;
                }
            }
        }
    }
}
