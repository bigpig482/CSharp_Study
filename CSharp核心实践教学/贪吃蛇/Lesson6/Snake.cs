using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 贪吃蛇.Lesson3;
using 贪吃蛇.Lesson4;
using 贪吃蛇.Lesson5;

namespace 贪吃蛇.Lesson6
{
    /// <summary>
    /// 蛇的移动方向
    /// </summary>
    enum E_MoveDir
    {
        /// <summary>
        /// 上
        /// </summary>
        Up,
        /// <summary>
        /// 下
        /// </summary>
        Down, 
        /// <summary>
        /// 左
        /// </summary>
        Left, 
        /// <summary>
        /// 右
        /// </summary>
        Right,
    }
    class Snake : IDraw
    {
        SnakeBody[] bodys;
        //记录当前蛇的长度
        int nowNum;
        //当前移动的方向
        E_MoveDir dir;
        public Snake(int x,int y)
        {
            //简单粗暴设计一个较大的数组
            bodys = new SnakeBody[200];

            bodys[0] = new SnakeBody(E_SnakeBody_Type.Head,x,y);
            nowNum = 1;
            dir = E_MoveDir.Right;
        }
        public void Draw()
        {
            //画一节一节身体
            for (int i = 0;i < nowNum;i++)
            {
                bodys[i].Draw();
            }
        }

        #region Lesson7 蛇的移动
        public void Move()
        {
            //移动前
            //擦除最后一个位置
            SnakeBody lastBody = bodys[nowNum - 1];
            Console.SetCursorPosition(lastBody.pos.x,lastBody.pos.y);
            Console.Write("  ");

            //在蛇头移动之前 从蛇尾开始 不停的 让后一个的位置 等于前一个的位置
            for(int i = nowNum - 1; i > 0;i--)
            {
                bodys[i].pos = bodys[i - 1].pos;
            }

            switch (dir)
            {
                case E_MoveDir.Up:
                    --bodys[0].pos.y;
                    break;
                case E_MoveDir.Down:
                    ++bodys[0].pos.y;
                    break;
                case E_MoveDir.Left:
                    bodys[0].pos.x -= 2;
                    break;
                case E_MoveDir.Right:
                    bodys[0].pos.x += 2;
                    break;
            }
        }
        #endregion

        #region Lesson8 改变方向
        public void ChangeDir(E_MoveDir dir)
        {
            //只有头部的时候 可以直接左转右 右转左 上转下 下转上
            //有身体时 这种情况就不能直接转

            if (this.dir == dir ||
                nowNum > 1 &&
                (this.dir == E_MoveDir.Left && dir == E_MoveDir.Right)||
                (this.dir == E_MoveDir.Right && dir == E_MoveDir.Left)||
                (this.dir == E_MoveDir.Down && dir == E_MoveDir.Up)||
                (this.dir == E_MoveDir.Up && dir == E_MoveDir.Down))
            {
                return;
            }

            this.dir = dir;
        }
        #endregion

        #region Lesson9 撞墙撞身体结束逻辑
        public bool CheckEnd(Map map)
        {
            for (int i = 0;i < map.walls.Length;i++)
            {
                if (bodys[0].pos == map.walls[i].pos)
                {
                    return true;
                }
            }

            for (int i = 1; i < nowNum;i++)
            {
                if (bodys[0].pos == bodys[i].pos)
                {
                    return true;
                }
            }
            return false;
        }
        #endregion

        #region Lesson10 吃食物相关
        public bool CheckSamePos(Position p)
        {
            for(int i = 0;i < nowNum;i++)
            {
                if (bodys[i].pos == p)
                {
                    return true;
                }
            }
            return false;
        }

        //吃食物
        public void CheckEatFood(Food food)
        {
            if (bodys[0].pos == food.pos)
            {
                //吃到了 就让食物再随机 增夹蛇身体的长度
                food.RandomPos(this);

                //长身体
                AddBody();
            }
        }
        #endregion

        #region Lesson11 长身体
        private void AddBody()
        {
            SnakeBody frontBody = bodys[nowNum - 1];
            //先长
            bodys[nowNum] = new SnakeBody(E_SnakeBody_Type.Body, frontBody.pos.x, frontBody.pos.y);
            //再加长度
            ++nowNum;
        }
        #endregion
    }
}
