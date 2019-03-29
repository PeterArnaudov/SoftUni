namespace CollectionHierarchy.Classes
{
    using CollectionHierarchy.Interfaces;
    using System;
    using System.Collections.Generic;

    public class AddCollection : IAddCollection
    {
        protected List<string> collection;

        public AddCollection()
        {
            this.collection = new List<string>();
        }

        public virtual int Add(string item)
        {
            this.collection.Add(item);;

            return collection.Count - 1;
        }
    }
}
