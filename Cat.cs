using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CS_ex
{
    public class Cat
    {
        private int id;
        private String name;
        private Date birthday;

        public Cat(int id, String name, Date birthday)
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;
        }

        public Cat(Cat other)
        {
            this.id = other.id;
            this.name = other.name;
            this.birthday = new Date(other.birthday.getDay(), other.birthday.getMonth(), other.birthday.getYear());
        }

        public int getId()
        {
            return id;
        }

        public String getName()
        {
            return name;
        }

        public Date getBirthday()
        {
            return birthday;
        }

      public bool equals(Cat other)
        {
            if (other == null)
            {
                return false;
            }
            if (this.id == other.id && this.name.Equals(other.name) && birthday.Equals(other.birthday))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

      public override String ToString()
        {
            String res = "Cat[id=" +id +", name=" + name + ", birthday=" + birthday + "]";
            return res;
        }
    }
}
