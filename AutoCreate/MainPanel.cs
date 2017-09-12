using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
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
        protected List<Coloumn> colNames = new List<Coloumn>();
        protected ToolsDbContext db = new ToolsDbContext();
        private void MainPanel_Load(object sender, EventArgs e)
        {
            
            tableNames=db.Database.SqlQuery<string>("SELECT TABLE_NAME FROM USER_TABLES").ToList();

        }

        private void btnChooseTableName_Click(object sender, EventArgs e)
        {
            if (tableNames.Contains(txtTabelName.Text))
            {
                colNames= db.Database.SqlQuery<Coloumn>(@"select 
                    concat(concat(column_name,' '),data_type) as ColoumnDetails ,
                    column_name as ColoumnName,
                    data_type as ColoumnType
                    from all_tab_columns 
                    where table_name = '" + txtTabelName.Text + "'").ToList();
                
                listBoxColoumn.DataSource=colNames;
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
               listBoxAddToSelect.Items.Add(listBoxColoumn.GetItemText( listBoxColoumn.SelectedItems[i]));
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
            string projectName= txtPath.Text.Split('\\')[txtPath.Text.Split('\\').Count()-1];

            //string fmtTableName = txtTabelName.Text.Substring(0, 1).ToUpper() + txtTabelName.Text.Substring(1).ToLower();
            //xxxViewModel.cs
            string strViewModel =FormatModel(projectName, txtRootName.Text);
            if (!Directory.Exists(txtPath.Text + "\\" + projectName + ".Model\\" +txtRootName.Text))
            {
                Directory.CreateDirectory(txtPath.Text + "\\"+ projectName +".Model\\" + txtRootName.Text);
            }
            File.WriteAllText(txtPath.Text+ "\\"+ projectName + ".Model\\" + txtRootName.Text+"\\" + txtRootName.Text+"ViewModel.cs", strViewModel, Encoding.UTF8);
            
            //xxxRepository.cs
            string strRepository = FormatRepository(projectName, txtRootName.Text);
            if (!Directory.Exists(txtPath.Text + "\\" + projectName + ".Repository"))
            {
                Directory.CreateDirectory(txtPath.Text + "\\" + projectName + ".Repository");
            }
            File.WriteAllText(txtPath.Text + "\\" + projectName + ".Repository\\" + txtRootName.Text + "Repository.cs", strRepository, Encoding.UTF8);

            //xxxBusiness.cs
            string strBusiness = FormatBusiness(projectName, txtRootName.Text);
            if (!Directory.Exists(txtPath.Text + "\\" + projectName + ".Business"))
            {
                Directory.CreateDirectory(txtPath.Text + "\\" + projectName + ".Business");
            }
            File.WriteAllText(txtPath.Text + "\\" + projectName + ".Business\\" + txtRootName.Text + "Business.cs", strBusiness, Encoding.UTF8);

            //xxxController.cs
            string strController = FormatController(projectName, txtRootName.Text);
            if (!Directory.Exists(txtPath.Text + "\\" + projectName + "\\Controllers"))
            {
                Directory.CreateDirectory(txtPath.Text + "\\" + projectName + "\\Controllers");
            }
            File.WriteAllText(txtPath.Text + "\\" + projectName + "\\Controllers\\" + txtRootName.Text + "Controller.cs", strController, Encoding.UTF8);

            //Index.cshtml
            string strView = FormatView(txtRootName.Text);
            if (!Directory.Exists(txtPath.Text + "\\" + projectName + "\\Views\\"+ txtRootName.Text))
            {
                Directory.CreateDirectory(txtPath.Text + "\\" + projectName + "\\Views\\" + txtRootName.Text);
            }
            File.WriteAllText(txtPath.Text + "\\" + projectName + "\\Views\\" + txtRootName.Text+"\\Index.cshtml", strView, Encoding.UTF8);

            MessageBox.Show("Mission Completed");


        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            txtPath.Text = path.SelectedPath;
        }
        public string FormatView(string fmtRootName)
        {
            string str = @"@{
    Layout = null;
}

<!DOCTYPE html>

<html>
<head>
    <meta name=" + "\"" + "viewport" + "\"" + " content=" + "\"" + "width = device - width" + "\"" + @" />
        <title></title>
    
        <link href = " + "\"" + "/Content/bootstrap.min.css" + "\"" + " rel = " + "\"" + "stylesheet" + "\"" + @" />
           <link href = " + "\"" + "/Content/Site.css" + "\"" + " rel = " + "\"" + "stylesheet" + "\"" + @" />

          </head>
          <body>
              <div ng - app = " + "\"" + "myApp" + "\"" + " ng - controller = " + "\"" + "myCtrl" + "\"" + @">
                       <div class=" + "\"" + "col-sm-12" + "\"" + @">

            <div class=" + "\"" + "col -sm-4" + "\"" + @">
                <strong>Search Type</strong>
                <select class=" + "\"" + "form-control" + "\"" + " ng -change=" + "\"" + "change(type)" + "\"" + " ng -model=" + "\"" + "type" + "\">";
            
            for (int i = 0; i <listBoxAddToSelect.Items.Count; i++)
            {
                string[] s = listBoxAddToSelect.GetItemText(listBoxAddToSelect.Items[i]).Split(' ');
                str += @"
<option value = " + "\"" + s[0]+ "\">"+ FormatName1(s[0]) + " </option>";
                
            }
            str += @"
                </select>
             </div>
             <div class=" + "\"" + "col-sm-4" + "\"" + @">
                <strong>Search Text</strong>
                <input type = " + "\"text\" class=\"form-control\" ng-show=\"showText\" ng-model=\"searchText\" ng-keyup=\"searchKeyUp($event)" + "\"" + @" />
                <input type = " + "\"date\" class=\"form-control\" ng-hide=\"showText\" ng-model=\"searchDate" + "\"" + @">
            </div>
            <div class=" + "\"" + "col-sm-4" + "\"" + @">
                <span></span><br>
                <button class=" + "\"btn btn-warning\" type =\"button\" ng-click=\"search()\">Search</button>" + @"
            </div>
        </div>
        <div style = " + "\"padding:90px 18px\"" + @">
            <table class=" + "\"table  table-striped table-bordered table-hover " + "\"" + @">
                <thead>
                    <tr>";
            for (int i = 0; i <listBoxAddToShow.Items.Count; i++)
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
            for (int i = 0; i <listBoxAddToShow.Items.Count; i++)
            {
                string[] s = listBoxAddToShow.GetItemText(listBoxAddToShow.Items[i]).Split(' ');
                str += @"
<td>{{x." + FormatName(s[0]) + "}} </td>";

            }
                str+=@"
                    </tr>

                </tbody>
            </table>
        </div>
    </div>
    <script src = "+"\"/Scripts/angular.min.js\""+@"></script>
    <script src=" + "\"/Scripts/moment.js\"" + @" ></script>
    <script>
        var app = angular.module('myApp', []);
app.controller('myCtrl', function($scope, $http, $location, $rootScope)
{
            $scope.showText = true;
            $scope.type = "+"\""+ FormatName(listBoxAddToSelect.GetItemText(listBoxAddToSelect.Items[0]).Split(' ')[0]) + "\""+@";
            $scope.change = function(type) {
                $scope.showText = $scope.type == 'DateCreated' ? false : true;

    }

            $scope.search = function() {

        if ($scope.type != 'DateCreated') {

            if (!$scope.searchText) {
                alert("+"\"Search Text Is Required\""+ @");
                return;
            }
        } else {
            if (!$scope.searchDate) {
                alert(" + "\"Search Date Is Required\""+ @");
                return;
            }
        }
                $scope.searchByUrl = false;
                $location.search({
                    coloumnName: $scope.type,
                    searchText: $scope.type != 'DateCreated' ? $scope.searchText : moment($scope.searchDate).format("+"\"YYYY-M-D\""+ @")
                });
        
                $http.post(
                  '/"+txtRootName.Text+ @"/Get" + fmtRootName + @"',
                   {
                       coloumnName: $scope.type,
                       searchText: $scope.type != 'DateCreated' ? $scope.searchText : moment($scope.searchDate).format(" + "\"YYYY-M-D\"" + @")

                   }
                ).success(function(response) {
                    $scope.searchByUrl = true;
                    $scope.dataInfo = response;
            angular.forEach($scope.schoolInfo, function(data) {
                data.DateCreated = new Date(parseInt(data.DateCreated.replace(/\D/igm,'')));
            })
                }).error(function(response) {
                    $scope.searchByUrl = true;
            alert("+"\"Error Callback\""+ @")
                });


    }
            $rootScope.$on('$locationChangeSuccess',
            function(event) {
        var searchObj = $location.search();
        if (!searchObj.coloumnName || !$scope.searchByUrl) {
            return;
        }
                $scope.type = searchObj.coloumnName;
        if (searchObj.coloumnName != 'DateCreated')
        {
                    $scope.searchText = searchObj.searchText;
        }
        else
        {
            
                    $scope.searchDate = new Date(searchObj.searchText)
                }
                $scope.showText = searchObj.coloumnName == 'DateCreated' ? false : true;
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
            string str = @"using "+ projectName + @".Business;
using System.Web.Mvc;

namespace " + projectName + @".Controllers
{
    public class " + fmtRootName + @"Controller : Controller
    {

        private " + fmtRootName + @"Business obj;
        public ActionResult Index()
        {
            return View();
        }
        public " + fmtRootName + @"Controller()
        {
            obj = new " + fmtRootName + @"Business();
        }
        public JsonResult Get" + fmtRootName + @"(string searchText, string coloumnName)
        {
            if (string.IsNullOrEmpty(searchText) || string.IsNullOrEmpty(coloumnName))
            {
                return Json(null);
            }
            else
            {
                return Json(obj.Get" + fmtRootName + @"(searchText, coloumnName));

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

namespace " + projectName + @".Model." + fmtRootName + @"
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
            str+=@"
    }
}
";
            return str;

        }
        public string FormatBusiness(string projectName, string fmtRootName)
        {
            string str = @"using System.Collections.Generic;
using "+ projectName + @".Model."+ fmtRootName + @";
using " + projectName + @".Repository;
namespace " + projectName + @".Business
{
    public class " + fmtRootName + @"Business
    {
        private " + fmtRootName + @"Repository obj;
        public " + fmtRootName + @"Business()
        {
            obj = new " + fmtRootName + @"Repository();
        }
        public List<" + fmtRootName + @"ViewModel> Get" + fmtRootName + @"(string searchText, string coloumnName)
        {

            return obj.Get" + fmtRootName + @"(searchText, coloumnName);

        }
    }
}";
            return str;
        }
        public string FormatRepository(string projectName, string fmtRootName)
        {
            string str = @"using System.Collections.Generic;
using System.Linq;
using " + projectName + @".Model." + fmtRootName + @";
using " + projectName + @".Repository.Tools;
using Oracle.ManagedDataAccess.Client;
namespace " + projectName + @".Repository
{
    public class " + fmtRootName + @"Repository
    {

        private ToolsDbContext db;

        public " + fmtRootName + @"Repository()
        {
            db = new ToolsDbContext();
        }
        public List<" + fmtRootName + @"Model> Get" + fmtRootName + @"(string searchText, string coloumnName)
        {
            string sql = @" + "\"" + @"select
";
            for (int i = 0; i < listBoxAddToShow.Items.Count; i++)
            {
                string[] s = listBoxAddToShow.GetItemText(listBoxAddToShow.Items[i]).Split(' ');
                str +=
@"                                "+s[0]+" as "+FormatName(s[0])+@"
";
            }
            str += "                            from " + txtTabelName.Text + " where " + "\"" + @";
            List < OracleParameter > parameters = new List<OracleParameter>();
            parameters.Add(new OracleParameter(" + "\"" + @"searchText" + "\"" + @", searchText));";
            
            string strSelString = "";
            string strSelTime = "";
            bool strSelStringFlag = false;
            for (int i=0;i< listBoxAddToSelect.Items.Count; i++)
            {
                

                string[] s = listBoxAddToSelect.GetItemText(listBoxAddToSelect.Items[i]).Split(' ');
                if (s[1].Contains("CHAR")||s[1].Contains("NUMBER"))
                {
                    if (!strSelStringFlag)
                    {
                        strSelString = "            List<string> coloumnNameList = new List<string> { \""+ s[0] + "\"";//FormatName(s[0]) 
                        strSelStringFlag = true;
                    }
                    else
                    {
                        strSelString += ",\""+ s[0] +"\"";
                    }
                    
                }
                if (s[1].Contains("DATE"))
                {
                    strSelTime += @"
            if (coloumnName == " + "\"" + s[0] + "\"" + @")
            {
                return db.Database.SqlQuery<ActivityStreamModel>(sql + " + "\"" + @"trunc("+s[0]+@") = to_date(:searchText,'yyyy-mm-dd')" + "\"" + @", parameters.ToArray()).ToList();
            }
";
                }
       
            }
            strSelString += @" };
            if (coloumnNameList.Contains(coloumnName))
            {
                return db.Database.SqlQuery<ActivityStreamModel>(sql + " + "\"" + @"instr(Lower(" + "\"" + @" + coloumnName + " + "\"" + @"),Lower(:searchText))>0" + "\"" + @", parameters.ToArray()).ToList();
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



        public string FormatName(string name)
        {
            string str = "";
            string[] nameArray = name.Split('_');
            for (int i = 0; i < nameArray.Count(); i++)
            {
                str += nameArray[i].Substring(0,1).ToUpper()+ nameArray[i].Substring(1).ToLower();
            }

            return str;
        }
        public string FormatName1(string name)
        {
            string str = "";
            string[] nameArray = name.Split('_');
            for (int i = 0; i < nameArray.Count(); i++)
            {
                str += nameArray[i].Substring(0, 1).ToUpper()+ nameArray[i].Substring(1).ToLower()+" ";
            }
            return str.Substring(0,str.Length-1);
}
public string FormatDbTypeToCsType(string dbType)
        {
            if (dbType.Contains("CHAR"))
            {
                return "string";
            }
            if (dbType.Contains("NUMBER"))
            {
                return "long";
            }
            if (dbType.Contains("DATE"))
            {
                return "DateTime";
            }
            return "object";
        }
    }
    public class Coloumn
    {
        public string ColoumnDetails { get; set; }
        public string ColoumnName { get; set; }
        public string ColoumnType { get; set; }
    }
    public class ToolsDbContext : DbContext
    {


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("IDSERV");
        }

    }

}
