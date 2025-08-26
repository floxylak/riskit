using UnityEngine;

public class PlayerSingleton : MonoBehaviour
{
    private static PlayerSingleton _instance;

    public static PlayerSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                Debug.LogError("PlayerSingleton is null. Make sure the Player object is in the scene.");
            }
            return _instance;
        }
    }

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Debug.LogWarning("Another instance of PlayerSingleton already exists. Destroying this duplicate.");
            Destroy(gameObject);
            return;
        }

        _instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void OnDestroy()
    {
        if (_instance == this)
        {
            _instance = null;
        }
    }

    // Add player properties and methods here
    
    // public int Health { get; set; }
    // public Vector3 Position => transform.position;
}