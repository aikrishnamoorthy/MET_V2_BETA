// Creating a module
var userApp = angular.module("userApp", [])

// Creating a controller from the module
userApp.controller("ContactController", function ($scope) {
    $scope.GetAllContacts = function () {
        $http.get('http://localhost/MET.BUSINESS.WEBAPI/api/GetAllWorkItems').
        success(function (data, status, headers, config) {
            $scope.contacts = data;
            // OUT PUT WILL BE [{contact1},{contact2},....]
        }).
        error(function (data, status, headers, config) {
            alert("couldn't get contacts.");
        });
    }
})

