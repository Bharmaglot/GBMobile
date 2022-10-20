using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Tween
{
    [RequireComponent(typeof(Renderer))]
    public class CustomButtonByInheritanceToo : Button
    {
        public static string DurationName => nameof(_duration);

        [Header("Components")]
        [SerializeField] private Renderer _renderer;

        [SerializeField] private float _duration;
        [SerializeField] private Color _endColor;

        protected override void Awake()
        {
            base.Awake();
            InitRenderer();
        }

             protected override void OnValidate()
        {
            base.OnValidate();
            InitRenderer();
        }

        private void InitRenderer() => _renderer ??= GetComponent<Renderer>();

        public override void OnPointerClick(PointerEventData eventData)
        {
            base.OnPointerClick(eventData);
            ActivateAnimation();
        }

        private void ActivateAnimation()
        {
            Material material = _renderer.material;
            material.DOColor(_endColor, _duration);
        }
    }
}   