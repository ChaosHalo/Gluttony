using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class trigger : MonoBehaviour
{
    public Rigidbody player;
    

    public Vector3 eatlist;

    public Text point_text;
    public Text level_text;

    public int point = 0;
    public int level = 1;

    public AudioSource eat;

    //public monster plant = new monster("plant", 1, 1);
    private void Awake()
    {
        eat = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        switch (collision.gameObject.tag)
        {
            case monster.PLANT_NAME: //植物
                if (level >= monster.plant.level)
                {
                    eat_event(collision, monster.plant.point);
                }
                break;
            case monster.ANIMAL_NAME:   //动物
                if (level >= monster.animal.level)
                {
                    eat_event(collision, monster.animal.point);
                }
                break;
            case monster.HUMAN_NAME:    //人类
                if (level >= monster.human.level)
                {
                    eat_event(collision, monster.human.point);
                }
                break;
            case monster.CAR_NAME:   //车
                if (level >= monster.car.level)
                {
                    eat_event(collision, monster.car.point);
                }
                break;
            case monster.SHIP_NAME:    //船
                if (level >= monster.ship.level)
                {
                    eat_event(collision, monster.ship.point);
                }
                break;
            case monster.CONTAINER_NAME:   //集装箱
                if (level >= monster.container.level)
                {
                    eat_event(collision, monster.container.point);
                }
                break;
            case monster.HOUSELET_NAME:    //小房子
                if (level >= monster.houselet.level)
                {
                    eat_event(collision, monster.houselet.point);
                }
                break;
            case monster.VILLA_NAME:   //别墅
                if (level >= monster.villa.level)
                {
                    eat_event(collision, monster.villa.point);
                }
                break;
        }
        set_player_level();
        point_text.text = point.ToString();
        level_text.text = level.ToString();
    }

    private void eat_event(Collision collision, int point_)
    {
        Destroy(collision.gameObject);
        float size = (float)point_ / 10;
        Vector3 scale = new Vector3(size, size, size);
        player.transform.localScale += scale;
        point += point_;
        eat.Play();
    }
    public void set_player_level()
    {
        int i = 1;
        for (i = 1; i <= point_Chart.player_level_need_point.Length; i++)
        {
            if (point_Chart.player_level_need_point[i] > point) break;
        }
        level = i;
    }
}