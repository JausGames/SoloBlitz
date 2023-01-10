using System.Collections;
using UnityEngine;

public abstract class Bonus : MonoBehaviour
{
    public float duration; // duration of the bonus 

    public abstract void Apply(); // Apply the bonus effect
    public abstract void Disable(); // Disable the bonus effect

    public void Collect()
    {
        Apply();
        StartCoroutine(DestroyAfterTime(duration));
    }

    private IEnumerator DestroyAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        Disable();
        Destroy(gameObject);
    }
}
