/**
 * This class models the Dog class from the Java language to C#.
 * @author Rob Kelley
 * @author cporter
 * @version 1/12/2020
 * CS-311 Programming Project 1
 * Spring 2020
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_CNP
{
    class Dog
    {
        private int age;
        private String name;

        /**
	     * Empty-argument constructor to put object
	     * into a consistent state.
	     */
        public Dog()
        {
            age = 0;
            name = "";
        }//end constructor

        /**
	     * Constructor accepts the age and
	     * name of the dog. This is the preferred
	     * constructor.
	     */
        public Dog(int age, String name)
        {
            this.SetAge(age);
            this.SetName(name);
        }//end constructor

        /**
         * This class converts the age of the dog
         * from human years into dog years.
         */
        public int CalcDogYears()
        {
            int dogYears = 15 + (this.age - 1) * 7;
            return dogYears;
        }//end CalcDogYears

        /**
	     * Getter for age
	     */
        public int GetAge()
        {
            return age;
        }//end GetAge

        /**
	     * Setter for age
	     * Checks the bounds so the age cannot be negative.
	     */
        public void SetAge(int age)
        {
            if (age < 0){
                this.age = 0;
            }
            else
            {
                this.age = age;
            }
        }//end SetAge

        /**
         * Getter for name
         */
        public String GetName()
        {
            return name;
        }//end GetName

        /**
	     * Setter for name. Ensures that only
	     * alpha characters are allowed in the name.
	     */
        public void SetName(String name)
        {
            Boolean valid = true;
            char[] n = name.ToCharArray();

            foreach(char c in n)
            {
                if (!Char.IsLetter(c))
                {
                    valid = false;
                    break;
                }//end if
            }//end foreach

            if (valid)
            {
                this.name = name;
            }
            else
            {
                this.name = "";
            }//end else
        }//end SetName
        
        override
        public String ToString()
        {
            return "Dog [age = " + age + ", name = " + name + "]";
        }//end toString

    }//end class

}//end namespace
