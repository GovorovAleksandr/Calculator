using EventBus.Public;
using Events.BusinessLogic;
using NaughtyAttributes;
using TMPro;
using UnityEngine;
using Zenject;

namespace Calculation.Core.Calculator.View
{
    [RequireComponent(typeof(RectTransform))]
    internal sealed class TextHeightTransformAdjuster : MonoBehaviour, IEventHandler<ResultCalculated>
    {
        [Inject] private readonly IReadOnlyEventBus _eventBus;
        
        [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private bool _limitHeight;
        [ShowIf(nameof(_limitHeight))]
        [SerializeField] [Min(1f)] private float _maxHeight = 500f;
        
        private RectTransform _rectTransform;
        private Vector2 _originalSize;

        public void Handle(ResultCalculated eventData) => UpdateHeight();

        private void UpdateHeight()
        {
            var size = _originalSize;
            size.y += _text.preferredHeight;
            if (_limitHeight) size.y = Mathf.Min(size.y, _maxHeight);
            _rectTransform.sizeDelta = size;
        }

        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
            _originalSize = _rectTransform.sizeDelta;
            
            _eventBus.Register(this);
        }

        private void Start() => UpdateHeight();

        private void OnDestroy()
        {
            _eventBus.Unregister(this);
        }
    }
}