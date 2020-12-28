using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace TehnologyProgramingReposytory
{
    static class DB
    {
        static DB()
        {
            Database = new LiteDatabase("TestDB");
        }
        public static LiteDatabase Database { get; set; }
    }

    public class BaseRepository<T>
    {
        protected ILiteCollection<T> Collection { get; set; }
        protected BaseRepository()
        {
            this.Collection = DB.Database.GetCollection<T>();
        }


        public virtual void Create(T item)
        {
            Collection.Insert(item);
        }
        public virtual List<T> ReadAll()
        {
            return Collection.FindAll().ToList();
        }

        public virtual bool Delete(Guid id)
        {
            if (Collection.FindById(id) != null)
            {
                this.Collection.Delete(id);
                return true;
            }
            else
                return false;

        }

    }
}
