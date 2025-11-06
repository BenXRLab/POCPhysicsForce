using UnityEngine;

public class UIPanelManager : MonoBehaviour
{
    // destroys the welcome screen
    public GameObject Welcome_Screen;

    public void DestroyTheGameObject()
    {
        Destroy(Welcome_Screen);
    }
}
