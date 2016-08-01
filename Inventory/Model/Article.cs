using System;
namespace Inventory.Model
{
	public class Article
	{
		private String id;

		private String name;

		private Articlegroup articleGroup;

		private int bestand;

        private DateTime created = new DateTime();

        private Customer owner;

		private int minBestand;
    
		private int meldeBestand;

        private int nr;

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

		public Articlegroup ArticleGroup
		{
			get
			{
				return articleGroup;
			}

			set
			{
				articleGroup = value;
			}
		}

		public int Bestand
		{
			get
			{
				return bestand;
			}

			set
			{
				bestand = value;
			}
		}

		public DateTime Created
		{
			get
			{
				return created;
			}

			set
			{
				created = value;
			}
		}

		public Customer Owner
		{
			get
			{
				return owner;
			}

			set
			{
				owner = value;
			}
		}

		public int MinBestand
		{
			get
			{
				return minBestand;
			}

			set
			{
				minBestand = value;
			}
		}

		public int MeldeBestand
		{
			get
			{
				return meldeBestand;
			}

			set
			{
				meldeBestand = value;
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

        public String OwnerName
        {
            get
            {
                return this.owner.Name;
            }
        }

        public String ArticleGroupName
        {
            get
            {
                return this.articleGroup.Name;
            }
        }
    }
}
