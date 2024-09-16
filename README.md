Модуль для 1EasyEcs.   
Зациклено переключает спрайты в дате.  

````csharp
        public struct StaticAnimation : IEcsComponent
        {
            public SpriteRenderer SpriteRenderer;
            public Sprite[] Sprites;
            public int CurrentSpriteIndex;
        }
````

Зависимости:  
[Ecs-Lite](https://github.com/Leopotam/ecslite.git)  
[1EasyEcs](https://github.com/exerussus/1EasyEcs.git)   