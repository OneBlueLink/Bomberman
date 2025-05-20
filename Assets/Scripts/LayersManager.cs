using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LayersManager : MonoBehaviour
{
    PlayerInputManager playerInputmanager;

    [SerializeField] List<Transform> spawnPos;
    [SerializeField] List<Material> playerMaterial;

    private void Awake()
    {
        playerInputmanager = GetComponent<PlayerInputManager>();
    }

    public void OnPlayerJoin(PlayerInput playerInput)
    {
        playerInput.gameObject.transform.position = spawnPos[playerInputmanager.playerCount - 1].position;
        playerInput.gameObject.GetComponent<MeshRenderer>().material = playerMaterial[playerInputmanager.playerCount - 1];
    }

    public void OnPlayerLeft(PlayerInput playerInput)
    {
        Debug.Log("Player is ded");
        
    }
}
