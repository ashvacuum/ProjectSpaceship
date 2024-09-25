using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

namespace ECS.Entities
{
    public partial class EntitySpawner : SystemBase
    {
        protected override void OnCreate()
        {
            EntityArchetype entityArcheType = EntityManager.CreateArchetype(
                typeof(LocalTransform),
                typeof(LocalToWorld));
        }

        protected override void OnUpdate()
        {
            
        }
    }
}
