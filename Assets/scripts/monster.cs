using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monster : MonoBehaviour
{
    public int level;
    public int point;
    public monster(int level_, int point_)
    {
        level = level_;
        point = point_;
    }

    public static monster plant = new monster(1, 1); //一定要声明成静态的
    public static monster human = new monster(2, 2);
    public static monster animal = new monster(2, 2);
    public static monster car = new monster(3, 4);
    public static monster ship = new monster(3, 4);
    public static monster container = new monster(4, 6);
    public static monster houselet = new monster(5, 10);
    public static monster villa = new monster(6, 50);

    public const string PLANT_NAME = ("plant");
    public const string HUMAN_NAME = ("human");
    public const string ANIMAL_NAME = ("animal");
    public const string CAR_NAME = ("car");
    public const string SHIP_NAME = ("ship");
    public const string CONTAINER_NAME = ("container");
    public const string HOUSELET_NAME = ("houselet");
    public const string VILLA_NAME = ("villa");
}

