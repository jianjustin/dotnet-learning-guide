using Microsoft.AspNetCore.Mvc;
using SimpleWebApp.Repositorys;
using SimpleWebApp.Models;

namespace SimpleWebApp.Controllers
{
    public class UserController : ControllerBase
    {
        private IUserRepository AlanDao;

        public UserController(IUserRepository alanDao)
        {
            AlanDao = alanDao;
        }

        //插入数据
        public ActionResult<string> Create(string name, string password)
        {

            var user = new User() { 
                name = name,
                password = password
            };

            var result = AlanDao.CreateUser(user);

            if (result)
            {
                return "插入成功";
            }
            return "插入失败";
        }

        //取全部记录
        public ActionResult<string> Gets()
        {
            var names = "没有数据";
            var users = AlanDao.GetUsers();

            if (users != null)
            {
                names = "";
                foreach (var s in users)
                {
                    names += $"{s.name} \r\n";
                }

            }

            return names;
        }

        //取某id记录
        public ActionResult<string> Get(int id)
        {
            var user = AlanDao.GetUserByID(id);
            return user.name;
        }

       

        //根据id删掉记录
        public ActionResult<string> Delete(int id)
        {
            var result = AlanDao.DeleteUserByID(id);

            if (result)
            {
                return "学生删除成功";
            }
            else
            {
                return "学生删除失败";
            }
        }
    }
}
