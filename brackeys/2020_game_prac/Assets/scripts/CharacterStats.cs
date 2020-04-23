using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public GameObject player;
   
    
    
    public Stat damage;
    public Stat armor;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {

    }

    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage. ");

        if (currentHealth <= 0)
        {
            Die();
 
        }
    }

    public virtual void Die()
    {

        if (gameObject != currentHealth <= 0)
        {
            Destroy(gameObject);
        }

        else if (player != currentHealth >= 0)
        {
            
        }

        else if (player != currentHealth <= 0)
        {
            SceneManager.LoadScene("Game_final");
        }

    }
}

