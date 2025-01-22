using SFML.System;
using System.Collections.Generic;

namespace Adderley
{
    class Bezier
    {
        public Vector2f start;
        public Vector2f end;
        public Vector2f startControl;
        public Vector2f endControl;
        public Vector2f movement;

        public List<Vector2f> ret;

        public int numSegments;
        public int i;
        public float distance;
        public float distper;
        public float dist;

        public bool kill;

        public Bezier()
        {
            
        }

        public void BezAdd(Vector2f start, Vector2f end, Vector2f startControl, Vector2f endControl, int numSegments, bool kill, float dist)
        {
            this.start = start;
            this.end = end;
            this.startControl = startControl;
            this.endControl = endControl;
            this.numSegments = numSegments;
            this.kill = kill;
            this.dist = dist;
            ret = new List<Vector2f>();
            CalcCubicBezier(start, end, startControl, endControl, numSegments);
            i = 0;
        }

        public Vector2f GetMovement(Vector2f position, float speed)
        {
            if (ret.Count != 0)
            {
                distance = MathHelper.GetDistance(position, end);
                distper = MathHelper.GetDistance(position, ret[i]);
                if (distper == 0)
                    distper = 0.1f;

                return new Vector2f((ret[i].X - position.X) * speed / distper,
                    (ret[i].Y - position.Y) * speed / distper);
            }
            else
            {
                return new Vector2f();
            }
        }

        public void ClearBez()
        {
            ret.RemoveRange(0, ret.Count);
        }

        public void CalcCubicBezier(Vector2f start, Vector2f end, Vector2f startControl, Vector2f endControl, int numSegments)
        {
            ret.Add(start);
            float p = 1f / numSegments;
            float q = p;
            for (int i = 1; i < numSegments; i++, p += q)
                ret.Add(p * p * p * (end + 3f * (startControl - endControl) - start) +
                              3f * p * p * (start - 2f * startControl + endControl) +
                              3f * p * (startControl - start) + start);
            ret.Add(end);
        }
    }
}
