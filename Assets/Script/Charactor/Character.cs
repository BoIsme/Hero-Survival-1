using System.Collections.Generic;
using UnityEngine;

public interface ICharacter
{
    string GetNameCharacter();
    int GetHealth();

    int GetArmor();
    List<string> Inventory { get; } // Biến nó thành một thuộc tính chỉ đọc và Inventory để chứa các item tiến hóa vũ khí

    
    GameObject GetImgHero();
}
