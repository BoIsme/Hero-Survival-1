using UnityEngine;

public class InputMoveHero : MonoBehaviour
{
    private static InputMoveHero instance;
    public static InputMoveHero Instance { get => instance; }

    protected Vector3 heroPos;

    private bool isFacingRight = true;
    public Vector3 HeroPos { get => heroPos; }

    private Rigidbody2D rb;
    protected float speedHero = 5f;

    private void Awake()
    {
        if (InputMoveHero.instance != null)
        {
            Debug.Log("Only 1 InputMoveHero instance allowed");
            Destroy(gameObject); // Destroy the duplicate instance
            return;
        }
        InputMoveHero.instance = this;
    }

    void Update()
    {
        MoveHero();
    }

    protected void MoveHero()
    {
        heroPos.x = Input.GetAxis("Horizontal");
        heroPos.y = Input.GetAxis("Vertical");
        heroPos.z = 0;
        transform.parent.position += heroPos * speedHero * Time.deltaTime;
        if (heroPos.x > 0 && !isFacingRight || heroPos.x < 0 && isFacingRight)
        {
            Flip();
        }
    }

    private void Flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
