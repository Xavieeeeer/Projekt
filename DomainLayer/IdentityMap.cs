using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer
{
    public class IdentityMap<T> where T : IDentity
    {
        private static Dictionary<int, T> _entities = new Dictionary<int, T>();

        public static T Get(int id)
        {
            if (_entities.ContainsKey(id))
            {
                return _entities[id];
            }

            return default(T);
        }
        public static void Add(T instance)
        {
            _entities.Add(instance.ID, instance);
        }
        public static void Update(T instance)
        {
            _entities[instance.ID] = instance;
        }
    }
}
