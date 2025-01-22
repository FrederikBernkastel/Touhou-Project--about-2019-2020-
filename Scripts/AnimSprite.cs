using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;

namespace Adderley
{
    // кадр
    class AnimationFrame
    {
        public int i, j;
        public float time;
        public int sprIn;

        public AnimationFrame(int i, int j, float time)
        {
            this.i = i;
            this.j = j;
            this.time = time;
        }

        public AnimationFrame(int sprIn, float time)
        {
            this.sprIn = sprIn;
            this.time = time;
        }
    }

    // анимация
    class Animation
    {
        public AnimationFrame[] frames;

        float timer;
        AnimationFrame currFrame;
        public int currFrameIndex;

        public Animation(params AnimationFrame[] frames)
        {
            this.frames = frames;
            Reset();
        }

        public int GetIn()
        {
            return currFrameIndex;
        }

        // начать проигрывание анимации с начала
        public void Reset()
        {
            timer = 0f;
            currFrameIndex = 0;
            currFrame = frames[currFrameIndex];
        }

        // следующий кадр
        public void NextFrame()
        {
            timer = 0f;
            currFrameIndex++;

            if (currFrameIndex == frames.Length)
                currFrameIndex = 0;

            currFrame = frames[currFrameIndex];
        }

        // получить текущий кадр
        public AnimationFrame GetFrame(float speed)
        {
            timer += speed;

            if (timer >= currFrame.time)
                NextFrame();

            return currFrame;
        }
    }

    // спрайт с анимацией
    class AnimSprite : Transformable, Drawable
    {
        public float Speed = 0.05f;
        RectangleShape rectShape;
        public Sprite spr;
        SpriteSheet ss;                     // набор спрайтов
        SortedDictionary<string, Animation> animations = new SortedDictionary<string, Animation>();
        Animation currAnim;                 // текущая анимация
        string currAnimName;                // имя текущей анимации
        Texture[] textures;

        public Vector2f PosSpr
        {
            set { spr.Position = value; }
            get { return spr.Position; }
        }

        public float RadPlSpr
        {
            set { spr.Rotation += value; }
            get { return spr.Rotation; }
        }

        public float RadSpr
        {
            set { spr.Rotation = value; }
            get { return spr.Rotation; }
        }

        public Vector2f OrSpr
        {
            set { spr.Origin = value; }
            get { return spr.Origin; }
        }

        public Vector2f ScSpr
        {
            set { spr.Scale = value; }
            get { return spr.Scale; }
        }

        // конструктор
        public AnimSprite(SpriteSheet ss)
        {
            this.ss = ss;

            rectShape = new RectangleShape(new Vector2f(ss.SubWidth, ss.SubHeight))
            {
                Origin = new Vector2f(ss.SubWidth / 2, ss.SubHeight / 2),
                Texture = ss.Texture
            };
        }

        public AnimSprite(params Texture[] textures)
        {
            this.textures = textures;
            
            spr = new Sprite();
        }

        // добавить анимацию
        public void AddAnimation(string name, Animation animation)
        {
            animations[name] = animation;
            currAnim = animation;
            currAnimName = name;
        }

        // проигрывает указанную анимацию
        public void Play(string name)
        {
            if (currAnimName == name)
                return;

            currAnim = animations[name];
            currAnimName = name;
            currAnim.Reset();
        }

        public IntRect GetTextureRect()
        {
            var currFrame = currAnim.GetFrame(Speed);
            return ss.GetTextureRect(currFrame.i, currFrame.j);
        }

        public Texture GetTexture()
        {
            var currFrame = currAnim.GetFrame(Speed);
            return textures[currFrame.sprIn];
        }

        public bool isOneSpr()
        {
            if (ss == null)
                return false;
            else
                return true;
        }

        public bool isMoreSpr()
        {
            if (textures == null)
                return false;
            else
                return true;
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            if (isOneSpr())
            {
                //rectShape.TextureRect = GetTextureRect();

                //states.Transform *= Transform;
                //target.Draw(rectShape, states);
            }
            else if (isMoreSpr())
            {
                spr.Texture = GetTexture();

                states.Transform *= Transform;
                target.Draw(spr, states);
            }
        }
    }
}
