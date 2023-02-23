using InfoVerse.Data;
using InfoVerse.Interfaces;
using InfoVerse.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace InfoVerse.Services
{
    public class ImageService : IImageModel
    {
        private IDbContextFactory<ImageDbContext> _dbContextFactory;

        public ImageService(IDbContextFactory<ImageDbContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }
        public void AddImage(ImageModel image)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Images.Add(image);
                context.SaveChanges();
            }
        }

        public void ChangeActiveStatus(int id)
        {
            var image = GetImage(id);

            if (image != null)
            {
                image.isActive = !image.isActive;

                using (var context = _dbContextFactory.CreateDbContext())
                {
                    context.Update(image);
                    context.SaveChanges();
                }
            }
        }

        public void DeleteImage(int id)
        {
            var image = GetImage(id);

            if (image != null)
            {
                using (var context = _dbContextFactory.CreateDbContext())
                {
                    context.Remove(image);
                    context.SaveChanges();
                }
            }   
            
        }

        public List<ImageModel> GetAllImages()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return context.Images.ToList();
            }
            
        }

        public ImageModel GetImage(int id)
        {
            
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return context.Images.FirstOrDefault(x => x.Id == id);
            }
        }

        public void UpdateImageInfo(ImageModel image)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Update(image);
                context.SaveChanges();
            }
            
        }
    }
}
