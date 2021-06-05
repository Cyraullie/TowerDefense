using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//TODO : changer le nom de level à autre chose 

public class Ennemy : MonoBehaviour
{
    private int id;

    protected int life;                       //Vie total
    protected int damage;                     //Dégats par coup
    protected bool physical_damage;
    protected int physical_resistance;        //La résistance aux dégats physique
    protected int magic_resistance;           //La résistance aux dégats magique

    protected string ennemy_type;
    protected int movement_speed;             //la vitesse de déplacement

    protected int attack_speed;               //la vitesse d'attack
    protected string attack_type;                //le type d'attaque (zone?/cac/distance)
    protected int range;                      //Portée
    protected string special_ability;            //Pouvoir spécial (soin ou autre)

    protected int loot;                       //Quantité de gold donnée à la mort

    protected int level;                      //Sorte de monstre d'une même race
    protected string ennemy_name;             //Nom de l'ennemie invoquer

    public Ennemy(int id, string ennemy_type)
    {
        this.id = id;
        this.ennemy_type = ennemy_type;
    }


    public Ennemy Create(int id, int level, string ennemy_type)
    {
        var ennemy = new Ennemy(id, ennemy_type);
        ennemy.level = level;
        switch(ennemy_type)
        {
            case "Goblin":
                switch (level)
                {
                    case 1:
                        ennemy.ennemy_name = "Goblin standard";
                        ennemy.life = 10;
                        ennemy.damage = 1;
                        ennemy.physical_damage = true;
                        ennemy.physical_resistance = 0;
                        ennemy.magic_resistance = 0;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 10;
                        ennemy.attack_type = "cac";
                        ennemy.range = 2;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 2:
                        ennemy.ennemy_name = "Goblin archer";
                        ennemy.life = 5;
                        ennemy.damage = 1;
                        ennemy.physical_damage = true;
                        ennemy.physical_resistance = 0;
                        ennemy.magic_resistance = 0;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 10;
                        ennemy.attack_type = "range";
                        ennemy.range = 10;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 3:
                        ennemy.ennemy_name = "Goblin shaman";
                        ennemy.life = 5;
                        ennemy.damage = 1;
                        ennemy.physical_damage = false;
                        ennemy.physical_resistance = 0;
                        ennemy.magic_resistance = 3;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 10;
                        ennemy.attack_type = "range";
                        ennemy.range = 10;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 4:
                        ennemy.ennemy_name = "Goblin paladin";
                        ennemy.life = 10;
                        ennemy.damage = 1;
                        ennemy.physical_damage = true;
                        ennemy.physical_resistance = 3;
                        ennemy.magic_resistance = 0;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 10;
                        ennemy.attack_type = "cac";
                        ennemy.range = 2;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 5:
                        ennemy.ennemy_name = "Goblin monté";
                        ennemy.life = 10;
                        ennemy.damage = 1;
                        ennemy.physical_damage = true;
                        ennemy.physical_resistance = 3;
                        ennemy.magic_resistance = 0;
                        ennemy.movement_speed = 10;
                        ennemy.attack_speed = 10;
                        ennemy.attack_type = "cac";
                        ennemy.range = 2;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 6:
                        ennemy.ennemy_name = "Goblin sorcier";
                        ennemy.life = 10;
                        ennemy.damage = 1;
                        ennemy.physical_damage = false;
                        ennemy.physical_resistance = 0;
                        ennemy.magic_resistance = 2;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 5;
                        ennemy.attack_type = "cac";
                        ennemy.range = 10;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 7: //BOSS
                        ennemy.ennemy_name = "Seigneur Goblin";
                        ennemy.life = 50;
                        ennemy.damage = 10;
                        ennemy.physical_damage = true;
                        ennemy.physical_resistance = 5;
                        ennemy.magic_resistance = 5;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 2;
                        ennemy.attack_type = "cac";
                        ennemy.range = 2;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;
                }
                break;

            case "Orc":
                switch (level)
                {
                    case 1:
                        ennemy.ennemy_name = "Orc standard";
                        ennemy.life = 10;
                        ennemy.damage = 1;
                        ennemy.physical_damage = true;
                        ennemy.physical_resistance = 0;
                        ennemy.magic_resistance = 0;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 10;
                        ennemy.attack_type = "cac";
                        ennemy.range = 2;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 2:
                        ennemy.ennemy_name = "Orc archer";
                        ennemy.life = 5;
                        ennemy.damage = 1;
                        ennemy.physical_damage = true;
                        ennemy.physical_resistance = 0;
                        ennemy.magic_resistance = 0;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 10;
                        ennemy.attack_type = "range";
                        ennemy.range = 10;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 3:
                        ennemy.ennemy_name = "Orc shaman";
                        ennemy.life = 5;
                        ennemy.damage = 1;
                        ennemy.physical_damage = false;
                        ennemy.physical_resistance = 0;
                        ennemy.magic_resistance = 3;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 10;
                        ennemy.attack_type = "range";
                        ennemy.range = 10;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 4:
                        ennemy.ennemy_name = "Orc paladin";
                        ennemy.life = 10;
                        ennemy.damage = 1;
                        ennemy.physical_damage = true;
                        ennemy.physical_resistance = 3;
                        ennemy.magic_resistance = 0;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 10;
                        ennemy.attack_type = "cac";
                        ennemy.range = 2;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 5:
                        ennemy.ennemy_name = "Orc monté";
                        ennemy.life = 10;
                        ennemy.damage = 1;
                        ennemy.physical_damage = true;
                        ennemy.physical_resistance = 3;
                        ennemy.magic_resistance = 0;
                        ennemy.movement_speed = 10;
                        ennemy.attack_speed = 10;
                        ennemy.attack_type = "cac";
                        ennemy.range = 2;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;

                    case 6: //BOSS
                        ennemy.ennemy_name = "Seigneur Orc";
                        ennemy.life = 50;
                        ennemy.damage = 10;
                        ennemy.physical_damage = true;
                        ennemy.physical_resistance = 5;
                        ennemy.magic_resistance = 5;
                        ennemy.movement_speed = 2;
                        ennemy.attack_speed = 2;
                        ennemy.attack_type = "cac";
                        ennemy.range = 10;
                        ennemy.special_ability = "";
                        ennemy.loot = 2;
                        break;
                }
                break;
        }
        


        
        return ennemy;
    }


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
