using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7_task2
{
    /// <summary>
    /// Class for multiplicity with 
    /// </summary>
    /// <typeparam name="ElementType"> </typeparam>
    public class Multiplicity<ElementType>
    {
        /// <summary>
        /// Class for element of multiplicity.
        /// </summary>
        public class MultiplicityElement
        {
            public ElementType Value { get; set; }
            public MultiplicityElement(ElementType value)
            {
                Value = value;
            }
            public MultiplicityElement Next { get; set; }
        }
        private MultiplicityElement begin = null;

        /// <summary>
        /// First element.
        /// </summary>
        /// <returns></returns>
        public MultiplicityElement First()
        {
            return this.begin;
        }

        /// <summary>
        /// Check for empty.
        /// </summary>
        public bool IsEmpty()
        {
            return this.begin == null;
        }

        /// <summary>
        /// Check for the existence.
        /// </summary>
        /// <param name="value">Value to be checked.</param>
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

        /// <summary>
        /// Add element in our multiplicity.
        /// </summary>
        /// <param name="value">Value to be added.</param>
        public void AddElement(ElementType value)
        {
            if (ElementExist(value))
                return;
            if (this.begin == null)
            {
                var newElement = new MultiplicityElement(value);
                this.begin = newElement;
                return;
            }
            var tempElement = this.begin;
            while (tempElement != null)
            {
                tempElement = tempElement.Next;
            }
            tempElement = new MultiplicityElement(value);
        }

        /// <summary>
        /// Delete element.
        /// </summary>
        /// <param name="value">Value for removing.</param>
        public void DeleteELement(ElementType value)
        {
            if (ElementExist(value))
            {
                var tempElement = this.begin;
                if (tempElement.Value.Equals(value))
                {
                    this.begin = this.begin.Next;
                    return;
                }
                while (!tempElement.Next.Value.Equals(value))
                {
                    tempElement = tempElement.Next;
                }
                tempElement.Next = tempElement.Next.Next;
            }
        }

        /// <summary>
        /// Intersects the sets.
        /// </summary>
        /// <param name="many1">Multiplicity №1</param>
        /// <returns></returns>
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

        /// <summary>
        /// Combines multiple.
        /// </summary>
        /// <param name="many1">Multiplicity №1</param>
        public void Unification(Multiplicity<ElementType> many1)
        {
            var tempElement = many1.First();
            while (tempElement != null)
            {
                if (!this.ElementExist(tempElement.Value))
                {
                    this.AddElement(tempElement.Value);
                }
                tempElement = tempElement.Next;
            }
        }
    }
}
