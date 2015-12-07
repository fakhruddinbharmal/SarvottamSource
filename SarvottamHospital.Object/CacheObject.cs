using System;
using System.Collections.Generic;
using System.Text;

namespace SarvottamHospital.Object
{
    public class CacheObject<T> where T : Objectbase
    {
        private DateTime mAccessedOn = DateTime.Now;
        private TimeSpan mCacheExpiry;
        private T mItem;

        public CacheObject(T item) : this(item, new TimeSpan(0, 5, 0)) { }

        public CacheObject(T item, TimeSpan expiry)
        {
            this.mItem = item;
            this.mCacheExpiry = expiry;
        }

        public bool IsExpired
        {
            get { return this.mAccessedOn.Add(mCacheExpiry) > DateTime.Now; }
        }

        public T Item
        {
            get
            {
                if (!Objectbase.IsNullOrEmpty(this.mItem) && IsExpired && this.mItem.RefershData())
                {
                    this.mAccessedOn = DateTime.Now;
                }
                return this.mItem;
            }
        }
    }
}
