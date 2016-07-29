using System;
namespace Inventory.Model
{
	public class Articlegroup
	{
		
		private String id;

		private String name;

        private int nr;

		public Articlegroup(String id, String name, int nr)
		{
			this.Name = name;
			this.Id = id;
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
