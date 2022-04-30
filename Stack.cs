using System.Collections;

namespace InheritanceExercise
{
    public class Stack
    {
        public ArrayList List { get; }
        public Stack()
        {
            List = new ArrayList();
        }
        public void Push(object obj)
        {
            if (obj == null)
            {
                throw new System.InvalidOperationException("Should not contain a null object.");
            }
            else
            {
                List.Add(obj);
            }
            
        }

        public object Pop()
        {
            if (List.Count == 0)
            {
                throw new System.InvalidOperationException("This ArrayList is empty.");
            }
            else
            {
                var popItem = List[List.Count - 1];
                List.Remove(List[List.Count - 1]);
                return popItem;
            }
        }

        public void Clear()
        {
            List.Clear();
        }

    }
}
