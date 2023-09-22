using DG.Tweening;
using UniEx;
using UnityEngine;

namespace OneButton.InGame.Presentation.View
{
    public abstract class ItemView : MonoBehaviour
    {
        [SerializeField] private SpriteRenderer spriteRenderer = default;

        public abstract PatternType pattern { get; }

        public Tween Show(float duration)
        {
            return spriteRenderer
                .DOFade(1.0f, duration)
                .SetEase(Ease.Linear)
                .SetLink(gameObject);
        }

        public Tween Hide(float duration)
        {
            return spriteRenderer
                .DOFade(0.0f, duration)
                .SetEase(Ease.Linear)
                .SetLink(gameObject);
        }
    }
}