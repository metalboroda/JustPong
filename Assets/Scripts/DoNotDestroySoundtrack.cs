using UnityEngine;

public class DoNotDestroySoundtrack : MonoBehaviour
{
    public static DoNotDestroySoundtrack instance = null;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}