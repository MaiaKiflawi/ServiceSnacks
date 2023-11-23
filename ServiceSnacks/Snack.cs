using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model
{
    [DataContract]
    public class Snack: BaseEntity
    {
        private string snackName;
        private int calAmount;
        public bool isSweet;
        public int amount;
        public int grams;
        public bool like;
        public string company;
        [DataMember]
        public string SnackName 
        {
            get { return snackName; }
            set { snackName = value; }
        }
        [DataMember]
        public int CalAmount
        {
            get { return calAmount; }
            set { calAmount = value; }
        }
        [DataMember]
        public bool IsSweet
        {
            get { return isSweet; }
            set { isSweet = value; }
        }
        [DataMember]
        public int Amount

        {
            get { return amount; }
            set { amount = value; }
        }
        [DataMember]
        public int Grams
        {
            get { return grams; }
            set { grams = value; }
        }
        [DataMember]
        public bool Like
        {
            get { return like; }
            set { like = value; }
        }
        [DataMember]
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
    }
    [CollectionDataContract]
    public class SnackList : List<Snack>
    {
        public SnackList() { } //בנאי ברירת מחדל
        public SnackList(IEnumerable<Snack> list) :
            base(list)
        { } //המרה של רשימת קורסים לאוסף של קורסים
        public SnackList(IEnumerable<BaseEntity> list) :
            base(list.Cast<Snack>().ToList())
        { } //המרה כלפי מטה מישות בסיס לרשימת קורסים

    }
}
