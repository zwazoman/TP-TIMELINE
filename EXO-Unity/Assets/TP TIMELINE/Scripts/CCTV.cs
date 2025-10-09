using Unity.Cinemachine;
using UnityEngine;

public class CCTV : MonoBehaviour
{
    [SerializeField] CinemachineBrain brain;

    void SwapBrainBlend(CinemachineBlendDefinition.Styles blendDef)
    {
        brain.DefaultBlend.Style = blendDef;
    }

    public void SwapBlendToEase()
    {
        SwapBrainBlend(CinemachineBlendDefinition.Styles.EaseInOut);
    }

    public void SwapBlendToCut()
    {
        SwapBrainBlend(CinemachineBlendDefinition.Styles.Cut);
    }
}
