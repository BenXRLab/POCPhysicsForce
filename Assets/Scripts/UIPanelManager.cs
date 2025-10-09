using UnityEngine;

public class UIPanelManager : MonoBehaviour
{
    public GameObject Welcome_Screen;

    public void DestroyTheGameObject()
    {
        Destroy(Welcome_Screen);
    }
}
