using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordMan : MonoBehaviour, ICharacter // Giả sử bạn đã đổi tên Charactor thành ICharacter và tuân theo quy ước đặt tên
{
    // Đảm bảo phương thức này phù hợp với tên và chữ ký từ giao diện ICharacter

    public GameObject imgHero;
    public string GetNameCharacter()
    {
        return "SwordMan";
    }

    public int GetHealth()
    {
        // Giả sử trả về một giá trị mặc định, bạn sẽ cần triển khai logic thực tế ở đây
        return 100;
    }

    public int GetArmor()
    {
        // Giả sử trả về một giá trị mặc định, bạn sẽ cần triển khai logic thực tế ở đây
        return 40;
    }

    public List<string> Inventory { get; } = new List<string>() {"sword"}; // Triển khai thuộc tính Inventory từ ICharacter

    public GameObject GetImgHero()
    {
        // Trả về hình ảnh của SwordMan
        return imgHero;
    }    // Constructor và các phương thức khác (nếu cần)

}
