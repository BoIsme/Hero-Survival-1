using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordWeapon : MonoBehaviour, IWeapon
{   
    public GameObject imgWeapon;

      public string GetNameCharacter()
    {
        return "Sword";
    }

    public int GetDame()
    {
        return 10; // Điều chỉnh theo sát thương của Sword
    }

    public int RangeAttack()
    {
        return 1; // Điều chỉnh theo phạm vi tấn công của Sword
    }

    public int LevelWeapon()
    {
        return 1; // Điều chỉnh theo cấp độ của Sword
    }

    public GameObject GetImgWeapon()
    {
        // Trả về hình ảnh của Sword dưới dạng GameObject
        return imgWeapon; // Thay bằng GameObject chứa hình ảnh của Sword
    }
}
