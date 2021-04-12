using System;
using System.Collections.Generic;

namespace TodoApplication
{
    public class ListModel<TItem>
    {
        public enum TypeAction
        {
            AddItem,
            RemoveItem
        }

        public List<TItem> Items { get; }
        public int Limit;
        LimitedSizeStack<Tuple<TypeAction, TItem, int>> storyAction;

        public ListModel(int limit)
        {
            Items = new List<TItem>();
            Limit = limit;
            storyAction = new LimitedSizeStack<Tuple<TypeAction, TItem, int>>(limit);
        }

        public void AddItem(TItem item)
        {
            storyAction.Push(Tuple.Create(TypeAction.AddItem, item, Items.Count));
            Items.Add(item);
        }

        public void RemoveItem(int index)
        {
            storyAction.Push(Tuple.Create(TypeAction.RemoveItem, Items[index], index));
            Items.RemoveAt(index);
        }

        public bool CanUndo()
        {
            return storyAction.Count > 0;
        }

        public void Undo()
        {
            var lastAction = storyAction.Pop();
            switch (lastAction.Item1)
            {
                case TypeAction.AddItem:
                    Items.RemoveAt(storyAction.Count);
                    break;
                case TypeAction.RemoveItem:
                    Items.Insert(lastAction.Item3, lastAction.Item2);
                    break;
            }
        }
    }
}


