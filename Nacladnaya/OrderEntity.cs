using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Nacladnaya
{
    public class DataSetEntity
    {
        private string _DocNumber;
        public string DocNumber
        {
            get { return _DocNumber; }
            set { _DocNumber = value; }
        }

        private DateTime _DocDate;
        public DateTime DocDate
        {
            get { return _DocDate; }
            set { _DocDate = value; }
        }

        private BindingList<OrderEntity> _EntityList;
        public BindingList<OrderEntity> EntityList
        {
            get { return _EntityList; }
            set { _EntityList = value; }
        }



    };


    public class OrderEntity
    {
        private int _OrderId;
        public int OrderId 
        {
            get { return _OrderId; }
            set { _OrderId = value;}
        }
        
        private string _OrderNumber;
        public string OrderNumber
        {
            get { return _OrderNumber; }
            set { _OrderNumber = value; }
        }

        private string _OrderDescription;
        public string OrderDescription
        {
            get { return _OrderDescription; }
            set { _OrderDescription = value; }
        }

        private string _UnitName;
        public string UnitName
        {
            get { return _UnitName; }
            set { _UnitName = value; }
        }

        private string _Stoikost;
        public string Stoikost
        {
            get { return _Stoikost; }
            set { _Stoikost = value; }
        }

        public int _Qty;
        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        public string QtySpelled
        {
            get { return RusNumber.RusSpelledOut(_Qty, _UnitName != "шт."); }
        }

    }
}
