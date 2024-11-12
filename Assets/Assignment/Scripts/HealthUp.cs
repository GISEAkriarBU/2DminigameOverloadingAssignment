using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : PowerUp
{
    int healthIncrease;
    private void Start() 
    {
        healthIncrease = 20;
    }
    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(healthIncrease);
    }
}
