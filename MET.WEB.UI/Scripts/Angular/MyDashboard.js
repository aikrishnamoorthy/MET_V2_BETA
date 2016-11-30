app.controller('myDashboardCtrl', function ($scope, $http) {

    //$http.get("/api/MyDashboard/DefaultLoad").success(function (data, status, headers, config) {
    //    $scope.FirstName = data.FirstName;
    //    $scope.LastName = data.LastName;
    //    $scope.TotalTasksCompleted = data.TotalTasksCompleted;
    //    $scope.TotalTasksInProgress = data.TotalTasksInProgress;
    //    $scope.TotalTasksNotStarted = data.TotalTasksNotStarted;
    //    $scope.TaskResults = data.TaskResults;
    //    $scope.CurrentPage = 0;

    $http.get("http://localhost/MET.BUSINESS.WEBAPI/api/GetAllWorkItems").success(function (data, status, headers, config) {
        $scope.FirstName = "FirstName";
        $scope.LastName = "LastName";
        $scope.TotalTasksCompleted = 0;
        $scope.TotalTasksInProgress = 0;
        $scope.TotalTasksNotStarted = 0;
        $scope.TaskResults = data;
        $scope.CurrentPage = 0;

    }).error(function (data, status, headers, config) {
        $scope.title = "Oops... something went wrong";
        $scope.working = false;
    }).finally(function (status) {
    });

    //$scope.TotalTasksFunction = function (input) {
    //    $http.get("/api/MyDashboard/GetTaskResults").success(function (data, status, headers, config) {
        
    //        $scope.TaskResults = data;


    //    }).error(function (data, status, headers, config) {
    //        $scope.title = "Oops... something went wrong";
    //        $scope.working = false;
    //    });
    //}

    $scope.busy = false;


    //$scope.nextPage = function (input) {

    //   if ($scope.busy===true) return;
    //   $scope.busy = true;

    //   // $http.get("http://localhost/MET.BUSINESS.WEBAPI/api/GetAllWorkItems" + $scope.CurrentPage).success(function (data, status, headers, config) {
    //    $http.get("http://localhost/MET.BUSINESS.WEBAPI/api/GetAllWorkItems").success(function (data, status, headers, config) {


    //        var items = data;
    //        for (var i = 0; i < items.length; i++) {
    //            $scope.TaskResults.push(items[i]);
    //        }
    //        $scope.CurrentPage =  $scope.CurrentPage +   items.length;
       
    //      $scope.busy = false;


    //    }).error(function (data, status, headers, config) {
    //        $scope.title = "Oops... something went wrong";
    //        $scope.working = false;
    //    });

    //}

    $scope.onEnd = function () {
        $timeout(function () {
            alert('all done');
        }, 1);
    };

});

app.controller('myRecentReleases', function ($scope, $http) {

    var userSeq = 28 //TODO: Dynamically populate with logged in user data

    $http.get("http://localhost/MET.BUSINESS.WEBAPI/api/GetNoOfRelTskByUserSeq/" + userSeq).success(function (releasedata, status, headers, config) {
        $scope.releaseItems = releasedata;

    }).error(function (data, status, headers, config) {
        $scope.title = "Oops... something went wrong";
        $scope.working = false;
    });
});

app.directive("repeatEnd", function () {
    return {
        restrict: "A",
        link: function (scope, element, attrs) {
            
            if (scope.$last) {
              //  $('#datatable').dataTable();
                //scope.$eval(attrs.repeatEnd);
            }
        }
    };
});

