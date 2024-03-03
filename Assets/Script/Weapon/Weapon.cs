using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{
    string GetNameCharacter();
    int GetDame();

    int RangeAttack();

    int LevelWeapon();
    GameObject GetImgWeapon();   
}

