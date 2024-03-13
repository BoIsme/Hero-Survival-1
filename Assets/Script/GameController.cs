using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Player player;
    [SerializeField] public GameObject playerPrefab; // Reference to the Player Prefab


    void Start()
    {
        // Kiểm tra xem đã gán Prefab vào trường playerPrefab chưa
        if (playerPrefab == null)
        {
            Debug.LogError("Player Prefab not assigned in the Inspector.");
            return;
        }

        // Tạo một instance của Prefab
        GameObject playerInstance = Instantiate(playerPrefab);

        // Lấy tham chiếu đến thành phần Player từ GameObject
        player = playerInstance.GetComponent<Player>();
        
        if (player == null)
        {
            Debug.LogError("Player component not found on the Player GameObject.");
            return;
        }

        // Tạo một nhân vật SwordMan
        ICharacter swordMan = player.CreateCharacter("SwordMan");

        // Tạo một nhân vật MagicHero
        // ICharacter magicHero = player.CreateCharacter("MagicHero");
        Debug.Log(player);

        IWeapon weapon = player.CreateWeapon("Sword");
    }
}


    // void Update()
    // {
    //     // Spawn enemy periodically
    //     if (Time.time >= spawnTime)
    //     {
    //         SpawnEnemy();
    //         spawnTime = Time.time + Random.Range(1f, 3f); // Spawn enemy every 1-3 seconds
    //     }
    // }

    // void SpawnEnemy()
    // {
    //     enemy = new Enemy(); // Spawn enemy
    // }

    // void Replay()
    // {
    //     // Implement replay logic
    // }

    // void GameOver()
    // {
    //     // Implement game over logic
    // }

    // int GetScore()
    // {
    //     return score;
    // }

    // void IncrementScore(int value)
    // {
    //     score += value;
    // }

    // bool IsGameOver()
    // {
    //     // Implement game over condition
    //     return false; // Placeholder
    // }

