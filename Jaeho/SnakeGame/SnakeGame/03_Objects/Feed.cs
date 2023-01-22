﻿namespace SnakeGame
{
    public class Feed : GameObject
    {
        private Renderer renderer;
        public bool IsAlive = true;

        public override void Start()
        {
            AddComponent(new Collider());
            AddComponent(new Renderer("F", 1));
            renderer = GetComponent<Renderer>();

            base.Start();
        }
        public override void Update()
        {
            base.Update();
        }
        public override void Render()
        {
            Console.SetCursorPosition(Position.X, Position.Y);
            Console.Write(renderer.OwnerIcon);
        }
    }
}