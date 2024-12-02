// ------------------------------------------------------------------------------
// <author>: Iurii Ponomarev (Ponyu)
// <created>: 2024-12-02
// <file>: TransformBehaviour.cs
// ------------------------------------------------------------------------------

using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace _Game.GameEngine.Behaviours.Visual
{
    public sealed class TransformBehaviour : IEntityInit, IEntityUpdate 
    {
        private Const<Transform> _transform;
        private IReactiveValue<Vector3> _position;
        private IReactiveValue<Quaternion> _rotation;
        
        public void Init(IEntity entity)
        {
            _transform = entity.GetTransform();
            _position = entity.GetPosition();
            _rotation = entity.GetRotation();
            
            _transform.Value.SetPositionAndRotation(_position.Value, _rotation.Value);
        }

        public void OnUpdate(IEntity entity, float deltaTime)
        {
            _transform.Value.SetPositionAndRotation(_position.Value, _rotation.Value);
        }
    }
}