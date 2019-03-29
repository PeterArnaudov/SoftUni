namespace CollectionHierarchy.Classes
{
    using CollectionHierarchy.Interfaces;
    using System;
    using System.Linq;

    public class MyList : AddRemoveCollection, IMyList
    {
        public MyList()
            : base()
        {
        }

        public override string Remove()
        {
            string removed = this.collection.First();
            this.collection.Remove(removed);

            return removed;
        }

        public void Used()
        {
            Console.WriteLine(this.collection.Count);
        }
    }
}
