using System;
using System.Linq;
using System.Linq.Expressions;
using Portfolio.Data.Abstract;
using Portfolio.Entity;

namespace Portfolio.Data.Concrete.EFCore {
    public class EFProjectRepository : EFGenericRepository<Project>, IProjectRepository {
        public EFProjectRepository (PortfolioContext context) : base (context) { }
        public PortfolioContext PortfolioContext {
            get { return context as PortfolioContext; }
        }

        public void DeleteById (int portId) {
            var port = PortfolioContext.Projects.FirstOrDefault (p => p.ProjectId == portId);
            if (port != null) {
                PortfolioContext.Projects.Remove (port);
                PortfolioContext.SaveChanges ();
            }
        }

        // public void Save (Project entity) {
        //     if (entity.ProjectId == 0) {
        //         Add (entity);
        //     } else {
        //         Edit (entity);
        //     }
        // }

        public void Edit2 (Project entity) {
            var port = GetById (entity.ProjectId);
            if (port != null) {
                port.Text = entity.Text;
                port.Title = entity.Title;
                // port.Categories = entity.Categories;
                port.isDone = entity.isDone;
                if (!(entity.Image is null)) {
                    port.Image = entity.Image;
                }
                // if (entity.Images.Count != 0) {
                //     port.Images = entity.Images;
                //çoklu resim şimdilik dursun
                // }
                context.SaveChanges ();
            }
        }
    }
}