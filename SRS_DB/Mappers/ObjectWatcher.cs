using SRS_DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_DB.Mappers
{
    internal class ObjectWatcher
    {
        private static ObjectWatcher _instance = new ObjectWatcher();
        private ObjectWatcher() { }
        public static ObjectWatcher Instance { get { return _instance; } }
        private Dictionary<string, DomainObject> _objectsMap = new Dictionary<string, DomainObject>();

        public DomainObject GetObject(string object_id)
        {
            if (_objectsMap.ContainsKey(object_id))
            {
                return _objectsMap[object_id];
            }
            else
            {
                return null;
            }
        }
        public void Add(string object_id, DomainObject domainObject)
        {
            _objectsMap[object_id] = domainObject;
        }
    }
}
