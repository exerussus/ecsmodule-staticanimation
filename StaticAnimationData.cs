
using Exerussus._1EasyEcs.Scripts.Core;
using UnityEngine;

namespace ECS.Modules.Exerussus.StaticAnimation
{
    public static class StaticAnimationData
    {
        public struct StaticAnimation : IEcsComponent
        {
            public SpriteRenderer SpriteRenderer;
            public Sprite[] Sprites;
            public int CurrentSpriteIndex;
        }
    }
}
