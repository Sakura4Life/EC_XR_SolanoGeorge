using UnityEngine;

public class ToggleLuz : MonoBehaviour
{
    public Light luzObjetivo;

    public void Alternar()
    {
        if (luzObjetivo != null)
        {
            luzObjetivo.enabled = !luzObjetivo.enabled;
            Debug.Log("Luz: " + (luzObjetivo.enabled ? "encendida" : "apagada"));
        }
    }
}