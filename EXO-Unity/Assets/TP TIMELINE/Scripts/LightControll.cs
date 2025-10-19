using UnityEngine;

public class LightControll : MonoBehaviour
{
    [SerializeField] Light _directionnalLight;
    [SerializeField] float _fadeStrength = 0.5f;

    bool _fadeOut = false;
    float t = 0f;
    float _initialIntensity;

    private void Awake()
    {
        TryGetComponent(out  _directionnalLight);
        _initialIntensity = _directionnalLight.intensity;
    }

    public void StarLightFadeOut()
    {
        _fadeOut = true;
    }

    public void ActivateLight()
    {
        _directionnalLight.intensity = _initialIntensity;
    }

    public void DeactivateLight()
    {
        _directionnalLight.intensity = 0;
    }

    private void Update()
    {
        if (!_fadeOut)
            return;

        t += _fadeStrength * Time.deltaTime;

        _directionnalLight.intensity = Mathf.Lerp(_initialIntensity, 0f, t);
    }
}
