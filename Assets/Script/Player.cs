using UnityEngine;
public class Player : MonoBehaviour
{
    private CharacterFactory characterFactory;

    private WeaponFactory weaponFactory;

    public Player()
    {
        characterFactory = new CharacterFactory();
        weaponFactory = new WeaponFactory();
    }

    public ICharacter CreateCharacter(string characterType)
    {
        return characterFactory.CreateCharacter(characterType);
    }

    public IWeapon CreateWeapon(string weaponType)
    {
        return weaponFactory.CreateWeapon(weaponType);
    }

    protected void Attack()
    {

    }

    

    

}
