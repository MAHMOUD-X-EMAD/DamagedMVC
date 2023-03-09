using Final.Models;

namespace Final.Repository
{
    public class CommentRepository : ICommentRepository
    {
        Context context;
        public CommentRepository(Context context)
        {
            this.context = context;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetAll()
        {
            throw new NotImplementedException();
        }

        public Comment GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Comment Comment)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Comment Comment)
        {
            throw new NotImplementedException();
        }
    }
}
