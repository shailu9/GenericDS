using System;
using System.Collections.Generic;
using System.Text;

namespace SinglyLinkListOperations.POCO
{
    public class TrainCompartment
    {
        public int Compartment_Id { get; set; }
        public int Seating_Capcity { get; set; }
        public string Compartment_Class { get; set; }
        public bool IsEngin_Compartement { get; set; }

        public TrainCompartment(int id,int capcity,string _class,bool isEngin=false)
        {
            this.Compartment_Class = _class;
            this.Compartment_Id = id;
            this.Seating_Capcity = capcity;
            this.IsEngin_Compartement = isEngin;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (this.IsEngin_Compartement)
                sb.Append("Engine ");
            else
            sb.Append( this.Compartment_Id + " " + this.Compartment_Class + " (" + this.Seating_Capcity + ")");
            return sb.ToString();
        }
    }
}
