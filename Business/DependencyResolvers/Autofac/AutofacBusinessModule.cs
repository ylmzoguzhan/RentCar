using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<CarManager>().As<ICarService>();
            builder.RegisterType<EfCarDal>().As<ICarDal>();

            builder.RegisterType<RentManager>().As<IRentService>();
            builder.RegisterType<EfRentDal>().As<IRentDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<CarCommentManager>().As<ICarCommentService>();
            builder.RegisterType<EfCarCommentDal>().As<ICarCommentDal>();

            builder.RegisterType<CarImageManager>().As<ICarImageService>();
            builder.RegisterType<EfCarImageDal>().As<ICarImageDal>();

            builder.RegisterType<UserCommentManager>().As<IUserCommentService>();
            builder.RegisterType<EfUserCommentDal>().As<IUserCommentDal>();

            builder.RegisterType<UserImageManager>().As<IUserImageService>();
            builder.RegisterType<EfUserImageDal>().As<IUserImageDal>();
            //builder.RegisterType<AuthManager>().As<IAuthService>();
            //builder.RegisterType<JwtHelper>().As<ITokenHelper>();


            //builder.RegisterType<HttpContextAccessor>().As<IHttpContextAccessor>();

        }
    }
}
