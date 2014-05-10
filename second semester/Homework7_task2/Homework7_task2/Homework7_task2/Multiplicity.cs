using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_task2
{
    public class Multiplicity<ElementType>
    {
        private ElementType Value;

        public Multiplicity<ElementType> Next { get; set; }

        private Multiplicity<ElementType> begin = null;

        public Multiplicity<ElementType> First()
        {
            return this.begin;
        }

        public bool ElementExist(ElementType value)
        {
            var tempElement = this.begin;
            while (tempElement != null)
            {
                if (tempElement.Value.Equals(value))
                {
                    return true;
                }

                tempElement = tempElement.Next;
            }
            return false;
        }

        public void AddElement(ElementType value)
        {
            if (ElementExist(value))
                return;

            if (this.begin == null)
            {
                this.begin.Value = value;
                return;
            }

            var tempElement = this.begin;

            while (tempElement != null)
            {
                tempElement = tempElement.Next;
            }

            tempElement.Value = value;
        }
    
        public void DeleteELement(ElementType value)
        {
            if (ElementExist(value))
            {
                var tempElement = this.begin;
                if (tempElement.Value.Equals(value))
                {
                    this.begin = this.begin.Next;
                }


                while (!tempElement.Next.Value.Equals(value))
                {
                    tempElement = tempElement.Next;
                }

                tempElement.Next = tempElement.Next.Next;
            }
        }

        public Multiplicity<ElementType> Intersection(Multiplicity<ElementType> many1)
        {
            Multiplicity<ElementType> resultMany = new Multiplicity<ElementType>();
            var tempElement = many1.First();
            while (tempElement != null)
            {
                if (this.ElementExist(tempElement.Value))
                {
                    resultMany.AddElement(tempElement.Value);
                }
                tempElement = tempElement.Next;
            }
            return resultMany;                   
         }

        public void Unification(Multiplicity<ElementType> many1)
        {
            var tempElement = many1.First();
            while (tempElement != null)
            {
                if (!this.ElementExist(tempElement.Value))
                {
                    this.AddElement(tempElement.Value);
                }
            }
        }

    }
}
