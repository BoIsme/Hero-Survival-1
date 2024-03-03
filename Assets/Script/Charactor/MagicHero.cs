using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicHero : MonoBehaviour, ICharacter
{
    public GameObject imgHero;

    // Đảm bảo phương thức này phù hợp với tên và chữ ký từ giao diện ICharacter
    public string GetNameCharacter()
    {
        return "MagicHero";
    }

    public int GetHealth()
    {
        // Giả sử trả về một giá trị mặc định, bạn sẽ cần triển khai logic thực tế ở đây
        return 80; // Giả sử MagicHero có ít máu hơn SwordMan do đặc tính phòng thủ yếu hơn
    }

    // Giả sử MagicHero không sử dụng giáp như SwordMan nhưng có khả năng phòng thủ phép thuật
    public int GetMagicDefense()
    {
        // Giả sử trả về một giá trị mặc định, bạn sẽ cần triển khai logic thực tế ở đây
        return 60;
    }

    public List<string> Inventory { get; } = new List<string>() {"basic spell"}; // Triển khai thuộc tính Inventory từ ICharacter với một phép thuật cơ bản

    // Constructor và các phương thức khác (nếu cần)

    // Bạn có thể thêm các phương thức đặc biệt cho MagicHero, như một phương thức để sử dụng phép thuật
    public int GetArmor()
    {
        // Giả sử trả về một giá trị mặc định, bạn sẽ cần triển khai logic thực tế ở đây
        return 40;
    }
    public GameObject GetImgHero()
    {
        // Trả về hình ảnh của SwordMan
        return imgHero;
    }
}
