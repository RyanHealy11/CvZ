using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeMenu : MonoBehaviour
{
    private Score money;
    private Shoot gun;
    private PlayerController dude;

    public int damagePrice = 5;
    public int speedPrice = 5;
    public int firePrice = 5;
    // Start is called before the first frame update
    void Start()
    {
        money = Score.instance;
        gun = Shoot.instance;
        dude = PlayerController.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpgradeDameage() 
    {
        if (money.curMoney >= damagePrice) 
        {
            money.curMoney -= damagePrice;
            damagePrice *= 2;
            gun.damage++;
        }
    }
    public void UpgradeSpeed() 
    {
        if (money.curMoney >= speedPrice) 
        {
            money.curMoney -= speedPrice;
            speedPrice *= 2;
            dude.speed++;
        }
    }
    public void UpgradeFireRate() 
    {
        if (money.curMoney >= firePrice) 
        {
            //implement fire rate
        }
    }
}
