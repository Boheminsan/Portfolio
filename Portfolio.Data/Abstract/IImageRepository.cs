using System.Collections.Generic;
using Portfolio.Entity;

namespace Portfolio.Data.Abstract {
    public interface IImageRepository : IGenericRepository<Image> {
        public List<Image> GetFolder (string Path);
    }
}