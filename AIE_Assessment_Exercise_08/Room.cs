using System;
using System.Collections.Generic;
using System.Text;

namespace AIE_Assessment_Exercise_08
{
    class Room
    {
        GameObject[] objects = new GameObject[3];

        public void AddGameObject(GameObject go)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] == null)
                {
                    objects[i] = go;
                    return;
                }
            }
        }

        public void RemoveGameObject(GameObject go)
        {
            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] == go)
                {
                    objects[i] = null;
                    break;
                }
            }

            GameObject[] temp = new GameObject[3];

            for (int i = 0; i < objects.Length; i++)
            {
                if (objects[i] != null)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (temp[j] == null)
                        {
                            temp[j] = objects[i];
                            return;
                        }
                    }
                }
            }

            objects = temp;
        }

        public virtual void Draw()
        {
            if(objects[0] == null)
            {
                Console.Write("_");
            }
            else
            {
                objects[0].Draw();
            }
        }
    }
}
