using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRS_DB.Models
{
    internal abstract class DomainObject
    {
        int _id;
        public int Id { 
            get { return _id; } 
            set { _id = value; }
        }        
        protected abstract void LoadObject(List<string> _params);

        public DomainObject(List<string> _params)
        {
            _id = Convert.ToInt32(_params[0]);
            LoadObject(_params);
        }
        public abstract List<string> GetColums();
        public abstract List<string> GetValues();

    }
}
