using System;
namespace Inventory.Model
{
	public class Customer
	{
		private String id;

		private String name;

		private String email;

		private String tel;

        private int nr;

		public Customer(String id, String name, String email, String tel, int nr)
		{
			this.Name = name;
			this.Id = id;
			this.Email = email;
			this.Tel = tel;
            this.Nr = nr;
		}

		public string Id
		{
			get
			{
				return id;
			}

			set
			{
				id = value;
			}
		}

		public string Name
		{
			get
			{
				return name;
			}

			set
			{
				name = value;
			}
		}

		public string Email
		{
			get
			{
				return email;
			}

			set
			{
				email = value;
			}
		}

		public string Tel
		{
			get
			{
				return tel;
			}

			set
			{
				tel = value;
			}
		}

        public int Nr
        {
            get
            {
                return nr;
            }

            set
            {
                nr = value;
            }
        }
    }
}
