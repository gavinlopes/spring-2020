using UnityEngine;

public class EndPoint : MonoBehaviour
{
    public PlayerManager playerManager;
    private void OnTriggerEnter()
    {
        playerManager.CompleteLevel();
    }
}
