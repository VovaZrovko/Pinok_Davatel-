
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Logic
{
    public static class ProjectDB
    {
        public static void createproject(string _name, string _shortdescription, string _fulldescription, string _owner)
        {
            ProjectModel project = new ProjectModel {
                name = _name,
                shortdescription = _shortdescription,
                fulldescription = _fulldescription,
                owner = _owner
            };

            string sql = @"INSERT INTO dbo.createdproject (name,shortdescription,fulldescription,owner)
                    VALUES(@name, @shortdescription, @fulldescription, @owner)";
            DBAccess.SQLworkflow.saveData(sql, project);
        }

        public static List<ProjectModel> loadproject(string username)
        {
            string sql = @"SELECT * FROM dbo.createdproject where owner='" + username + "'";
            return DBAccess.SQLworkflow.loadData<ProjectModel>(sql);
        }
        
    }
}
