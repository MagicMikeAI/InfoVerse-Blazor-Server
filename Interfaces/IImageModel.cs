using InfoVerse.Models;

namespace InfoVerse.Interfaces
{
    public interface IImageModel
    {
        List<ImageModel> GetAllImages();
        ImageModel GetImage(int id);
        void AddImage (ImageModel image);
        void UpdateImageInfo (ImageModel image);
        void ChangeActiveStatus(int id);
        void DeleteImage (int id);



    }
}
