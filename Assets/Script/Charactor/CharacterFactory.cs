using UnityEngine;
public class CharacterFactory : MonoBehaviour
{
    public ICharacter CreateCharacter(string characterType)
    {
        if (characterType == "SwordMan")
        {
            return new SwordMan();
        }
        else if (characterType == "MagicHero")
        {
            return new MagicHero();
        }
        else
        {
            Debug.LogError("Unknown character type: " + characterType);
            return null;
        }
    }
}
