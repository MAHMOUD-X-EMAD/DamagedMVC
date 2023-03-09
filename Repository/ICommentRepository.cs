using Final.Models;

namespace Final.Repository
{
    public interface ICommentRepository
    {
        List<Comment> GetAll();
        Comment GetById(int id);
        void Insert(Comment Comment);
        void Update(int id, Comment Comment);
        void Delete(int id);
    }
}
