using UnityEngine;

public class ActivateConfetti : MonoBehaviour
{
    [SerializeField] private ButtonPress m_targetButton;
    [SerializeField] private ParticleSystem confettiParticles;

    private void OnEnable()
    {
        confettiParticles.Play();
    }

    private void TriggerConfetti(ButtonPress button)
    {
        //TODO: Execute the Confetti Particle system!
        Debug.Log("Confetti Time!");
    }
}
