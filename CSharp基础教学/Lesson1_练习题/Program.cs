using System;

namespace Lesson1_练习题
{
    /// <summary>
    /// QQ状态枚举
    /// </summary>
    enum E_QQStatus
    { 
        Online,
        Offline,
        Busy,
    }
    /// <summary>
    /// 杯型
    /// </summary>
    enum E_CupType
    {
        MediumCup,
        LargeCup,
        ExtraLargeCup,
    }
    /// <summary>
    /// 性别
    /// </summary>
    enum E_Sex
    {
        Man,
        Women,
    }
    /// <summary>
    /// 职业
    /// </summary>
    enum E_Occupation
    {
        Warrior,
        Hunter,
        Mage
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举练习题");
            #region 练习题一
            //定义QQ状态的枚举，并提示用户选择一个在线状态，我们接受输入的
            //数字，并将其转换成枚举类型

            //try
            //{
            //    E_QQStatus status;
            //    Console.WriteLine("请选择你的QQ状态(0在线 1离线 2忙碌)");
            //    //int Input = int.Parse(Console.ReadLine());
            //    //status = (E_QQStatus)Input;
            //    status = (E_QQStatus)int.Parse(Console.ReadLine());
            //    Console.WriteLine(status);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的类型");
            //}

            #endregion

            //Console.WriteLine("---------------------------");

            #region 练习题二
            //用户去星巴克买咖啡，分为中杯（35元），大杯（40元），超大杯
            //（43元），请用户选择要购买的类型，用户选择后，打印：您购买了
            //xx咖啡，花费了xx元
            //例：你购买了中杯咖排，花费了35元

            //int money;
            //string cupType;
            //try
            //{
            //    E_CupType ctype;
            //    Console.WriteLine("请选择你要购买的类型(0中杯 1大杯 2超大杯)");
            //    int cInput = int.Parse(Console.ReadLine());
            //    ctype = (E_CupType)cInput;
            //    switch (ctype)
            //    {
            //        case E_CupType.MediumCup:
            //            cupType = "中杯";
            //            money = 35;
            //            Console.WriteLine("您购买了{0}咖啡，花费了{1}元", cupType, money);
            //            break;
            //        case E_CupType.LargeCup:
            //            cupType = "大杯";
            //            money = 40;
            //            Console.WriteLine("您购买了{0}咖啡，花费了{1}元", cupType, money);
            //            break;
            //        case E_CupType.ExtraLargeCup:
            //            cupType = "超大杯";
            //            money = 43;
            //            Console.WriteLine("您购买了{0}咖啡，花费了{1}元", cupType, money);
            //            break;
            //    }

            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的类型");
            //}

            #endregion

            #region 练习题三
            /*请用户选择英雄性别与英雄职业，最后打印英雄的基本属性（攻击力，
              防御力，技能）
              性别：
              男(攻击力+50，防御力+100）
              女（攻击力+150，防御力+20）
              职业：
              战士(攻击力+20，防御力+100，技能：冲锋）
              猎人(攻击力+120，防御力+30，技能：假死）
              法师（攻击力+200，防御力+10，技能：奥术冲击）
              举例打印：你选择了“女性法师，攻击力：350，防御力：30职业
              技能：奥术冲击*/

            //try
            //{
            //    int mAtk = 50, mDfs = 100;
            //    int wAtk = 150, wDfs = 20;
            //    int warAtk = 20, warDfs = 30;
            //    int hunAtk = 120, hunDfs = 30;
            //    int mageAtk = 200, mageDfs = 10;

            //    string occ;
            //    string warOcc = "战士";
            //    string hunOcc = "猎人";
            //    string mageOcc = "法师";
            //    string skill;

            //    string warSkill = "冲锋";
            //    string hunSkill = "假死";
            //    string mageSkill = "奥术冲击";
            //    E_Sex eSex;
            //    E_Occupation eOcc;
            //    Console.WriteLine("请选择英雄性别(0男 1女)");
            //    int iSex = int.Parse(Console.ReadLine());
            //    eSex = (E_Sex)iSex;
            //    Console.WriteLine("请选择英雄职业(0战士 1猎人 2法师)");
            //    int iOcc = int.Parse(Console.ReadLine());
            //    eOcc = (E_Occupation)iOcc;

            //    switch (eSex)
            //    {
            //        case E_Sex.Man:
            //            switch (eOcc)
            //            {
            //                case E_Occupation.Warrior:
            //                    occ = warOcc;
            //                    mAtk += warAtk;
            //                    mDfs += warDfs;
            //                    skill = warSkill;
            //                    Console.WriteLine("你选择了男性{0}，攻击力：{1}，防御力：{2} 职业技能：{3}",occ,mAtk,mDfs,skill);
            //                    break;
            //                case E_Occupation.Hunter:
            //                    occ = hunOcc;
            //                    mAtk += hunAtk;
            //                    mDfs += hunDfs;
            //                    skill = hunSkill;
            //                    Console.WriteLine("你选择了男性{0}，攻击力：{1}，防御力：{2} 职业技能：{3}", occ, mAtk, mDfs, skill);
            //                    break;
            //                case E_Occupation.Mage:
            //                    occ = mageOcc;
            //                    mAtk += mageAtk;
            //                    mDfs += mageDfs;
            //                    skill = mageSkill;
            //                    Console.WriteLine("你选择了男性{0}，攻击力：{1}，防御力：{2} 职业技能：{3}", occ, mAtk, mDfs, skill);
            //                    break;
            //                default:
            //                    Console.WriteLine("请输入正确的类型");
            //                    break;
            //            }
            //            break;
            //        case E_Sex.Women:
            //            switch (eOcc)
            //            {
            //                case E_Occupation.Warrior:
            //                    occ = warOcc;
            //                    wAtk += warAtk;
            //                    wDfs += warDfs;
            //                    skill = warSkill;
            //                    Console.WriteLine("你选择了女性{0}，攻击力：{1}，防御力：{2} 职业技能：{3}", occ, wAtk, wDfs, skill);
            //                    break;
            //                case E_Occupation.Hunter:
            //                    occ = hunOcc;
            //                    wAtk += hunAtk;
            //                    wDfs += hunDfs;
            //                    skill = hunSkill;
            //                    Console.WriteLine("你选择了女性{0}，攻击力：{1}，防御力：{2} 职业技能：{3}", occ, wAtk, wDfs, skill);
            //                    break;
            //                case E_Occupation.Mage:
            //                    occ = mageOcc;
            //                    wAtk += mageAtk;
            //                    wDfs += mageDfs;
            //                    skill = mageSkill;
            //                    Console.WriteLine("你选择了女性{0}，攻击力：{1}，防御力：{2} 职业技能：{3}", occ, wAtk, wDfs, skill);
            //                    break;
            //                default:
            //                    Console.WriteLine("请输入正确的类型");
            //                    break;
            //            }
            //            break;
            //        default:
            //            Console.WriteLine("请输入正确的类型");
            //            break;
            //    }

            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确的类型");
            //}

            #endregion
        }
    }
}
