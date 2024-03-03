using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponFactory : MonoBehaviour
{
     public IWeapon CreateWeapon(string weaponType)
    {
        if (weaponType == "Sword")
        {
            return new SwordWeapon();
        }
        // else if (weaponType == "Staff")
        // {
        //     return new MagicHero();
        // }
        else
        {
            Debug.LogError("Unknown weaponType type: " + weaponType);
            return null;
        }
    }
}
