using ECS.Modules.Exerussus.StaticAnimation.System;
using Exerussus._1EasyEcs.Scripts.Custom;
using Leopotam.EcsLite;

namespace ECS.Modules.Exerussus.StaticAnimation
{
    public class StaticAnimationGroup : EcsGroup<StaticAnimationPooler>
    {
        protected override void SetFixedUpdateSystems(IEcsSystems fixedUpdateSystems)
        {
            fixedUpdateSystems.Add(new StaticAnimationSystem());
        }
    }
}