﻿using MVCBlog.Core.Entities;
using MVCBlog.Entity.Entities.Identity;

namespace MVCBlog.Entity.Entities
{
    public class Article : EntityBase
	{
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }

        //Category
        public Guid CategoryId { get; set; } 
		public Category Category { get; set; }

        //Image
		public Guid? ImageId { get; set; } 
        public Image Image { get; set; }

        //User
        public Guid AppUserId { get; set; }
        public AppUser User { get; set; }

    }
}
