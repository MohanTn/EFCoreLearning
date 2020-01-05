using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreLearning.Domain
{
    public class GrandGrandParent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual List<GrandParent> GrandParents { get; set; }

        public GrandGrandParent()
        {
            this.GrandParents = new List<GrandParent>();
        }
    }

    public class GrandParent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual GrandGrandParent GrandGrandParent { get; set; }
        public virtual List<Parent> Parents { get; set; }

        public GrandParent()
        {
            this.Parents = new List<Parent>();
        }
    }

    public class Parent
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual GrandParent GrandParent { get; set; }
        public virtual List<Child> Children { get; set; }

        public Parent()
        {
            this.Children = new List<Child>();
        }
    }

    public class Child
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual Parent Parent { get; set; }
    }
}
