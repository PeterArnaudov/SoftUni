namespace CollectionHierarchy.Classes
{
    using CollectionHierarchy.Interfaces;
    using System;
    using System.Linq;

    public class AddRemoveCollection : AddCollection, IAddRemoveCollection
    {
        public AddRemoveCollection()
            : base()
        {
        }

        public override int Add(string item)
        {
            this.collection.Insert(0, item);
            return 0;
        }

        public virtual string Remove()
        {
            string removed = this.collection.Last();
            this.collection.Remove(removed);

            return removed;
        }
    }
}
