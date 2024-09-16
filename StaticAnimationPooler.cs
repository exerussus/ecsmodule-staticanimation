using Exerussus._1EasyEcs.Scripts.Core;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace ECS.Modules.Exerussus.StaticAnimation
{
    public class StaticAnimationPooler : IGroupPooler
    {
        public void Initialize(EcsWorld world)
        {
            StaticAnimation = new PoolerModule<StaticAnimationData.StaticAnimation>(world);
        }
        
        public PoolerModule<StaticAnimationData.StaticAnimation> StaticAnimation { get; private set; }
    }
}