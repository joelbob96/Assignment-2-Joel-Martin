using UnityEngine;
using UnityEngine.UI;

public class MaterialSwapper : MonoBehaviour
{
    public Material Red;
    public Material Blue;
    public Material Green;
    public GameObject Player;
    public Dropdown color;

    void Update()
    {
        switch (color.value)
        {
            case 0:
                Player.GetComponent<MeshRenderer>().material = Red;
                break;

            case 1:
                Player.GetComponent<MeshRenderer>().material = Blue;
                break;

            case 2:
                Player.GetComponent<MeshRenderer>().material = Green;
                break;

            default:
                Player.GetComponent<MeshRenderer>().material = Green;
                break;
        }
        
    }
}
