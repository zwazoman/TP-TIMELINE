using UnityEngine;

public class LightControll : MonoBehaviour
{
    [SerializeField] Light _directionnalLight;
    [SerializeField] float _fadeStrength = 0.5f;

    bool _fadeOut = false;
    float t = 0f;

    private void Awake()
    {
        TryGetComponent(out  _directionnalLight);
    }

    public void StarLightFadeOut()
    {
        _fadeOut = true;
    }

    private void Update()
    {
        if (!_fadeOut)
            return;

        t += _fadeStrength * Time.deltaTime;

        _directionnalLight.intensity = Mathf.Lerp(_directionnalLight.intensity, 0f, t);
    }
}
