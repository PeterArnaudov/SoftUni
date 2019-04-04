namespace SoftUniRestaurant.Factories
{
    using SoftUniRestaurant.Models.Tables;
    using SoftUniRestaurant.Models.Tables.Contracts;
    using System;

    public static class TableFactory
    {
        public static ITable CreateTable(string type, int tableNumber, int capacity)
        {
            if (type == "Inside")
            {
                return new InsideTable(tableNumber, capacity);
            }
            else if (type == "Outside")
            {
                return new OutsideTable(tableNumber, capacity);
            }

            return null;
        }
    }
}
