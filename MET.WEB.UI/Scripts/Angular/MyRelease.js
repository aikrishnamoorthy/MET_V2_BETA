app.controller('myReleaseDetails', function ($scope, $http, $location) {

   
    var filters = $location.search();

    var releaseSeq = filters.id;

    $http.get("http://localhost/MET.BUSINESS.WEBAPI/api/GetReleaseDetailsBySeq/" + releaseSeq).success(function (releaseDetailsdata, status, headers, config) {
        $scope.releaseDetailsdata = releaseDetailsdata;

    }).error(function (data, status, headers, config) {
        $scope.title = "Oops... something went wrong";
        $scope.working = false;
    });
});