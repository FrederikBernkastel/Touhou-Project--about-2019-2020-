using SFML.Graphics;
using SFML.System;
using System.Collections.Generic;

namespace Adderley
{
    class Animations
    {
        public List<IntRect> frames = new List<IntRect>();
        public List<float> time = new List<float>();
        public Texture texture;
        public bool isLooped;

        public Animations(Texture texture, bool looped)
        {
            this.texture = texture;
            isLooped = looped;
        }

        public void AddFrame(IntRect rect, float time)
        {
            frames.Add(rect);
            this.time.Add(time);
        }
    }

    class AnimatedSprite : Transformable, Drawable
    {
        public float Speed = 0.05f;
        public Animations currAnim;
        public float timer;
        public int currFrameIndex;
        public bool isPaused;
        public RectangleShape rectShape;

        public AnimatedSprite(bool paused)
        {
            isPaused = paused;
            rectShape = new RectangleShape();
        }

        public void SetAnimation(Animations currAnim)
        {
            this.currAnim = currAnim;
            rectShape.Texture = currAnim.texture;
        }

        public void Play()
        {
            if (!isPaused)
                isPaused = false;
        }

        public void Play(Animations animation)
        {
            if (currAnim != animation)
            {
                SetAnimation(animation);
                Reset();
            }

            Play();
        }

        public void Pause()
        {
            isPaused = true;
        }
        
        public void Stop()
        {
            isPaused = true;
            currFrameIndex = 0;
            SetFrame(currFrameIndex);
        }

        public void Reset()
        {
            timer = 0f;
            currFrameIndex = 0;
            SetFrame(currFrameIndex);
            isPaused = false;
        }

        public void SetFrame(int newFrame)
        {
            if (currAnim != null)
            {
                IntRect rect = currAnim.frames[newFrame];
                rectShape.Size = new Vector2f(rect.Width, rect.Height);
                rectShape.Origin = new Vector2f(rectShape.Size.X / 2, rectShape.Size.Y / 2);
                rectShape.TextureRect = rect;
            }
        }

        public void Update()
        {
            if (!isPaused && currAnim != null)
            {
                timer += Speed;

                if (timer >= currAnim.time[currFrameIndex])
                {
                    timer = 0f;

                    if (currFrameIndex + 1 < currAnim.frames.Count)
                        currFrameIndex++;
                    else
                    {
                        if (!currAnim.isLooped)
                        {
                            isPaused = true;
                        }
                        else
                        {
                            currFrameIndex = 0;
                        }
                    }

                    SetFrame(currFrameIndex);
                }
            }
        }

        public void Draw(RenderTarget target, RenderStates states)
        {
            if (currAnim != null && rectShape.Texture != null)
            {
                states.Transform *= Transform;

                target.Draw(rectShape, states);
            }
        }
    }
}
