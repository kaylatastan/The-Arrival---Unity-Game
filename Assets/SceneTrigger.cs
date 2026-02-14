using UnityEngine;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor; // This namespace only exists in the Editor
#endif

public class SceneTrigger : MonoBehaviour
{
    [Header("Scene Settings")]
    [SerializeField] private string targetSceneName; // This stores the name for the build

#if UNITY_EDITOR
    // This field only appears in the Unity Editor Inspector
    [SerializeField] private SceneAsset sceneObject;

    // This runs whenever you change something in the Inspector
    private void OnValidate()
    {
        if (sceneObject != null)
        {
            targetSceneName = sceneObject.name;
        }
    }
#endif

    [Header("Trigger Settings")]
    public string targetTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(targetTag))
        {
            ExecuteSceneChange();
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(targetTag))
        {
            ExecuteSceneChange();
        }
    }

    private void ExecuteSceneChange()
    {
        if (!string.IsNullOrEmpty(targetSceneName))
        {
            SceneManager.LoadScene(targetSceneName);
        }
        else
        {
            Debug.LogError($"No scene selected on {gameObject.name}!");
        }
    }
}