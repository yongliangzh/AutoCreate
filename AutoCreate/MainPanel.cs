using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace AutoCreate
{

    public partial class MainPanel : Form
    {
        public MainPanel()
        {
            InitializeComponent();
        }
        protected List<string> tableNames = new List<string>();
        protected List<string> colNames = new List<string>();
        protected ToolsDbContext db = new ToolsDbContext();
        private void MainPanel_Load(object sender, EventArgs e)
        {

            tableNames = db.Database.SqlQuery<string>("SELECT TABLE_NAME FROM USER_TABLES").ToList();

        }

        private void btnChooseTableName_Click(object sender, EventArgs e)
        {
            if (tableNames.Contains(txtTabelName.Text))
            {
                colNames = db.Database.SqlQuery<string>(@"select 
                    concat(concat(column_name,' '),data_type) as ColoumnDetails 
                    from all_tab_columns 
                    where table_name = '" + txtTabelName.Text + "' order by rownum desc").ToList();
                listBoxColoumn.DataSource = colNames;
                listBoxColoumn.DisplayMember = "ColoumnDetails";

            }
            else
            {
                MessageBox.Show("Error Table Name");
            }
        }

        private void btnAddToSelect_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxColoumn.SelectedItems.Count; i++)
            {
                if (listBoxAddToSelect.Items.Contains(listBoxColoumn.GetItemText(listBoxColoumn.SelectedItems[i])))
                {
                    continue;
                }
                listBoxAddToSelect.Items.Add(listBoxColoumn.GetItemText(listBoxColoumn.SelectedItems[i]));
            }

        }

        private void btnAddToShow_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBoxColoumn.SelectedItems.Count; i++)
            {
                if (listBoxAddToShow.Items.Contains(listBoxColoumn.GetItemText(listBoxColoumn.SelectedItems[i])))
                {
                    continue;
                }
                listBoxAddToShow.Items.Add(listBoxColoumn.GetItemText(listBoxColoumn.SelectedItems[i]));
            }
        }
        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            listBoxAddToSelect.Items.Remove(listBoxAddToSelect.GetItemText(listBoxAddToSelect.SelectedItem));
        }

        private void btnDeleteShow_Click(object sender, EventArgs e)
        {

            listBoxAddToShow.Items.Remove(listBoxAddToShow.GetItemText(listBoxAddToShow.SelectedItems));

        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath.Text))
            {
                return;
            }
            string projectName = txtPath.Text.Split('\\')[txtPath.Text.Split('\\').Count() - 1];

            //xxxViewModel.cs
            string strViewModel = FormatModel(projectName, txtRootName.Text);
            if (!Directory.Exists(txtPath.Text + "\\" + projectName + ".Model\\Tools"))
            {
                Directory.CreateDirectory(txtPath.Text + "\\" + projectName + ".Model\\Tools");
            }
            File.WriteAllText(txtPath.Text + "\\" + projectName + ".Model\\Tools\\" + txtRootName.Text + "ViewModel.cs", strViewModel, Encoding.UTF8);

            //xxxRepository.cs
            string strRepository = "";
            if (rdbSingleSearch.Checked)
            {
                strRepository = FormatRepository1(projectName, txtRootName.Text);
            }
            else
            {
                strRepository = FormatRepository1(projectName, txtRootName.Text);
            }
            if (!Directory.Exists(txtPath.Text + "\\" + projectName + ".Repository\\Tools\\Repositories"))
            {
                Directory.CreateDirectory(txtPath.Text + "\\" + projectName + ".Repository\\Tools\\Repositories");
            }
            File.WriteAllText(txtPath.Text + "\\" + projectName + ".Repository\\Tools\\Repositories\\" + txtRootName.Text + "Repository.cs", strRepository, Encoding.UTF8);

            //xxxBusiness.cs
            string strBusiness = FormatBusiness(projectName, txtRootName.Text);
            if (!Directory.Exists(txtPath.Text + "\\" + projectName + ".Business\\Tools"))
            {
                Directory.CreateDirectory(txtPath.Text + "\\" + projectName + ".Business\\Tools");
            }
            File.WriteAllText(txtPath.Text + "\\" + projectName + ".Business\\Tools\\" + txtRootName.Text + "Business.cs", strBusiness, Encoding.UTF8);

            //xxxController.cs
            string strController = strController = FormatController(projectName, txtRootName.Text);

            if (!Directory.Exists(txtPath.Text + "\\" + projectName + ".UI\\Areas\\Tools\\Controllers"))
            {
                Directory.CreateDirectory(txtPath.Text + "\\" + projectName + ".UI\\Areas\\Tools\\Controllers");
            }
            File.WriteAllText(txtPath.Text + "\\" + projectName + ".UI\\Areas\\Tools\\Controllers\\" + txtRootName.Text + "Controller.cs", strController, Encoding.UTF8);
            

            //Index.cshtml
            string strView = FormatView1(txtRootName.Text);
            if (!Directory.Exists(txtPath.Text + "\\" + projectName + ".UI\\Areas\\Tools\\Views\\" + txtRootName.Text))
            {
                Directory.CreateDirectory(txtPath.Text + "\\" + projectName + ".UI\\Areas\\Tools\\Views\\" + txtRootName.Text);
            }
            File.WriteAllText(txtPath.Text + "\\" + projectName + ".UI\\Areas\\Tools\\Views\\" + txtRootName.Text + "\\Index.cshtml", strView, Encoding.UTF8);

            MessageBox.Show("Mission Completed");


        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            txtPath.Text = path.SelectedPath;
        }
        public string FormatView1(string fmtRootName)
        {

            string str = @"@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name=" + "\"viewport\" content=\"width = device - width\"" + @" />
        <title>" + fmtRootName + @"</title>
    
    <link href=" + "\"https://fonts.font.im/css?family=Fjalla+One\" rel=\"stylesheet\" type=\"text/css\"" + @">
    <link rel=" + "\"stylesheet\" href=\"https://cdn.bootcss.com/bootstrap/3.3.7/css/bootstrap.min.css\" integrity=\"sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u\" crossorigin=\"anonymous\"" + @">

          </head>
          <body>
              <div ng - app = " + "\"myApp\" ng-controller = \"myCtrl\"" + @">
                       <div class=" + "\"col-sm-12\"  style = \"margin-bottom:30px\"" + @">
            <div class=" + "\"page - header\" style=\"font-family: 'Fjalla One', sans-serif; \"" + @">
                       <h1>" + fmtRootName + @"<small>" + fmtRootName + @"</small></h1>
                      </div>
                      <div class=" + "\"col-sm-4\"" + @">
                <strong>Search Type</strong>
                <select class=" + "\"form-control\" ng -change=\"change(type)\" ng-model=\"type\">";

            for (int i = 0; i < listBoxAddToSelect.Items.Count; i++)
            {
                string[] s = listBoxAddToSelect.GetItemText(listBoxAddToSelect.Items[i]).Split(' ');
                str += @"
<option value = " + "\"" + s[0] + "\">" + FormatName1(s[0]) + " </option>";

            }
            str += @"
                </select>
             </div>
             <div class=" + "\"col-sm-4\"" + @">
                <strong>Search Text</strong>
                <input type = " + "\"text\" class=\"form-control\" ng-show=\"showText\" ng-model=\"searchText\" ng-keyup=\"searchKeyUp($event)" + "\"" + @" />
                <input type = " + "\"date\" class=\"form-control\" ng-hide=\"showText\" ng-model=\"searchDate\"" + @">
            </div>
            <div class=" + "\"col-sm-4\"" + @">
                <span></span><br>
                <button class=" + "\"btn btn-warning\" type =\"button\" ng-click=\"search()\">Search</button>" + @"
            </div>
        </div>
        <div style = " + "\"padding:90px 18px\"" + @">
            <table class=" + "\"table  table-striped table-bordered table-hover \"" + @">
                <thead>
                    <tr>";
            for (int i = 0; i < listBoxAddToShow.Items.Count; i++)
            {
                string[] s = listBoxAddToShow.GetItemText(listBoxAddToShow.Items[i]).Split(' ');
                str += @"
<th>" + FormatName1(s[0]) + " </th>";

            }
            str += @"
                    </tr>
                </thead>
                <tbody>
                    <tr ng-repeat= " + "\"x in dataInfo\">";
            for (int i = 0; i < listBoxAddToShow.Items.Count; i++)
            {
                string[] s = listBoxAddToShow.GetItemText(listBoxAddToShow.Items[i]).Split(' ');
                if (s[1] != "DATE")
                {
                    str += @"
<td>{{x." + FormatName(s[0]) + "}} </td>";
                }
                else
                {
                    str += @"
<td>{{x." + FormatName(s[0]) + "|date:'yyyy/MM/dd HH:mm:ss'}} </td>";
                }

            }
            str += @"
                    </tr>

                </tbody>
            </table>
        </div>
    </div>
    <script src = " + "\"/Scripts/angular.min.js\"" + @"></script>
    <script src=" + "\"/Scripts/moment.js\"" + @" ></script>
    <script>
        var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $http, $location, $rootScope)
{
            $scope.showText = true;
            $scope.type = " + "\"" + listBoxAddToSelect.GetItemText(listBoxAddToSelect.Items[0]).Split(' ')[0] + "\"" + @";
            $scope.change = function(type) {
                $scope.showText = $scope.type == 'DateCreated' ? false : true;

    }

            $scope.search = function() {

        if ($scope.type != 'DateCreated') {

            if (!$scope.searchText) {
                alert(" + "\"Search Text Is Required\"" + @");
                return;
            }
        } else {
            if (!$scope.searchDate) {
                alert(" + "\"Search Date Is Required\"" + @");
                return;
            }
        }
                $scope.searchByUrl = false;
                $location.search({
                    type: $scope.type,
                    searchText: $scope.type != 'DateCreated' ? $scope.searchText : moment($scope.searchDate).format(" + "\"YYYY-M-D\"" + @")
                });
        
                $http.post(
                  '/" + txtRootName.Text + @"/Get" + fmtRootName + @"',
                   {
                       type: $scope.type,
                       searchText: $scope.type != 'DateCreated' ? $scope.searchText : moment($scope.searchDate).format(" + "\"YYYY-M-D\"" + @")

                   }
                ).success(function(response) {
                    $scope.searchByUrl = true;
                    $scope.dataInfo = response;
            angular.forEach($scope.dataInfo, function(data) {
                data.DateCreated = new Date(parseInt(data.DateCreated.replace(/\D/igm,'')));
            })
                }).error(function(response) {
                    $scope.searchByUrl = true;
            alert(" + "\"Error Callback\"" + @")
                });


    }
            $rootScope.$on('$locationChangeSuccess',
            function(event) {
        var searchObj = $location.search();
        if (!searchObj.type || !$scope.searchByUrl) {
            return;
        }
                $scope.type = searchObj.type;
        if (searchObj.type != 'DateCreated')
        {
                    $scope.searchText = searchObj.searchText;
        }
        else
        {
            
                    $scope.searchDate = new Date(searchObj.searchText)
                }
                $scope.showText = searchObj.type == 'DateCreated' ? false : true;
                $scope.search();
    })
            $scope.searchKeyUp = function(e) {
        var keycode = window.event ? e.keyCode : e.which;
        if (keycode == 13)
        {
                    $scope.search();
        }
    };
});
    </script>
</body>
</html>
";
            return str;
        }
        public string FormatController(string projectName, string fmtRootName)
        {
            string str = @"using " + projectName + @".Business.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace " + projectName + @".UI.Areas.Tools.Controllers
{
    [Authorize]
    public class " + fmtRootName + @"Controller : Controller
    {

        private " + fmtRootName + @"Business " + fmtRootName + @"Biz;
        public ActionResult Index()
        {
            return View();
        }
        public " + fmtRootName + @"Controller()
        {
            " + fmtRootName + @"Biz = new " + fmtRootName + @"Business();
        }
        public JsonResult Get" + fmtRootName + @"(string searchText, string type)
        {
            if (string.IsNullOrEmpty(searchText) || string.IsNullOrEmpty(type))
            {
                return Json(null);
            }
            else
            {
                return Json(" + fmtRootName + @"Biz.Get" + fmtRootName + @"(searchText, type));

            }

        }

    }
}";

            return str;
        }
        public string FormatModel(string projectName, string fmtRootName)
        {
            string str = "";
            str = @"using System;

namespace " + projectName + @".Model.Tools
{
    public class " + fmtRootName + @"ViewModel
    {
";

            for (int i = 0; i < listBoxAddToShow.Items.Count; i++)
            {
                string[] s = listBoxAddToShow.GetItemText(listBoxAddToShow.Items[i]).Split(' ');
                str +=
@"        public " + FormatDbTypeToCsType(s[1]) + @" " + FormatName(s[0]) + @" { get; set; }

";
            }
            str += @"
    }
}
";
            return str;

        }
        public string FormatBusiness(string projectName, string fmtRootName)
        {
            string str = @"using System.Collections.Generic;
using " + projectName + @".Model.Tools;
using " + projectName + @".Repository.Tools;
namespace " + projectName + @".Business.Tools
{
    public class " + fmtRootName + @"Business
    {
        private ToolDataUnitOfWork uow;
        public " + fmtRootName + @"Business()
        {
            uow = new ToolDataUnitOfWork();
        }
        public List<" + fmtRootName + @"ViewModel> Get" + fmtRootName + @"(string searchText, string type)
        {

            return uow." + fmtRootName + @".Repository.Get" + fmtRootName + @"(searchText, type);

        }
    }
}";
            return str;
        }
        public string FormatRepository1(string projectName, string fmtRootName)
        {
            string str = @"using System.Collections.Generic;
using System.Linq;
using " + projectName + @".Model.Tools;
using Oracle.ManagedDataAccess.Client;
using System;
namespace " + projectName + @".Repository.Tools.Repository
{
    public class " + fmtRootName + @"Repository: BaseRepository<DBNull>
    {

        public " + fmtRootName + @"Repository(System.Data.Entity.DbContext _db) : base(_db) { }

        public List<" + fmtRootName + @"Model> Get" + fmtRootName + @"(string searchText, string type)
        {
            string sql = @" + "\"" + @"select
";
            for (int i = 0; i < listBoxAddToShow.Items.Count; i++)
            {
                string[] s = listBoxAddToShow.GetItemText(listBoxAddToShow.Items[i]).Split(' ');
                str +=
@"                                " + s[0] + " as " + FormatName(s[0]) + @"
";
            }
            str += "                            from " + txtTabelName.Text + " where " + "\"" + @";
            List < OracleParameter > parameters = new List<OracleParameter>();
            parameters.Add(new OracleParameter(" + "\"" + @"searchText" + "\"" + @", searchText));";

            string strSelString = "";
            string strSelTime = "";
            bool strSelStringFlag = false;
            for (int i = 0; i < listBoxAddToSelect.Items.Count; i++)
            {


                string[] s = listBoxAddToSelect.GetItemText(listBoxAddToSelect.Items[i]).Split(' ');
                if (s[1].Contains("CHAR") || s[1].Contains("NUMBER"))
                {
                    if (!strSelStringFlag)
                    {
                        strSelString = "            List<string> typeList = new List<string> { \"" + s[0] + "\"";//FormatName(s[0]) 
                        strSelStringFlag = true;
                    }
                    else
                    {
                        strSelString += ",\"" + s[0] + "\"";
                    }

                }
                if (s[1].Contains("DATE"))
                {
                    strSelTime += @"
            if (type == " + "\"" + s[0] + "\"" + @")
            {
                return DbContext.Database.SqlQuery<ActivityStreamModel>(sql + " + "\"" + @"trunc(" + s[0] + @") = to_date(:searchText,'yyyy-mm-dd')" + "\"" + @", parameters.ToArray()).ToList();
            }
";
                }

            }
            strSelString += @" };
            if (typeList.Contains(type))
            {
                return DbContext.Database.SqlQuery<ActivityStreamModel>(sql + " + "\"" + @"instr(Lower(" + "\"" + @" + type + " + "\"" + @"),Lower(:searchText))>0" + "\"" + @", parameters.ToArray()).ToList();
            }
            else
            {
                return new List<" + fmtRootName + @"Model>();
            }

        }

    }
}
";
            str += strSelTime + strSelString;
            return str;
        }

//        public string FormatRepository2(string projectName, string fmtRootName)
//        {
//            string str = @"using System.Collections.Generic;
//using System.Linq;
//using ABE.Model.Tools;
//using Oracle.ManagedDataAccess.Client;
//using ABE.Repository;
//using System;

//namespace ABE.Repository.Tools.Repositories
//{
//    public class ParametersRepository : BaseRepository<DBNull>
//    {
//        public ParametersRepository(System.Data.Entity.DbContext _db) : base(_db) { }
//        public List<ParametersViewModel> GetParameters(";
//            string strVariable = "";
//            for (int i = 0; i < listBoxAddToSelect.Items.Count; i++)
//            {
//                string[] s= listBoxAddToSelect.GetItemText(listBoxAddToSelect.Items[i]).Split(' ');
//                strVariable +="string " FormatName2(s[0])+",";
//            }
//            str+=strVariable.Substring(0, strVariable.Length - 1);
//            str+=@"
//            )
//        {
//            string sql = @" + "\"" + @"select
//";
//            for (int i = 0; i < listBoxAddToShow.Items.Count; i++)
//            {
//                string[] s = listBoxAddToShow.GetItemText(listBoxAddToShow.Items[i]).Split(' ');
//                str +=
//@"                                " + s[0] + " as " + FormatName(s[0]) + @"
//";
//            }
//            str += "                            from " + txtTabelName.Text + " where rownum<50 " + "\"" + @";

//            List<OracleParameter> parameters = new List<OracleParameter>();
//            if (!string.IsNullOrEmpty(entityType))
//            {
//                sql += " and instr(Lower(ENTITY_TYPE),Lower(:entityType))>0 ";
//                parameters.Add(new OracleParameter("entityType", entityType));
//            }
//            if (!string.IsNullOrEmpty(seqIdEntity))
//            {
//                sql += " and instr(Lower(SEQID_ENTITY),Lower(:seqIdEntity))>0 ";
//                parameters.Add(new OracleParameter("seqIdEntity", seqIdEntity));
//            }
//            if (!string.IsNullOrEmpty(key))
//            {
//                sql += " and instr(Lower(KEY),Lower(:key))>0 ";
//                parameters.Add(new OracleParameter("key", key));
//            }
//            if (!string.IsNullOrEmpty(valueString))
//            {
//                sql += " and instr(Lower(VALUE_STRING),Lower(:valueString))>0 ";
//                parameters.Add(new OracleParameter("valueString", valueString));
//            }

//            return DbContext.Database.SqlQuery<ParametersViewModel>(sql, parameters.ToArray()).ToList();

//        }

//    }
//}

//";

//            return str;
//        }


        public string FormatName(string name)
        {
            string str = "";
            string[] nameArray = name.Split('_');
            for (int i = 0; i < nameArray.Count(); i++)
            {
                str += nameArray[i].Substring(0, 1).ToUpper() + nameArray[i].Substring(1).ToLower();
            }

            return str;
        }
        public string FormatName1(string name)
        {
            string str = "";
            string[] nameArray = name.Split('_');
            for (int i = 0; i < nameArray.Count(); i++)
            {
                str += nameArray[i].Substring(0, 1).ToUpper() + nameArray[i].Substring(1).ToLower() + " ";
            }
            return str.Substring(0, str.Length - 1);
        }
        public string FormatName2(string name)
        {
            string str = "";
            string[] nameArray = name.Split('_');
    int count = 0;
            for (int i = 0; i < nameArray.Count(); i++)
            {
        if (count == 0)
        {
            str += nameArray[i].ToLower() + " ";
            count++;
        }
        else
        {
            str += nameArray[i].Substring(0, 1).ToUpper() + nameArray[i].Substring(1).ToLower() + " ";
        }
            }
            return str.Substring(0, str.Length - 1);
        }
public string FormatDbTypeToCsType(string dbType)
        {
            if (dbType.Contains("CHAR"))
            {
                return "string";
            }
            if (dbType.Contains("NUMBER"))
            {
                return "decimal ?";
            }
            if (dbType.Contains("DATE"))
            {
                return "DateTime ?";
            }
            return "object";
        }
    }
}
