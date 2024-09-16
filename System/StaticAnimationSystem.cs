using Exerussus._1EasyEcs.Scripts.Core;
using Leopotam.EcsLite;

namespace ECS.Modules.Exerussus.StaticAnimation.System
{
    public class StaticAnimationSystem : EasySystem<StaticAnimationPooler>
    {
        private EcsFilter _staticAnimationFilter;
        
        protected override void Initialize()
        {
            _staticAnimationFilter = World.Filter<StaticAnimationData.StaticAnimation>().End();
        }

        protected override void Update()
        {
            foreach (var entity in _staticAnimationFilter)
            {
                ref var staticAnimationData = ref Pooler.StaticAnimation.Get(entity);
                staticAnimationData.CurrentSpriteIndex++;
                if (staticAnimationData.CurrentSpriteIndex >= staticAnimationData.Sprites.Length) staticAnimationData.CurrentSpriteIndex = 0;
                staticAnimationData.SpriteRenderer.sprite = staticAnimationData.Sprites[staticAnimationData.CurrentSpriteIndex];
            }
        }
    }
}