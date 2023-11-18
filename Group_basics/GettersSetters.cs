using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Group_basics;

namespace Group_basics
{
    public class GettersSetters
    {

        public int number1Field;//to access only field
        public int _number2Field;//to access both field and property
        public int _number3Field;//to access both field and property
        private int _number4Field;//to access both property

        public int Number2Property
        {
            get
            {
                return
                    (_number2Field * 10);
            }
            set
            {
                _number2Field = value;
            }
        }

        public int Number3Property
        {
            get
            {
                return _number3Field;
            }
            set
            {
                _number3Field = value * 10;
            }
        }

        public int Number4Property
        {
            get
            {
                return _number4Field;
            }
            set
            {
                _number4Field = value * 5;
            }
        }

        private void printFieldsProps(int n1, string name)
        {
            Console.WriteLine($"Value of {name} is {n1}");
        }

        public void RunGetSetters()
        {
            number1Field = 15000;
            printFieldsProps(number1Field, "number1Field");

            _number2Field = 60;
            printFieldsProps(_number2Field, "_number3Field");
            printFieldsProps(Number2Property, "Number2Property");

            //Directly retrieve property without setting
            printFieldsProps(Number3Property, "Number3Property");

            //set field and retrieve property
            _number3Field = 60;
            printFieldsProps(_number3Field, "_number3Field");
            printFieldsProps(Number3Property, "Number3Property");

            Number4Property = 15;//set property and retrieve property
            printFieldsProps(Number4Property, "Number4Property");
        }
    }
}
