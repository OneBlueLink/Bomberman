using UnityEngine;

public class PlayerBombManager : MonoBehaviour
{
    InputManager InputManager;
    public GameObject bombprefab;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        InputManager = GetComponent<InputManager>();
    }

private void OnEnable()
    {
    InputManager.onBombP.AddListener(DeployBomb);
    }

private void OnDisable()
{
    InputManager.onBombP.RemoveListener(DeployBomb);
}

private void DeployBomb()
{
    Instantiate(bombprefab, transform.position, Quaternion.identity);
}

    // Update is called once per frame
    
}
