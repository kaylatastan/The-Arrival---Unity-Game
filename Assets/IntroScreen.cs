using UnityEngine;

public class IntroScreen : MonoBehaviour
{
    void Update()
    {
        if (Input.anyKeyDown || Input.GetMouseButtonDown(0))
        {
            gameObject.SetActive(false);
        }
    }
}
