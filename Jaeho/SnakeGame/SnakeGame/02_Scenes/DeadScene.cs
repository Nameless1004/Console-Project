﻿namespace SnakeGame
{
    public class DeadScene : Scene
    {

        public override void Start()
        {
            SoundManager.Instance.Play("EndingBackgroundMusic");
        }

        public override void Update()
        {
            switch (InputManager.Instance.Key)
            {
                case ConsoleKey.Enter:
                    SceneManager.Instance.ChangeScene(_nextSceneName);
                    return;
                    break;
            }
        }

        public override void Render()
        {
            Console.SetCursorPosition(0, 0);
            Console.Write("Die...");
            Console.SetCursorPosition(0, 1);
            Console.Write("Enter누르면 종료");
        }

    }
}
