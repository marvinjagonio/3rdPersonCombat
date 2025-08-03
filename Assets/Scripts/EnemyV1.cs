using Unity.VisualScripting;
using UnityEngine;

public class EnemyV1 : MonoBehaviour
{
    private Animator enemyAnim;
    private PlayerV1 playerAccess;
    private void Awake()
    {
        enemyAnim = GetComponent<Animator>();
        playerAccess = GameObject.Find("AlienSoldier").GetComponent<PlayerV1>();

    }

    private void Start()
    {
       
    }

    private void Update()
    {
       
    }

  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Kick" && playerAccess.isKicking)
        {
            enemyAnim.SetTrigger("Kicked");
            playerAccess.isKicking = false;

        }

        if (other.gameObject.tag == "Punch" && playerAccess.isPunching)
        {
            enemyAnim.SetTrigger("Hit");
            playerAccess.isPunching = false;
            Debug.Log("Done Punching");
        }

    }
}
