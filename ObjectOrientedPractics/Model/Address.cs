using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит информацию о адресе.
    /// </summary>
    public class Address : ICloneable, IEquatable<Address>
    {
        public event EventHandler<EventArgs> AddressChanged;

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Название страны/региона.
        /// </summary>
        private string _country;

        /// <summary>
        /// Название города.
        /// </summary>
        private string _city;

        /// <summary>
        /// Название улицы.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задаёт почтовый индекс. Не может быть длиннее 6 символов.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value.ToString(), 6, nameof(Index));
                if (_index != value)
                {
                    var args = new EventArgs();
                    _index = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт название страны/региона. Не может быть длиннее 50 символов.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                if (_country != value)
                {
                    var args = new EventArgs();
                    _country = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт название города. Не может или длиннее 50 символов.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                if (_city != value)
                {
                    var args = new EventArgs();
                    _city = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт название улицы. Не может или длиннее 100 символов.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                if (_street != value)
                {
                    var args = new EventArgs();
                    _street = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома. Не может или длиннее 10 символов.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                if (_building != value)
                {
                    var args = new EventArgs();
                    _building = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры. Не может или длиннее 10 символов.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                if (_apartment != value)
                {
                    var args = new EventArgs();
                    _apartment = value;
                    AddressChanged?.Invoke(this, args);
                }
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Не может быть длиннее 6 символов.</param>
        /// <param name="country">Название страны. Не может быть длиннее 50 символов.</param>
        /// <param name="city">Название города. Не может быть длиннее 50 символов.</param>
        /// <param name="street">Название улицы. Не может быть длиннее 100 символов.</param>
        /// <param name="building">Номер дома. Не может быть длиннее 10 символов.</param>
        /// <param name="apartment">Номер квартиры. Не может быть длиннее 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
        public Address() { }

        /// <summary>
        /// Клонирует экземпляр класса <see cref="Address"/>.
        /// </summary>
        public object Clone()
        {
            return new Address(this.Index, this.Country, this.City, this.Street, this.Building, this.Apartment);
        }

        /// <summary>
        /// Сравнивает экземпляры класса
        /// </summary>
        /// <param name="other">Экземпляр, с которым будет происходить сравнение.</param>
        /// <returns>true, если равны и false, если не равны.</returns>
        public bool Equals(Address other)
        {
            //Обязательные проверки прежде чем мы сравним поля
            if (other == null)
                return false;
            if (!(other is Address))
                return false;
            if (object.ReferenceEquals(this, other))
                return true;
            var address2 = (Address)other;

            //Только теперь мы можем сделать собственное сравнение
            if (this.Index != address2.Index)
                return false;
            if (this.Country != address2.Country)
                return false;
            if (this.City != address2.City)
                return false;
            if (this.Street != address2.Street)
                return false;
            if (this.Building != address2.Building)
                return false;
            return (this.Apartment == address2.Apartment);
        }
    }
}