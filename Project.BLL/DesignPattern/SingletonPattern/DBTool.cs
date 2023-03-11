using Project.DAL.ContextClasses;

namespace Project.BLL.DesignPattern.SingletonPattern
{
    public class DBTool
    {
        DBTool() { }

        static MyContext _dbInstance;
        public static MyContext DbInstance
        {
            get 
            {
                if (_dbInstance == null)
                {
                    _dbInstance = new MyContext();
                }
                return _dbInstance;
            }

        }
    }
}
